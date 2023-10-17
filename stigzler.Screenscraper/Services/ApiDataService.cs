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

namespace stigzler.Screenscraper.Services
{
    internal class ApiDataService

    {
        private ApiServerParameters apiServerParameters;
        private int maxThreads;
        private int requestTimeout;
        // internal event EventHandler<EventArgs.ProgressChangedEventArgs> OperationUpdate;

        internal ApiDataService(ApiServerParameters apiServerParameters, int maxThreads, int requestTimeout)
        {
            this.apiServerParameters = apiServerParameters;
            this.maxThreads = maxThreads;
            this.requestTimeout = requestTimeout;
        }

        internal ApiGetOutcome GetFile(Uri uri, string destinationFilename)
        {
            ModifiedNet.WebClient webClient = new ModifiedNet.WebClient(requestTimeout);
            ApiGetOutcome outcome = new ApiGetOutcome();
            outcome.Uri = uri;
            //object result = null;

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

            return outcome;
        }


        internal ApiGetOutcome GetString(Uri uri)
        {
            ModifiedNet.WebClient webClient = new ModifiedNet.WebClient(requestTimeout);
            ApiGetOutcome outcome = new ApiGetOutcome();
            outcome.Uri = uri;
            string result = null;

            try
            {
                result = webClient.DownloadString(uri);
                outcome.Successfull = true;
                outcome.StatusCode = 200;
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

            //CancellationToken resolvedCancellationToken;
            //if (cancellationToken != null) { resolvedCancellationToken = (CancellationToken) cancellationToken; }
            //else { resolvedCancellationToken = new CancellationToken(); }
            
            ParallelOptions parallelOptions = new ParallelOptions()
            {
                MaxDegreeOfParallelism = maxThreads,
            };

            int total = objectUris.Count;
            string objectName = string.Empty;

            Stopwatch sw = Stopwatch.StartNew();

            Parallel.ForEach(objectUris, parallelOptions, (KeyValuePair<ApiSearchParameters, Uri> objectUri, ParallelLoopState state) =>
            {
                if (cancellationToken != null && cancellationToken.IsCancellationRequested)
                {
                    state.Break();
                }
                var outcome = GetString(objectUri.Value);
                outcome.AssociatedSearchParameters = objectUri.Key;
                outcomes.Add(outcome);

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
                        ProgressPercentage = (int)((double)outcomes.Count / total * 100),
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
