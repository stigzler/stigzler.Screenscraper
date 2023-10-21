using stigzler.Winforms.Base.Forms.BaseForm;

namespace stigzler.ScreenScraper.Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VerticalSC = new System.Windows.Forms.SplitContainer();
            this.VarsPN = new System.Windows.Forms.Panel();
            this.groupBox3 = new stigzler.Winforms.Base.UIElements.GroupBox();
            this.RomFolderTB = new stigzler.Winforms.Base.UserControls.FolderBrowserTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SystemsCB = new stigzler.Winforms.Base.UIElements.ComboBox();
            this.groupBox1 = new stigzler.Winforms.Base.UIElements.GroupBox();
            this.DevIdTB = new System.Windows.Forms.TextBox();
            this.DevPwTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DevSoftwareTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new stigzler.Winforms.Base.UIElements.GroupBox();
            this.ViewXmlBT = new stigzler.Winforms.Base.UIElements.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.CrcTB = new System.Windows.Forms.TextBox();
            this.DlFormatCB = new stigzler.Winforms.Base.UIElements.ComboBox();
            this.Md5TB = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RegionsCB = new stigzler.Winforms.Base.UIElements.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Sha1TB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MediaTypeCB = new stigzler.Winforms.Base.UIElements.ComboBox();
            this.GamesCB = new stigzler.Winforms.Base.UIElements.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.UpdatePN = new System.Windows.Forms.Panel();
            this.UpdateRateLB = new stigzler.Winforms.Base.UIElements.Label();
            this.UpdateLB = new stigzler.Winforms.Base.UIElements.Label();
            this.UpdatePB = new System.Windows.Forms.ProgressBar();
            this.MainOpTitleLB = new stigzler.Winforms.Base.UIElements.Label();
            this.OpsPN = new System.Windows.Forms.Panel();
            this.SaveGamesToDbBT = new System.Windows.Forms.CheckBox();
            this.QueryTypeCB = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.outputFormatCB = new System.Windows.Forms.ComboBox();
            this.ButtonsPN = new System.Windows.Forms.FlowLayoutPanel();
            this.GoBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            this.TestBT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UserThreadsNUM = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.RhsSC = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new stigzler.Winforms.Base.UIElements.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RtbPN = new System.Windows.Forms.Panel();
            this.MainRTB = new stigzler.Winforms.Base.UIElements.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.WordwrapBT = new System.Windows.Forms.ToolStripButton();
            this.ClearConsoleBT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SerchTextTB = new System.Windows.Forms.ToolStripTextBox();
            this.SearchTextBT = new System.Windows.Forms.ToolStripButton();
            this.MediaBroswerPN = new stigzler.Winforms.Base.UIElements.Panel();
            this.MediaPB = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.OpenVideoBT = new stigzler.Winforms.Base.UIElements.Button();
            this.OpenManualBT = new stigzler.Winforms.Base.UIElements.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveSettingsBT = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new stigzler.Winforms.Base.UIElements.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrapeAllRomsForSelectedSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllGameImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new stigzler.Winforms.Base.UIElements.GroupBox();
            this.GameNameSearchTB = new System.Windows.Forms.TextBox();
            this.RomNameSearchTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.GameIdTB = new System.Windows.Forms.TextBox();
            this.GameIdLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSC)).BeginInit();
            this.VerticalSC.Panel1.SuspendLayout();
            this.VerticalSC.Panel2.SuspendLayout();
            this.VerticalSC.SuspendLayout();
            this.VarsPN.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.UpdatePN.SuspendLayout();
            this.OpsPN.SuspendLayout();
            this.ButtonsPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserThreadsNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RhsSC)).BeginInit();
            this.RhsSC.Panel1.SuspendLayout();
            this.RhsSC.Panel2.SuspendLayout();
            this.RhsSC.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.RtbPN.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.MediaBroswerPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPB)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // VerticalSC
            // 
            this.VerticalSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VerticalSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerticalSC.Location = new System.Drawing.Point(0, 24);
            this.VerticalSC.Name = "VerticalSC";
            // 
            // VerticalSC.Panel1
            // 
            this.VerticalSC.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.VerticalSC.Panel1.Controls.Add(this.VarsPN);
            this.VerticalSC.Panel1.Controls.Add(this.UpdatePN);
            this.VerticalSC.Panel1.Controls.Add(this.OpsPN);
            this.VerticalSC.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.VerticalSC.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // VerticalSC.Panel2
            // 
            this.VerticalSC.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.VerticalSC.Panel2.Controls.Add(this.RhsSC);
            this.VerticalSC.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.VerticalSC.Size = new System.Drawing.Size(1180, 848);
            this.VerticalSC.SplitterDistance = 565;
            this.VerticalSC.TabIndex = 3;
            // 
            // VarsPN
            // 
            this.VarsPN.AutoScroll = true;
            this.VarsPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.VarsPN.Controls.Add(this.groupBox4);
            this.VarsPN.Controls.Add(this.groupBox3);
            this.VarsPN.Controls.Add(this.groupBox1);
            this.VarsPN.Controls.Add(this.groupBox2);
            this.VarsPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarsPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.VarsPN.Location = new System.Drawing.Point(4, 148);
            this.VarsPN.Name = "VarsPN";
            this.VarsPN.Size = new System.Drawing.Size(555, 589);
            this.VarsPN.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.groupBox3.BorderThickness = 1;
            this.groupBox3.Controls.Add(this.RomFolderTB);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.SystemsCB);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.groupBox3.Location = new System.Drawing.Point(11, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 78);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General";
            this.groupBox3.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            // 
            // RomFolderTB
            // 
            this.RomFolderTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RomFolderTB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RomFolderTB.BackColor = System.Drawing.Color.Transparent;
            this.RomFolderTB.DarkMode = false;
            this.RomFolderTB.DirectoryPath = "C:\\Start\\AnExamplePath\\To\\Your\\Stuff\\Middle\\Ellipse\\Test\\Here\\Yeah\\Path\\End";
            this.RomFolderTB.EllipsisPosition = stigzler.Winforms.Base.UserControls.FolderBrowserTextBox.EllipsisPositions.Middle;
            this.RomFolderTB.FolderBrowserDesription = "Please select the rom folder for this system";
            this.RomFolderTB.FontStyle = System.Drawing.FontStyle.Regular;
            this.RomFolderTB.Image = ((System.Drawing.Image)(resources.GetObject("RomFolderTB.Image")));
            this.RomFolderTB.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RomFolderTB.Location = new System.Drawing.Point(92, 47);
            this.RomFolderTB.Margin = new System.Windows.Forms.Padding(0);
            this.RomFolderTB.Name = "RomFolderTB";
            this.RomFolderTB.ReadOnly = true;
            this.RomFolderTB.ScaleFont = 100;
            this.RomFolderTB.Size = new System.Drawing.Size(419, 20);
            this.RomFolderTB.TabIndex = 18;
            this.RomFolderTB.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomFolderTB.DirectoryPathChanged += new stigzler.Winforms.Base.Events.DirectoryPathChanged(this.RomFolderTB_DirectoryPathChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "System:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "RomFolder";
            // 
            // SystemsCB
            // 
            this.SystemsCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemsCB.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.SystemsCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SystemsCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SystemsCB.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SystemsCB.ComboBoxMode = stigzler.Winforms.Base.UIElements.ComboBoxMode.Normal;
            this.SystemsCB.DropDownImages = null;
            this.SystemsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemsCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemsCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.SystemsCB.FormattingEnabled = true;
            this.SystemsCB.Location = new System.Drawing.Point(92, 19);
            this.SystemsCB.Name = "SystemsCB";
            this.SystemsCB.RedrawOnResize = true;
            this.SystemsCB.Size = new System.Drawing.Size(419, 21);
            this.SystemsCB.TabIndex = 17;
            this.SystemsCB.SelectedIndexChanged += new System.EventHandler(this.SystemsCB_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.groupBox1.BorderThickness = 1;
            this.groupBox1.Controls.Add(this.DevIdTB);
            this.groupBox1.Controls.Add(this.DevPwTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DevSoftwareTB);
            this.groupBox1.Controls.Add(this.PasswordTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UsernameTB);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API Parameters";
            this.groupBox1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            // 
            // DevIdTB
            // 
            this.DevIdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DevIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DevIdTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DevIdTB.Location = new System.Drawing.Point(91, 19);
            this.DevIdTB.Name = "DevIdTB";
            this.DevIdTB.Size = new System.Drawing.Size(424, 20);
            this.DevIdTB.TabIndex = 1;
            // 
            // DevPwTB
            // 
            this.DevPwTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevPwTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DevPwTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DevPwTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DevPwTB.Location = new System.Drawing.Point(92, 45);
            this.DevPwTB.Name = "DevPwTB";
            this.DevPwTB.Size = new System.Drawing.Size(424, 20);
            this.DevPwTB.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DevID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dev Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // DevSoftwareTB
            // 
            this.DevSoftwareTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevSoftwareTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DevSoftwareTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DevSoftwareTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DevSoftwareTB.Location = new System.Drawing.Point(92, 71);
            this.DevSoftwareTB.Name = "DevSoftwareTB";
            this.DevSoftwareTB.Size = new System.Drawing.Size(424, 20);
            this.DevSoftwareTB.TabIndex = 7;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.PasswordTB.Location = new System.Drawing.Point(91, 123);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(424, 20);
            this.PasswordTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dev Software";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.UsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.UsernameTB.Location = new System.Drawing.Point(92, 97);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(424, 20);
            this.UsernameTB.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.groupBox2.BorderThickness = 1;
            this.groupBox2.Controls.Add(this.ViewXmlBT);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.DlFormatCB);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.RegionsCB);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.MediaTypeCB);
            this.groupBox2.Controls.Add(this.GamesCB);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.groupBox2.Location = new System.Drawing.Point(11, 447);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 132);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "API Download Parameters";
            this.groupBox2.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            // 
            // ViewXmlBT
            // 
            this.ViewXmlBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewXmlBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ViewXmlBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ViewXmlBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ViewXmlBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewXmlBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ViewXmlBT.Image = global::stigzler.ScreenScraper.Test.Properties.Resources.document_export;
            this.ViewXmlBT.Location = new System.Drawing.Point(483, 18);
            this.ViewXmlBT.Name = "ViewXmlBT";
            this.ViewXmlBT.Size = new System.Drawing.Size(33, 23);
            this.ViewXmlBT.TabIndex = 23;
            this.ViewXmlBT.UseVisualStyleBackColor = true;
            this.ViewXmlBT.Click += new System.EventHandler(this.ViewXmlBT_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Img Format:";
            // 
            // CrcTB
            // 
            this.CrcTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CrcTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CrcTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrcTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CrcTB.Location = new System.Drawing.Point(91, 97);
            this.CrcTB.Name = "CrcTB";
            this.CrcTB.Size = new System.Drawing.Size(419, 20);
            this.CrcTB.TabIndex = 11;
            // 
            // DlFormatCB
            // 
            this.DlFormatCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DlFormatCB.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DlFormatCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DlFormatCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DlFormatCB.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DlFormatCB.ComboBoxMode = stigzler.Winforms.Base.UIElements.ComboBoxMode.Normal;
            this.DlFormatCB.DropDownImages = null;
            this.DlFormatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DlFormatCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DlFormatCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DlFormatCB.FormattingEnabled = true;
            this.DlFormatCB.Items.AddRange(new object[] {
            "png",
            "jpg"});
            this.DlFormatCB.Location = new System.Drawing.Point(91, 100);
            this.DlFormatCB.Name = "DlFormatCB";
            this.DlFormatCB.RedrawOnResize = true;
            this.DlFormatCB.Size = new System.Drawing.Size(424, 21);
            this.DlFormatCB.TabIndex = 27;
            // 
            // Md5TB
            // 
            this.Md5TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Md5TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Md5TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Md5TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Md5TB.Location = new System.Drawing.Point(91, 123);
            this.Md5TB.Name = "Md5TB";
            this.Md5TB.Size = new System.Drawing.Size(419, 20);
            this.Md5TB.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(39, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Region:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "CRC";
            // 
            // RegionsCB
            // 
            this.RegionsCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegionsCB.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RegionsCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RegionsCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.RegionsCB.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.RegionsCB.ComboBoxMode = stigzler.Winforms.Base.UIElements.ComboBoxMode.Normal;
            this.RegionsCB.DropDownImages = null;
            this.RegionsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionsCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegionsCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RegionsCB.FormattingEnabled = true;
            this.RegionsCB.Location = new System.Drawing.Point(91, 73);
            this.RegionsCB.Name = "RegionsCB";
            this.RegionsCB.RedrawOnResize = true;
            this.RegionsCB.Size = new System.Drawing.Size(424, 21);
            this.RegionsCB.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "MD5";
            // 
            // Sha1TB
            // 
            this.Sha1TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sha1TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Sha1TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sha1TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Sha1TB.Location = new System.Drawing.Point(91, 149);
            this.Sha1TB.Name = "Sha1TB";
            this.Sha1TB.Size = new System.Drawing.Size(419, 20);
            this.Sha1TB.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Img Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "SHA1";
            // 
            // MediaTypeCB
            // 
            this.MediaTypeCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaTypeCB.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MediaTypeCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MediaTypeCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MediaTypeCB.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MediaTypeCB.ComboBoxMode = stigzler.Winforms.Base.UIElements.ComboBoxMode.Normal;
            this.MediaTypeCB.DropDownImages = null;
            this.MediaTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MediaTypeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediaTypeCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MediaTypeCB.FormattingEnabled = true;
            this.MediaTypeCB.Location = new System.Drawing.Point(91, 46);
            this.MediaTypeCB.Name = "MediaTypeCB";
            this.MediaTypeCB.RedrawOnResize = true;
            this.MediaTypeCB.Size = new System.Drawing.Size(424, 21);
            this.MediaTypeCB.TabIndex = 22;
            // 
            // GamesCB
            // 
            this.GamesCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamesCB.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.GamesCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GamesCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.GamesCB.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.GamesCB.ComboBoxMode = stigzler.Winforms.Base.UIElements.ComboBoxMode.Normal;
            this.GamesCB.DropDownImages = null;
            this.GamesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GamesCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamesCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.GamesCB.FormattingEnabled = true;
            this.GamesCB.Location = new System.Drawing.Point(91, 19);
            this.GamesCB.Name = "GamesCB";
            this.GamesCB.RedrawOnResize = true;
            this.GamesCB.Size = new System.Drawing.Size(386, 21);
            this.GamesCB.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(45, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Game:";
            // 
            // UpdatePN
            // 
            this.UpdatePN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.UpdatePN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdatePN.Controls.Add(this.UpdateRateLB);
            this.UpdatePN.Controls.Add(this.UpdateLB);
            this.UpdatePN.Controls.Add(this.UpdatePB);
            this.UpdatePN.Controls.Add(this.MainOpTitleLB);
            this.UpdatePN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UpdatePN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.UpdatePN.Location = new System.Drawing.Point(4, 737);
            this.UpdatePN.Name = "UpdatePN";
            this.UpdatePN.Size = new System.Drawing.Size(555, 105);
            this.UpdatePN.TabIndex = 13;
            // 
            // UpdateRateLB
            // 
            this.UpdateRateLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateRateLB.AutoEllipsis = true;
            this.UpdateRateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRateLB.FontStyle = System.Drawing.FontStyle.Regular;
            this.UpdateRateLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.UpdateRateLB.Location = new System.Drawing.Point(13, 72);
            this.UpdateRateLB.Name = "UpdateRateLB";
            this.UpdateRateLB.Padding = new System.Windows.Forms.Padding(4);
            this.UpdateRateLB.ScaleFont = 100;
            this.UpdateRateLB.Size = new System.Drawing.Size(521, 21);
            this.UpdateRateLB.TabIndex = 3;
            this.UpdateRateLB.Text = "Rate";
            this.UpdateRateLB.ToolTip = null;
            this.UpdateRateLB.ToolTipHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.UpdateRateLB.ToolTipImage = null;
            this.UpdateRateLB.ToolTipText = null;
            this.UpdateRateLB.ToolTipTitle = null;
            this.UpdateRateLB.Click += new System.EventHandler(this.UpdateRateLB_Click);
            // 
            // UpdateLB
            // 
            this.UpdateLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateLB.AutoEllipsis = true;
            this.UpdateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLB.FontStyle = System.Drawing.FontStyle.Regular;
            this.UpdateLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.UpdateLB.Location = new System.Drawing.Point(13, 49);
            this.UpdateLB.Name = "UpdateLB";
            this.UpdateLB.Padding = new System.Windows.Forms.Padding(4);
            this.UpdateLB.ScaleFont = 100;
            this.UpdateLB.Size = new System.Drawing.Size(527, 23);
            this.UpdateLB.TabIndex = 0;
            this.UpdateLB.Text = "Progress";
            this.UpdateLB.ToolTip = null;
            this.UpdateLB.ToolTipHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.UpdateLB.ToolTipImage = null;
            this.UpdateLB.ToolTipText = null;
            this.UpdateLB.ToolTipTitle = null;
            // 
            // UpdatePB
            // 
            this.UpdatePB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdatePB.Location = new System.Drawing.Point(10, 34);
            this.UpdatePB.MarqueeAnimationSpeed = 10;
            this.UpdatePB.Name = "UpdatePB";
            this.UpdatePB.Size = new System.Drawing.Size(530, 10);
            this.UpdatePB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.UpdatePB.TabIndex = 1;
            // 
            // MainOpTitleLB
            // 
            this.MainOpTitleLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainOpTitleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainOpTitleLB.FontStyle = System.Drawing.FontStyle.Bold;
            this.MainOpTitleLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MainOpTitleLB.Location = new System.Drawing.Point(7, 6);
            this.MainOpTitleLB.Name = "MainOpTitleLB";
            this.MainOpTitleLB.Padding = new System.Windows.Forms.Padding(4);
            this.MainOpTitleLB.ScaleFont = 100;
            this.MainOpTitleLB.Size = new System.Drawing.Size(533, 21);
            this.MainOpTitleLB.TabIndex = 2;
            this.MainOpTitleLB.Text = "Operation";
            this.MainOpTitleLB.ToolTip = null;
            this.MainOpTitleLB.ToolTipHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.MainOpTitleLB.ToolTipImage = null;
            this.MainOpTitleLB.ToolTipText = null;
            this.MainOpTitleLB.ToolTipTitle = null;
            // 
            // OpsPN
            // 
            this.OpsPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.OpsPN.Controls.Add(this.SaveGamesToDbBT);
            this.OpsPN.Controls.Add(this.QueryTypeCB);
            this.OpsPN.Controls.Add(this.label16);
            this.OpsPN.Controls.Add(this.outputFormatCB);
            this.OpsPN.Controls.Add(this.ButtonsPN);
            this.OpsPN.Controls.Add(this.label6);
            this.OpsPN.Controls.Add(this.UserThreadsNUM);
            this.OpsPN.Controls.Add(this.label9);
            this.OpsPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpsPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.OpsPN.Location = new System.Drawing.Point(4, 4);
            this.OpsPN.Name = "OpsPN";
            this.OpsPN.Size = new System.Drawing.Size(555, 144);
            this.OpsPN.TabIndex = 21;
            // 
            // SaveGamesToDbBT
            // 
            this.SaveGamesToDbBT.AutoSize = true;
            this.SaveGamesToDbBT.Location = new System.Drawing.Point(85, 87);
            this.SaveGamesToDbBT.Name = "SaveGamesToDbBT";
            this.SaveGamesToDbBT.Size = new System.Drawing.Size(143, 17);
            this.SaveGamesToDbBT.TabIndex = 21;
            this.SaveGamesToDbBT.Text = "SaveGamesToDatabase";
            this.toolTip1.SetToolTip(this.SaveGamesToDbBT, "Saves any scraped games to the database");
            this.SaveGamesToDbBT.UseVisualStyleBackColor = true;
            // 
            // QueryTypeCB
            // 
            this.QueryTypeCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryTypeCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.QueryTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QueryTypeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryTypeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryTypeCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.QueryTypeCB.FormattingEnabled = true;
            this.QueryTypeCB.Items.AddRange(new object[] {
            "Server Details"});
            this.QueryTypeCB.Location = new System.Drawing.Point(85, 3);
            this.QueryTypeCB.Name = "QueryTypeCB";
            this.QueryTypeCB.Size = new System.Drawing.Size(467, 24);
            this.QueryTypeCB.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Query:";
            // 
            // outputFormatCB
            // 
            this.outputFormatCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFormatCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.outputFormatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputFormatCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputFormatCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.outputFormatCB.FormattingEnabled = true;
            this.outputFormatCB.Items.AddRange(new object[] {
            "Server Details"});
            this.outputFormatCB.Location = new System.Drawing.Point(85, 33);
            this.outputFormatCB.Name = "outputFormatCB";
            this.outputFormatCB.Size = new System.Drawing.Size(467, 21);
            this.outputFormatCB.TabIndex = 5;
            this.outputFormatCB.SelectedIndexChanged += new System.EventHandler(this.outputFormatCB_SelectedIndexChanged);
            // 
            // ButtonsPN
            // 
            this.ButtonsPN.AutoSize = true;
            this.ButtonsPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonsPN.Controls.Add(this.GoBT);
            this.ButtonsPN.Controls.Add(this.CancelBT);
            this.ButtonsPN.Controls.Add(this.TestBT);
            this.ButtonsPN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPN.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ButtonsPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ButtonsPN.Location = new System.Drawing.Point(0, 115);
            this.ButtonsPN.Name = "ButtonsPN";
            this.ButtonsPN.Size = new System.Drawing.Size(555, 29);
            this.ButtonsPN.TabIndex = 19;
            // 
            // GoBT
            // 
            this.GoBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.GoBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.GoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.GoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.GoBT.Location = new System.Drawing.Point(477, 3);
            this.GoBT.Name = "GoBT";
            this.GoBT.Size = new System.Drawing.Size(75, 23);
            this.GoBT.TabIndex = 4;
            this.GoBT.Text = "Go";
            this.GoBT.UseVisualStyleBackColor = true;
            this.GoBT.Click += new System.EventHandler(this.GoBT_Click);
            // 
            // CancelBT
            // 
            this.CancelBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CancelBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.CancelBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CancelBT.Location = new System.Drawing.Point(396, 3);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 14;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // TestBT
            // 
            this.TestBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TestBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TestBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TestBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.TestBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TestBT.Location = new System.Drawing.Point(315, 3);
            this.TestBT.Name = "TestBT";
            this.TestBT.Size = new System.Drawing.Size(75, 23);
            this.TestBT.TabIndex = 20;
            this.TestBT.Text = "Test";
            this.TestBT.UseVisualStyleBackColor = true;
            this.TestBT.Click += new System.EventHandler(this.TestBT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Output:";
            // 
            // UserThreadsNUM
            // 
            this.UserThreadsNUM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserThreadsNUM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.UserThreadsNUM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.UserThreadsNUM.Location = new System.Drawing.Point(85, 60);
            this.UserThreadsNUM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserThreadsNUM.Name = "UserThreadsNUM";
            this.UserThreadsNUM.Size = new System.Drawing.Size(467, 20);
            this.UserThreadsNUM.TabIndex = 15;
            this.UserThreadsNUM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "User Threads:";
            // 
            // RhsSC
            // 
            this.RhsSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RhsSC.Location = new System.Drawing.Point(0, 0);
            this.RhsSC.Name = "RhsSC";
            this.RhsSC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // RhsSC.Panel1
            // 
            this.RhsSC.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RhsSC.Panel1.Controls.Add(this.tabControl1);
            this.RhsSC.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            // 
            // RhsSC.Panel2
            // 
            this.RhsSC.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RhsSC.Panel2.Controls.Add(this.MediaBroswerPN);
            this.RhsSC.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RhsSC.Size = new System.Drawing.Size(609, 846);
            this.RhsSC.SplitterDistance = 602;
            this.RhsSC.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.HideBorders = false;
            this.tabControl1.HideTabs = false;
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(187)))));
            this.tabControl1.Size = new System.Drawing.Size(609, 602);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.TabOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.tabControl1.UnselectedTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage1.Controls.Add(this.RtbPN);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Console";
            // 
            // RtbPN
            // 
            this.RtbPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RtbPN.Controls.Add(this.MainRTB);
            this.RtbPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RtbPN.Location = new System.Drawing.Point(3, 28);
            this.RtbPN.Name = "RtbPN";
            this.RtbPN.Padding = new System.Windows.Forms.Padding(4);
            this.RtbPN.Size = new System.Drawing.Size(595, 545);
            this.RtbPN.TabIndex = 3;
            // 
            // MainRTB
            // 
            this.MainRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainRTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MainRTB.Location = new System.Drawing.Point(4, 4);
            this.MainRTB.Name = "MainRTB";
            this.MainRTB.Size = new System.Drawing.Size(587, 537);
            this.MainRTB.TabIndex = 0;
            this.MainRTB.Text = "";
            this.MainRTB.WordWrap = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.toolStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordwrapBT,
            this.ClearConsoleBT,
            this.toolStripSeparator1,
            this.SerchTextTB,
            this.SearchTextBT});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(595, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // WordwrapBT
            // 
            this.WordwrapBT.CheckOnClick = true;
            this.WordwrapBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.WordwrapBT.Image = global::stigzler.ScreenScraper.Test.Properties.Resources.arrow_return_180;
            this.WordwrapBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WordwrapBT.Name = "WordwrapBT";
            this.WordwrapBT.Size = new System.Drawing.Size(23, 22);
            this.WordwrapBT.Text = "toolStripButton1";
            this.WordwrapBT.ToolTipText = "Toggle Wordwrap";
            this.WordwrapBT.Click += new System.EventHandler(this.WordwrapBT_Click);
            // 
            // ClearConsoleBT
            // 
            this.ClearConsoleBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearConsoleBT.Image = global::stigzler.ScreenScraper.Test.Properties.Resources.eraser;
            this.ClearConsoleBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearConsoleBT.Name = "ClearConsoleBT";
            this.ClearConsoleBT.Size = new System.Drawing.Size(23, 22);
            this.ClearConsoleBT.Text = "toolStripButton1";
            this.ClearConsoleBT.ToolTipText = "Clear Console";
            this.ClearConsoleBT.Click += new System.EventHandler(this.ClearConsoleBT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SerchTextTB
            // 
            this.SerchTextTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SerchTextTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerchTextTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SerchTextTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.SerchTextTB.Name = "SerchTextTB";
            this.SerchTextTB.Size = new System.Drawing.Size(200, 25);
            // 
            // SearchTextBT
            // 
            this.SearchTextBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchTextBT.Image = global::stigzler.ScreenScraper.Test.Properties.Resources.magnifier;
            this.SearchTextBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchTextBT.Name = "SearchTextBT";
            this.SearchTextBT.Size = new System.Drawing.Size(23, 22);
            this.SearchTextBT.Text = "toolStripButton1";
            this.SearchTextBT.Click += new System.EventHandler(this.SearchTextBT_Click);
            // 
            // MediaBroswerPN
            // 
            this.MediaBroswerPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MediaBroswerPN.Controls.Add(this.MediaPB);
            this.MediaBroswerPN.Controls.Add(this.flowLayoutPanel2);
            this.MediaBroswerPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaBroswerPN.Emphasis = 0;
            this.MediaBroswerPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MediaBroswerPN.Location = new System.Drawing.Point(0, 0);
            this.MediaBroswerPN.Name = "MediaBroswerPN";
            this.MediaBroswerPN.Size = new System.Drawing.Size(609, 240);
            this.MediaBroswerPN.TabIndex = 0;
            // 
            // MediaPB
            // 
            this.MediaPB.BackgroundImage = global::stigzler.ScreenScraper.Test.Properties.Resources.ImgBG;
            this.MediaPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MediaPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaPB.Location = new System.Drawing.Point(0, 0);
            this.MediaPB.Name = "MediaPB";
            this.MediaPB.Size = new System.Drawing.Size(476, 240);
            this.MediaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MediaPB.TabIndex = 0;
            this.MediaPB.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel2.Controls.Add(this.OpenVideoBT);
            this.flowLayoutPanel2.Controls.Add(this.OpenManualBT);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(476, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(133, 240);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // OpenVideoBT
            // 
            this.OpenVideoBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OpenVideoBT.Enabled = false;
            this.OpenVideoBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OpenVideoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.OpenVideoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenVideoBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.OpenVideoBT.Location = new System.Drawing.Point(3, 3);
            this.OpenVideoBT.Name = "OpenVideoBT";
            this.OpenVideoBT.Size = new System.Drawing.Size(127, 23);
            this.OpenVideoBT.TabIndex = 0;
            this.OpenVideoBT.Text = "Open Video";
            this.OpenVideoBT.UseVisualStyleBackColor = true;
            this.OpenVideoBT.Click += new System.EventHandler(this.OpenVideoBT_Click);
            // 
            // OpenManualBT
            // 
            this.OpenManualBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OpenManualBT.Enabled = false;
            this.OpenManualBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OpenManualBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.OpenManualBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenManualBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.OpenManualBT.Location = new System.Drawing.Point(3, 32);
            this.OpenManualBT.Name = "OpenManualBT";
            this.OpenManualBT.Size = new System.Drawing.Size(127, 23);
            this.OpenManualBT.TabIndex = 1;
            this.OpenManualBT.Text = "Open Manual";
            this.OpenManualBT.UseVisualStyleBackColor = true;
            this.OpenManualBT.Click += new System.EventHandler(this.OpenManualBT_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel1.Controls.Add(this.SaveSettingsBT);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 872);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1180, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // SaveSettingsBT
            // 
            this.SaveSettingsBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveSettingsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SaveSettingsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveSettingsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SaveSettingsBT.Location = new System.Drawing.Point(1082, 3);
            this.SaveSettingsBT.Name = "SaveSettingsBT";
            this.SaveSettingsBT.Size = new System.Drawing.Size(95, 23);
            this.SaveSettingsBT.TabIndex = 0;
            this.SaveSettingsBT.Text = "Save Settings";
            this.SaveSettingsBT.UseVisualStyleBackColor = true;
            this.SaveSettingsBT.Click += new System.EventHandler(this.SaveSettingsBT_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1180, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ToolTip = null;
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scrapeAllRomsForSelectedSystemToolStripMenuItem,
            this.resetDatabaseToolStripMenuItem,
            this.getAllGameImagesToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // scrapeAllRomsForSelectedSystemToolStripMenuItem
            // 
            this.scrapeAllRomsForSelectedSystemToolStripMenuItem.Name = "scrapeAllRomsForSelectedSystemToolStripMenuItem";
            this.scrapeAllRomsForSelectedSystemToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.scrapeAllRomsForSelectedSystemToolStripMenuItem.Text = "Scrape all Roms for selected System";
            this.scrapeAllRomsForSelectedSystemToolStripMenuItem.Click += new System.EventHandler(this.scrapeAllRomsForSelectedSystemToolStripMenuItem_Click);
            // 
            // resetDatabaseToolStripMenuItem
            // 
            this.resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
            this.resetDatabaseToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.resetDatabaseToolStripMenuItem.Text = "Reset Database";
            this.resetDatabaseToolStripMenuItem.Click += new System.EventHandler(this.resetDatabaseToolStripMenuItem_Click);
            // 
            // getAllGameImagesToolStripMenuItem
            // 
            this.getAllGameImagesToolStripMenuItem.Name = "getAllGameImagesToolStripMenuItem";
            this.getAllGameImagesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.getAllGameImagesToolStripMenuItem.Text = "Get all images for selected Game";
            this.getAllGameImagesToolStripMenuItem.Click += new System.EventHandler(this.getAllGameImagesToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.groupBox4.BorderThickness = 1;
            this.groupBox4.Controls.Add(this.GameIdTB);
            this.groupBox4.Controls.Add(this.GameIdLB);
            this.groupBox4.Controls.Add(this.GameNameSearchTB);
            this.groupBox4.Controls.Add(this.RomNameSearchTB);
            this.groupBox4.Controls.Add(this.CrcTB);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.Md5TB);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.Sha1TB);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.groupBox4.Location = new System.Drawing.Point(11, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(524, 182);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serach Parameters";
            this.groupBox4.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            // 
            // GameNameSearchTB
            // 
            this.GameNameSearchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameNameSearchTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GameNameSearchTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameNameSearchTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.GameNameSearchTB.Location = new System.Drawing.Point(92, 19);
            this.GameNameSearchTB.Name = "GameNameSearchTB";
            this.GameNameSearchTB.Size = new System.Drawing.Size(419, 20);
            this.GameNameSearchTB.TabIndex = 11;
            // 
            // RomNameSearchTB
            // 
            this.RomNameSearchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RomNameSearchTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RomNameSearchTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomNameSearchTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RomNameSearchTB.Location = new System.Drawing.Point(91, 71);
            this.RomNameSearchTB.Name = "RomNameSearchTB";
            this.RomNameSearchTB.Size = new System.Drawing.Size(419, 20);
            this.RomNameSearchTB.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Game Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Rom Name:";
            // 
            // GameIdTB
            // 
            this.GameIdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GameIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameIdTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.GameIdTB.Location = new System.Drawing.Point(92, 45);
            this.GameIdTB.Name = "GameIdTB";
            this.GameIdTB.Size = new System.Drawing.Size(419, 20);
            this.GameIdTB.TabIndex = 21;
            // 
            // GameIdLB
            // 
            this.GameIdLB.AutoSize = true;
            this.GameIdLB.Location = new System.Drawing.Point(32, 47);
            this.GameIdLB.Name = "GameIdLB";
            this.GameIdLB.Size = new System.Drawing.Size(52, 13);
            this.GameIdLB.TabIndex = 20;
            this.GameIdLB.Text = "Game ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 901);
            this.Controls.Add(this.VerticalSC);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DarkMode = true;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VerticalSC.Panel1.ResumeLayout(false);
            this.VerticalSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSC)).EndInit();
            this.VerticalSC.ResumeLayout(false);
            this.VarsPN.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.UpdatePN.ResumeLayout(false);
            this.OpsPN.ResumeLayout(false);
            this.OpsPN.PerformLayout();
            this.ButtonsPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserThreadsNUM)).EndInit();
            this.RhsSC.Panel1.ResumeLayout(false);
            this.RhsSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RhsSC)).EndInit();
            this.RhsSC.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.RtbPN.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MediaBroswerPN.ResumeLayout(false);
            this.MediaBroswerPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPB)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer VerticalSC;
        private System.Windows.Forms.TextBox DevPwTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DevSoftwareTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DevIdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SaveSettingsBT;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ClearConsoleBT;
        private System.Windows.Forms.Button GoBT;
        private System.Windows.Forms.ComboBox QueryTypeCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox outputFormatCB;
        private System.Windows.Forms.ProgressBar UpdatePB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripTextBox SerchTextTB;
        private System.Windows.Forms.ToolStripButton SearchTextBT;
        private Winforms.Base.UIElements.Label MainOpTitleLB;
        private Winforms.Base.UIElements.Label UpdateLB;
        private Winforms.Base.UIElements.Label UpdateRateLB;
        private System.Windows.Forms.Panel UpdatePN;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.NumericUpDown UserThreadsNUM;
        private Winforms.Base.UIElements.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Winforms.Base.UIElements.ComboBox SystemsCB;
        private System.Windows.Forms.Panel RtbPN;
        private Winforms.Base.UIElements.RichTextBox MainRTB;
        private Winforms.Base.UIElements.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CrcTB;
        private System.Windows.Forms.TextBox Md5TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Sha1TB;
        private System.Windows.Forms.Label label13;
        private Winforms.Base.UIElements.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel ButtonsPN;
        private Winforms.Base.UIElements.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel VarsPN;
        private System.Windows.Forms.Panel OpsPN;
        private Winforms.Base.UserControls.FolderBrowserTextBox RomFolderTB;
        private System.Windows.Forms.Label label17;
        private Winforms.Base.UIElements.ComboBox GamesCB;
        private System.Windows.Forms.Label label18;
        private Winforms.Base.UIElements.ComboBox MediaTypeCB;
        private Winforms.Base.UIElements.Button ViewXmlBT;
        private System.Windows.Forms.PictureBox MediaPB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Winforms.Base.UIElements.Button OpenVideoBT;
        private Winforms.Base.UIElements.Button OpenManualBT;
        private System.Windows.Forms.SplitContainer RhsSC;
        private Winforms.Base.UIElements.Panel MediaBroswerPN;
        private System.Windows.Forms.Label label19;
        private Winforms.Base.UIElements.ComboBox RegionsCB;
        private System.Windows.Forms.Label label20;
        private Winforms.Base.UIElements.ComboBox DlFormatCB;
        private System.Windows.Forms.ToolStripButton WordwrapBT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button TestBT;
        private System.Windows.Forms.CheckBox SaveGamesToDbBT;
        private System.Windows.Forms.ToolTip toolTip1;
        private Winforms.Base.UIElements.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrapeAllRomsForSelectedSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAllGameImagesToolStripMenuItem;
        private Winforms.Base.UIElements.GroupBox groupBox4;
        private System.Windows.Forms.TextBox GameNameSearchTB;
        private System.Windows.Forms.TextBox RomNameSearchTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox GameIdTB;
        private System.Windows.Forms.Label GameIdLB;
    }
}

