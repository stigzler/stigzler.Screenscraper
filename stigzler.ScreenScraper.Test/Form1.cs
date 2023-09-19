using stigzler.Screenscraper;
using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.Enums;
using stigzler.ScreenScraper.Test.Properties;
using stigzler.Winforms.Base.Forms.BaseForm;
using System;
using myEventArgs = stigzler.Screenscraper.EventArgs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Web.Caching;
using stigzler.Screenscraper.Entities;
using System.Xml.Serialization;
using System.Xml;

namespace stigzler.ScreenScraper.Test
{
    public partial class Form1 : BaseForm
    {
        string romsDir = @"\\HPSERVER\ServerFolders\Arcade\ROMS\Atari 7800\Hyperspin Ready";

        Credentials credentials = new Credentials();
        ApiServerParameters serverParameters = new ApiServerParameters();
        GetData getData;

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        Database database = new Database();


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
            LoadDatabase();
            LoadSettings();
            PopulatePrivateMembers();
            UpdateCredentialsAndApiParams();

        }

        private void LoadDatabase()
        {
            if (Settings.Default.databaseXml.Count() == 0) return;

            var xmls = new XmlSerializer(database.GetType());
            StringReader stringReader = new StringReader(Settings.Default.databaseXml);
            //   xmls.Serialize(stringWriter, database);
            //Debug.WriteLine(stringWriter.ToString());
            using (StringReader sr = new StringReader(Settings.Default.databaseXml))
            {
                database = (Database)xmls.Deserialize(stringReader);
            }
            Debug.WriteLine(database.Systems.Count);

        }

        private void PopulatePrivateMembers()
        {

            QueryTypeCB.DataSource = Enum.GetValues(typeof(ApiQueryType));
            QueryTypeCB.Text = "GameInfo";

            outputFormatCB.DataSource = Enum.GetValues(typeof(MetadataOutput));

            if (database.Systems.Count > 0)
            {
                SystemsCB.DisplayMember = "Name";
                SystemsCB.ValueMember = "id";
                SystemsCB.DataSource = database.Systems;

                SystemsCB.SelectedValue= Settings.Default.SystemID;
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

            getData.ApiParameters = serverParameters;
            getData.Credentials = credentials;
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
            Settings.Default.SystemID = SystemsCB.ValueMember;
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


            Progress<myEventArgs.ProgressChangedEventArgs> progress = new Progress<myEventArgs.ProgressChangedEventArgs>();
            progress.ProgressChanged += Progress_ProgressChanged;

            log("Query Type: " + queryType.ToString());
            switch (queryType)
            {
                case ApiQueryType.ServerInfo:
                    outcome = await Task.Run(() => getData.GetApiServerInfo().Result);
                    break;

                case ApiQueryType.UserInfo:
                    outcome = await Task.Run(() => getData.GetUserInfo().Result);
                    break;

                case ApiQueryType.SystemList:
                    outcome = await Task.Run(() => getData.GetSystemList().Result);
                    break;

                case ApiQueryType.GameInfo:
                    List<string> romFilepaths = Directory.GetFiles(Settings.Default.RomFolder, "*.*", SearchOption.AllDirectories).ToList();
                    List<string> romFilenames = new List<string>();
                    MainOpTitleLB.Text = "Processing Roms";

                    getData.UserThreads = (int)UserThreadsNUM.Value;
                    log(">> Batch Game Info, using " + getData.UserThreads + " threads for " + romFilepaths.Count);

                    foreach (var romFilename in romFilepaths)
                    {
                        romFilenames.Add(Path.GetFileName(romFilename));
                    }

                    int systemID = Int32.Parse(Settings.Default.SystemID);

                    outcomes = await Task.Run(() =>
                        getData.GetGamesInfo(systemID, romFilenames, cancellationTokenSource.Token, progress));

                    batchOperation = true;

                    break;

                default:
                    queryDone = false;
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
            }

            Cursor = Cursors.Default;

            sw.Stop();
            log("Process took: " + sw.Elapsed.TotalSeconds.ToString("#.#") + "s");
            GoBT.Enabled = true;

            return outcomes;
        }

        // ==================================================================================
        private async void RefreshSystemsBT_Click(object sender, EventArgs e)
        {
            log(" ** PLEASE WAIT ** ");
            log("Importing systems from Screenscraper");

            List<ApiGetOutcome> outcomes = await GetApiOutcomes(ApiQueryType.SystemList);
            ApiGetOutcome outcome = outcomes[0];

            //Approach 1

            XDocument xdoc = XDocument.Parse(outcome.Data.ToString());

            Database database = new Database();


            var systems = xdoc.Descendants("systeme");
            foreach (var system in systems)
            {
                Debug.WriteLine(system.ToString());
                Screenscraper.Entities.System newSystem = new Screenscraper.Entities.System();

                newSystem.ID = Int32.Parse(system.Element("id").Value);
                newSystem.Name = system.Descendants("nom_eu").ToList()[0].Value;
                database.Systems.Add(newSystem);
            }

            database.Systems = database.Systems.OrderBy(x => x.Name).ToList();

            var xmls = new XmlSerializer(database.GetType());
            StringWriter stringWriter = new StringWriter();
            xmls.Serialize(stringWriter, database);
            Debug.WriteLine(stringWriter.ToString());
            Settings.Default.databaseXml = stringWriter.ToString();
            Settings.Default.Save();

            log("Import done");

            return;

        }

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
            cancellationTokenSource = new CancellationTokenSource();
        }

    }


}
