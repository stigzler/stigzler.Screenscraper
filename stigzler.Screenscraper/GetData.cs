using stigzler.Screenscraper.Data;
using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.Enums;
using stigzler.Screenscraper.Helpers;
using stigzler.Screenscraper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper
{
    public class GetData
    {
        #region Properties

        // Public Members
        public Credentials Credentials { get; set; }
        public ApiServerParameters ApiParameters { get; set; }
        public HttpClient HttpClient { get; set; }
        public MetadataOutput MetadataOutputFormat
        {
            get { return metadataOutputFormat; }
            set
            {
                metadataOutputFormat = value;
                urlBuilder.MetadataOutputType = metadataOutputFormat;
            }
        }
        public int UserThreads
        {
            get { return userThreads; }
            set
            {
                if (value > Data.Constants.MaxApiThreads)
                { throw new ArgumentException("UserThreads cannot exceed the maximum for the Screenscraper API server: " + Data.Constants.MaxApiThreads); }
                else
                {
                    userThreads = value;
                    SetNumberApiThreads();
                }
            }
        }




        // Any Property private members
        private int userThreads = 1;
        private MetadataOutput metadataOutputFormat = MetadataOutput.xml;

        #endregion



        // Class level private vars
        private ApiUrlBuilder urlBuilder;
        private GetDataService getDataService;

        public GetData(Credentials credentials, ApiServerParameters apiServerParameters, HttpClient httpClient)
        {
            // Set Public Properties
            Credentials = credentials;
            ApiParameters = apiServerParameters;
            HttpClient = httpClient;

            // Set threads to default of 1
            ServicePointManager.FindServicePoint(new Uri(ApiParameters.HostAddress)).ConnectionLimit = 1;

            // Setup getDataService
            getDataService = new GetDataService(apiServerParameters, UserThreads, HttpClient);

            urlBuilder = new ApiUrlBuilder(Credentials, ApiParameters);

        }

        private void SetNumberApiThreads()
        {
            getDataService.MaxConcurrentRequests = UserThreads;
            ServicePointManager.FindServicePoint(new Uri(ApiParameters.HostAddress)).ConnectionLimit = userThreads;
        }

        public async Task<ApiGetOutcome> GetApiServerInfo()
        {
            List<string> urlList = new List<string> { urlBuilder.Build(ApiQueryType.ServerInfo) };
            var result = await Task.Run(() => getDataService.GetUrlListData(urlList));


            //Progress<OperationProgressChangedEventArgs> progress = new Progress<OperationProgressChangedEventArgs>();
            //progress.ProgressChanged += Progress_ProgressChanged;
            //bool EmptySuccessful = await Task.Run(() => Method(progress));

            return result.First(); // First, because this operation only has one entry
        }

        public async Task<ApiGetOutcome> GetUserInfo()
        {
            List<string> urlList = new List<string> { urlBuilder.Build(ApiQueryType.UserInfo) };

            var result = await Task.Run(() => getDataService.GetUrlListData(urlList));
            return result.First(); // First, because this operation only has one entry
        }

        public async Task<List<ApiGetOutcome>> GetGameInfo(int systemID, List<string> romNames)
        {
            List<QueryParameter> parameters = new List<QueryParameter>();
            List<string> urlList = new List<string>();
            foreach (string romname in romNames)
            {
                parameters.Clear();
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.RomFilename, Value = romname});
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.SystemID, Value = systemID.ToString() });

                urlList.Add(urlBuilder.Build(ApiQueryType.GameInfo, parameters));
            }
            var result = await Task.Run(() => getDataService.GetUrlListData(urlList));
            return result; // First, because this operation only has one entry


        }




    }
}
