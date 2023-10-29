using stigzler.Screenscraper;
using stigzler.Screenscraper.Data;
using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.Enums;
using stigzler.ScreenScraper.Test.Entities;
using stigzler.ScreenScraper.Test.Properties;
using stigzler.Winforms.Base.Forms.BaseForm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using myEventArgs = stigzler.Screenscraper.EventArgs;
using stig = stigzler.ScreenScraper.Test.Entities;

namespace stigzler.ScreenScraper.Test
{
    /// <summary>
    /// Sorry about the down n dirty code - only so much life left...
    /// </summary>
    public partial class Form1 : BaseForm
    {

        ApiCredentials credentials = new ApiCredentials();
        ApiServerParameters serverParameters = new ApiServerParameters();
        GetData getData;

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        Entities.Database database = new Entities.Database();
        BindingSource resultsBS = new BindingSource();

        List<Image> GameImages = new List<Image>();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            log("ScreenscraperAPI Wrapper Demo");
            log("================ ======= ====");
            log("Settings Location: " + ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath);

            UpdateCredentialsAndApiParams();

            getData = new GetData(credentials, serverParameters, 1);

            if (Settings.Default.databaseXml.Count() == 0)
            {
                await SetupDatabase();
                SaveDatabase();
            }

            LoadDatabase();

            LoadSettings();

            PopulatePrivateMembers();
        }

        private async Task<Task> SetupDatabase()
        {
            log("Please wait - setting up database");
            log("Importing systems from Screenscraper");

            database.Systems.Clear();

            // Get Systems
            List<ApiGetOutcome> outcomes = await GetApiOutcomes(ApiQueryType.SystemList);
            ApiGetOutcome outcome = outcomes[0];

            XDocument xdoc = XDocument.Parse(outcome.Data.ToString());

            List<stigzler.Screenscraper.Data.Entities.System> systemEntities = new List<Screenscraper.Data.Entities.System>();


            var systems = xdoc.Descendants("systeme");
            foreach (var system in systems)
            {
                Entities.System newSystem = new Entities.System();
                newSystem.ID = Int32.Parse(system.Element("id").Value);
                newSystem.Name = system.Descendants("nom_eu").ToList()[0].Value;
                database.Systems.Add(newSystem);

                Screenscraper.Data.Entities.System systemEntity = new Screenscraper.Data.Entities.System(system);
                systemEntities.Add(systemEntity);


            }
            database.Systems = database.Systems.OrderBy(x => x.Name).ToList();

            // Get GameMedia types           
            outcomes = await GetApiOutcomes(ApiQueryType.GameMediaList);
            outcome = outcomes[0];
            xdoc = XDocument.Parse(outcome.Data.ToString());
            var medias = xdoc.Descendants("media");
            database.GameMediaTypes.Clear();
            foreach (var media in medias)
            {
                stig.GameMediaType newGameMediaType = new stig.GameMediaType();
                newGameMediaType.ID = Int32.Parse(media.Descendants("id").First().Value);
                newGameMediaType.ShortName = media.Descendants("nomcourt").First().Value;
                newGameMediaType.LongName = media.Descendants("nom").First().Value;
                database.GameMediaTypes.Add(newGameMediaType);
            }
            database.GameMediaTypes = database.GameMediaTypes.OrderBy(x => x.LongName).ToList();

            // Get Regions           
            outcomes = await GetApiOutcomes(ApiQueryType.RegionList);
            outcome = outcomes[0];
            xdoc = XDocument.Parse(outcome.Data.ToString());
            var regions = xdoc.Descendants("region");
            database.Regions.Clear();
            foreach (var region in regions)
            {
                stig.Region newRegion = new stig.Region();
                newRegion.ID = Int32.Parse(region.Descendants("id").First().Value);
                newRegion.ShortName = region.Descendants("nomcourt").First().Value;
                newRegion.Name = region.Descendants("nom_en").First().Value;
                database.Regions.Add(newRegion);
            }
            database.Regions = database.Regions.OrderBy(x => x.Name).ToList();

            log("Import done");

            return Task.CompletedTask;

        }

        private void LoadDatabase()
        {
            if (Settings.Default.databaseXml.Count() == 0) return;

            var xmls = new XmlSerializer(database.GetType());
            StringReader stringReader = new StringReader(Settings.Default.databaseXml);
            using (StringReader sr = new StringReader(Settings.Default.databaseXml))
            {
                database = (Entities.Database)xmls.Deserialize(stringReader);
            }
            Debug.WriteLine(database.Systems.Count);
        }

        private void SaveDatabase()
        {
            var xmls = new XmlSerializer(database.GetType());
            StringWriter stringWriter = new StringWriter();
            xmls.Serialize(stringWriter, database);
            Settings.Default.databaseXml = stringWriter.ToString();
            Settings.Default.Save();
        }

        private void PopulatePrivateMembers()
        {
            QueryTypeCB.DataSource = Enum.GetValues(typeof(ApiQueryType))
                                    .Cast<ApiQueryType>()
                                    .OrderBy(x => x.ToString())
                                    .ToList();
            QueryTypeCB.Text = "GameImageDownload";


            outputFormatCB.DataSource = Enum.GetValues(typeof(MetadataOutput));

            outputFormatCB.SelectedIndex = 0;

            BindDatabaseComboboxes();

            getData = new GetData(credentials, serverParameters, (int)Settings.Default.UserThreads);
        }

        private void BindDatabaseComboboxes()
        {
            MediaTypeCB.DisplayMember = "LongName";
            MediaTypeCB.ValueMember = "ShortName";
            MediaTypeCB.DataSource = database.GameMediaTypes;

            RegionsCB.DisplayMember = "Name";
            RegionsCB.ValueMember = "ShortName";
            RegionsCB.DataSource = database.Regions;

            SystemsCB.DisplayMember = "Name";
            SystemsCB.ValueMember = "id";
            SystemsCB.DataSource = database.Systems;
            SystemsCB.SelectedValue = Settings.Default.SystemID;

            DlFormatCB.SelectedIndex = 0;
        }

        private void UpdateCredentialsAndApiParams()
        {
            credentials.DeveloperID = Properties.Settings.Default.DevID;
            credentials.DeveloperPassword = Properties.Settings.Default.DevPassword;
            credentials.DeveloperSoftware = Properties.Settings.Default.DevSoftware;
            credentials.UserID = Settings.Default.Username;
            credentials.UserPassword = Settings.Default.Password;

            serverParameters.HostAddress = Settings.Default.ApiHostAddress;
            serverParameters.ApiPath = Settings.Default.ApiPathRoot;



            //getData.ApiParameters = serverParameters;
            //getData.Credentials = credentials;
        }


        private void Progress_ProgressChanged(object sender, string e)
        {
            log(e);
        }

        private void log(string message)
        {
            MainRTB.AppendText(message + Environment.NewLine);
            MainRTB.ScrollToCaret();
        }

        private void SaveSettings()
        {
            Settings.Default.DevID = DevIdTB.Text;
            Settings.Default.DevPassword = DevPwTB.Text;
            Settings.Default.DevSoftware = DevSoftwareTB.Text;
            Settings.Default.Username = UsernameTB.Text;
            Settings.Default.Password = PasswordTB.Text;
            Settings.Default.SystemID = (int)SystemsCB.SelectedValue;
            Settings.Default.RomFolder = RomFolderTB.Text;
            Settings.Default.UserThreads = (int)UserThreadsNUM.Value;
            Settings.Default.Save();
        }

        private void LoadSettings()
        {
            DevIdTB.Text = Settings.Default.DevID;
            DevPwTB.Text = Settings.Default.DevPassword;
            DevSoftwareTB.Text = Settings.Default.DevSoftware;
            UsernameTB.Text = Settings.Default.Username;
            PasswordTB.Text = Settings.Default.Password;
            SystemsCB.SelectedValue = Settings.Default.SystemID;
            UserThreadsNUM.Value = Settings.Default.UserThreads;
            RomFolderTB.Text = Settings.Default.RomFolder;
        }

        private void ClearConsoleBT_Click(object sender, EventArgs e)
        {
            MainRTB.Text = "";
        }

        private void SaveSettingsBT_Click(object sender, EventArgs e)
        {
            SaveSettings();
            UpdateCredentialsAndApiParams();
        }

        private async void GoBT_Click(object sender, EventArgs e)
        {
            await GetApiOutcomes((ApiQueryType)QueryTypeCB.SelectedItem);
        }

        private async Task<List<ApiGetOutcome>> GetApiOutcomes(ApiQueryType queryType)
        {
            //Cursor = Cursors.WaitCursor;
            GoBT.Enabled = false;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            ApiGetOutcome outcome = new ApiGetOutcome();
            List<ApiGetOutcome> outcomes = new List<ApiGetOutcome>();

            bool batchOperation = false;
            bool queryDone = true;

            OpenVideoBT.Enabled = false;
            OpenManualBT.Enabled = false;
            MediaPB.Image = null;


            log("-----------------------------------------------------------");
            log("Query Type: " + queryType.ToString());

            ApiQueryGroup queryGroup = Constants.ApiQueryGroups.Where(x => x.Value.Contains(queryType)).FirstOrDefault().Key;
            ApiDownloadParameters downloadParameters;
            string downloadFilename;

            switch (queryGroup)
            {
                case ApiQueryGroup.InfoAndLists:
                    outcome = await Task.Run(() => getData.GetListOrInfo(queryType));
                    break;

                case ApiQueryGroup.Searches:

                    ApiSearchParameters searchParameters = new ApiSearchParameters()
                    {
                        RomName = RomNameSearchTB.Text,
                        GameName = GameNameSearchTB.Text,
                        SystemID = (int)SystemsCB.SelectedValue,
                        CRC = CrcTB.Text,
                        MD5 = Md5TB.Text,
                        SHA1 = Sha1TB.Text,
                    };

                    int GameId;
                    bool validGameId = int.TryParse(GameIdTB.Text, out GameId);
                    if (validGameId) searchParameters.GameID = GameId;

                    outcome = getData.GetGameInfo(searchParameters, queryType);
                    break;



                //switch (QueryTypeCB.SelectedItem)
                //{
                //    case ApiQueryType.GameRomSearch:


                //        break;
                //    default:
                //        queryDone = false;
                //        break;
                //}
                //break;

                case ApiQueryGroup.Downloads:

                    switch (QueryTypeCB.SelectedItem)
                    {
                        case ApiQueryType.GameImageDownload:

                            downloadParameters = new ApiDownloadParameters
                            {
                                MediaTypeName = MediaTypeCB.SelectedValue.ToString() +
                                                "(" + RegionsCB.SelectedValue + ")",
                                MediaFormat = DlFormatCB.Text,
                                ObjectID = (int)GamesCB.SelectedValue,
                                SystemID = (int)SystemsCB.SelectedValue,
                            };

                            downloadFilename = Path.Combine(Path.GetTempPath(), "GameImage.img");
                            //TODO - reinstate this once method re-written
                            outcome = await Task.Run(() => getData.GetFileFromDetails(queryType, downloadParameters, downloadFilename));

                            if (outcome.Successfull) MediaPB.Image = stigzler.Utilities.Base.Operations.ImageOperation.UnlockedImageFromFile(downloadFilename);
                            break;

                        case ApiQueryType.GameVideoDownload:

                            downloadParameters = new ApiDownloadParameters
                            {
                                MediaTypeName = "video",
                                ObjectID = (int)GamesCB.SelectedValue,
                                SystemID = (int)SystemsCB.SelectedValue,
                            };
                            downloadFilename = Path.Combine(Path.GetTempPath(), "GameVideo.mp4");
                            //TODO - reinstate this once method re-written
                            outcome = await Task.Run(() => getData.GetFileFromDetails(queryType, downloadParameters, downloadFilename));
                            if (outcome.Successfull) OpenVideoBT.Enabled = true;
                            break;

                        case ApiQueryType.GameManualDownload:
                            downloadParameters = new ApiDownloadParameters
                            {
                                MediaTypeName = "manuel" +
                                                "(" + RegionsCB.SelectedValue + ")",
                                ObjectID = (int)GamesCB.SelectedValue,
                                SystemID = (int)SystemsCB.SelectedValue,
                            };
                            downloadFilename = Path.Combine(Path.GetTempPath(), "GameManual.pdf");
                            //TODO - reinstate this once method re-written
                            outcome = await Task.Run(() => getData.GetFileFromDetails(queryType, downloadParameters, downloadFilename));
                            if (outcome.Successfull) OpenManualBT.Enabled = true;
                            break;


                    }
                    break;
            }

            if (queryDone && !batchOperation)
            {
                log("Uri: " + outcome.Uri);
                if (outcome.Successfull == true)
                { log("Successful? " + outcome.Successfull + Environment.NewLine + HttpUtility.HtmlDecode(outcome.Data.ToString())); }
                else
                {
                    log("Successful? " + outcome.Successfull + Environment.NewLine
                        + "Status Code: " + outcome.StatusCode + Environment.NewLine
                        + "Server Message: " + outcome.Data);
                    if (outcome.Exception != null)
                    {
                        log("Full Exception: " + Environment.NewLine + outcome.Exception.ToString());
                    }
                }
                outcomes.Add(outcome);
            }
            else if (queryDone && batchOperation)
            {
                log("Batch operation complete. Results returned: " + outcomes.Count);
                resultsBS.DataSource = outcomes;
                resultsBS.ResetBindings(false);

                //(ResultsDGV.DataSource as BindingSource).List.CopyTo(outcomes.ToArray(), 0);

            }

            Cursor = Cursors.Default;

            sw.Stop();
            log("Process took: " + sw.Elapsed.TotalSeconds.ToString("#.#") + "s");
            GoBT.Enabled = true;

            return outcomes;
        }

        // ==================================================================================



        private void Progress_ProgressChanged(object sender, myEventArgs.ProgressChangedEventArgs e)
        {
            UpdateLB.Text = e.DataObject;
            UpdatePB.Value = e.ProgressPercentage;
            UpdateRateLB.Text = "Rate: " + e.Rate.ToString("#.#") + "/s";
        }

        private void outputFormatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (getData == null) return;
            getData.MetadataOutputFormat = (MetadataOutput)outputFormatCB.SelectedItem;
        }

        public static void FindText(RichTextBox rtb, String word, Color color)
        {
            if (word == "")
            {
                return;
            }
            int s_start = rtb.SelectionStart, startIndex = 0, index;
            while ((index = rtb.Text.IndexOf(word, startIndex)) != -1)
            {
                rtb.Select(index, word.Length);
                rtb.ScrollToCaret();
                rtb.SelectionBackColor = color;
                rtb.SelectionColor = Color.Black;
                startIndex = index + word.Length;
            }
            //rtb.SelectionStart = 0;
            //rtb.SelectionLength = rtb.TextLength;
            //rtb.SelectionColor = Color.Black;
        }

        private void SearchTextBT_Click(object sender, EventArgs e)
        {
            FindText(MainRTB, SerchTextTB.Text, Color.Yellow);
        }

        private void UpdateRateLB_Click(object sender, EventArgs e)
        {

        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
            MainOpTitleLB.Text = "Canceling System Roms scrape. Please wait...";
            cancellationTokenSource = new CancellationTokenSource();
        }



        private void SystemsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RomFolderTB.DirectoryPath = ((Entities.System)SystemsCB.SelectedItem).RomFolder;

            LoadGames(((Entities.System)SystemsCB.SelectedItem).ID);

        }

        private void LoadGames(int SystemId)
        {
            List<stig.Game> games = new List<stig.Game>();
            games = database.Games.Where(x => x.SystemID == SystemId).OrderBy(x => x.Name).ToList();
            if (games.Count > 0)
            {
                GamesCB.DisplayMember = "Name";
                GamesCB.ValueMember = "ID";
                GamesCB.DataSource = games;
            }
            else
            {
                GamesCB.DataSource = null;
            }

        }

        private void RomFolderTB_DirectoryPathChanged(Winforms.Base.Events.DirectoryPathChangedEventArgs e)
        {
            Entities.System selectedSystem = (Entities.System)SystemsCB.SelectedItem;
            if (selectedSystem == null) return;

            selectedSystem.RomFolder = e.NewPath;
            SaveDatabase();

        }



        private async void ResetDatabaseBT_Click(object sender, EventArgs e)
        {
            database.Games.Clear();
            await SetupDatabase();
            SaveDatabase();
            BindDatabaseComboboxes();
        }

        private void ViewXmlBT_Click(object sender, EventArgs e)
        {
            stig.Game selectedGame = GamesCB.SelectedItem as stig.Game;
            if (selectedGame != null)
            {
                log(HttpUtility.HtmlDecode(selectedGame.GameXml));
            }
        }

        private void WordwrapBT_Click(object sender, EventArgs e)
        {
            MainRTB.WordWrap = WordwrapBT.Checked;
        }

        private void OpenVideoBT_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Path.GetTempPath(), "GameVideo.mp4"));
        }

        private void OpenManualBT_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Path.GetTempPath(), "GameManual.pdf"));
        }

        private async void TestBT_Click(object sender, EventArgs e)
        {

            //APIDownloadParameters downloadParameters = new APIDownloadParameters
            //{
            //    MediaTypeName = "manuel" +
            //        "(" + RegionsCB.SelectedValue + ")",
            //    ObjectID = (int)GamesCB.SelectedValue,
            //    SystemID = (int)SystemsCB.SelectedValue,
            //};
            //string downloadFilename = Path.Combine(Path.GetTempPath(), "GameManual.pdf");
            //try
            //{
            //    ApiGetOutcome outcome = await Task.Run(() => getData.GetFile(ApiQueryType.ClassificaitonList, downloadParameters, downloadFilename));
            //}
            //catch (stigzler.Screenscraper.Exceptions.QueryMismatchException error)
            //{
            //    Debug.WriteLine(error.ToString());
            //    throw;
            //}

            ApiSearchParameters searchParams = new ApiSearchParameters()
            {
                //SystemID = 41,
                GameID = 38005,
                //CRC = "BB7C1075",
                //RomName = "Choplifter! (USA).7z"
            };

            var outcome = await Task.Run(() =>
                  getData.GetGameInfo(searchParams, ApiQueryType.GameRomSearch, CancellationToken.None));

            log(outcome.Uri + Environment.NewLine + outcome.ToString() + ". Data: " + outcome.Data);

        }

        private void scrapeAllRomsForSelectedSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScrapeAllSystemRoms();
        }

        private void resetDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetDatabase();
        }

        private async void ResetDatabase()
        {
            database.Games.Clear();
            await SetupDatabase();
            SaveDatabase();
            BindDatabaseComboboxes();
        }

        private async void getAllGameImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAllGameMedia();
        }


        private async void GetAllGameMedia()
        {
            log("Downloading media for game: " + GamesCB.Text + " using " + (int)UserThreadsNUM.Value + " threads");

            Game game = database.Games.Find(x => x.ID.Equals(int.Parse(GamesCB.SelectedValue.ToString())));

            XDocument mediaXDoc = XDocument.Parse(game.GameXml);
            IEnumerable<XElement> mediaElements = mediaXDoc.Descendants("media");

            string mediaRootPath = "C:\\temp\\project tests\\gearbox\\MediaDownloadTests";
            List<ApiDownloadParameters> urisAndFilenames = new List<ApiDownloadParameters>();

            Progress<myEventArgs.ProgressChangedEventArgs> progress = new Progress<myEventArgs.ProgressChangedEventArgs>();
            progress.ProgressChanged += Progress_ProgressChanged;

            var downloadTasks = new List<DownloadTask>();

            foreach (var mediaElement in mediaElements)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(mediaRootPath + @"\");
                if (mediaElement.Attribute("type") != null) stringBuilder.Append(mediaElement.Attribute("type").Value);
                if (mediaElement.Attribute("region") != null) stringBuilder.Append(" (" + mediaElement.Attribute("region").Value + ")");
                stringBuilder.Append("." + mediaElement.Attribute("format").Value);

                string filename = Path.Combine(mediaRootPath, stringBuilder.ToString());
                urisAndFilenames.Add(new ApiDownloadParameters()
                {
                    DirectUri = new Uri(mediaElement.Value),
                    Filename = filename,
                });

                DownloadTask dlt = new DownloadTask { Url = mediaElement.Value, DestinationPath = filename };
                downloadTasks.Add(dlt);
            }

            ServicePointManager.FindServicePoint(new Uri("https://neoclone.screenscraper.fr/")).ConnectionLimit = (int)UserThreadsNUM.Value;
            getData.UserThreads = (int)UserThreadsNUM.Value;


            Stopwatch sw = Stopwatch.StartNew();
            //var downloader = new FileDownloader(maxConcurrentDownloads: (int)UserThreadsNUM.Value); // Adjust the maximum concurrent downloads as needed.
            //await downloader.DownloadFilesAsync(downloadTasks);
            //sw.Stop();

            var outcomes = await Task.Run(() =>
                    getData.GetFilesFromUris(urisAndFilenames, cancellationTokenSource.Token, progress)
                    );

            log("Media Download completed in " + sw.Elapsed.TotalMilliseconds + "ms using " + UserThreadsNUM.Value + " Threads");
            Debug.WriteLine(outcomes.Count);
        }

        private async void ScrapeAllSystemRoms()
        {
            Progress<myEventArgs.ProgressChangedEventArgs> progress = new Progress<myEventArgs.ProgressChangedEventArgs>();
            progress.ProgressChanged += Progress_ProgressChanged;

            List<ApiGetOutcome> outcomes = new List<ApiGetOutcome>();

            Entities.System selectedSystem = (Entities.System)SystemsCB.SelectedItem;
            if (selectedSystem.RomFolder == null)
            {
                log(" ** No Rom Folder Mapped against System **");
                return;
            }

            List<string> romFilepaths = Directory.GetFiles(selectedSystem.RomFolder, "*.*", SearchOption.AllDirectories).ToList();
            List<ApiSearchParameters> serachParameters = new List<ApiSearchParameters>();
            MainOpTitleLB.Text = "Processing Roms for System: " + SystemsCB.Text;

            getData.UserThreads = (int)UserThreadsNUM.Value;

            log("Processing all roms for system: " + SystemsCB.Text);
            log("Using " + getData.UserThreads + " threads for " + romFilepaths.Count + " roms.");

            foreach (var romFilename in romFilepaths)
            {
                serachParameters.Add(new ApiSearchParameters
                {
                    RomName = Path.GetFileName(romFilename),
                    SystemID = selectedSystem.ID
                });
            }

            int systemID = (int)SystemsCB.SelectedValue;

            outcomes = await Task.Run(() =>
                getData.GetGamesInfo(serachParameters, ApiQueryType.GameRomSearch, cancellationTokenSource.Token, progress));

            database.Games.RemoveAll(x => x.SystemID == systemID);

            if (SaveGamesToDbBT.Checked)
            {
                log("System Rom scrape complete. Now populating Database..");

                foreach (var outcome in outcomes)
                {
                    if (outcome.Successfull == false) continue;
                    string xmlString = outcome.Data.ToString();
                    XDocument xdoc = XDocument.Parse(xmlString);

                    Entities.Game newGame = new Entities.Game();

                    newGame.SystemID = systemID;
                    newGame.ID = Convert.ToInt32(xdoc.Descendants("jeu").First().Attributes("id").First().Value);
                    newGame.MainRomFilename = xdoc.Descendants("romfilename").First().Value;
                    newGame.GameXml = outcome.Data.ToString();
                    try
                    {
                        newGame.Name = xdoc.Descendants("nom").First(x => x.Attribute("region").Value == "ss").Value;
                    }
                    catch (Exception)
                    {
                        //throw;
                    }

                    database.Games.Add(newGame);

                }

                await Task.Run(() => SaveDatabase());
                log("Games saved to database");

            }

            MainOpTitleLB.Text = "Operation Finished.";
            UpdatePB.Value = 0;
            UpdateLB.Text = "";
            UpdateRateLB.Text = "";

        }




    }


}
