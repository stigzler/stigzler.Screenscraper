using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.Enums;
using stigzler.Screenscraper.EventArgs;
using stigzler.Screenscraper.Helpers;
using stigzler.Screenscraper.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace stigzler.Screenscraper
{
    public class GetData
    {
        #region Properties

        // Public Members
        public Credentials Credentials { get; set; }
        public ApiServerParameters ApiParameters { get; set; }
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
                }
            }
        }

        // Any Property private members
        private int userThreads = 1;
        private MetadataOutput metadataOutputFormat = MetadataOutput.xml;
        #endregion

        // Class level private vars
        private ApiUrlBuilder urlBuilder;
        private ApiDataService apiDataService;
        private IProgress<ProgressChangedEventArgs> progress;
        CancellationToken cancellationToken;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="credentials">Request Credentials</param>
        /// <param name="apiServerParameters">Server Parameters</param>
        /// <param name="userThreads">Specify number of API threads available to user</param>
        public GetData(Credentials credentials, ApiServerParameters apiServerParameters, int userThreads)
        {
            // Set Public Properties
            Credentials = credentials;
            ApiParameters = apiServerParameters;
            this.userThreads = userThreads;

            // Setup getDataService
            apiDataService = new ApiDataService(apiServerParameters, userThreads, apiServerParameters.HttpTimeout);
            urlBuilder = new ApiUrlBuilder(Credentials, ApiParameters);

            apiDataService.OperationUpdate += ApiDataService_OperationUpdate;

        }

        private void ApiDataService_OperationUpdate(object sender, ProgressChangedEventArgs e)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                progress.Report(e);
            }
        }

        public async Task<ApiGetOutcome> GetApiServerInfo()
        {
            List<string> urlList = new List<string> { urlBuilder.Build(ApiQueryType.ServerInfo) };
            var result = await Task.Run(() => apiDataService.GetString(new Uri(urlBuilder.Build(ApiQueryType.ServerInfo))));
            return result;
        }

        public async Task<ApiGetOutcome> GetUserInfo()
        {
            List<string> urlList = new List<string> { urlBuilder.Build(ApiQueryType.UserInfo) };
            var result = await Task.Run(() => apiDataService.GetString(new Uri(urlBuilder.Build(ApiQueryType.UserInfo))));
            return result;
        }

        public async Task<ApiGetOutcome> GetSystemList()
        {
            List<string> urlList = new List<string> { urlBuilder.Build(ApiQueryType.SystemList) };
            var result = await Task.Run(() => apiDataService.GetString(new Uri(urlBuilder.Build(ApiQueryType.SystemList))));
            return result;
        }

        public async Task<List<ApiGetOutcome>> GetGamesInfo(int systemID, List<string> romNames,
            CancellationToken cancellationToken,
            IProgress<ProgressChangedEventArgs> progress = null)
        {
            List<QueryParameter> parameters = new List<QueryParameter>();
            Dictionary<string,Uri> romUrisList = new Dictionary<string, Uri>();

            this.progress = (Progress<ProgressChangedEventArgs>)progress;
            this.cancellationToken = cancellationToken;

            // Set number of concurrent threads on server
            ServicePointManager.FindServicePoint(new Uri(ApiParameters.HostAddress)).ConnectionLimit = userThreads;

            // Construct all Uris:
            foreach (string romname in romNames)
            {
                parameters.Clear();
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.RomFilename, Value = romname });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.SystemID, Value = systemID.ToString() });
                romUrisList.Add(romname, new Uri(urlBuilder.Build(ApiQueryType.GameInfo, parameters)));
            }

            // Get outcomes:
            List<ApiGetOutcome> apiGetOutcomes = new List<ApiGetOutcome>();
            apiGetOutcomes = await Task.Run(() => apiDataService.GetStrings(romUrisList, cancellationToken));

            return apiGetOutcomes;
        }

   



    }
}
