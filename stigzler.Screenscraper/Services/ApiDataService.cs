using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.EventArgs;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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
                    outcome.Data = ParseExceptionRespose(ex).Trim();
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
        /// <param name="objectName">Used in the constructing the progress report. E.g. "rom" will result in "Processing rom"</param>
        /// <param name="cancellationToken"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        internal List<ApiGetOutcome> GetStrings(Dictionary<string, Uri> objectUris,
                                                    string objectName,
                                                    CancellationToken cancellationToken,
                                                    IProgress<ProgressChangedEventArgs> progress)
        {

            Stopwatch sw = Stopwatch.StartNew();
            ConcurrentBag<ApiGetOutcome> outcomes = new ConcurrentBag<ApiGetOutcome>();

            ParallelOptions parallelOptions = new ParallelOptions()
            {
                MaxDegreeOfParallelism = maxThreads,
            };

            int total = objectUris.Count;

            Parallel.ForEach(objectUris, parallelOptions, (KeyValuePair<string, Uri> objectUri, ParallelLoopState state) =>
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    state.Break();
                }

                outcomes.Add(GetString(objectUri.Value));

                progress.Report(new EventArgs.ProgressChangedEventArgs
                {
                    DataObject = "Processed " + objectName + " (" + outcomes.Count + "/" + total + "): " + objectUri.Key,
                    Uri = objectUri.Value,
                    ProgressPercentage = (int)((double)outcomes.Count / total * 100),
                    Rate = (outcomes.Count / sw.Elapsed.TotalSeconds)
                });

            });

            return outcomes.ToList();
        }




        public static string ParseExceptionRespose(WebException exception)
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
