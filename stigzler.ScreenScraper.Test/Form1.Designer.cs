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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VerticalSC = new System.Windows.Forms.SplitContainer();
            this.UpdatePN = new System.Windows.Forms.Panel();
            this.UpdateRateLB = new stigzler.Winforms.Base.UIElements.Label();
            this.UpdateLB = new stigzler.Winforms.Base.UIElements.Label();
            this.UpdatePB = new System.Windows.Forms.ProgressBar();
            this.MainOpTitleLB = new stigzler.Winforms.Base.UIElements.Label();
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
            this.label15 = new System.Windows.Forms.Label();
            this.ObjectIdTB = new System.Windows.Forms.TextBox();
            this.CrcTB = new System.Windows.Forms.TextBox();
            this.Md5TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Sha1TB = new System.Windows.Forms.TextBox();
            this.MediaFormatTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.MediaTypeNameTB = new System.Windows.Forms.TextBox();
            this.ButtonsPN = new System.Windows.Forms.FlowLayoutPanel();
            this.GoBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            this.OpsPN = new System.Windows.Forms.Panel();
            this.QueryTypeCB = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.outputFormatCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UserThreadsNUM = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new stigzler.Winforms.Base.UIElements.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RtbPN = new System.Windows.Forms.Panel();
            this.MainRTB = new stigzler.Winforms.Base.UIElements.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ClearConsoleBT = new System.Windows.Forms.ToolStripButton();
            this.SerchTextTB = new System.Windows.Forms.ToolStripTextBox();
            this.SearchTextBT = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ResultsDGV = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveSettingsBT = new System.Windows.Forms.Button();
            this.ScrapeAllSystemRomsBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSC)).BeginInit();
            this.VerticalSC.Panel1.SuspendLayout();
            this.VerticalSC.Panel2.SuspendLayout();
            this.VerticalSC.SuspendLayout();
            this.UpdatePN.SuspendLayout();
            this.VarsPN.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ButtonsPN.SuspendLayout();
            this.OpsPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserThreadsNUM)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.RtbPN.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDGV)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VerticalSC
            // 
            this.VerticalSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VerticalSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerticalSC.Location = new System.Drawing.Point(0, 0);
            this.VerticalSC.Name = "VerticalSC";
            // 
            // VerticalSC.Panel1
            // 
            this.VerticalSC.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.VerticalSC.Panel1.Controls.Add(this.UpdatePN);
            this.VerticalSC.Panel1.Controls.Add(this.VarsPN);
            this.VerticalSC.Panel1.Controls.Add(this.ButtonsPN);
            this.VerticalSC.Panel1.Controls.Add(this.OpsPN);
            this.VerticalSC.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.VerticalSC.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // VerticalSC.Panel2
            // 
            this.VerticalSC.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.VerticalSC.Panel2.Controls.Add(this.tabControl1);
            this.VerticalSC.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.VerticalSC.Size = new System.Drawing.Size(1227, 759);
            this.VerticalSC.SplitterDistance = 588;
            this.VerticalSC.TabIndex = 3;
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
            this.UpdatePN.Location = new System.Drawing.Point(4, 648);
            this.UpdatePN.Name = "UpdatePN";
            this.UpdatePN.Size = new System.Drawing.Size(578, 105);
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
            this.UpdateRateLB.Size = new System.Drawing.Size(544, 21);
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
            this.UpdateLB.Size = new System.Drawing.Size(550, 23);
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
            this.UpdatePB.Size = new System.Drawing.Size(553, 10);
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
            this.MainOpTitleLB.Size = new System.Drawing.Size(556, 21);
            this.MainOpTitleLB.TabIndex = 2;
            this.MainOpTitleLB.Text = "Operation";
            this.MainOpTitleLB.ToolTip = null;
            this.MainOpTitleLB.ToolTipHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.MainOpTitleLB.ToolTipImage = null;
            this.MainOpTitleLB.ToolTipText = null;
            this.MainOpTitleLB.ToolTipTitle = null;
            // 
            // VarsPN
            // 
            this.VarsPN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VarsPN.AutoScroll = true;
            this.VarsPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.VarsPN.Controls.Add(this.groupBox3);
            this.VarsPN.Controls.Add(this.groupBox1);
            this.VarsPN.Controls.Add(this.groupBox2);
            this.VarsPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.VarsPN.Location = new System.Drawing.Point(4, 130);
            this.VarsPN.Name = "VarsPN";
            this.VarsPN.Size = new System.Drawing.Size(578, 518);
            this.VarsPN.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.groupBox3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.groupBox3.BorderThickness = 1;
            this.groupBox3.Controls.Add(this.RomFolderTB);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.SystemsCB);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General";
            this.groupBox3.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
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
            this.RomFolderTB.Location = new System.Drawing.Point(79, 56);
            this.RomFolderTB.Margin = new System.Windows.Forms.Padding(0);
            this.RomFolderTB.Name = "RomFolderTB";
            this.RomFolderTB.ReadOnly = true;
            this.RomFolderTB.ScaleFont = 100;
            this.RomFolderTB.Size = new System.Drawing.Size(472, 20);
            this.RomFolderTB.TabIndex = 18;
            this.RomFolderTB.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomFolderTB.DirectoryPathChanged += new stigzler.Winforms.Base.Events.DirectoryPathChanged(this.RomFolderTB_DirectoryPathChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "System:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "RomFolder";
            // 
            // SystemsCB
            // 
            this.SystemsCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemsCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SystemsCB.ComboBoxMode = stigzler.Winforms.Base.UIElements.ComboBoxMode.Normal;
            this.SystemsCB.DropDownImages = null;
            this.SystemsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemsCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemsCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.SystemsCB.FormattingEnabled = true;
            this.SystemsCB.Location = new System.Drawing.Point(78, 25);
            this.SystemsCB.Name = "SystemsCB";
            this.SystemsCB.RedrawOnResize = true;
            this.SystemsCB.Size = new System.Drawing.Size(473, 21);
            this.SystemsCB.TabIndex = 17;
            this.SystemsCB.SelectedIndexChanged += new System.EventHandler(this.SystemsCB_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
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
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API Parameters";
            this.groupBox1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
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
            this.DevIdTB.Size = new System.Drawing.Size(455, 20);
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
            this.DevPwTB.Size = new System.Drawing.Size(455, 20);
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
            this.DevSoftwareTB.Size = new System.Drawing.Size(455, 20);
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
            this.PasswordTB.Size = new System.Drawing.Size(455, 20);
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
            this.UsernameTB.Size = new System.Drawing.Size(455, 20);
            this.UsernameTB.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.groupBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.groupBox2.BorderThickness = 1;
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.ObjectIdTB);
            this.groupBox2.Controls.Add(this.CrcTB);
            this.groupBox2.Controls.Add(this.Md5TB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Sha1TB);
            this.groupBox2.Controls.Add(this.MediaFormatTB);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.MediaTypeNameTB);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 183);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "API Download Parameters";
            this.groupBox2.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Object ID";
            // 
            // ObjectIdTB
            // 
            this.ObjectIdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ObjectIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjectIdTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ObjectIdTB.Location = new System.Drawing.Point(109, 149);
            this.ObjectIdTB.Name = "ObjectIdTB";
            this.ObjectIdTB.Size = new System.Drawing.Size(447, 20);
            this.ObjectIdTB.TabIndex = 21;
            // 
            // CrcTB
            // 
            this.CrcTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CrcTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CrcTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrcTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CrcTB.Location = new System.Drawing.Point(109, 19);
            this.CrcTB.Name = "CrcTB";
            this.CrcTB.Size = new System.Drawing.Size(447, 20);
            this.CrcTB.TabIndex = 11;
            // 
            // Md5TB
            // 
            this.Md5TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Md5TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Md5TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Md5TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Md5TB.Location = new System.Drawing.Point(110, 45);
            this.Md5TB.Name = "Md5TB";
            this.Md5TB.Size = new System.Drawing.Size(447, 20);
            this.Md5TB.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "CRC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "MD5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Media Format";
            // 
            // Sha1TB
            // 
            this.Sha1TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sha1TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Sha1TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sha1TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Sha1TB.Location = new System.Drawing.Point(110, 71);
            this.Sha1TB.Name = "Sha1TB";
            this.Sha1TB.Size = new System.Drawing.Size(447, 20);
            this.Sha1TB.TabIndex = 17;
            // 
            // MediaFormatTB
            // 
            this.MediaFormatTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaFormatTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MediaFormatTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MediaFormatTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MediaFormatTB.Location = new System.Drawing.Point(109, 123);
            this.MediaFormatTB.Name = "MediaFormatTB";
            this.MediaFormatTB.Size = new System.Drawing.Size(447, 20);
            this.MediaFormatTB.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "SHA1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Media Type Name";
            // 
            // MediaTypeNameTB
            // 
            this.MediaTypeNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaTypeNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MediaTypeNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MediaTypeNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MediaTypeNameTB.Location = new System.Drawing.Point(110, 97);
            this.MediaTypeNameTB.Name = "MediaTypeNameTB";
            this.MediaTypeNameTB.Size = new System.Drawing.Size(447, 20);
            this.MediaTypeNameTB.TabIndex = 15;
            // 
            // ButtonsPN
            // 
            this.ButtonsPN.AutoSize = true;
            this.ButtonsPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonsPN.Controls.Add(this.GoBT);
            this.ButtonsPN.Controls.Add(this.CancelBT);
            this.ButtonsPN.Controls.Add(this.ScrapeAllSystemRomsBT);
            this.ButtonsPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPN.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ButtonsPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ButtonsPN.Location = new System.Drawing.Point(4, 101);
            this.ButtonsPN.Name = "ButtonsPN";
            this.ButtonsPN.Size = new System.Drawing.Size(578, 29);
            this.ButtonsPN.TabIndex = 19;
            // 
            // GoBT
            // 
            this.GoBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.GoBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.GoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.GoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.GoBT.Location = new System.Drawing.Point(500, 3);
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
            this.CancelBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.CancelBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.CancelBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CancelBT.Location = new System.Drawing.Point(419, 3);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 14;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // OpsPN
            // 
            this.OpsPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.OpsPN.Controls.Add(this.QueryTypeCB);
            this.OpsPN.Controls.Add(this.label16);
            this.OpsPN.Controls.Add(this.outputFormatCB);
            this.OpsPN.Controls.Add(this.label6);
            this.OpsPN.Controls.Add(this.UserThreadsNUM);
            this.OpsPN.Controls.Add(this.label9);
            this.OpsPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpsPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.OpsPN.Location = new System.Drawing.Point(4, 4);
            this.OpsPN.Name = "OpsPN";
            this.OpsPN.Size = new System.Drawing.Size(578, 97);
            this.OpsPN.TabIndex = 21;
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
            this.QueryTypeCB.Size = new System.Drawing.Size(490, 24);
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
            this.outputFormatCB.Location = new System.Drawing.Point(85, 43);
            this.outputFormatCB.Name = "outputFormatCB";
            this.outputFormatCB.Size = new System.Drawing.Size(490, 21);
            this.outputFormatCB.TabIndex = 5;
            this.outputFormatCB.SelectedIndexChanged += new System.EventHandler(this.outputFormatCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Output:";
            // 
            // UserThreadsNUM
            // 
            this.UserThreadsNUM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserThreadsNUM.Location = new System.Drawing.Point(85, 70);
            this.UserThreadsNUM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserThreadsNUM.Name = "UserThreadsNUM";
            this.UserThreadsNUM.Size = new System.Drawing.Size(490, 20);
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
            this.label9.Location = new System.Drawing.Point(5, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "User Threads:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.HideBorders = false;
            this.tabControl1.HideTabs = false;
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(187)))));
            this.tabControl1.Size = new System.Drawing.Size(633, 757);
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
            this.tabPage1.Size = new System.Drawing.Size(625, 731);
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
            this.RtbPN.Size = new System.Drawing.Size(619, 700);
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
            this.MainRTB.Size = new System.Drawing.Size(611, 692);
            this.MainRTB.TabIndex = 0;
            this.MainRTB.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.toolStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearConsoleBT,
            this.SerchTextTB,
            this.SearchTextBT});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(619, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ClearConsoleBT
            // 
            this.ClearConsoleBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearConsoleBT.Image = global::stigzler.ScreenScraper.Test.Properties.Resources.eraser;
            this.ClearConsoleBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearConsoleBT.Name = "ClearConsoleBT";
            this.ClearConsoleBT.Size = new System.Drawing.Size(23, 22);
            this.ClearConsoleBT.Text = "toolStripButton1";
            this.ClearConsoleBT.Click += new System.EventHandler(this.ClearConsoleBT_Click);
            // 
            // SerchTextTB
            // 
            this.SerchTextTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SerchTextTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerchTextTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SerchTextTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.SerchTextTB.Name = "SerchTextTB";
            this.SerchTextTB.Size = new System.Drawing.Size(100, 25);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage2.Controls.Add(this.ResultsDGV);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 731);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            // 
            // ResultsDGV
            // 
            this.ResultsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsDGV.Location = new System.Drawing.Point(3, 3);
            this.ResultsDGV.Name = "ResultsDGV";
            this.ResultsDGV.Size = new System.Drawing.Size(619, 725);
            this.ResultsDGV.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel1.Controls.Add(this.SaveSettingsBT);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 759);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1227, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // SaveSettingsBT
            // 
            this.SaveSettingsBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveSettingsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.SaveSettingsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.SaveSettingsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SaveSettingsBT.Location = new System.Drawing.Point(1129, 3);
            this.SaveSettingsBT.Name = "SaveSettingsBT";
            this.SaveSettingsBT.Size = new System.Drawing.Size(95, 23);
            this.SaveSettingsBT.TabIndex = 0;
            this.SaveSettingsBT.Text = "Save Settings";
            this.SaveSettingsBT.UseVisualStyleBackColor = true;
            this.SaveSettingsBT.Click += new System.EventHandler(this.SaveSettingsBT_Click);
            // 
            // ScrapeAllSystemRomsBT
            // 
            this.ScrapeAllSystemRomsBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrapeAllSystemRomsBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ScrapeAllSystemRomsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.ScrapeAllSystemRomsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.ScrapeAllSystemRomsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScrapeAllSystemRomsBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ScrapeAllSystemRomsBT.Location = new System.Drawing.Point(270, 3);
            this.ScrapeAllSystemRomsBT.Name = "ScrapeAllSystemRomsBT";
            this.ScrapeAllSystemRomsBT.Size = new System.Drawing.Size(143, 23);
            this.ScrapeAllSystemRomsBT.TabIndex = 18;
            this.ScrapeAllSystemRomsBT.Text = "Scrape all System Roms";
            this.ScrapeAllSystemRomsBT.UseVisualStyleBackColor = true;
            this.ScrapeAllSystemRomsBT.Click += new System.EventHandler(this.ScrapeAllSystemRomsBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 788);
            this.Controls.Add(this.VerticalSC);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DarkMode = true;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VerticalSC.Panel1.ResumeLayout(false);
            this.VerticalSC.Panel1.PerformLayout();
            this.VerticalSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSC)).EndInit();
            this.VerticalSC.ResumeLayout(false);
            this.UpdatePN.ResumeLayout(false);
            this.VarsPN.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ButtonsPN.ResumeLayout(false);
            this.OpsPN.ResumeLayout(false);
            this.OpsPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserThreadsNUM)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.RtbPN.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDGV)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ResultsDGV;
        private Winforms.Base.UIElements.ComboBox SystemsCB;
        private System.Windows.Forms.Panel RtbPN;
        private Winforms.Base.UIElements.RichTextBox MainRTB;
        private Winforms.Base.UIElements.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CrcTB;
        private System.Windows.Forms.TextBox Md5TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Sha1TB;
        private System.Windows.Forms.TextBox MediaFormatTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MediaTypeNameTB;
        private Winforms.Base.UIElements.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ObjectIdTB;
        private System.Windows.Forms.FlowLayoutPanel ButtonsPN;
        private Winforms.Base.UIElements.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel VarsPN;
        private System.Windows.Forms.Panel OpsPN;
        private Winforms.Base.UserControls.FolderBrowserTextBox RomFolderTB;
        private System.Windows.Forms.Button ScrapeAllSystemRomsBT;
    }
}

