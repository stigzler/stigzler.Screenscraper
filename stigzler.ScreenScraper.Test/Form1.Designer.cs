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
            this.MainRTB = new System.Windows.Forms.RichTextBox();
            this.VerticalSC = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UserThreadsTB = new System.Windows.Forms.TextBox();
            this.SystemIdTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdatePB = new System.Windows.Forms.ProgressBar();
            this.outputFormatCB = new System.Windows.Forms.ComboBox();
            this.GoBT = new System.Windows.Forms.Button();
            this.QueryTypeCB = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ClearConsoleBT = new System.Windows.Forms.ToolStripButton();
            this.SerchTextTB = new System.Windows.Forms.ToolStripTextBox();
            this.SearchTextBT = new System.Windows.Forms.ToolStripButton();
            this.HorizontalSC = new System.Windows.Forms.SplitContainer();
            this.RomFolderBT = new System.Windows.Forms.Button();
            this.RomFolderTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DevPwTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DevSoftwareTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DevIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveSettingsBT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateLB = new stigzler.Winforms.Base.UIElements.Label();
            this.MainOpTitleLB = new stigzler.Winforms.Base.UIElements.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSC)).BeginInit();
            this.VerticalSC.Panel1.SuspendLayout();
            this.VerticalSC.Panel2.SuspendLayout();
            this.VerticalSC.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSC)).BeginInit();
            this.HorizontalSC.Panel1.SuspendLayout();
            this.HorizontalSC.Panel2.SuspendLayout();
            this.HorizontalSC.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainRTB
            // 
            this.MainRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MainRTB.Location = new System.Drawing.Point(0, 25);
            this.MainRTB.Name = "MainRTB";
            this.MainRTB.Size = new System.Drawing.Size(536, 363);
            this.MainRTB.TabIndex = 1;
            this.MainRTB.Text = "";
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
            this.VerticalSC.Panel1.Controls.Add(this.panel1);
            this.VerticalSC.Panel1.Controls.Add(this.label10);
            this.VerticalSC.Panel1.Controls.Add(this.label9);
            this.VerticalSC.Panel1.Controls.Add(this.UserThreadsTB);
            this.VerticalSC.Panel1.Controls.Add(this.SystemIdTB);
            this.VerticalSC.Panel1.Controls.Add(this.label6);
            this.VerticalSC.Panel1.Controls.Add(this.outputFormatCB);
            this.VerticalSC.Panel1.Controls.Add(this.GoBT);
            this.VerticalSC.Panel1.Controls.Add(this.QueryTypeCB);
            this.VerticalSC.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            // 
            // VerticalSC.Panel2
            // 
            this.VerticalSC.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.VerticalSC.Panel2.Controls.Add(this.MainRTB);
            this.VerticalSC.Panel2.Controls.Add(this.toolStrip1);
            this.VerticalSC.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.VerticalSC.Size = new System.Drawing.Size(812, 390);
            this.VerticalSC.SplitterDistance = 270;
            this.VerticalSC.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "System ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "User Threads:";
            // 
            // UserThreadsTB
            // 
            this.UserThreadsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserThreadsTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.UserThreadsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserThreadsTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.UserThreadsTB.Location = new System.Drawing.Point(90, 77);
            this.UserThreadsTB.Name = "UserThreadsTB";
            this.UserThreadsTB.Size = new System.Drawing.Size(161, 20);
            this.UserThreadsTB.TabIndex = 7;
            this.UserThreadsTB.Text = "7";
            // 
            // SystemIdTB
            // 
            this.SystemIdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SystemIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SystemIdTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.SystemIdTB.Location = new System.Drawing.Point(90, 103);
            this.SystemIdTB.Name = "SystemIdTB";
            this.SystemIdTB.Size = new System.Drawing.Size(161, 20);
            this.SystemIdTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Output:";
            // 
            // UpdatePB
            // 
            this.UpdatePB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdatePB.Location = new System.Drawing.Point(7, 26);
            this.UpdatePB.MarqueeAnimationSpeed = 10;
            this.UpdatePB.Name = "UpdatePB";
            this.UpdatePB.Size = new System.Drawing.Size(241, 11);
            this.UpdatePB.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.UpdatePB.TabIndex = 1;
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
            this.outputFormatCB.Location = new System.Drawing.Point(55, 47);
            this.outputFormatCB.Name = "outputFormatCB";
            this.outputFormatCB.Size = new System.Drawing.Size(128, 21);
            this.outputFormatCB.TabIndex = 5;
            this.outputFormatCB.SelectedIndexChanged += new System.EventHandler(this.outputFormatCB_SelectedIndexChanged);
            // 
            // GoBT
            // 
            this.GoBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.GoBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.GoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.GoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.GoBT.Location = new System.Drawing.Point(189, 46);
            this.GoBT.Name = "GoBT";
            this.GoBT.Size = new System.Drawing.Size(75, 23);
            this.GoBT.TabIndex = 4;
            this.GoBT.Text = "Go";
            this.GoBT.UseVisualStyleBackColor = true;
            this.GoBT.Click += new System.EventHandler(this.GoBT_Click);
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
            this.QueryTypeCB.Location = new System.Drawing.Point(3, 4);
            this.QueryTypeCB.Name = "QueryTypeCB";
            this.QueryTypeCB.Size = new System.Drawing.Size(262, 24);
            this.QueryTypeCB.TabIndex = 3;
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(536, 25);
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
            // HorizontalSC
            // 
            this.HorizontalSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HorizontalSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorizontalSC.Location = new System.Drawing.Point(0, 0);
            this.HorizontalSC.Name = "HorizontalSC";
            this.HorizontalSC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HorizontalSC.Panel1
            // 
            this.HorizontalSC.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.HorizontalSC.Panel1.Controls.Add(this.VerticalSC);
            this.HorizontalSC.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            // 
            // HorizontalSC.Panel2
            // 
            this.HorizontalSC.Panel2.AutoScroll = true;
            this.HorizontalSC.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.HorizontalSC.Panel2.Controls.Add(this.RomFolderBT);
            this.HorizontalSC.Panel2.Controls.Add(this.RomFolderTB);
            this.HorizontalSC.Panel2.Controls.Add(this.label8);
            this.HorizontalSC.Panel2.Controls.Add(this.DevPwTB);
            this.HorizontalSC.Panel2.Controls.Add(this.label5);
            this.HorizontalSC.Panel2.Controls.Add(this.DevSoftwareTB);
            this.HorizontalSC.Panel2.Controls.Add(this.label4);
            this.HorizontalSC.Panel2.Controls.Add(this.UsernameTB);
            this.HorizontalSC.Panel2.Controls.Add(this.label3);
            this.HorizontalSC.Panel2.Controls.Add(this.PasswordTB);
            this.HorizontalSC.Panel2.Controls.Add(this.label2);
            this.HorizontalSC.Panel2.Controls.Add(this.DevIdTB);
            this.HorizontalSC.Panel2.Controls.Add(this.label1);
            this.HorizontalSC.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.HorizontalSC.Size = new System.Drawing.Size(812, 732);
            this.HorizontalSC.SplitterDistance = 390;
            this.HorizontalSC.TabIndex = 4;
            // 
            // RomFolderBT
            // 
            this.RomFolderBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RomFolderBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RomFolderBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.RomFolderBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.RomFolderBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RomFolderBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.RomFolderBT.Image = global::stigzler.ScreenScraper.Test.Properties.Resources.folder_horizontal_open;
            this.RomFolderBT.Location = new System.Drawing.Point(732, 141);
            this.RomFolderBT.Name = "RomFolderBT";
            this.RomFolderBT.Size = new System.Drawing.Size(36, 23);
            this.RomFolderBT.TabIndex = 14;
            this.RomFolderBT.UseVisualStyleBackColor = true;
            // 
            // RomFolderTB
            // 
            this.RomFolderTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RomFolderTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RomFolderTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomFolderTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RomFolderTB.Location = new System.Drawing.Point(118, 143);
            this.RomFolderTB.Name = "RomFolderTB";
            this.RomFolderTB.Size = new System.Drawing.Size(608, 20);
            this.RomFolderTB.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "RomFolder";
            // 
            // DevPwTB
            // 
            this.DevPwTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevPwTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DevPwTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DevPwTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DevPwTB.Location = new System.Drawing.Point(118, 39);
            this.DevPwTB.Name = "DevPwTB";
            this.DevPwTB.Size = new System.Drawing.Size(650, 20);
            this.DevPwTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dev Password";
            // 
            // DevSoftwareTB
            // 
            this.DevSoftwareTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevSoftwareTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DevSoftwareTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DevSoftwareTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DevSoftwareTB.Location = new System.Drawing.Point(118, 65);
            this.DevSoftwareTB.Name = "DevSoftwareTB";
            this.DevSoftwareTB.Size = new System.Drawing.Size(650, 20);
            this.DevSoftwareTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dev Software";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.UsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.UsernameTB.Location = new System.Drawing.Point(118, 91);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(650, 20);
            this.UsernameTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.PasswordTB.Location = new System.Drawing.Point(117, 117);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(650, 20);
            this.PasswordTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // DevIdTB
            // 
            this.DevIdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DevIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DevIdTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DevIdTB.Location = new System.Drawing.Point(117, 13);
            this.DevIdTB.Name = "DevIdTB";
            this.DevIdTB.Size = new System.Drawing.Size(650, 20);
            this.DevIdTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DevID";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel1.Controls.Add(this.SaveSettingsBT);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 732);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(812, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // SaveSettingsBT
            // 
            this.SaveSettingsBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveSettingsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.SaveSettingsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.SaveSettingsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SaveSettingsBT.Location = new System.Drawing.Point(714, 3);
            this.SaveSettingsBT.Name = "SaveSettingsBT";
            this.SaveSettingsBT.Size = new System.Drawing.Size(95, 23);
            this.SaveSettingsBT.TabIndex = 0;
            this.SaveSettingsBT.Text = "Save Settings";
            this.SaveSettingsBT.UseVisualStyleBackColor = true;
            this.SaveSettingsBT.Click += new System.EventHandler(this.SaveSettingsBT_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MainOpTitleLB);
            this.panel1.Controls.Add(this.UpdateLB);
            this.panel1.Controls.Add(this.UpdatePB);
            this.panel1.Location = new System.Drawing.Point(7, 315);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(257, 65);
            this.panel1.TabIndex = 12;
            // 
            // UpdateLB
            // 
            this.UpdateLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateLB.AutoEllipsis = true;
            this.UpdateLB.FontStyle = System.Drawing.FontStyle.Regular;
            this.UpdateLB.Location = new System.Drawing.Point(7, 40);
            this.UpdateLB.Name = "UpdateLB";
            this.UpdateLB.ScaleFont = 100;
            this.UpdateLB.Size = new System.Drawing.Size(241, 23);
            this.UpdateLB.TabIndex = 0;
            this.UpdateLB.Text = "label7";
            this.UpdateLB.ToolTip = null;
            this.UpdateLB.ToolTipHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.UpdateLB.ToolTipImage = null;
            this.UpdateLB.ToolTipText = null;
            this.UpdateLB.ToolTipTitle = null;
            // 
            // MainOpTitleLB
            // 
            this.MainOpTitleLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainOpTitleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainOpTitleLB.FontStyle = System.Drawing.FontStyle.Bold;
            this.MainOpTitleLB.Location = new System.Drawing.Point(4, 4);
            this.MainOpTitleLB.Name = "MainOpTitleLB";
            this.MainOpTitleLB.ScaleFont = 100;
            this.MainOpTitleLB.Size = new System.Drawing.Size(244, 19);
            this.MainOpTitleLB.TabIndex = 2;
            this.MainOpTitleLB.Text = "label7";
            this.MainOpTitleLB.ToolTip = null;
            this.MainOpTitleLB.ToolTipHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.MainOpTitleLB.ToolTipImage = null;
            this.MainOpTitleLB.ToolTipText = null;
            this.MainOpTitleLB.ToolTipTitle = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 761);
            this.Controls.Add(this.HorizontalSC);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DarkMode = true;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.VerticalSC.Panel1.ResumeLayout(false);
            this.VerticalSC.Panel1.PerformLayout();
            this.VerticalSC.Panel2.ResumeLayout(false);
            this.VerticalSC.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSC)).EndInit();
            this.VerticalSC.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.HorizontalSC.Panel1.ResumeLayout(false);
            this.HorizontalSC.Panel2.ResumeLayout(false);
            this.HorizontalSC.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSC)).EndInit();
            this.HorizontalSC.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox MainRTB;
        private System.Windows.Forms.SplitContainer VerticalSC;
        private System.Windows.Forms.SplitContainer HorizontalSC;
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
        private System.Windows.Forms.Button RomFolderBT;
        private System.Windows.Forms.TextBox RomFolderTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SystemIdTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UserThreadsTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripTextBox SerchTextTB;
        private System.Windows.Forms.ToolStripButton SearchTextBT;
        private System.Windows.Forms.Panel panel1;
        private Winforms.Base.UIElements.Label MainOpTitleLB;
        private Winforms.Base.UIElements.Label UpdateLB;
    }
}

