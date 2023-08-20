using stigzler.Screenscraper;
using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.Enums;
using stigzler.ScreenScraper.Test.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Compilation;
using System.Windows.Forms;

namespace stigzler.ScreenScraper.Test
{


    public partial class Form1 : Form
    {
        string romsDir = @"\\HPSERVER\ServerFolders\Arcade\ROMS\Sega Genesis\Hyperspin Ready";

        HttpClient httpClient = new HttpClient();
        Credentials credentials = new Credentials();
        ApiServerParameters serverParameters = new ApiServerParameters();

        GetData getData;

        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            PopulatePrivateMembers();
            UpdateCredentialsAndApiParams();
        }

        private void PopulatePrivateMembers()
        {

            QueryTypeCB.DataSource = Enum.GetValues(typeof(ApiQueryType));
            outputFormatCB.DataSource = Enum.GetValues(typeof(MetadataOutput));

            outputFormatCB.SelectedIndex = 0;

            getData = new GetData(credentials, serverParameters, httpClient);
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

        private void TestRomfolderDownload()
        {
            int userThreads = 7;

            // Set number of concurrent downloads
            //    SetMaxConcurrency(baseUrl, userThreads);
            ProcessRomsFolder();
        }


        /// <summary>
        /// Sets maximum number of concurrent connections to a server
        /// </summary>
        /// <param name="url"></param>
        /// <param name="maxConcurrentRequests"></param>
        private void SetMaxConcurrency(string url, int maxConcurrentRequests)
        {
            ServicePointManager.FindServicePoint(new Uri(url)).ConnectionLimit = maxConcurrentRequests;
        }

        private void ProcessRomsFolder()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            ParallelOptions po = new ParallelOptions();
            po.CancellationToken = cts.Token;
            //po.MaxDegreeOfParallelism = 7;

            IProgress<string> progress = new Progress<string>();
            ((Progress<string>)progress).ProgressChanged += Progress_ProgressChanged;

            List<string> urls = new List<string>();

            Parallel.ForEach(Directory.GetFiles(romsDir), file =>
            {
                urls.Add(BuildUrl(file));
            });

            HttpClient httpClient = new HttpClient();
            // httpClient.BaseAddress = new Uri(baseUrl);
            httpClient.Timeout = new TimeSpan(0, 0, 2);

            //HttpGetter httpGet = new HttpGetter(httpClient);

            //HttpDownloadManager downloadManager = new HttpDownloadManager(httpGet, urls);

            //  downloadManager.Download();



            log(Environment.NewLine + "  ** FINISHED **");
            //foreach (string file in Directory.GetFiles(romsDir))
            //{
            //    var response = await httpClient.GetAsync(BuildUrl(file));
            //    ServicePoint sp1 = ServicePointManager.FindServicePoint(new Uri("https://www.screenscraper.fr"));
            //    Debug.WriteLine(Environment.NewLine + "Current Connections: " + sp1.CurrentConnections.ToString());
            //    Debug.WriteLine(response.ToString());
            //}
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

        private string BuildUrl(string romfile)
        {
            var builder = new UriBuilder("");
            builder.Port = -1;
            builder.Path = @"api2/jeuInfos.php";
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["devid"] = "stigzler";
            query["devpassword"] = "85c4bFxP43TWCdvQ";
            query["softname"] = "OmniGameZ";
            query["ssid"] = "stigzler";
            query["sspassword"] = "astraastra";
            query["output"] = "xml";
            query["systemeid"] = "1";
            query["romnom"] = Path.GetFileName(romfile);

            builder.Query = query.ToString();
            string url = builder.Uri.AbsoluteUri;
            Debug.WriteLine(url);

            return url;
        }


        private void ResearchKeeps()
        {
            // below gets object with current number of connections 
            ServicePoint sp1 = ServicePointManager.FindServicePoint(new Uri("https://www.screenscraper.fr"));

        }



        private void SaveSettings()
        {
            Settings.Default.DevID = DevIdTB.Text;
            Settings.Default.DevPassword = DevPwTB.Text;
            Settings.Default.DevSoftware = DevSoftwareTB.Text;
            Settings.Default.Username = UsernameTB.Text;
            Settings.Default.Password = PasswordTB.Text;
            Settings.Default.SystemID = SystemIdTB.Text;
            Settings.Default.RomFolder = RomFolderTB.Text;

            Settings.Default.Save();
        }

        private void LoadSettings()
        {
            DevIdTB.Text = Settings.Default.DevID;
            DevPwTB.Text = Settings.Default.DevPassword;
            DevSoftwareTB.Text = Settings.Default.DevSoftware;
            UsernameTB.Text = Settings.Default.Username;
            PasswordTB.Text = Settings.Default.Password;
            SystemIdTB.Text = Settings.Default.SystemID;
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
            Cursor = Cursors.WaitCursor;
            // ApiGetOutcome outcome = new ApiGetOutcome();


            switch (QueryTypeCB.SelectedItem)
            {
                case ApiQueryType.ServerInfo:
                    ApiGetOutcome outcome = await Task.Run(() => getData.GetApiServerInfo().Result);
                    string text = await ((HttpContent)outcome.Data).ReadAsStringAsync();
                    log(outcome.Url);
                    log(text.Trim());
                    break;

                case ApiQueryType.UserInfo:
                    outcome = await Task.Run(() => getData.GetUserInfo().Result);
                    text = await ((HttpContent)outcome.Data).ReadAsStringAsync();
                    log(outcome.Url);
                    log(text.Trim());
                    break;

                case ApiQueryType.GameInfo:

                    List<string> romFilenames = new List<string>();
                    foreach (var romFilename in Directory.GetFiles(Settings.Default.RomFolder,"*.*",SearchOption.AllDirectories))
                    {
                        romFilenames.Add(Path.GetFileName(romFilename));
                    }

                    List<ApiGetOutcome> outcomes = await Task.Run(() => getData.GetGameInfo(Int32.Parse(Settings.Default.SystemID),romFilenames).Result);

                    break;


            }
            Cursor = Cursors.Default;
        }

        private void outputFormatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (getData == null) return;
            getData.MetadataOutputFormat = (MetadataOutput)outputFormatCB.SelectedItem;
        }
    }
}
