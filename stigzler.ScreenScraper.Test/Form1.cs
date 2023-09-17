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

namespace stigzler.ScreenScraper.Test
{
    public partial class Form1 : BaseForm
    {
        string romsDir = @"\\HPSERVER\ServerFolders\Arcade\ROMS\Atari 7800\Hyperspin Ready";

        Credentials credentials = new Credentials();
        ApiServerParameters serverParameters = new ApiServerParameters();
        GetData getData;

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = new CancellationToken();

        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            PopulatePrivateMembers();
            UpdateCredentialsAndApiParams();

            cancellationToken = cancellationTokenSource.Token;

        }

        private void PopulatePrivateMembers()
        {

            QueryTypeCB.DataSource = Enum.GetValues(typeof(ApiQueryType));
            QueryTypeCB.SelectedText = "GameInfo";

            outputFormatCB.DataSource = Enum.GetValues(typeof(MetadataOutput));

            outputFormatCB.SelectedIndex = 0;

            getData = new GetData(credentials, serverParameters, Int32.Parse(Settings.Default.UserThreads));
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
            httpClient.BaseAddress = new Uri(Settings.Default.ApiHostAddress);
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

            log("Query Type: " + QueryTypeCB.SelectedItem.ToString());
            switch (QueryTypeCB.SelectedItem)
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

                    getData.UserThreads = Int32.Parse(UserThreadsTB.Text);
                    log(">> Batch Game Info, using " + getData.UserThreads + " threads for " + romFilepaths.Count);

                    foreach (var romFilename in romFilepaths)
                    {
                        romFilenames.Add(Path.GetFileName(romFilename));
                    }
                    outcomes = await Task.Run(() => getData.GetGamesInfo(Int32.Parse(Settings.Default.SystemID), romFilenames,
                        cancellationToken, progress));
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
            }
            else if (queryDone && batchOperation)
            {
            }

            Cursor = Cursors.Default;

            sw.Stop();
            log("Process took: " + sw.Elapsed.TotalSeconds.ToString("#.#") + "s");
            GoBT.Enabled = true;
        }

        private void Progress_ProgressChanged(object sender, myEventArgs.ProgressChangedEventArgs e)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                UpdateLB.Text = e.DataObject;
                UpdatePB.Value = e.ProgressPercentage;
                UpdateRateLB.Text = "Rate: " + e.Rate.ToString("#.#") + "/s";
            }
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
        }
    }


}
