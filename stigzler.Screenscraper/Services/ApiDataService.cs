using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.ModifiedNet;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
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

        internal ApiDataService(ApiServerParameters apiServerParameters, int maxThreads, int requestTimeout)
        {
            this.apiServerParameters = apiServerParameters;
            this.maxThreads = maxThreads;
            this.requestTimeout = requestTimeout;
        }

        //internal async Task<List<ApiGetOutcome>> GetUrlListData(List<string> UrlList)
        //{
        //    ConcurrentBag<ApiGetOutcome> results = new ConcurrentBag<ApiGetOutcome>();
        //    //foreach (string url in UrlList)
        //    Parallel.ForEach(UrlList, new ParallelOptions() { MaxDegreeOfParallelism = 7 }, async url =>
        //    {
        //      //  var result = await Task.Run(() => GetUrlData(url).Result);
        //        results.Add(result);
        //        Debug.WriteLine(results.Count);
        //    });
        //    return results.ToList();
        //}

        internal List<ApiGetOutcome> GetStrings(List<Uri> uris)
        {

            Stopwatch sw = Stopwatch.StartNew();
            ConcurrentBag<ApiGetOutcome> outcomes = new ConcurrentBag<ApiGetOutcome>();

            //Parallel.ForEach(uris, new ParallelOptions() { MaxDegreeOfParallelism = maxThreads }, uri =>
            //{
            //    using (ModifiedNet.WebClient webClient = new ModifiedNet.WebClient(requestTimeout))
            //    {
            //        var result = webClient.DownloadString(uri);
            //        outcomes.Add(new ApiGetOutcome() { Data = result, Uri = uri });
            //        Debug.WriteLine(outcomes.Count + ". Rate: " + outcomes.Count / sw.Elapsed.TotalSeconds);
            //    }
            //});



            Parallel.ForEach(uris, new ParallelOptions() { MaxDegreeOfParallelism = maxThreads }, uri =>
            {
                outcomes.Add(GetString(uri));
                Debug.WriteLine(outcomes.Count + ". Rate: " + outcomes.Count / sw.Elapsed.TotalSeconds);
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
