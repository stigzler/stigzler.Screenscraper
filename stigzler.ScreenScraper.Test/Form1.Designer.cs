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
            this.Button1 = new System.Windows.Forms.Button();
            this.MainRTB = new System.Windows.Forms.RichTextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.VerticalSC = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.MainPB = new System.Windows.Forms.ProgressBar();
            this.outputFormatCB = new System.Windows.Forms.ComboBox();
            this.GoBT = new System.Windows.Forms.Button();
            this.QueryTypeCB = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.HorizontalSC = new System.Windows.Forms.SplitContainer();
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
            this.SystemIdTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RomFolderTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ClearConsoleBT = new System.Windows.Forms.ToolStripButton();
            this.RomFolderBT = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(11, 147);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Test Single";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // MainRTB
            // 
            this.MainRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainRTB.Location = new System.Drawing.Point(0, 25);
            this.MainRTB.Name = "MainRTB";
            this.MainRTB.Size = new System.Drawing.Size(536, 363);
            this.MainRTB.TabIndex = 1;
            this.MainRTB.Text = "";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(11, 118);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Test Batch";
            this.Button2.UseVisualStyleBackColor = true;
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
            this.VerticalSC.Panel1.Controls.Add(this.label6);
            this.VerticalSC.Panel1.Controls.Add(this.MainPB);
            this.VerticalSC.Panel1.Controls.Add(this.outputFormatCB);
            this.VerticalSC.Panel1.Controls.Add(this.GoBT);
            this.VerticalSC.Panel1.Controls.Add(this.QueryTypeCB);
            this.VerticalSC.Panel1.Controls.Add(this.Button1);
            this.VerticalSC.Panel1.Controls.Add(this.Button2);
            // 
            // VerticalSC.Panel2
            // 
            this.VerticalSC.Panel2.Controls.Add(this.MainRTB);
            this.VerticalSC.Panel2.Controls.Add(this.toolStrip1);
            this.VerticalSC.Size = new System.Drawing.Size(812, 390);
            this.VerticalSC.SplitterDistance = 270;
            this.VerticalSC.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Output:";
            // 
            // MainPB
            // 
            this.MainPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPB.Location = new System.Drawing.Point(3, 372);
            this.MainPB.MarqueeAnimationSpeed = 10;
            this.MainPB.Name = "MainPB";
            this.MainPB.Size = new System.Drawing.Size(262, 13);
            this.MainPB.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.MainPB.TabIndex = 1;
            // 
            // outputFormatCB
            // 
            this.outputFormatCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFormatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputFormatCB.FormattingEnabled = true;
            this.outputFormatCB.Items.AddRange(new object[] {
            "Server Details"});
            this.outputFormatCB.Location = new System.Drawing.Point(56, 32);
            this.outputFormatCB.Name = "outputFormatCB";
            this.outputFormatCB.Size = new System.Drawing.Size(128, 21);
            this.outputFormatCB.TabIndex = 5;
            this.outputFormatCB.SelectedIndexChanged += new System.EventHandler(this.outputFormatCB_SelectedIndexChanged);
            // 
            // GoBT
            // 
            this.GoBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBT.Location = new System.Drawing.Point(190, 31);
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
            this.QueryTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QueryTypeCB.FormattingEnabled = true;
            this.QueryTypeCB.Items.AddRange(new object[] {
            "Server Details"});
            this.QueryTypeCB.Location = new System.Drawing.Point(3, 4);
            this.QueryTypeCB.Name = "QueryTypeCB";
            this.QueryTypeCB.Size = new System.Drawing.Size(262, 21);
            this.QueryTypeCB.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearConsoleBT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(536, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            this.HorizontalSC.Panel1.Controls.Add(this.VerticalSC);
            // 
            // HorizontalSC.Panel2
            // 
            this.HorizontalSC.Panel2.AutoScroll = true;
            this.HorizontalSC.Panel2.Controls.Add(this.RomFolderBT);
            this.HorizontalSC.Panel2.Controls.Add(this.RomFolderTB);
            this.HorizontalSC.Panel2.Controls.Add(this.label8);
            this.HorizontalSC.Panel2.Controls.Add(this.SystemIdTB);
            this.HorizontalSC.Panel2.Controls.Add(this.label7);
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
            this.HorizontalSC.Size = new System.Drawing.Size(812, 732);
            this.HorizontalSC.SplitterDistance = 390;
            this.HorizontalSC.TabIndex = 4;
            // 
            // DevPwTB
            // 
            this.DevPwTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.flowLayoutPanel1.Controls.Add(this.SaveSettingsBT);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 732);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(812, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // SaveSettingsBT
            // 
            this.SaveSettingsBT.Location = new System.Drawing.Point(714, 3);
            this.SaveSettingsBT.Name = "SaveSettingsBT";
            this.SaveSettingsBT.Size = new System.Drawing.Size(95, 23);
            this.SaveSettingsBT.TabIndex = 0;
            this.SaveSettingsBT.Text = "Save Settings";
            this.SaveSettingsBT.UseVisualStyleBackColor = true;
            this.SaveSettingsBT.Click += new System.EventHandler(this.SaveSettingsBT_Click);
            // 
            // SystemIdTB
            // 
            this.SystemIdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemIdTB.Location = new System.Drawing.Point(118, 143);
            this.SystemIdTB.Name = "SystemIdTB";
            this.SystemIdTB.Size = new System.Drawing.Size(650, 20);
            this.SystemIdTB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "SystemID";
            // 
            // RomFolderTB
            // 
            this.RomFolderTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RomFolderTB.Location = new System.Drawing.Point(117, 169);
            this.RomFolderTB.Name = "RomFolderTB";
            this.RomFolderTB.Size = new System.Drawing.Size(608, 20);
            this.RomFolderTB.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "RomFolder";
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
            // RomFolderBT
            // 
            this.RomFolderBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RomFolderBT.Image = global::stigzler.ScreenScraper.Test.Properties.Resources.folder_horizontal_open;
            this.RomFolderBT.Location = new System.Drawing.Point(731, 167);
            this.RomFolderBT.Name = "RomFolderBT";
            this.RomFolderBT.Size = new System.Drawing.Size(36, 23);
            this.RomFolderBT.TabIndex = 14;
            this.RomFolderBT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 761);
            this.Controls.Add(this.HorizontalSC);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.RichTextBox MainRTB;
        private System.Windows.Forms.Button Button2;
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
        private System.Windows.Forms.ProgressBar MainPB;
        private System.Windows.Forms.Button RomFolderBT;
        private System.Windows.Forms.TextBox RomFolderTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SystemIdTB;
        private System.Windows.Forms.Label label7;
    }
}

