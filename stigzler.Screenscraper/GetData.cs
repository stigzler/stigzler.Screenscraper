using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.Enums;
using stigzler.Screenscraper.EventArgs;
using stigzler.Screenscraper.Helpers;
using stigzler.Screenscraper.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using help = stigzler.Screenscraper.Helpers;

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
                userThreads = value;

                //if (value > Data.Constants.MaxApiThreads)
                //{ throw new ArgumentException("UserThreads cannot exceed the maximum for the Screenscraper API server: " + Data.Constants.MaxApiThreads); }
                //else
                //{
                //    userThreads = value;
                //}
            }
        }

        // Any Property private members
        private int userThreads = 1;
        private MetadataOutput metadataOutputFormat = MetadataOutput.xml;
        #endregion

        // Class level private vars
        private ApiUrlBuilder urlBuilder;
        private ApiDataService apiDataService;

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
        }

        public ApiGetOutcome GetListOrInfo(ApiQueryType queryType)
        {
            string uriStr = urlBuilder.Build(queryType);
            ApiGetOutcome apiGetOutcome = apiDataService.GetString(new Uri(uriStr));
            return apiGetOutcome;
        }

        public ApiGetOutcome GetFile(ApiQueryType queryType, APIDownloadParameters downloadParameters, string destinationFilename)
        {
            List<QueryParameter> parameters = new List<QueryParameter>()
            {
            new QueryParameter() { Parameter = ApiQueryParameter.CRC, Value = downloadParameters.CRC },
            new QueryParameter() { Parameter = ApiQueryParameter.MD5, Value = downloadParameters.MD5 },
            new QueryParameter() { Parameter = ApiQueryParameter.SHA1, Value = downloadParameters.SHA1 },
            new QueryParameter() { Parameter = ApiQueryParameter.MediaTypeName, Value = downloadParameters.MediaTypeName },
            new QueryParameter() { Parameter = ApiQueryParameter.MediaFormat, Value = downloadParameters.MediaFormat },
            new QueryParameter() { Parameter = ApiQueryParameter.SystemID, Value = downloadParameters.SystemID.ToString() }
            };

            switch (queryType)
            {
                case ApiQueryType.GameImageDownload:
                case ApiQueryType.GameVideoDownload:
                case ApiQueryType.GameManualDownload:
                    parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.GameID, Value = downloadParameters.ObjectID.ToString() });
                    break;
                case ApiQueryType.GameGenreImageDownload:
                    parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.GenreID, Value = downloadParameters.ObjectID.ToString() });
                    break;
                case ApiQueryType.GameOrganisationImageDownload:
                    parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.OrganisationID, Value = downloadParameters.ObjectID.ToString() });
                    break;
                default:
                    break;
            }

            string uriStr = urlBuilder.Build(queryType, parameters);
            ApiGetOutcome apiGetOutcome = apiDataService.GetFile(new Uri(uriStr), destinationFilename);

            return apiGetOutcome;
        }

        public List<ApiGetOutcome> GetGamesInfo(int systemID, List<string> romNames,
                                                            CancellationToken cancellationToken,
                                                            IProgress<ProgressChangedEventArgs> progress = null)
        {
            List<QueryParameter> parameters = new List<QueryParameter>();
            Dictionary<string, Uri> romUrisList = new Dictionary<string, Uri>();

            // Set number of concurrent threads on server
            ServicePointManager.FindServicePoint(new Uri(ApiParameters.HostAddress)).ConnectionLimit = userThreads;

            // Construct all Uris:
            foreach (string romname in romNames)
            {
                parameters.Clear();
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.RomFilename, Value = romname });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.SystemID, Value = systemID.ToString() });
                romUrisList.Add(romname, new Uri(urlBuilder.Build(ApiQueryType.GameRomSearch, parameters)));
            }

            // Get API Data:
            List<ApiGetOutcome> apiGetOutcomes = new List<ApiGetOutcome>();
            apiGetOutcomes = apiDataService.GetStrings(romUrisList, "rom", cancellationToken, progress);

            return apiGetOutcomes;
        }
    }
}
