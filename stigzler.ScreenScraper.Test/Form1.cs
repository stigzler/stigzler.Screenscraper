using stigzler.Screenscraper;
using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.Enums;
using stigzler.ScreenScraper.Test.Properties;
using stigzler.Winforms.Base.Forms.BaseForm;
using System;
using myEventArgs = stigzler.Screenscraper.EventArgs;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Entities = stigzler.ScreenScraper.Test.Entities;
using System.Xml.Serialization;
using System.Configuration;
using stigzler.Screenscraper.Data;

namespace stigzler.ScreenScraper.Test
{
    /// <summary>
    /// Sorry about the down n dirty code - only so much life left...
    /// </summary>
    public partial class Form1 : BaseForm
    {

        Credentials credentials = new Credentials();
        ApiServerParameters serverParameters = new ApiServerParameters();
        GetData getData;

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        Entities.Database database = new Entities.Database();
        BindingSource resultsBS = new BindingSource();

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

            ResultsDGV.DataSource = resultsBS;
        }

        private async Task<Task> SetupDatabase()
        {
            log("Please wait - setting up database");
            log("Importing systems from Screenscraper");

            database.Systems.Clear();

            List<ApiGetOutcome> outcomes = await GetApiOutcomes(ApiQueryType.SystemList);
            ApiGetOutcome outcome = outcomes[0];

            XDocument xdoc = XDocument.Parse(outcome.Data.ToString());

            var systems = xdoc.Descendants("systeme");
            foreach (var system in systems)
            {
                Entities.System newSystem = new Entities.System();
                newSystem.ID = Int32.Parse(system.Element("id").Value);
                newSystem.Name = system.Descendants("nom_eu").ToList()[0].Value;
                database.Systems.Add(newSystem);
            }

            database.Systems = database.Systems.OrderBy(x => x.Name).ToList();

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

            QueryTypeCB.Text = "GameInfo";

            outputFormatCB.DataSource = Enum.GetValues(typeof(MetadataOutput));

            if (database.Systems.Count > 0)
            {
                SystemsCB.DisplayMember = "Name";
                SystemsCB.ValueMember = "id";
                SystemsCB.DataSource = database.Systems;

                SystemsCB.SelectedValue = Settings.Default.SystemID;
            }

            outputFormatCB.SelectedIndex = 0;

            getData = new GetData(credentials, serverParameters, (int)Settings.Default.UserThreads);
        }

        private void UpdateCredentialsAndApiParams()
        {
            credentials.DeveloperID = Properties.Settings.Default.DevID;
            credentials.DeveloperPassword = Properties.Settings.Default.DevPassword;
            credentials.DeveloperSoftware = Properties.Settings.Default.DevSoftware;
            credentials.UserID = Settings.Default.Username;
            credentials.UserPassword = Settings.Default.Password;

            serverParameters.HostAddress = Settings.Default.ApiHostAddress;
            serverParameters.HostPort = Int32.Parse(Settings.Default.ApiPort);
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



            log("Query Type: " + queryType.ToString());

            ApiQueryGroup queryGroup = Constants.ApiQueryGroups.Where(x => x.Value.Contains(queryType)).FirstOrDefault().Key;


            switch (queryGroup)
            {
                case ApiQueryGroup.InfoAndLists:
                    outcome = await Task.Run(() => getData.GetListOrInfo(queryType));
                    break;

                //case ApiQueryType.UserInfo:
                //    outcome = await Task.Run(() => getData.GetUserInfo().Result);
                //    break;

                //case ApiQueryType.SystemList:
                //    outcome = await Task.Run(() => getData.GetSystemList().Result);
                //    break;

                case ApiQueryGroup.Searches:
                    switch (QueryTypeCB.SelectedItem)
                    {
                        case ApiQueryType.GameRomSearch:

                            batchOperation = true;
                            break;
                        default:
                            queryDone = false;
                            break;
                    }
                    break;



            }

            if (queryDone && !batchOperation)
            {
                log("Uri: " + outcome.Uri);
                if (outcome.Successfull == true)
                { log("Success: " + Environment.NewLine + outcome.Data.ToString()); }
                else
                {
                    log("Unsuccessful: " + Environment.NewLine
                        + "Status Code: " + outcome.StatusCode + Environment.NewLine
                        + "Server Message: " + outcome.Data + Environment.NewLine
                        + "Full Exception: " + Environment.NewLine
                    + outcome.Exception.ToString());
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
        }

        private void RomFolderTB_DirectoryPathChanged(Winforms.Base.Events.DirectoryPathChangedEventArgs e)
        {
            Entities.System selectedSystem = (Entities.System)SystemsCB.SelectedItem;
            if (selectedSystem == null) return;

            selectedSystem.RomFolder = e.NewPath;
            SaveDatabase();

        }

        private void ScrapeAllSystemRomsBT_Click(object sender, EventArgs e)
        {
            ScrapeAllSystemRoms();
        }

        private async void ScrapeAllSystemRoms()
        {
            Progress<myEventArgs.ProgressChangedEventArgs> progress = new Progress<myEventArgs.ProgressChangedEventArgs>();
            progress.ProgressChanged += Progress_ProgressChanged;

            List<ApiGetOutcome> outcomes = new List<ApiGetOutcome>();

            Entities.System selectedSystem = (Entities.System)SystemsCB.SelectedItem;
            if (selectedSystem.RomFolder == null) return;

            List<string> romFilepaths = Directory.GetFiles(selectedSystem.RomFolder, "*.*", SearchOption.AllDirectories).ToList();
            List<string> romFilenames = new List<string>();
            MainOpTitleLB.Text = "Processing Roms for System: " + SystemsCB.Text;

            getData.UserThreads = (int)UserThreadsNUM.Value;

            log("Processing all roms for system: " + SystemsCB.Text);
            log("Using " + getData.UserThreads + " threads for " + romFilepaths.Count + " roms.");

            foreach (var romFilename in romFilepaths)
            {
                romFilenames.Add(Path.GetFileName(romFilename));
            }

            int systemID = (int)SystemsCB.SelectedValue;

            outcomes = await Task.Run(() =>
                getData.GetGamesInfo(systemID, romFilenames, cancellationTokenSource.Token, progress));

            log("System Rom scrape complete. Now populating Database..");

            database.Games.RemoveAll(x=> x.SystemID == systemID);

            foreach (var outcome in outcomes)
            {

            XDocument xdoc = XDocument.Parse(outcome.Data.ToString());

                Entities.Game newGame = new Entities.Game();

                newGame.SystemID = systemID;
                newGame.ID = Convert.ToInt32( xdoc.Descendants("jeu").First().Attributes("id").First().Value);
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

                SaveDatabase();

            }


        }

    }


}
