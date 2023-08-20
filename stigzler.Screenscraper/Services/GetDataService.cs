using stigzler.Screenscraper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Services
{
    internal class GetDataService

    {
        internal ApiServerParameters ApiServerParameters { get; set; }
        internal int MaxConcurrentRequests { get; set; } = 1;
        internal HttpClient HttpClient { get; set; }


        // Operational
        private SemaphoreSlim semaphore;

        internal GetDataService(ApiServerParameters apiServerParameters, int concurrentRequests, HttpClient httpClient)
        {
            ApiServerParameters = apiServerParameters;
            semaphore = new SemaphoreSlim(concurrentRequests);
            HttpClient = httpClient;
        }

        internal async Task<List<ApiGetOutcome>> GetUrlListData(List<string> UrlList)
        {
            List<ApiGetOutcome> results = new List<ApiGetOutcome>();
            foreach (string url in UrlList)
            {
                var result = await Task.Run(() => GetUrlData(url).Result);
                results.Add(result);
            }

            return results;
        }

        private async Task<ApiGetOutcome> GetUrlData(string Url)
        {
            ApiGetOutcome outcome = new ApiGetOutcome();
            outcome.Url = Url;
            try
            {
                await semaphore.WaitAsync();

                var response = await HttpClient.GetAsync(Url);

                outcome.HttpStatus = response.StatusCode;
                outcome.Successfull = true;
                outcome.Data = response.Content;

            }
            catch (Exception ex)
            {
                outcome.Exception = ex;
            }
            finally
            {
                semaphore.Release();
            }

            return outcome;

        }





    }
}
