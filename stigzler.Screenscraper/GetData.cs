using stigzler.Screenscraper.Data;
using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.Enums;
using stigzler.Screenscraper.EventArgs;
using stigzler.Screenscraper.Helpers;
using stigzler.Screenscraper.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading;
using help = stigzler.Screenscraper.Helpers;
using stigArgs = stigzler.Screenscraper.EventArgs;

namespace stigzler.Screenscraper
{
    /// <summary>
    /// This is the main Class used to retrieve data from the 
    /// ScreenScraper.fr API.
    /// Commonly, all Get requests take <see cref="Enums.ApiQueryType">ApiQueryType</see>.
    /// </summary>
    public class GetData
    {
        #region Properties

        /// <summary>
        /// Api and User credentials for accessing the API.
        /// </summary>
        public ApiCredentials Credentials { get; set; }

        /// <summary>
        /// Api specific parameters. <see cref="ApiServerParameters"/>
        /// </summary>
        public ApiServerParameters ApiParameters { get; set; }

        /// <summary>
        /// What format for any metadata output (xml or json)
        /// </summary>
        public MetadataOutput MetadataOutputFormat
        {
            get { return metadataOutputFormat; }
            set
            {
                metadataOutputFormat = value;
                urlBuilder.MetadataOutputType = metadataOutputFormat;
            }
        }
        /// <summary>
        /// How many threads the screenscraper User has available when using the API
        /// </summary>
        public int UserThreads
        {
            get { return userThreads; }
            set
            {
                userThreads = value;
                UpdateNumberThreads();
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

        private void UpdateNumberThreads()
        {
            // Set number of concurrent threads on server
            ServicePointManager.FindServicePoint(new Uri(ApiParameters.HostAddress)).ConnectionLimit = userThreads;
        }

        /// <summary>
        /// <para>The main method used to retrieve data from the 
        /// ScreenScraper API.  
        /// </para>    
        /// </summary>        
        /// <param name="credentials">API and User credentials</param>
        /// <param name="apiServerParameters">API and Query Server Parameters</param>
        /// <param name="userThreads">Specify number of API threads available to the user's account</param>
        public GetData(ApiCredentials credentials, ApiServerParameters apiServerParameters, int userThreads)
        {
            // Set Public Properties
            Credentials = credentials;
            ApiParameters = apiServerParameters;
            this.userThreads = userThreads;

            // Setup getDataService
            apiDataService = new ApiDataService(apiServerParameters, userThreads, apiServerParameters.HttpTimeout);
            urlBuilder = new ApiUrlBuilder(Credentials, ApiParameters);

            // Set number of threads on server
            UpdateNumberThreads();
        }

        /// <summary>
        /// Simple query to return the relevant lists from the API
        /// </summary>
        /// <param name="queryType">The type of query to perform.</param>
        /// <remarks>
        /// Viable queryTypes:
        /// <list type = "table">
        ///    <listheader>
        ///        <term>Type</term>
        ///       <description> description </description>
        ///    </listheader>
        ///    <item>
        ///        <term cref="ApiQueryType.ClassificaitonList">ApiQueryType.ClassificaitonList</term>
        ///        <description>Returns all age Classifications</description>
        ///    </item>
        ///    <item>
        ///        <term cref="ApiQueryType.GameInfoList">ApiQueryType.GameInfoList</term>
        ///       <description>This returns the different game data properties. 
        ///       <example>Family, Mode, Number, Resolution, Themes</example>
        ///       </description>
        ///    </item>
        /// </list>
        /// <exception cref="Exceptions.QueryMismatchException">
        /// QueryMismatchException thrown if wrong form of query sent to this method. Only takes download queries. 
        /// <remarks><see cref="Exceptions.QueryMismatchException"/></remarks>
        /// </exception>
        /// <returns>An ApiGetOutcome object containing pertinent results of the Get request. The ApiGetOutcome.Data in this case is the returned xml/json or any error message</returns>

        public ApiGetOutcome GetListOrInfo(ApiQueryType queryType)
        {
            // First check acceptable query type
            ApiQueryGroup apiQueryGroup = Constants.ApiQueryGroups.FirstOrDefault(x => x.Value.Contains(queryType)).Key;
            if (apiQueryGroup != ApiQueryGroup.InfoAndLists) throw new Exceptions.QueryMismatchException(queryType, ApiQueryGroup.InfoAndLists);

            string uriStr = urlBuilder.Build(queryType);
            ApiGetOutcome apiGetOutcome = apiDataService.GetString(new Uri(uriStr));
            return apiGetOutcome;
        }

        /// <summary>
        /// Downloads a file if one available. Covers various download functions for 
        /// Game and System Images/Videos/Manuals/Company/Genre etc
        /// </summary>
        /// <param name="queryType">The type of Download Query.</param>
        /// <param name="downloadParameters">Parameters related to the download.</param>
        /// <param name="destinationFilename">The full filename to save the file as (with path, filename and extension).</param>
        /// <exception cref="Exceptions.QueryMismatchException">
        /// QueryMismatchException thrown if wrong form of query sent to this method. Only takes download queries. 
        /// </exception>
        /// <returns>An ApiGetOutcome object containing pertinent results of the Get request. The ApiGetOutcome.Data in this case is the returned xml/json or any error message</returns>

        public ApiGetOutcome GetFile(ApiQueryType queryType, APIDownloadParameters downloadParameters, string destinationFilename)
        {
            // First check acceptable query type
            ApiQueryGroup apiQueryGroup = Constants.ApiQueryGroups.FirstOrDefault(x => x.Value.Contains(queryType)).Key;
            if (apiQueryGroup != ApiQueryGroup.Downloads) throw new Exceptions.QueryMismatchException(queryType, ApiQueryGroup.Downloads);

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

        /// <summary>
        /// Gets game information via romname or gamename. 
        /// Query types supported: GameNameSearch, GameRomSearch
        /// </summary>
        /// <param name="gameSearchParametersList">Parameters for each game search</param>
        /// <param name="queryType">Type of query to return. Query types supported: GameNameSearch, GameRomSearch</param>
        /// <param name="cancellationToken">Any cancellation token</param>
        /// <param name="progress">IProgress object for updates on progress</param>
        /// <returns></returns>
        public List<ApiGetOutcome> GetGamesInfo(List<ApiSearchParameters> gameSearchParametersList, ApiQueryType queryType,
                                                            CancellationToken? cancellationToken = null,
                                                            IProgress<EventArgs.ProgressChangedEventArgs> progress = null)
        {
            ApiQueryGroup apiQueryGroup = Constants.ApiQueryGroups.FirstOrDefault(x => x.Value.Contains(queryType)).Key;
            if (apiQueryGroup != ApiQueryGroup.Searches) throw new Exceptions.QueryMismatchException(queryType, ApiQueryGroup.Searches);

            string progressUpdateObjectText = "RomName";

            List<QueryParameter> parameters = new List<QueryParameter>();
            Dictionary<string, Uri> gameSerachList = new Dictionary<string, Uri>();

            // Set number of concurrent threads on server
            ServicePointManager.FindServicePoint(new Uri(ApiParameters.HostAddress)).ConnectionLimit = userThreads;

            string gameSearchObjectLabel;

            // Construct all Uris:
            foreach (ApiSearchParameters gameSearchParameters in gameSearchParametersList)
            {
                parameters.Clear();
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.SystemID, Value = gameSearchParameters.SystemID.ToString() });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.GameID, Value = gameSearchParameters.GameID.ToString() });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.GameName, Value = gameSearchParameters.GameName });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.RomName, Value = gameSearchParameters.RomName });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.CRC, Value = gameSearchParameters.CRC });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.MD5, Value = gameSearchParameters.MD5 });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.SHA1, Value = gameSearchParameters.SHA1 });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.RomFileType, Value = gameSearchParameters.RomFileType });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.RomSize, Value = gameSearchParameters.RomSize.ToString() });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.SeriaNumber, Value = gameSearchParameters.SerialNumber.ToString() });

                gameSearchObjectLabel = string.Empty;
                if (gameSearchParameters.GameID != -1) gameSearchObjectLabel += "(" + gameSearchParameters.GameID + ") ";
                if (gameSearchParameters.GameName != null) gameSearchObjectLabel += gameSearchParameters.GameName;
                if (gameSearchParameters.RomName != null) gameSearchObjectLabel += gameSearchParameters.RomName;



                if (queryType == ApiQueryType.GameNameSearch)
                {
                    gameSerachList.Add(gameSearchParameters.GameName, new Uri(urlBuilder.Build(ApiQueryType.GameNameSearch, parameters)));
                    progressUpdateObjectText = "GameName";
                }
                else if (queryType == ApiQueryType.GameRomSearch)
                {
                    gameSerachList.Add(gameSearchObjectLabel, new Uri(urlBuilder.Build(ApiQueryType.GameRomSearch, parameters)));
                }

            }
            // Get API Data:
            List<ApiGetOutcome> apiGetOutcomes = new List<ApiGetOutcome>();
            apiGetOutcomes = apiDataService.GetStrings(gameSerachList, progressUpdateObjectText, cancellationToken, progress);

            return apiGetOutcomes;
        }

        /// <summary>
        /// Gets game information via romname or gamename. 
        /// Query types supported: GameNameSearch, GameRomSearch
        /// </summary>
        /// <param name="gameSearchParameters">Parameters for the game search</param>
        /// <param name="queryType">Type of query to return. Query types supported: GameNameSearch, GameRomSearch</param>
        /// <param name="cancellationToken">Any cancellation token</param>
        /// <param name="progress">IProgress object for updates on progress.</param>
        /// <returns></returns>

        public ApiGetOutcome GetGameInfo(ApiSearchParameters gameSearchParameters, ApiQueryType queryType,
                CancellationToken? cancellationToken = null, IProgress<EventArgs.ProgressChangedEventArgs> progress = null)
        {
            ApiQueryGroup apiQueryGroup = Constants.ApiQueryGroups.FirstOrDefault(x => x.Value.Contains(queryType)).Key;
            if (apiQueryGroup != ApiQueryGroup.Searches) throw new Exceptions.QueryMismatchException(queryType, ApiQueryGroup.Searches);

            List<ApiSearchParameters> apiSearchParametersToList = new List<ApiSearchParameters>();
            apiSearchParametersToList.Add(gameSearchParameters);

            List<ApiGetOutcome> apiGetOutcomes = new List<ApiGetOutcome>();
            apiGetOutcomes = GetGamesInfo(apiSearchParametersToList, queryType, cancellationToken, progress);

            return apiGetOutcomes[0];
        }
    }
}
