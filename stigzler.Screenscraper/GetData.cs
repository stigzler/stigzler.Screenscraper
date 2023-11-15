using stigzler.Screenscraper.Data;
using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.Enums;
using stigzler.Screenscraper.EventArgs;
using stigzler.Screenscraper.Helpers;
using stigzler.Screenscraper.Services;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;
using help = stigzler.Screenscraper.Helpers;
using stigArgs = stigzler.Screenscraper.EventArgs;

namespace stigzler.Screenscraper
{
    /// <summary>
    /// This is the main Class used to retrieve data from the 
    /// ScreenScraper.fr API.
    /// Commonly, all Get requests take <see cref="Enums.ApiQueryType">ApiQueryType</see>.
    /// </summary>    /// 
    /// I know the design of this is wonky given how it handles batch/singular operations
    /// However, life's too fucking short so, meh. Crackhouse coding, baby. 

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
                SetNumberApiThreads();
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

        private void SetNumberApiThreads()
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
        public GetData(ApiCredentials credentials, ApiServerParameters apiServerParameters, int userThreads = 1)
        {
            // Set Public Properties
            Credentials = credentials;
            ApiParameters = apiServerParameters;
            this.userThreads = userThreads;

            // Setup getDataService
            apiDataService = new ApiDataService(apiServerParameters, userThreads, apiServerParameters.HttpTimeout);
            urlBuilder = new ApiUrlBuilder(Credentials, ApiParameters);

            // Set number of threads on server
            SetNumberApiThreads();
        }

        /// <summary>
        /// Simple query to return the relevant lists from the API
        /// </summary>
        /// <param name="queryType">The type of query to perform.</param>
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

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="queryType">The type of Download Query.</param>
        ///// <param name="parametersAndFilenames">Dictionary of DownloadParameters and their desired filenames</param>
        ///// <param name="cancellationToken">[Optional] Cancellation Token if required. Use <code>CancellationToken.None</code> if not needed.</param>
        ///// <param name="progress">[Optional] IProgress object for updates on progress</param>
        ///// <returns></returns>
        //public List<ApiGetOutcome> GetFiles(ApiQueryType queryType, List<ApiDownloadParameters> downloadParameters,
        //                                    CancellationToken cancellationToken = default(CancellationToken),
        //                                    IProgress<EventArgs.ProgressChangedEventArgs> progress = null)
        //{
        //    ConcurrentBag<ApiGetOutcome> outcomes = new ConcurrentBag<ApiGetOutcome>();

        //    SetNumberApiThreads(); // this may be redundant

        //    // Set the paralell.ForEach max parallelism to the thread count
        //    ParallelOptions parallelOptions = new ParallelOptions() { MaxDegreeOfParallelism = userThreads };

        //    ApiDownloadParameters downloadParameters = new ApiDownloadParameters();
        //    string filename = string.Empty;

        //    int total = parametersAndFilenames.Count;

        //    Stopwatch sw = Stopwatch.StartNew();

        //    Parallel.ForEach(parametersAndFilenames, parallelOptions, (KeyValuePair<ApiDownloadParameters, string> parametersAndFilename, ParallelLoopState state) =>
        //    {
        //        // Checks cancellation token. If set, breaks out of parallel foreach loop
        //        if (cancellationToken != null && cancellationToken.IsCancellationRequested)
        //        {
        //            state.Break();
        //        }

        //        downloadParameters = parametersAndFilename.Key;
        //        filename = parametersAndFilename.Value;

        //        // Do File get.
        //        ApiGetOutcome outcome = GetFile(queryType, downloadParameters, filename);
        //        outcome.AssociatedDownloadParameters = downloadParameters;

        //        // Now process progress object if set
        //        if (progress != null)
        //        {
        //            progress.Report(new EventArgs.ProgressChangedEventArgs
        //            {
        //                DataObject = "Downloaded file: " + downloadParameters.MediaTypeName + " (" + outcomes.Count + "/" + total + ")",
        //                Uri = outcome.Uri,
        //                ProgressPercentage = (int)((double)outcomes.Count / total * 100),
        //                Rate = (outcomes.Count / sw.Elapsed.TotalSeconds)
        //            });
        //        }

        //    });
        //    sw.Stop();
        //    return outcomes.ToList();
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="downloadsParameters">ApiDownloadParameters containing Uris and their desired Filenames</param>
        /// <param name="cancellationToken">[Optional] Cancellation Token if required. Use <code>CancellationToken.None</code> if not needed.</param>
        /// <param name="progress">[Optional] IProgress object for updates on progress</param>
        /// <returns></returns>
        public List<ApiGetOutcome> GetFilesFromUris(List<ApiDownloadParameters> downloadsParameters,
                                            CancellationToken cancellationToken = default(CancellationToken),
                                            IProgress<EventArgs.ProgressChangedEventArgs> progress = null)
        {
            ConcurrentBag<ApiGetOutcome> outcomes = new ConcurrentBag<ApiGetOutcome>();

            SetNumberApiThreads(); // this may be redundant

            // Set the paralell.ForEach max parallelism to the thread count
            ParallelOptions parallelOptions = new ParallelOptions() { MaxDegreeOfParallelism = userThreads };
            Debug.WriteLine("Degrees of Parallelism = " + UserThreads);

            string filename = string.Empty;

            int total = downloadsParameters.Count;

            Stopwatch sw = Stopwatch.StartNew();

            Parallel.ForEach(downloadsParameters, parallelOptions,
                             (ApiDownloadParameters downloadParameters, ParallelLoopState state) =>
            {
                Thread.Sleep(100);
                // Checks cancellation token. If set, breaks out of parallel foreach loop
                if (cancellationToken != null && cancellationToken.IsCancellationRequested)
                {
                    state.Break();
                }

                // Do File get.
                //ApiGetOutcome outcome = GetFileFromUri(downloadParameters);
                ApiGetOutcome outcome = apiDataService.GetFile(downloadParameters.DirectUri, downloadParameters.Filename);


                outcomes.Add(outcome);

                // Now process progress object if set
                if (progress != null)
                {
                    progress.Report(new EventArgs.ProgressChangedEventArgs
                    {
                        DataObject = "Downloaded media to file: " + Path.GetFileName(filename) + " (" + outcomes.Count + "/" + total + ")",
                        Uri = outcome.Uri,
                        ProgressPercentage = Math.Min( (int)((double)outcomes.Count / total * 100), 100),
                        Rate = (outcomes.Count / sw.Elapsed.TotalSeconds)
                    });
                }

            });
            sw.Stop();
            return outcomes.ToList();
        }


        /// <summary>
        /// Downloads a file if one available.Covers various download functions for 
        /// Game and System Images/Videos/Manuals/Company/Genre etc
        /// </summary>
        /// <param name = "queryType" > The type of Download Query.</param>
        /// <param name = "downloadParameters" > Parameters related to the download.</param>
        /// <param name = "destinationFilename" > The full filename to save the file as (with path, filename and extension).</param>
        /// <exception cref = "Exceptions.QueryMismatchException" >
        /// QueryMismatchException thrown if wrong form of query sent to this method.Only takes download queries.
        /// </exception>
        /// <returns>
        /// An ApiGetOutcome object containing pertinent results of the Get request. 
        /// The ApiGetOutcome.Data in this case is the returned xml/json or any error message.
        /// ApiGetOutcome.AssociatedDownloadParameters contains the original Parameters plus the constructed Uri
        /// </returns>

        public ApiGetOutcome GetFileFromDetails(ApiQueryType queryType, ApiDownloadParameters downloadParameters, string destinationFilename)
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
                    parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.DownloadGameID, Value = downloadParameters.ObjectID.ToString() });
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

            string uriString = urlBuilder.Build(queryType, parameters);
            ApiGetOutcome apiGetOutcome = apiDataService.GetFile(new Uri(uriString), destinationFilename);
            apiGetOutcome.AssociatedDownloadParameters = downloadParameters;

            return apiGetOutcome;
        }

        /// <summary>
        /// Get file directly from the Uri for the media resource.
        /// Often used where you already know the full Uri via Searches such as ApiQueryType.GameRomSearch
        /// 
        /// </summary>
        /// <param name="downloadParameters">
        /// You must supply both the Uri and Filename in this data object. 
        /// </param>
        /// <returns>
        /// An ApiGetOutcome object containing pertinent results of the Get request. 
        /// The ApiGetOutcome.Data in this case is the returned xml/json or any error message.
        /// </returns>
        public ApiGetOutcome GetFileFromUri(ApiDownloadParameters downloadParameters)
        {
            ApiGetOutcome apiGetOutcome = apiDataService.GetFile(downloadParameters.DirectUri, downloadParameters.Filename);
            return apiGetOutcome;
        }

        /// <summary>
        /// Gets game information via romname or gamename. 
        /// Query types supported: GameNameSearch, GameRomSearch
        /// </summary>
        /// <param name="gameSearchParametersList">Parameters for each game search</param>
        /// <param name="queryType">Type of query to return. Query types supported: GameNameSearch, GameRomSearch</param>
        /// <param name="cancellationToken">[Optional] Cancellation Token if required. Use <code>CancellationToken.None</code> if not needed.</param>
        /// <param name="progress">[Optional] IProgress object for updates on progress</param>
        /// <returns></returns>
        public List<ApiGetOutcome> GetGamesInfo(List<ApiSearchParameters> gameSearchParametersList, ApiQueryType queryType,
                                                            CancellationToken cancellationToken = default(CancellationToken),
                                                            IProgress<EventArgs.ProgressChangedEventArgs> progress = null)
        {
            ApiQueryGroup apiQueryGroup = Constants.ApiQueryGroups.FirstOrDefault(x => x.Value.Contains(queryType)).Key;
            if (apiQueryGroup != ApiQueryGroup.Searches) throw new Exceptions.QueryMismatchException(queryType, ApiQueryGroup.Searches);

            string progressUpdateObjectText = "RomName";

            List<QueryParameter> parameters = new List<QueryParameter>();
            Dictionary<ApiSearchParameters, Uri> gameSearchDict = new Dictionary<ApiSearchParameters, Uri>();

            // Set number of concurrent threads on server
            SetNumberApiThreads(); // this may be redundant

            string gameSearchObjectLabel;

            // Construct all Uris:
            foreach (ApiSearchParameters gameSearchParameters in gameSearchParametersList)
            {
                parameters.Clear();
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.SystemID, Value = gameSearchParameters.SystemID.ToString() });
                parameters.Add(new QueryParameter() { Parameter = ApiQueryParameter.SearchGameID, Value = gameSearchParameters.GameID.ToString() });
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
                    gameSearchDict.Add(gameSearchParameters, new Uri(urlBuilder.Build(ApiQueryType.GameNameSearch, parameters)));
                    progressUpdateObjectText = "GameName";
                }
                else if (queryType == ApiQueryType.GameRomSearch)
                {
                    gameSearchDict.Add(gameSearchParameters, new Uri(urlBuilder.Build(ApiQueryType.GameRomSearch, parameters)));
                }


            }
            // Get API Data:
            List<ApiGetOutcome> apiGetOutcomes = new List<ApiGetOutcome>();
            apiGetOutcomes = apiDataService.GetStrings(gameSearchDict, progressUpdateObjectText, cancellationToken, progress);

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
                CancellationToken cancellationToken = default(CancellationToken), IProgress<EventArgs.ProgressChangedEventArgs> progress = null)
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
