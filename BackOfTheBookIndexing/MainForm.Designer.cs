using System.Drawing;

namespace BackOfTheBookIndexing
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.HomeTabPage = new System.Windows.Forms.TabPage();
            this.myProgressBar = new System.Windows.Forms.ProgressBar();
            this.FileInfoLabel = new System.Windows.Forms.Label();
            this.BrowseBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.MachineGenerateBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DocumentSlctTxtBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DomainTabPage = new System.Windows.Forms.TabPage();
            this.myProgressBarDomain = new System.Windows.Forms.ProgressBar();
            this.FileInfoLabelDomain = new System.Windows.Forms.Label();
            this.SelectDropdown = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.GenerateIndexBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DomainFileSelectBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DomainFileSelectTxtbox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.FileBrowseForDomainBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.FileBrowseDomainTxtbox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.kryptonGroupBox2 = new AC.ExtendedRenderer.Toolkit.KryptonGroupBox();
            this.office10BlueChbox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.sparkleBlueChbox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.office07SilverChbox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.office10BlackChbox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.office10SilverChbox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.office07BlackChbox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.HelpTabPage = new System.Windows.Forms.TabPage();
            this.kryptonWrapLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.AboutTabPage = new System.Windows.Forms.TabPage();
            this.myLinkLabel = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.myKryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.MainTabControl.SuspendLayout();
            this.HomeTabPage.SuspendLayout();
            this.DomainTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDropdown)).BeginInit();
            this.SettingsTabPage.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.HelpTabPage.SuspendLayout();
            this.AboutTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.AllowCloseButton = false;
            this.MainTabControl.AllowContextButton = true;
            this.MainTabControl.AllowNavigatorButtons = false;
            this.MainTabControl.AllowSelectedTabHigh = false;
            this.MainTabControl.BorderWidth = 1;
            this.MainTabControl.Controls.Add(this.HomeTabPage);
            this.MainTabControl.Controls.Add(this.DomainTabPage);
            this.MainTabControl.Controls.Add(this.SettingsTabPage);
            this.MainTabControl.Controls.Add(this.HelpTabPage);
            this.MainTabControl.Controls.Add(this.AboutTabPage);
            this.MainTabControl.CornerRoundRadiusWidth = 15;
            this.MainTabControl.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.MainTabControl.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.MainTabControl.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Null;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainTabControl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.HotTrack = true;
            this.MainTabControl.ItemSize = new System.Drawing.Size(73, 40);
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.PreserveTabColor = false;
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(794, 469);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.UseExtendedLayout = false;
            // 
            // HomeTabPage
            // 
            this.HomeTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.HomeTabPage.Controls.Add(this.myProgressBar);
            this.HomeTabPage.Controls.Add(this.FileInfoLabel);
            this.HomeTabPage.Controls.Add(this.BrowseBtn);
            this.HomeTabPage.Controls.Add(this.MachineGenerateBtn);
            this.HomeTabPage.Controls.Add(this.DocumentSlctTxtBox);
            this.HomeTabPage.ForeColor = System.Drawing.SystemColors.Control;
            this.HomeTabPage.Location = new System.Drawing.Point(4, 44);
            this.HomeTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.HomeTabPage.Name = "HomeTabPage";
            this.HomeTabPage.Size = new System.Drawing.Size(786, 421);
            this.HomeTabPage.TabIndex = 0;
            this.HomeTabPage.Tag = false;
            this.HomeTabPage.Text = "Home";
            // 
            // myProgressBar
            // 
            this.myProgressBar.Location = new System.Drawing.Point(8, 392);
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.Size = new System.Drawing.Size(769, 21);
            this.myProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.myProgressBar.TabIndex = 5;
            this.myProgressBar.Visible = false;
            // 
            // FileInfoLabel
            // 
            this.FileInfoLabel.AutoSize = true;
            this.FileInfoLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileInfoLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.FileInfoLabel.Location = new System.Drawing.Point(249, 212);
            this.FileInfoLabel.Name = "FileInfoLabel";
            this.FileInfoLabel.Size = new System.Drawing.Size(0, 19);
            this.FileInfoLabel.TabIndex = 4;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(725, 17);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(52, 46);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Values.Text = ".........";
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // MachineGenerateBtn
            // 
            this.MachineGenerateBtn.Location = new System.Drawing.Point(284, 113);
            this.MachineGenerateBtn.Name = "MachineGenerateBtn";
            this.MachineGenerateBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.MachineGenerateBtn.Size = new System.Drawing.Size(160, 56);
            this.MachineGenerateBtn.TabIndex = 1;
            this.MachineGenerateBtn.Values.Text = "Machine Generate Index";
            this.MachineGenerateBtn.Click += new System.EventHandler(this.MachineGenerateBtn_Click);
            // 
            // DocumentSlctTxtBox
            // 
            this.DocumentSlctTxtBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocumentSlctTxtBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DocumentSlctTxtBox.Location = new System.Drawing.Point(8, 30);
            this.DocumentSlctTxtBox.Name = "DocumentSlctTxtBox";
            this.DocumentSlctTxtBox.ReadOnly = true;
            this.DocumentSlctTxtBox.Size = new System.Drawing.Size(711, 20);
            this.DocumentSlctTxtBox.TabIndex = 0;
            this.DocumentSlctTxtBox.TextChanged += new System.EventHandler(this.DocumentSlctTxtBox_TextChanged);
            // 
            // DomainTabPage
            // 
            this.DomainTabPage.Controls.Add(this.myProgressBarDomain);
            this.DomainTabPage.Controls.Add(this.FileInfoLabelDomain);
            this.DomainTabPage.Controls.Add(this.SelectDropdown);
            this.DomainTabPage.Controls.Add(this.GenerateIndexBtn);
            this.DomainTabPage.Controls.Add(this.DomainFileSelectBtn);
            this.DomainTabPage.Controls.Add(this.DomainFileSelectTxtbox);
            this.DomainTabPage.Controls.Add(this.kryptonLabel1);
            this.DomainTabPage.Controls.Add(this.FileBrowseForDomainBtn);
            this.DomainTabPage.Controls.Add(this.FileBrowseDomainTxtbox);
            this.DomainTabPage.Location = new System.Drawing.Point(4, 44);
            this.DomainTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.DomainTabPage.Name = "DomainTabPage";
            this.DomainTabPage.Size = new System.Drawing.Size(786, 421);
            this.DomainTabPage.TabIndex = 4;
            this.DomainTabPage.Tag = false;
            this.DomainTabPage.Text = "Domain";
            // 
            // myProgressBarDomain
            // 
            this.myProgressBarDomain.Location = new System.Drawing.Point(9, 392);
            this.myProgressBarDomain.Name = "myProgressBarDomain";
            this.myProgressBarDomain.Size = new System.Drawing.Size(769, 21);
            this.myProgressBarDomain.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.myProgressBarDomain.TabIndex = 13;
            this.myProgressBarDomain.Visible = false;
            // 
            // FileInfoLabelDomain
            // 
            this.FileInfoLabelDomain.AutoSize = true;
            this.FileInfoLabelDomain.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileInfoLabelDomain.ForeColor = System.Drawing.Color.DarkGreen;
            this.FileInfoLabelDomain.Location = new System.Drawing.Point(153, 216);
            this.FileInfoLabelDomain.Name = "FileInfoLabelDomain";
            this.FileInfoLabelDomain.Size = new System.Drawing.Size(0, 19);
            this.FileInfoLabelDomain.TabIndex = 12;
            // 
            // SelectDropdown
            // 
            this.SelectDropdown.DropDownWidth = 145;
            this.SelectDropdown.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.SelectDropdown.Items.AddRange(new object[] {
            "Geography",
            "Machine Learning",
            "Economics",
            "Management",
            "Psychology",
            "Football",
            "Custom"});
            this.SelectDropdown.Location = new System.Drawing.Point(8, 101);
            this.SelectDropdown.Name = "SelectDropdown";
            this.SelectDropdown.Size = new System.Drawing.Size(145, 21);
            this.SelectDropdown.TabIndex = 10;
            this.SelectDropdown.Text = "Select";
            this.SelectDropdown.SelectedIndexChanged += new System.EventHandler(this.SelectDropdown_SelectedIndexChanged);
            // 
            // GenerateIndexBtn
            // 
            this.GenerateIndexBtn.Location = new System.Drawing.Point(673, 256);
            this.GenerateIndexBtn.Name = "GenerateIndexBtn";
            this.GenerateIndexBtn.Size = new System.Drawing.Size(100, 43);
            this.GenerateIndexBtn.TabIndex = 9;
            this.GenerateIndexBtn.Values.Text = "Generate";
            this.GenerateIndexBtn.Click += new System.EventHandler(this.GenerateIndexBtn_Click);
            // 
            // DomainFileSelectBtn
            // 
            this.DomainFileSelectBtn.Location = new System.Drawing.Point(721, 148);
            this.DomainFileSelectBtn.Name = "DomainFileSelectBtn";
            this.DomainFileSelectBtn.Size = new System.Drawing.Size(52, 46);
            this.DomainFileSelectBtn.TabIndex = 8;
            this.DomainFileSelectBtn.Values.Text = ".........";
            this.DomainFileSelectBtn.Visible = false;
            this.DomainFileSelectBtn.Click += new System.EventHandler(this.DomainFileSelectBtn_Click);
            // 
            // DomainFileSelectTxtbox
            // 
            this.DomainFileSelectTxtbox.Location = new System.Drawing.Point(3, 162);
            this.DomainFileSelectTxtbox.Name = "DomainFileSelectTxtbox";
            this.DomainFileSelectTxtbox.ReadOnly = true;
            this.DomainFileSelectTxtbox.Size = new System.Drawing.Size(712, 20);
            this.DomainFileSelectTxtbox.TabIndex = 7;
            this.DomainFileSelectTxtbox.Visible = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(8, 75);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Domain";
            // 
            // FileBrowseForDomainBtn
            // 
            this.FileBrowseForDomainBtn.Location = new System.Drawing.Point(726, 17);
            this.FileBrowseForDomainBtn.Name = "FileBrowseForDomainBtn";
            this.FileBrowseForDomainBtn.Size = new System.Drawing.Size(52, 46);
            this.FileBrowseForDomainBtn.TabIndex = 4;
            this.FileBrowseForDomainBtn.Values.Text = ".........";
            this.FileBrowseForDomainBtn.Click += new System.EventHandler(this.FileBrowseForDomainBtn_Click);
            // 
            // FileBrowseDomainTxtbox
            // 
            this.FileBrowseDomainTxtbox.Location = new System.Drawing.Point(8, 31);
            this.FileBrowseDomainTxtbox.Name = "FileBrowseDomainTxtbox";
            this.FileBrowseDomainTxtbox.ReadOnly = true;
            this.FileBrowseDomainTxtbox.Size = new System.Drawing.Size(712, 20);
            this.FileBrowseDomainTxtbox.TabIndex = 0;
            this.FileBrowseDomainTxtbox.TextChanged += new System.EventHandler(this.FileBrowseDomainTxtbox_TextChanged);
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsTabPage.Controls.Add(this.kryptonGroupBox2);
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 44);
            this.SettingsTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Size = new System.Drawing.Size(786, 421);
            this.SettingsTabPage.TabIndex = 1;
            this.SettingsTabPage.Tag = false;
            this.SettingsTabPage.Text = "Settings";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.BorderStyle = AC.ExtendedRenderer.Toolkit.KryptonGroupBox.BorderMode.FullCustom;
            this.kryptonGroupBox2.Controls.Add(this.office10BlueChbox);
            this.kryptonGroupBox2.Controls.Add(this.sparkleBlueChbox);
            this.kryptonGroupBox2.Controls.Add(this.office07SilverChbox);
            this.kryptonGroupBox2.Controls.Add(this.office10BlackChbox);
            this.kryptonGroupBox2.Controls.Add(this.office10SilverChbox);
            this.kryptonGroupBox2.Controls.Add(this.office07BlackChbox);
            this.kryptonGroupBox2.DarkerColors = true;
            this.kryptonGroupBox2.DrawBottomLine = false;
            this.kryptonGroupBox2.DrawShadows = false;
            this.kryptonGroupBox2.ForceTransparent = false;
            this.kryptonGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonGroupBox2.Location = new System.Drawing.Point(8, 15);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            this.kryptonGroupBox2.PaintDefault = false;
            this.kryptonGroupBox2.Size = new System.Drawing.Size(332, 272);
            this.kryptonGroupBox2.TabIndex = 7;
            this.kryptonGroupBox2.TabStop = false;
            this.kryptonGroupBox2.Text = "Themes";
            this.kryptonGroupBox2.UseAlternateForeColor = false;
            // 
            // office10BlueChbox
            // 
            this.office10BlueChbox.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.office10BlueChbox.Location = new System.Drawing.Point(6, 46);
            this.office10BlueChbox.Name = "office10BlueChbox";
            this.office10BlueChbox.Size = new System.Drawing.Size(113, 20);
            this.office10BlueChbox.TabIndex = 0;
            this.office10BlueChbox.Text = "Office 2010 Blue";
            this.office10BlueChbox.Values.Text = "Office 2010 Blue";
            this.office10BlueChbox.CheckedChanged += new System.EventHandler(this.office10BlueChbox_CheckedChanged);
            // 
            // sparkleBlueChbox
            // 
            this.sparkleBlueChbox.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.sparkleBlueChbox.Location = new System.Drawing.Point(167, 184);
            this.sparkleBlueChbox.Name = "sparkleBlueChbox";
            this.sparkleBlueChbox.Size = new System.Drawing.Size(90, 20);
            this.sparkleBlueChbox.TabIndex = 6;
            this.sparkleBlueChbox.Text = "Sparkle Blue";
            this.sparkleBlueChbox.Values.Text = "Sparkle Blue";
            this.sparkleBlueChbox.CheckedChanged += new System.EventHandler(this.sparkleBlueChbox_CheckedChanged);
            // 
            // office07SilverChbox
            // 
            this.office07SilverChbox.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.office07SilverChbox.Location = new System.Drawing.Point(167, 46);
            this.office07SilverChbox.Name = "office07SilverChbox";
            this.office07SilverChbox.Size = new System.Drawing.Size(118, 20);
            this.office07SilverChbox.TabIndex = 2;
            this.office07SilverChbox.Text = "Office 2007 Silver";
            this.office07SilverChbox.Values.Text = "Office 2007 Silver";
            this.office07SilverChbox.CheckedChanged += new System.EventHandler(this.office07SilverChbox_CheckedChanged);
            // 
            // office10BlackChbox
            // 
            this.office10BlackChbox.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.office10BlackChbox.Location = new System.Drawing.Point(6, 184);
            this.office10BlackChbox.Name = "office10BlackChbox";
            this.office10BlackChbox.Size = new System.Drawing.Size(117, 20);
            this.office10BlackChbox.TabIndex = 5;
            this.office10BlackChbox.Text = "Office 2010 Black";
            this.office10BlackChbox.Values.Text = "Office 2010 Black";
            this.office10BlackChbox.CheckedChanged += new System.EventHandler(this.office10BlackChbox_CheckedChanged);
            // 
            // office10SilverChbox
            // 
            this.office10SilverChbox.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.office10SilverChbox.Location = new System.Drawing.Point(6, 116);
            this.office10SilverChbox.Name = "office10SilverChbox";
            this.office10SilverChbox.Size = new System.Drawing.Size(118, 20);
            this.office10SilverChbox.TabIndex = 3;
            this.office10SilverChbox.Text = "Office 2010 Silver";
            this.office10SilverChbox.Values.Text = "Office 2010 Silver";
            this.office10SilverChbox.CheckedChanged += new System.EventHandler(this.office10SilverChbox_CheckedChanged);
            // 
            // office07BlackChbox
            // 
            this.office07BlackChbox.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.office07BlackChbox.Location = new System.Drawing.Point(167, 116);
            this.office07BlackChbox.Name = "office07BlackChbox";
            this.office07BlackChbox.Size = new System.Drawing.Size(114, 20);
            this.office07BlackChbox.TabIndex = 4;
            this.office07BlackChbox.Text = "Office2007 Black";
            this.office07BlackChbox.Values.Text = "Office2007 Black";
            this.office07BlackChbox.CheckedChanged += new System.EventHandler(this.office07BlackChbox_CheckedChanged);
            // 
            // HelpTabPage
            // 
            this.HelpTabPage.Controls.Add(this.kryptonWrapLabel2);
            this.HelpTabPage.Controls.Add(this.kryptonLabel6);
            this.HelpTabPage.Controls.Add(this.kryptonLabel2);
            this.HelpTabPage.Controls.Add(this.kryptonWrapLabel1);
            this.HelpTabPage.Location = new System.Drawing.Point(4, 44);
            this.HelpTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.HelpTabPage.Name = "HelpTabPage";
            this.HelpTabPage.Size = new System.Drawing.Size(786, 421);
            this.HelpTabPage.TabIndex = 2;
            this.HelpTabPage.Tag = false;
            this.HelpTabPage.Text = "Help";
            // 
            // kryptonWrapLabel2
            // 
            this.kryptonWrapLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel2.Location = new System.Drawing.Point(9, 262);
            this.kryptonWrapLabel2.Name = "kryptonWrapLabel2";
            this.kryptonWrapLabel2.Size = new System.Drawing.Size(518, 75);
            this.kryptonWrapLabel2.Text = resources.GetString("kryptonWrapLabel2.Text");
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(8, 211);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonLabel6.Size = new System.Drawing.Size(283, 20);
            this.kryptonLabel6.TabIndex = 2;
            this.kryptonLabel6.Values.Text = "How to generate Index using domain Knowledge?";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(8, 34);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonLabel2.Size = new System.Drawing.Size(247, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "How to generate Index in automatic mode?";
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(8, 80);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(468, 90);
            this.kryptonWrapLabel1.Text = resources.GetString("kryptonWrapLabel1.Text");
            // 
            // AboutTabPage
            // 
            this.AboutTabPage.Controls.Add(this.myLinkLabel);
            this.AboutTabPage.Controls.Add(this.kryptonGroupBox1);
            this.AboutTabPage.Controls.Add(this.kryptonLabel5);
            this.AboutTabPage.Controls.Add(this.kryptonLabel4);
            this.AboutTabPage.Controls.Add(this.kryptonHeader1);
            this.AboutTabPage.Location = new System.Drawing.Point(4, 44);
            this.AboutTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.AboutTabPage.Name = "AboutTabPage";
            this.AboutTabPage.Size = new System.Drawing.Size(786, 421);
            this.AboutTabPage.TabIndex = 3;
            this.AboutTabPage.Tag = false;
            this.AboutTabPage.Text = "About";
            // 
            // myLinkLabel
            // 
            this.myLinkLabel.Location = new System.Drawing.Point(131, 174);
            this.myLinkLabel.Name = "myLinkLabel";
            this.myLinkLabel.Size = new System.Drawing.Size(200, 20);
            this.myLinkLabel.TabIndex = 7;
            this.myLinkLabel.Values.Text = "http://backofthebookindexing.com";
            this.myLinkLabel.LinkClicked += new System.EventHandler(this.myLinkLabel_LinkClicked);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlAlternate;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(536, 3);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(236, 191);
            this.kryptonGroupBox1.TabIndex = 6;
            this.kryptonGroupBox1.Text = "Project Members";
            this.kryptonGroupBox1.Values.Heading = "Project Members";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 38);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(201, 77);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "Hem Sharma Acharya\r\n   Bikram Adhikari\r\n       Amir Bhujel";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(228, 318);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonLabel5.Size = new System.Drawing.Size(270, 29);
            this.kryptonLabel5.TabIndex = 5;
            this.kryptonLabel5.Values.Text = "Supervised by: Bidur Devkota";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(8, 384);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonLabel4.Size = new System.Drawing.Size(764, 20);
            this.kryptonLabel4.TabIndex = 4;
            this.kryptonLabel4.Values.Text = "Krypton Toolkit, iTextsharp, Lemmasharp, SharpNLP are the properties of their res" +
    "pective owners/developers and used as permitted by license.";
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Location = new System.Drawing.Point(131, 17);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonHeader1.Size = new System.Drawing.Size(367, 132);
            this.kryptonHeader1.TabIndex = 0;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Back Of The Book Indexer";
            this.kryptonHeader1.Values.Image = global::BackOfTheBookIndexing.Properties.Resources._1378420475_MB__book;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 469);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Back of the Book Indexer";
            this.TextExtra = "Machine Aided Indexing system";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.HomeTabPage.ResumeLayout(false);
            this.HomeTabPage.PerformLayout();
            this.DomainTabPage.ResumeLayout(false);
            this.DomainTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDropdown)).EndInit();
            this.SettingsTabPage.ResumeLayout(false);
            this.kryptonGroupBox2.ResumeLayout(false);
            this.kryptonGroupBox2.PerformLayout();
            this.HelpTabPage.ResumeLayout(false);
            this.HelpTabPage.PerformLayout();
            this.AboutTabPage.ResumeLayout(false);
            this.AboutTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl MainTabControl;
        private System.Windows.Forms.TabPage HomeTabPage;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.TabPage HelpTabPage;
        private System.Windows.Forms.TabPage AboutTabPage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton MachineGenerateBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox DocumentSlctTxtBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BrowseBtn;
        private System.Windows.Forms.Label FileInfoLabel;
        private System.Windows.Forms.TabPage DomainTabPage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton FileBrowseForDomainBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox FileBrowseDomainTxtbox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton GenerateIndexBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton DomainFileSelectBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox DomainFileSelectTxtbox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox SelectDropdown;
        private System.Windows.Forms.ProgressBar myProgressBar;
        private System.Windows.Forms.Label FileInfoLabelDomain;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel myLinkLabel;
        private System.Windows.Forms.ProgressBar myProgressBarDomain;
        private AC.ExtendedRenderer.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox office10BlueChbox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox sparkleBlueChbox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox office07SilverChbox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox office10BlackChbox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox office10SilverChbox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox office07BlackChbox;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager myKryptonManager;

       
       

    }
}

