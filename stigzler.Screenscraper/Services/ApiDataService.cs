using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.EventArgs;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace stigzler.Screenscraper.Services
{
    internal class ApiDataService

    {
        /// <summary>
        /// Number of user threads to use
        /// </summary>
        public int UserThreads { get; set; }

        private ApiServerParameters apiServerParameters;
        //private int maxThreads = 1;
        private int requestTimeout = 5000;
        private int webRequestAttempts = 5;
        // internal event EventHandler<EventArgs.ProgressChangedEventArgs> OperationUpdate;

        /// <summary>
        /// Constructor for 
        /// </summary>
        /// <param name="apiServerParameters"></param>
        /// <param name="userThreads">User Threads</param>
        /// <param name="requestTimeout">Time in ms before WebReuqest times out</param>
        /// <param name="webRequestAttempts">How many attempts will be made for a successful WebRequest</param>
        internal ApiDataService(ApiServerParameters apiServerParameters, int userThreads = 1,
                                    int requestTimeout = 5000, int webRequestAttempts = 5)
        {
            this.apiServerParameters = apiServerParameters;
            this.UserThreads = userThreads;
            this.requestTimeout = requestTimeout;
            this.webRequestAttempts = webRequestAttempts;
        }

        internal ApiGetOutcome GetFile(Uri uri, string destinationFilename)
        {
            ModifiedNet.WebClient webClient = new ModifiedNet.WebClient(requestTimeout);
            ApiGetOutcome outcome = new ApiGetOutcome();
            outcome.Uri = uri;
            //object result = null;

            int attempts = 0;

            while (outcome.Successfull == false && attempts < webRequestAttempts)
            {
                //if (attempts > 0) Debug.WriteLine("Attempt " + attempts + " on " + Path.GetFileName(destinationFilename));
                try
                {
                    webClient.DownloadFile(uri, destinationFilename);

                    using (var fileStream = File.OpenRead(destinationFilename))
                    {
                        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
                        {
                            String line = streamReader.ReadLine();

                            if (line == "NOMEDIA" || line == "Problème de paramètres")
                            {
                                outcome.Successfull = false;
                                outcome.StatusCode = 200;
                                outcome.Data = line;
                            }
                            else
                            {
                                outcome.Successfull = true;
                                outcome.StatusCode = 200;
                                outcome.Data = destinationFilename;
                            }
                        }
                    }

                    if (outcome.Successfull == false)
                    {
                        File.Delete(destinationFilename);
                    }
                }
                catch (WebException ex)
                {
                    // First check whether this is due to a duplicate file. If so, change destinationFilename to numbered alt
                    // This handles parallelism where trying to write two files of the same name at the same time
                    // it DOES NOT handle duplicate filenames in destination folder as WebClient.DownloadFile automaticaly
                    // overwrites any files of the same filename 

                    if (File.Exists(destinationFilename))
                    {
                        int duplicateImageNumber = 0;
                        string prospectiveFilename = destinationFilename;
                        while (File.Exists(prospectiveFilename))
                        {
                            duplicateImageNumber += 1;
                            prospectiveFilename = Path.Combine(Path.GetDirectoryName(destinationFilename),
                            Path.GetFileNameWithoutExtension(destinationFilename) +
                            " (" + duplicateImageNumber + ")" +
                            Path.GetExtension(destinationFilename));
                        }
                        destinationFilename = prospectiveFilename;
                    }

                    outcome.Exception = ex;

                    if (ex.Response != null)
                    {
                        outcome.StatusCode = (int)((HttpWebResponse)ex.Response).StatusCode;
                        outcome.Data = ParseExceptionResponse(ex).Trim();
                    }
                }
                catch (OperationCanceledException)
                {
                    Debug.WriteLine("Cancelled");

                }
                catch (Exception ex)
                {
                    outcome.Exception = ex;
                }
                finally { attempts += 1; }
            }
            return outcome;
        }


        internal ApiGetOutcome GetString(Uri uri)
        {
            ModifiedNet.WebClient webClient = new ModifiedNet.WebClient(requestTimeout)
            {
                Encoding = Encoding.UTF8                            
            };           
                
            ApiGetOutcome outcome = new ApiGetOutcome();
            outcome.Uri = uri;
            string result = null;
            int attempts = 0;

            while (outcome.Successfull == false && attempts < webRequestAttempts)

            {
                try
                {
                    result = webClient.DownloadString(uri);

                    outcome.Successfull = true;
                    outcome.StatusCode = 200;
                    //outcome.Data = HttpUtility.HtmlDecode(result);
                    outcome.Data = result;
                }
                catch (WebException ex)
                {
                    outcome.Exception = ex;
                    if (ex.Response != null)
                    {
                        outcome.StatusCode = (int)((HttpWebResponse)ex.Response).StatusCode;
                        outcome.Data = ParseExceptionResponse(ex).Trim();
                    }
                }
                catch (OperationCanceledException)
                {
                    Debug.WriteLine("Cancelled");
                }
                catch (Exception ex)
                {
                    outcome.Exception = ex;
                }
                finally { attempts += 1; }
            }
            return outcome;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectUris">Dictionary of string,Uri where the string value is used in the progress report. E.g. "Wipeout.7z" for roms or "Wipeout" for Gamename </param>
        /// <param name="objectType">Used in the constructing the progress report. E.g. "rom" will result in "Processing rom"</param>
        /// <param name="cancellationToken"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        internal List<ApiGetOutcome> GetStrings(Dictionary<ApiSearchParameters, Uri> objectUris,
                                                    string objectType,
                                                    CancellationToken cancellationToken,
                                                    IProgress<ProgressChangedEventArgs> progress = null)
        {

            ConcurrentBag<ApiGetOutcome> outcomes = new ConcurrentBag<ApiGetOutcome>();

            ParallelOptions parallelOptions = new ParallelOptions() { MaxDegreeOfParallelism = UserThreads };

            int total = objectUris.Count;
            string objectName = string.Empty;

            ApiGetOutcome outcome = new ApiGetOutcome();
            int attempts = 0;

            Stopwatch sw = Stopwatch.StartNew();

            Parallel.ForEach(objectUris, parallelOptions,
                                        (KeyValuePair<ApiSearchParameters, Uri> objectUri, ParallelLoopState state) =>
            {
                attempts = 0;
                outcome = new ApiGetOutcome();

                if (cancellationToken != null && cancellationToken.IsCancellationRequested)
                {
                    state.Break();
                }

                while (outcome.Successfull == false && attempts < webRequestAttempts)

                {
                    try
                    {
                        outcome = GetString(objectUri.Value);
                        outcome.AssociatedSearchParameters = objectUri.Key;
                        outcomes.Add(outcome);
                    }
                    catch (WebException ex)
                    {
                        outcome.Exception = ex;
                        if (ex.Response != null)
                        {
                            outcome.StatusCode = (int)((HttpWebResponse)ex.Response).StatusCode;
                            outcome.Data = ParseExceptionResponse(ex).Trim();
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        outcome.Data = "User Cancelled Operation";
                    }
                    catch (Exception ex)
                    {
                        outcome.Exception = ex;
                    }
                    finally { attempts += 1; }
                }

                objectName = outcome.AssociatedSearchParameters.GameName;
                if (objectName == null)
                {
                    objectName = outcome.AssociatedSearchParameters.RomName;
                }

                if (progress != null)
                {
                    progress.Report(new EventArgs.ProgressChangedEventArgs
                    {
                        DataObject = "Processed " + objectType + " (" + outcomes.Count + "/" + total + "): " + objectName,
                        Uri = objectUri.Value,
                        ProgressPercentage = Math.Min((int)((double)outcomes.Count / total * 100), 100),
                        Rate = (outcomes.Count / sw.Elapsed.TotalSeconds)
                    });
                }

            });

            return outcomes.ToList();
        }
        internal static string ParseExceptionResponse(WebException exception)
        {
            string responseContents;
            Stream descrption = ((HttpWebResponse)exception.Response).GetResponseStream();

            using (StreamReader readStream = new StreamReader(descrption))
            {
                responseContents = readStream.ReadToEnd();
            }

            return responseContents;

        }
    }
}
