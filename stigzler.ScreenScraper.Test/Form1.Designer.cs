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
            this.SystemsCB = new stigzler.Winforms.Base.UIElements.ComboBox();
            this.RefreshSystemsBT = new System.Windows.Forms.Button();
            this.UserThreadsNUM = new System.Windows.Forms.NumericUpDown();
            this.CancelBT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateRateLB = new stigzler.Winforms.Base.UIElements.Label();
            this.UpdateLB = new stigzler.Winforms.Base.UIElements.Label();
            this.UpdatePB = new System.Windows.Forms.ProgressBar();
            this.MainOpTitleLB = new stigzler.Winforms.Base.UIElements.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outputFormatCB = new System.Windows.Forms.ComboBox();
            this.GoBT = new System.Windows.Forms.Button();
            this.QueryTypeCB = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new stigzler.Winforms.Base.UIElements.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ClearConsoleBT = new System.Windows.Forms.ToolStripButton();
            this.SerchTextTB = new System.Windows.Forms.ToolStripTextBox();
            this.SearchTextBT = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ResultsDGV = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSC)).BeginInit();
            this.VerticalSC.Panel1.SuspendLayout();
            this.VerticalSC.Panel2.SuspendLayout();
            this.VerticalSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserThreadsNUM)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSC)).BeginInit();
            this.HorizontalSC.Panel1.SuspendLayout();
            this.HorizontalSC.Panel2.SuspendLayout();
            this.HorizontalSC.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainRTB
            // 
            this.MainRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MainRTB.Location = new System.Drawing.Point(3, 28);
            this.MainRTB.Name = "MainRTB";
            this.MainRTB.Size = new System.Drawing.Size(552, 281);
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
            this.VerticalSC.Panel1.Controls.Add(this.SystemsCB);
            this.VerticalSC.Panel1.Controls.Add(this.RefreshSystemsBT);
            this.VerticalSC.Panel1.Controls.Add(this.UserThreadsNUM);
            this.VerticalSC.Panel1.Controls.Add(this.CancelBT);
            this.VerticalSC.Panel1.Controls.Add(this.panel1);
            this.VerticalSC.Panel1.Controls.Add(this.label10);
            this.VerticalSC.Panel1.Controls.Add(this.label9);
            this.VerticalSC.Panel1.Controls.Add(this.label6);
            this.VerticalSC.Panel1.Controls.Add(this.outputFormatCB);
            this.VerticalSC.Panel1.Controls.Add(this.GoBT);
            this.VerticalSC.Panel1.Controls.Add(this.QueryTypeCB);
            this.VerticalSC.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.VerticalSC.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // VerticalSC.Panel2
            // 
            this.VerticalSC.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.VerticalSC.Panel2.Controls.Add(this.tabControl1);
            this.VerticalSC.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.VerticalSC.Size = new System.Drawing.Size(856, 340);
            this.VerticalSC.SplitterDistance = 284;
            this.VerticalSC.TabIndex = 3;
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
            this.SystemsCB.Location = new System.Drawing.Point(94, 101);
            this.SystemsCB.Name = "SystemsCB";
            this.SystemsCB.RedrawOnResize = true;
            this.SystemsCB.Size = new System.Drawing.Size(181, 21);
            this.SystemsCB.TabIndex = 17;
            // 
            // RefreshSystemsBT
            // 
            this.RefreshSystemsBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshSystemsBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RefreshSystemsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.RefreshSystemsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.RefreshSystemsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshSystemsBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.RefreshSystemsBT.Location = new System.Drawing.Point(7, 200);
            this.RefreshSystemsBT.Name = "RefreshSystemsBT";
            this.RefreshSystemsBT.Size = new System.Drawing.Size(106, 23);
            this.RefreshSystemsBT.TabIndex = 16;
            this.RefreshSystemsBT.Text = "Refresh Systems";
            this.RefreshSystemsBT.UseVisualStyleBackColor = true;
            this.RefreshSystemsBT.Click += new System.EventHandler(this.RefreshSystemsBT_Click);
            // 
            // UserThreadsNUM
            // 
            this.UserThreadsNUM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserThreadsNUM.Location = new System.Drawing.Point(94, 75);
            this.UserThreadsNUM.Name = "UserThreadsNUM";
            this.UserThreadsNUM.Size = new System.Drawing.Size(181, 20);
            this.UserThreadsNUM.TabIndex = 15;
            // 
            // CancelBT
            // 
            this.CancelBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.CancelBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.CancelBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CancelBT.Location = new System.Drawing.Point(119, 200);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 14;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UpdateRateLB);
            this.panel1.Controls.Add(this.UpdateLB);
            this.panel1.Controls.Add(this.UpdatePB);
            this.panel1.Controls.Add(this.MainOpTitleLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.panel1.Location = new System.Drawing.Point(4, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 105);
            this.panel1.TabIndex = 13;
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
            this.UpdateRateLB.Size = new System.Drawing.Size(240, 21);
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
            this.UpdateLB.Size = new System.Drawing.Size(246, 23);
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
            this.UpdatePB.Size = new System.Drawing.Size(249, 10);
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
            this.MainOpTitleLB.Size = new System.Drawing.Size(252, 21);
            this.MainOpTitleLB.TabIndex = 2;
            this.MainOpTitleLB.Text = "Operation";
            this.MainOpTitleLB.ToolTip = null;
            this.MainOpTitleLB.ToolTipHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.MainOpTitleLB.ToolTipImage = null;
            this.MainOpTitleLB.ToolTipText = null;
            this.MainOpTitleLB.ToolTipTitle = null;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "System ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "User Threads:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Output:";
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
            this.outputFormatCB.Location = new System.Drawing.Point(94, 48);
            this.outputFormatCB.Name = "outputFormatCB";
            this.outputFormatCB.Size = new System.Drawing.Size(181, 21);
            this.outputFormatCB.TabIndex = 5;
            this.outputFormatCB.SelectedIndexChanged += new System.EventHandler(this.outputFormatCB_SelectedIndexChanged);
            // 
            // GoBT
            // 
            this.GoBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.GoBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.GoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.GoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.GoBT.Location = new System.Drawing.Point(200, 200);
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
            this.QueryTypeCB.Location = new System.Drawing.Point(7, 8);
            this.QueryTypeCB.Name = "QueryTypeCB";
            this.QueryTypeCB.Size = new System.Drawing.Size(268, 24);
            this.QueryTypeCB.TabIndex = 3;
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
            this.tabControl1.Size = new System.Drawing.Size(566, 338);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.TabOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.tabControl1.UnselectedTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage1.Controls.Add(this.MainRTB);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Console";
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
            this.toolStrip1.Size = new System.Drawing.Size(552, 25);
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
            this.tabPage2.Size = new System.Drawing.Size(558, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            // 
            // ResultsDGV
            // 
            this.ResultsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsDGV.Location = new System.Drawing.Point(3, 3);
            this.ResultsDGV.Name = "ResultsDGV";
            this.ResultsDGV.Size = new System.Drawing.Size(552, 306);
            this.ResultsDGV.TabIndex = 0;
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
            this.HorizontalSC.Size = new System.Drawing.Size(856, 639);
            this.HorizontalSC.SplitterDistance = 340;
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
            this.RomFolderBT.Location = new System.Drawing.Point(776, 141);
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
            this.RomFolderTB.Size = new System.Drawing.Size(652, 20);
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
            this.DevPwTB.Size = new System.Drawing.Size(694, 20);
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
            this.DevSoftwareTB.Size = new System.Drawing.Size(694, 20);
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
            this.UsernameTB.Size = new System.Drawing.Size(694, 20);
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
            this.PasswordTB.Size = new System.Drawing.Size(694, 20);
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
            this.DevIdTB.Size = new System.Drawing.Size(694, 20);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 639);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(856, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // SaveSettingsBT
            // 
            this.SaveSettingsBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveSettingsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.SaveSettingsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.SaveSettingsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SaveSettingsBT.Location = new System.Drawing.Point(758, 3);
            this.SaveSettingsBT.Name = "SaveSettingsBT";
            this.SaveSettingsBT.Size = new System.Drawing.Size(95, 23);
            this.SaveSettingsBT.TabIndex = 0;
            this.SaveSettingsBT.Text = "Save Settings";
            this.SaveSettingsBT.UseVisualStyleBackColor = true;
            this.SaveSettingsBT.Click += new System.EventHandler(this.SaveSettingsBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 668);
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
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSC)).EndInit();
            this.VerticalSC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserThreadsNUM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDGV)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripTextBox SerchTextTB;
        private System.Windows.Forms.ToolStripButton SearchTextBT;
        private Winforms.Base.UIElements.Label MainOpTitleLB;
        private Winforms.Base.UIElements.Label UpdateLB;
        private Winforms.Base.UIElements.Label UpdateRateLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.NumericUpDown UserThreadsNUM;
        private System.Windows.Forms.Button RefreshSystemsBT;
        private Winforms.Base.UIElements.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ResultsDGV;
        private Winforms.Base.UIElements.ComboBox SystemsCB;
    }
}

