using stigzler.Screenscraper.Data.Models;
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
        internal event EventHandler<EventArgs.ProgressChangedEventArgs> OperationUpdate;

        internal ApiDataService(ApiServerParameters apiServerParameters, int maxThreads, int requestTimeout)
        {
            this.apiServerParameters = apiServerParameters;
            this.maxThreads = maxThreads;
            this.requestTimeout = requestTimeout;
        }
        internal List<ApiGetOutcome> GetStrings(Dictionary<string, Uri> objectUris, CancellationToken cancellationToken)
        {

            Stopwatch sw = Stopwatch.StartNew();
            ConcurrentBag<ApiGetOutcome> outcomes = new ConcurrentBag<ApiGetOutcome>();

            ParallelOptions parallelOptions = new ParallelOptions()
            {
                MaxDegreeOfParallelism = maxThreads,
                CancellationToken = cancellationToken
            };

            Parallel.ForEach(objectUris, parallelOptions, objectUri =>
            {
                try
                {
                    if (!parallelOptions.CancellationToken.IsCancellationRequested)
                    {
                        int total = objectUris.Count;
                        outcomes.Add(GetString(objectUri.Value));

                        if (!parallelOptions.CancellationToken.IsCancellationRequested)
                        {
                            OperationUpdate.Invoke(this, new EventArgs.ProgressChangedEventArgs
                            {
                                DataObject = "Processed object: " + objectUri.Key,
                                Uri = objectUri.Value,
                                ProgressPercentage = (int)((double)outcomes.Count / total * 100),
                                Rate = (outcomes.Count / sw.Elapsed.TotalSeconds)
                            });
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    Debug.WriteLine("Canceled");
                }

            });

            return outcomes.ToList();
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
