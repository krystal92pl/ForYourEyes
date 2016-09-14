namespace ForYourEyes
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.windowTabControl = new MetroFramework.Controls.MetroTabControl();
            this.settingsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.startWithWindowsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.setDefaultButton = new MetroFramework.Controls.MetroButton();
            this.saveSettingButton = new MetroFramework.Controls.MetroButton();
            this.settingInformationLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.durationShortBreakLabel = new MetroFramework.Controls.MetroLabel();
            this.durationLongBreakTextBox = new MetroFramework.Controls.MetroTextBox();
            this.durationLongBreakLabel = new MetroFramework.Controls.MetroLabel();
            this.distanceLongBreakTextBox = new MetroFramework.Controls.MetroTextBox();
            this.distanceLongBreakLabel = new MetroFramework.Controls.MetroLabel();
            this.quantityShortBreaksLabel = new MetroFramework.Controls.MetroLabel();
            this.durationShortBreakTextBox = new MetroFramework.Controls.MetroTextBox();
            this.quantityShortBreaksTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addProfileButton = new MetroFramework.Controls.MetroButton();
            this.addProfileTextBox = new MetroFramework.Controls.MetroTextBox();
            this.deleteProfileButton = new MetroFramework.Controls.MetroButton();
            this.showAddProfileButton = new MetroFramework.Controls.MetroButton();
            this.profilesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.profilLabel = new MetroFramework.Controls.MetroLabel();
            this.breaksTabPage = new MetroFramework.Controls.MetroTabPage();
            this.nextPictureButton = new MetroFramework.Controls.MetroButton();
            this.previousPictureButton = new MetroFramework.Controls.MetroButton();
            this.choosePictureLabel = new MetroFramework.Controls.MetroLabel();
            this.deleteBreakButton = new MetroFramework.Controls.MetroButton();
            this.breaksListBox = new System.Windows.Forms.ListBox();
            this.editBreakButton = new MetroFramework.Controls.MetroButton();
            this.editBreakTextBox = new MetroFramework.Controls.MetroTextBox();
            this.editBreakLabel = new MetroFramework.Controls.MetroLabel();
            this.editBreakPictureBox = new System.Windows.Forms.PictureBox();
            this.addNewBreakButton = new MetroFramework.Controls.MetroButton();
            this.newBreakInstructionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.newBreakLabel = new MetroFramework.Controls.MetroLabel();
            this.viewSoundTabPage = new MetroFramework.Controls.MetroTabPage();
            this.soundLabel = new MetroFramework.Controls.MetroLabel();
            this.soundCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.yellowTile = new MetroFramework.Controls.MetroTile();
            this.saveViewSoundAllButton = new MetroFramework.Controls.MetroButton();
            this.saveViewSoundOneButton = new MetroFramework.Controls.MetroButton();
            this.blackTile = new MetroFramework.Controls.MetroTile();
            this.silverTile = new MetroFramework.Controls.MetroTile();
            this.saveViewSoundForAllLabel = new MetroFramework.Controls.MetroLabel();
            this.blueTile = new MetroFramework.Controls.MetroTile();
            this.saveViewSoundForOneLabel = new MetroFramework.Controls.MetroLabel();
            this.greenTile = new MetroFramework.Controls.MetroTile();
            this.opacityLabel = new MetroFramework.Controls.MetroLabel();
            this.redTile = new MetroFramework.Controls.MetroTile();
            this.opacityBreakLabel = new MetroFramework.Controls.MetroLabel();
            this.limeTile = new MetroFramework.Controls.MetroTile();
            this.opacityTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.tealTile = new MetroFramework.Controls.MetroTile();
            this.pinkTile = new MetroFramework.Controls.MetroTile();
            this.styleLabel = new MetroFramework.Controls.MetroLabel();
            this.purpleTile = new MetroFramework.Controls.MetroTile();
            this.themeLabel = new MetroFramework.Controls.MetroLabel();
            this.brownTile = new MetroFramework.Controls.MetroTile();
            this.changeThemeTile = new MetroFramework.Controls.MetroTile();
            this.magentaTile = new MetroFramework.Controls.MetroTile();
            this.orangeTile = new MetroFramework.Controls.MetroTile();
            this.isWorkingLabel = new MetroFramework.Controls.MetroLabel();
            this.stopTile = new MetroFramework.Controls.MetroTile();
            this.startTile = new MetroFramework.Controls.MetroTile();
            this.msmMainWindow = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.otwórzForYourEyesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijForYourEyesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowTabControl.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.breaksTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editBreakPictureBox)).BeginInit();
            this.viewSoundTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMainWindow)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowTabControl
            // 
            this.windowTabControl.Controls.Add(this.settingsTabPage);
            this.windowTabControl.Controls.Add(this.breaksTabPage);
            this.windowTabControl.Controls.Add(this.viewSoundTabPage);
            this.windowTabControl.Location = new System.Drawing.Point(24, 64);
            this.windowTabControl.Name = "windowTabControl";
            this.windowTabControl.SelectedIndex = 0;
            this.windowTabControl.Size = new System.Drawing.Size(503, 273);
            this.windowTabControl.TabIndex = 0;
            this.windowTabControl.UseSelectable = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.startWithWindowsCheckBox);
            this.settingsTabPage.Controls.Add(this.setDefaultButton);
            this.settingsTabPage.Controls.Add(this.saveSettingButton);
            this.settingsTabPage.Controls.Add(this.settingInformationLabel);
            this.settingsTabPage.Controls.Add(this.metroLabel6);
            this.settingsTabPage.Controls.Add(this.metroLabel5);
            this.settingsTabPage.Controls.Add(this.durationShortBreakLabel);
            this.settingsTabPage.Controls.Add(this.durationLongBreakTextBox);
            this.settingsTabPage.Controls.Add(this.durationLongBreakLabel);
            this.settingsTabPage.Controls.Add(this.distanceLongBreakTextBox);
            this.settingsTabPage.Controls.Add(this.distanceLongBreakLabel);
            this.settingsTabPage.Controls.Add(this.quantityShortBreaksLabel);
            this.settingsTabPage.Controls.Add(this.durationShortBreakTextBox);
            this.settingsTabPage.Controls.Add(this.quantityShortBreaksTextBox);
            this.settingsTabPage.Controls.Add(this.addProfileButton);
            this.settingsTabPage.Controls.Add(this.addProfileTextBox);
            this.settingsTabPage.Controls.Add(this.deleteProfileButton);
            this.settingsTabPage.Controls.Add(this.showAddProfileButton);
            this.settingsTabPage.Controls.Add(this.profilesComboBox);
            this.settingsTabPage.Controls.Add(this.profilLabel);
            this.settingsTabPage.HorizontalScrollbarBarColor = true;
            this.settingsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTabPage.HorizontalScrollbarSize = 10;
            this.settingsTabPage.Location = new System.Drawing.Point(4, 38);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(495, 231);
            this.settingsTabPage.TabIndex = 0;
            this.settingsTabPage.Text = "Ustawienia";
            this.settingsTabPage.VerticalScrollbarBarColor = true;
            this.settingsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTabPage.VerticalScrollbarSize = 10;
            // 
            // startWithWindowsCheckBox
            // 
            this.startWithWindowsCheckBox.AutoSize = true;
            this.startWithWindowsCheckBox.Location = new System.Drawing.Point(229, 216);
            this.startWithWindowsCheckBox.Name = "startWithWindowsCheckBox";
            this.startWithWindowsCheckBox.Size = new System.Drawing.Size(250, 15);
            this.startWithWindowsCheckBox.TabIndex = 61;
            this.startWithWindowsCheckBox.Text = "Uruchom ForYourEyes przy starcie systemu";
            this.startWithWindowsCheckBox.UseSelectable = true;
            this.startWithWindowsCheckBox.CheckedChanged += new System.EventHandler(this.startWithWindowsCheckBox_CheckedChanged);
            // 
            // setDefaultButton
            // 
            this.setDefaultButton.Location = new System.Drawing.Point(404, 65);
            this.setDefaultButton.Name = "setDefaultButton";
            this.setDefaultButton.Size = new System.Drawing.Size(75, 61);
            this.setDefaultButton.TabIndex = 60;
            this.setDefaultButton.Text = "Przywróć\r\nustawienia\r\ndomyślne";
            this.setDefaultButton.UseSelectable = true;
            this.setDefaultButton.Click += new System.EventHandler(this.setDefaultButton_Click);
            // 
            // saveSettingButton
            // 
            this.saveSettingButton.Location = new System.Drawing.Point(7, 208);
            this.saveSettingButton.Name = "saveSettingButton";
            this.saveSettingButton.Size = new System.Drawing.Size(172, 23);
            this.saveSettingButton.TabIndex = 59;
            this.saveSettingButton.Text = "Zapisz zmiany";
            this.saveSettingButton.UseSelectable = true;
            this.saveSettingButton.Click += new System.EventHandler(this.saveSettingButton_Click);
            // 
            // settingInformationLabel
            // 
            this.settingInformationLabel.AutoSize = true;
            this.settingInformationLabel.Location = new System.Drawing.Point(7, 185);
            this.settingInformationLabel.Name = "settingInformationLabel";
            this.settingInformationLabel.Size = new System.Drawing.Size(13, 19);
            this.settingInformationLabel.TabIndex = 58;
            this.settingInformationLabel.Text = " ";
            this.settingInformationLabel.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(229, 154);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(42, 19);
            this.metroLabel6.TabIndex = 57;
            this.metroLabel6.Text = "Minut";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(229, 95);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 56;
            this.metroLabel5.Text = "Sekund";
            // 
            // durationShortBreakLabel
            // 
            this.durationShortBreakLabel.AutoSize = true;
            this.durationShortBreakLabel.Location = new System.Drawing.Point(193, 69);
            this.durationShortBreakLabel.Name = "durationShortBreakLabel";
            this.durationShortBreakLabel.Size = new System.Drawing.Size(178, 19);
            this.durationShortBreakLabel.TabIndex = 55;
            this.durationShortBreakLabel.Text = "Czas trwania krotkiej przerwy";
            // 
            // durationLongBreakTextBox
            // 
            // 
            // 
            // 
            this.durationLongBreakTextBox.CustomButton.Image = null;
            this.durationLongBreakTextBox.CustomButton.Location = new System.Drawing.Point(8, 1);
            this.durationLongBreakTextBox.CustomButton.Name = "";
            this.durationLongBreakTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.durationLongBreakTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.durationLongBreakTextBox.CustomButton.TabIndex = 1;
            this.durationLongBreakTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.durationLongBreakTextBox.CustomButton.UseSelectable = true;
            this.durationLongBreakTextBox.CustomButton.Visible = false;
            this.durationLongBreakTextBox.Lines = new string[] {
        "5"};
            this.durationLongBreakTextBox.Location = new System.Drawing.Point(193, 150);
            this.durationLongBreakTextBox.MaxLength = 32767;
            this.durationLongBreakTextBox.Name = "durationLongBreakTextBox";
            this.durationLongBreakTextBox.PasswordChar = '\0';
            this.durationLongBreakTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.durationLongBreakTextBox.SelectedText = "";
            this.durationLongBreakTextBox.SelectionLength = 0;
            this.durationLongBreakTextBox.SelectionStart = 0;
            this.durationLongBreakTextBox.ShortcutsEnabled = true;
            this.durationLongBreakTextBox.Size = new System.Drawing.Size(30, 23);
            this.durationLongBreakTextBox.TabIndex = 54;
            this.durationLongBreakTextBox.Text = "5";
            this.durationLongBreakTextBox.UseSelectable = true;
            this.durationLongBreakTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.durationLongBreakTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // durationLongBreakLabel
            // 
            this.durationLongBreakLabel.AutoSize = true;
            this.durationLongBreakLabel.Location = new System.Drawing.Point(193, 128);
            this.durationLongBreakLabel.Name = "durationLongBreakLabel";
            this.durationLongBreakLabel.Size = new System.Drawing.Size(175, 19);
            this.durationLongBreakLabel.TabIndex = 53;
            this.durationLongBreakLabel.Text = "Czas trwania dlugiej przerwy";
            // 
            // distanceLongBreakTextBox
            // 
            // 
            // 
            // 
            this.distanceLongBreakTextBox.CustomButton.Image = null;
            this.distanceLongBreakTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.distanceLongBreakTextBox.CustomButton.Name = "";
            this.distanceLongBreakTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.distanceLongBreakTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.distanceLongBreakTextBox.CustomButton.TabIndex = 1;
            this.distanceLongBreakTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.distanceLongBreakTextBox.CustomButton.UseSelectable = true;
            this.distanceLongBreakTextBox.CustomButton.Visible = false;
            this.distanceLongBreakTextBox.Lines = new string[] {
        "55"};
            this.distanceLongBreakTextBox.Location = new System.Drawing.Point(7, 150);
            this.distanceLongBreakTextBox.MaxLength = 32767;
            this.distanceLongBreakTextBox.Name = "distanceLongBreakTextBox";
            this.distanceLongBreakTextBox.PasswordChar = '\0';
            this.distanceLongBreakTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.distanceLongBreakTextBox.SelectedText = "";
            this.distanceLongBreakTextBox.SelectionLength = 0;
            this.distanceLongBreakTextBox.SelectionStart = 0;
            this.distanceLongBreakTextBox.ShortcutsEnabled = true;
            this.distanceLongBreakTextBox.Size = new System.Drawing.Size(75, 23);
            this.distanceLongBreakTextBox.TabIndex = 52;
            this.distanceLongBreakTextBox.Text = "55";
            this.distanceLongBreakTextBox.UseSelectable = true;
            this.distanceLongBreakTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.distanceLongBreakTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // distanceLongBreakLabel
            // 
            this.distanceLongBreakLabel.AutoSize = true;
            this.distanceLongBreakLabel.Location = new System.Drawing.Point(7, 128);
            this.distanceLongBreakLabel.Name = "distanceLongBreakLabel";
            this.distanceLongBreakLabel.Size = new System.Drawing.Size(171, 19);
            this.distanceLongBreakLabel.TabIndex = 51;
            this.distanceLongBreakLabel.Text = "Co ile minut przerwa długa:";
            // 
            // quantityShortBreaksLabel
            // 
            this.quantityShortBreaksLabel.AutoSize = true;
            this.quantityShortBreaksLabel.Location = new System.Drawing.Point(7, 69);
            this.quantityShortBreaksLabel.Name = "quantityShortBreaksLabel";
            this.quantityShortBreaksLabel.Size = new System.Drawing.Size(130, 19);
            this.quantityShortBreaksLabel.TabIndex = 50;
            this.quantityShortBreaksLabel.Text = "Ilosc krotkich przerw:";
            // 
            // durationShortBreakTextBox
            // 
            // 
            // 
            // 
            this.durationShortBreakTextBox.CustomButton.Image = null;
            this.durationShortBreakTextBox.CustomButton.Location = new System.Drawing.Point(8, 1);
            this.durationShortBreakTextBox.CustomButton.Name = "";
            this.durationShortBreakTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.durationShortBreakTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.durationShortBreakTextBox.CustomButton.TabIndex = 1;
            this.durationShortBreakTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.durationShortBreakTextBox.CustomButton.UseSelectable = true;
            this.durationShortBreakTextBox.CustomButton.Visible = false;
            this.durationShortBreakTextBox.Lines = new string[] {
        "10"};
            this.durationShortBreakTextBox.Location = new System.Drawing.Point(193, 91);
            this.durationShortBreakTextBox.MaxLength = 32767;
            this.durationShortBreakTextBox.Name = "durationShortBreakTextBox";
            this.durationShortBreakTextBox.PasswordChar = '\0';
            this.durationShortBreakTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.durationShortBreakTextBox.SelectedText = "";
            this.durationShortBreakTextBox.SelectionLength = 0;
            this.durationShortBreakTextBox.SelectionStart = 0;
            this.durationShortBreakTextBox.ShortcutsEnabled = true;
            this.durationShortBreakTextBox.Size = new System.Drawing.Size(30, 23);
            this.durationShortBreakTextBox.TabIndex = 49;
            this.durationShortBreakTextBox.Text = "10";
            this.durationShortBreakTextBox.UseSelectable = true;
            this.durationShortBreakTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.durationShortBreakTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // quantityShortBreaksTextBox
            // 
            // 
            // 
            // 
            this.quantityShortBreaksTextBox.CustomButton.Image = null;
            this.quantityShortBreaksTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.quantityShortBreaksTextBox.CustomButton.Name = "";
            this.quantityShortBreaksTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.quantityShortBreaksTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantityShortBreaksTextBox.CustomButton.TabIndex = 1;
            this.quantityShortBreaksTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantityShortBreaksTextBox.CustomButton.UseSelectable = true;
            this.quantityShortBreaksTextBox.CustomButton.Visible = false;
            this.quantityShortBreaksTextBox.Lines = new string[] {
        "4"};
            this.quantityShortBreaksTextBox.Location = new System.Drawing.Point(7, 91);
            this.quantityShortBreaksTextBox.MaxLength = 32767;
            this.quantityShortBreaksTextBox.Name = "quantityShortBreaksTextBox";
            this.quantityShortBreaksTextBox.PasswordChar = '\0';
            this.quantityShortBreaksTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantityShortBreaksTextBox.SelectedText = "";
            this.quantityShortBreaksTextBox.SelectionLength = 0;
            this.quantityShortBreaksTextBox.SelectionStart = 0;
            this.quantityShortBreaksTextBox.ShortcutsEnabled = true;
            this.quantityShortBreaksTextBox.Size = new System.Drawing.Size(75, 23);
            this.quantityShortBreaksTextBox.TabIndex = 48;
            this.quantityShortBreaksTextBox.Text = "4";
            this.quantityShortBreaksTextBox.UseSelectable = true;
            this.quantityShortBreaksTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantityShortBreaksTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addProfileButton
            // 
            this.addProfileButton.Highlight = true;
            this.addProfileButton.Location = new System.Drawing.Point(369, 20);
            this.addProfileButton.Name = "addProfileButton";
            this.addProfileButton.Size = new System.Drawing.Size(75, 23);
            this.addProfileButton.TabIndex = 47;
            this.addProfileButton.Text = "Dodaj profil";
            this.addProfileButton.UseSelectable = true;
            this.addProfileButton.Visible = false;
            this.addProfileButton.Click += new System.EventHandler(this.addProfileButton_Click);
            // 
            // addProfileTextBox
            // 
            // 
            // 
            // 
            this.addProfileTextBox.CustomButton.Image = null;
            this.addProfileTextBox.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.addProfileTextBox.CustomButton.Name = "";
            this.addProfileTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.addProfileTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addProfileTextBox.CustomButton.TabIndex = 1;
            this.addProfileTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addProfileTextBox.CustomButton.UseSelectable = true;
            this.addProfileTextBox.CustomButton.Visible = false;
            this.addProfileTextBox.Lines = new string[] {
        "Nazwa profilu"};
            this.addProfileTextBox.Location = new System.Drawing.Point(256, 20);
            this.addProfileTextBox.MaxLength = 32767;
            this.addProfileTextBox.Name = "addProfileTextBox";
            this.addProfileTextBox.PasswordChar = '\0';
            this.addProfileTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addProfileTextBox.SelectedText = "";
            this.addProfileTextBox.SelectionLength = 0;
            this.addProfileTextBox.SelectionStart = 0;
            this.addProfileTextBox.ShortcutsEnabled = true;
            this.addProfileTextBox.Size = new System.Drawing.Size(110, 23);
            this.addProfileTextBox.TabIndex = 46;
            this.addProfileTextBox.Text = "Nazwa profilu";
            this.addProfileTextBox.UseSelectable = true;
            this.addProfileTextBox.Visible = false;
            this.addProfileTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addProfileTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // deleteProfileButton
            // 
            this.deleteProfileButton.Location = new System.Drawing.Point(222, 35);
            this.deleteProfileButton.Name = "deleteProfileButton";
            this.deleteProfileButton.Size = new System.Drawing.Size(28, 17);
            this.deleteProfileButton.TabIndex = 5;
            this.deleteProfileButton.Text = "X";
            this.deleteProfileButton.UseSelectable = true;
            this.deleteProfileButton.Click += new System.EventHandler(this.deleteProfileButton_Click);
            // 
            // showAddProfileButton
            // 
            this.showAddProfileButton.Location = new System.Drawing.Point(222, 12);
            this.showAddProfileButton.Name = "showAddProfileButton";
            this.showAddProfileButton.Size = new System.Drawing.Size(28, 17);
            this.showAddProfileButton.TabIndex = 4;
            this.showAddProfileButton.Text = "+";
            this.showAddProfileButton.UseSelectable = true;
            this.showAddProfileButton.Click += new System.EventHandler(this.showAddProfileButton_Click);
            // 
            // profilesComboBox
            // 
            this.profilesComboBox.FormattingEnabled = true;
            this.profilesComboBox.ItemHeight = 23;
            this.profilesComboBox.Location = new System.Drawing.Point(56, 16);
            this.profilesComboBox.Name = "profilesComboBox";
            this.profilesComboBox.Size = new System.Drawing.Size(160, 29);
            this.profilesComboBox.TabIndex = 3;
            this.profilesComboBox.UseSelectable = true;
            // 
            // profilLabel
            // 
            this.profilLabel.AutoSize = true;
            this.profilLabel.Location = new System.Drawing.Point(7, 20);
            this.profilLabel.Name = "profilLabel";
            this.profilLabel.Size = new System.Drawing.Size(43, 19);
            this.profilLabel.TabIndex = 2;
            this.profilLabel.Text = "Profil:";
            // 
            // breaksTabPage
            // 
            this.breaksTabPage.Controls.Add(this.nextPictureButton);
            this.breaksTabPage.Controls.Add(this.previousPictureButton);
            this.breaksTabPage.Controls.Add(this.choosePictureLabel);
            this.breaksTabPage.Controls.Add(this.deleteBreakButton);
            this.breaksTabPage.Controls.Add(this.breaksListBox);
            this.breaksTabPage.Controls.Add(this.editBreakButton);
            this.breaksTabPage.Controls.Add(this.editBreakTextBox);
            this.breaksTabPage.Controls.Add(this.editBreakLabel);
            this.breaksTabPage.Controls.Add(this.editBreakPictureBox);
            this.breaksTabPage.Controls.Add(this.addNewBreakButton);
            this.breaksTabPage.Controls.Add(this.newBreakInstructionTextBox);
            this.breaksTabPage.Controls.Add(this.newBreakLabel);
            this.breaksTabPage.HorizontalScrollbarBarColor = true;
            this.breaksTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.breaksTabPage.HorizontalScrollbarSize = 10;
            this.breaksTabPage.Location = new System.Drawing.Point(4, 38);
            this.breaksTabPage.Name = "breaksTabPage";
            this.breaksTabPage.Size = new System.Drawing.Size(495, 231);
            this.breaksTabPage.TabIndex = 1;
            this.breaksTabPage.Text = "Przerwy";
            this.breaksTabPage.VerticalScrollbarBarColor = true;
            this.breaksTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.breaksTabPage.VerticalScrollbarSize = 10;
            // 
            // nextPictureButton
            // 
            this.nextPictureButton.Location = new System.Drawing.Point(312, 142);
            this.nextPictureButton.Name = "nextPictureButton";
            this.nextPictureButton.Size = new System.Drawing.Size(30, 23);
            this.nextPictureButton.TabIndex = 30;
            this.nextPictureButton.Text = ">>";
            this.nextPictureButton.UseSelectable = true;
            this.nextPictureButton.UseStyleColors = true;
            this.nextPictureButton.Click += new System.EventHandler(this.nextPictureButton_Click);
            // 
            // previousPictureButton
            // 
            this.previousPictureButton.Location = new System.Drawing.Point(175, 142);
            this.previousPictureButton.Name = "previousPictureButton";
            this.previousPictureButton.Size = new System.Drawing.Size(30, 23);
            this.previousPictureButton.TabIndex = 29;
            this.previousPictureButton.Text = "<<";
            this.previousPictureButton.UseSelectable = true;
            this.previousPictureButton.UseStyleColors = true;
            this.previousPictureButton.Click += new System.EventHandler(this.previousPictureButton_Click);
            // 
            // choosePictureLabel
            // 
            this.choosePictureLabel.AutoSize = true;
            this.choosePictureLabel.Location = new System.Drawing.Point(206, 142);
            this.choosePictureLabel.Name = "choosePictureLabel";
            this.choosePictureLabel.Size = new System.Drawing.Size(108, 19);
            this.choosePictureLabel.TabIndex = 28;
            this.choosePictureLabel.Text = "Wybierz obrazek";
            // 
            // deleteBreakButton
            // 
            this.deleteBreakButton.Highlight = true;
            this.deleteBreakButton.Location = new System.Drawing.Point(3, 191);
            this.deleteBreakButton.Name = "deleteBreakButton";
            this.deleteBreakButton.Size = new System.Drawing.Size(166, 23);
            this.deleteBreakButton.TabIndex = 27;
            this.deleteBreakButton.Text = "Usuń przerwę";
            this.deleteBreakButton.UseSelectable = true;
            this.deleteBreakButton.Click += new System.EventHandler(this.deleteBreakButton_Click);
            // 
            // breaksListBox
            // 
            this.breaksListBox.FormattingEnabled = true;
            this.breaksListBox.Location = new System.Drawing.Point(3, 12);
            this.breaksListBox.Name = "breaksListBox";
            this.breaksListBox.Size = new System.Drawing.Size(166, 173);
            this.breaksListBox.TabIndex = 26;
            this.breaksListBox.SelectedIndexChanged += new System.EventHandler(this.breaksListBox_SelectedIndexChanged);
            // 
            // editBreakButton
            // 
            this.editBreakButton.Highlight = true;
            this.editBreakButton.Location = new System.Drawing.Point(175, 171);
            this.editBreakButton.Name = "editBreakButton";
            this.editBreakButton.Size = new System.Drawing.Size(167, 23);
            this.editBreakButton.TabIndex = 25;
            this.editBreakButton.Text = "Edytuj";
            this.editBreakButton.UseSelectable = true;
            this.editBreakButton.Click += new System.EventHandler(this.editBreakButton_Click);
            // 
            // editBreakTextBox
            // 
            // 
            // 
            // 
            this.editBreakTextBox.CustomButton.Image = null;
            this.editBreakTextBox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.editBreakTextBox.CustomButton.Name = "";
            this.editBreakTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.editBreakTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editBreakTextBox.CustomButton.TabIndex = 1;
            this.editBreakTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editBreakTextBox.CustomButton.UseSelectable = true;
            this.editBreakTextBox.CustomButton.Visible = false;
            this.editBreakTextBox.Lines = new string[0];
            this.editBreakTextBox.Location = new System.Drawing.Point(175, 34);
            this.editBreakTextBox.MaxLength = 32767;
            this.editBreakTextBox.Name = "editBreakTextBox";
            this.editBreakTextBox.PasswordChar = '\0';
            this.editBreakTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editBreakTextBox.SelectedText = "";
            this.editBreakTextBox.SelectionLength = 0;
            this.editBreakTextBox.SelectionStart = 0;
            this.editBreakTextBox.ShortcutsEnabled = true;
            this.editBreakTextBox.Size = new System.Drawing.Size(167, 23);
            this.editBreakTextBox.TabIndex = 24;
            this.editBreakTextBox.UseSelectable = true;
            this.editBreakTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editBreakTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // editBreakLabel
            // 
            this.editBreakLabel.AutoSize = true;
            this.editBreakLabel.Location = new System.Drawing.Point(175, 12);
            this.editBreakLabel.Name = "editBreakLabel";
            this.editBreakLabel.Size = new System.Drawing.Size(96, 19);
            this.editBreakLabel.TabIndex = 23;
            this.editBreakLabel.Text = "Edycja przerwy";
            // 
            // editBreakPictureBox
            // 
            this.editBreakPictureBox.Location = new System.Drawing.Point(175, 63);
            this.editBreakPictureBox.Name = "editBreakPictureBox";
            this.editBreakPictureBox.Size = new System.Drawing.Size(167, 73);
            this.editBreakPictureBox.TabIndex = 22;
            this.editBreakPictureBox.TabStop = false;
            // 
            // addNewBreakButton
            // 
            this.addNewBreakButton.Highlight = true;
            this.addNewBreakButton.Location = new System.Drawing.Point(348, 63);
            this.addNewBreakButton.Name = "addNewBreakButton";
            this.addNewBreakButton.Size = new System.Drawing.Size(75, 23);
            this.addNewBreakButton.TabIndex = 21;
            this.addNewBreakButton.Text = "Dodaj";
            this.addNewBreakButton.UseSelectable = true;
            this.addNewBreakButton.Click += new System.EventHandler(this.addNewBreakButton_Click);
            // 
            // newBreakInstructionTextBox
            // 
            // 
            // 
            // 
            this.newBreakInstructionTextBox.CustomButton.Image = null;
            this.newBreakInstructionTextBox.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.newBreakInstructionTextBox.CustomButton.Name = "";
            this.newBreakInstructionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.newBreakInstructionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newBreakInstructionTextBox.CustomButton.TabIndex = 1;
            this.newBreakInstructionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newBreakInstructionTextBox.CustomButton.UseSelectable = true;
            this.newBreakInstructionTextBox.CustomButton.Visible = false;
            this.newBreakInstructionTextBox.Lines = new string[] {
        "Instrukcja"};
            this.newBreakInstructionTextBox.Location = new System.Drawing.Point(348, 34);
            this.newBreakInstructionTextBox.MaxLength = 32767;
            this.newBreakInstructionTextBox.Name = "newBreakInstructionTextBox";
            this.newBreakInstructionTextBox.PasswordChar = '\0';
            this.newBreakInstructionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newBreakInstructionTextBox.SelectedText = "";
            this.newBreakInstructionTextBox.SelectionLength = 0;
            this.newBreakInstructionTextBox.SelectionStart = 0;
            this.newBreakInstructionTextBox.ShortcutsEnabled = true;
            this.newBreakInstructionTextBox.Size = new System.Drawing.Size(130, 23);
            this.newBreakInstructionTextBox.TabIndex = 20;
            this.newBreakInstructionTextBox.Text = "Instrukcja";
            this.newBreakInstructionTextBox.UseSelectable = true;
            this.newBreakInstructionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newBreakInstructionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newBreakLabel
            // 
            this.newBreakLabel.AutoSize = true;
            this.newBreakLabel.Location = new System.Drawing.Point(348, 12);
            this.newBreakLabel.Name = "newBreakLabel";
            this.newBreakLabel.Size = new System.Drawing.Size(94, 19);
            this.newBreakLabel.TabIndex = 19;
            this.newBreakLabel.Text = "Nowa przerwa";
            // 
            // viewSoundTabPage
            // 
            this.viewSoundTabPage.Controls.Add(this.soundLabel);
            this.viewSoundTabPage.Controls.Add(this.soundCheckBox);
            this.viewSoundTabPage.Controls.Add(this.yellowTile);
            this.viewSoundTabPage.Controls.Add(this.saveViewSoundAllButton);
            this.viewSoundTabPage.Controls.Add(this.saveViewSoundOneButton);
            this.viewSoundTabPage.Controls.Add(this.blackTile);
            this.viewSoundTabPage.Controls.Add(this.silverTile);
            this.viewSoundTabPage.Controls.Add(this.saveViewSoundForAllLabel);
            this.viewSoundTabPage.Controls.Add(this.blueTile);
            this.viewSoundTabPage.Controls.Add(this.saveViewSoundForOneLabel);
            this.viewSoundTabPage.Controls.Add(this.greenTile);
            this.viewSoundTabPage.Controls.Add(this.opacityLabel);
            this.viewSoundTabPage.Controls.Add(this.redTile);
            this.viewSoundTabPage.Controls.Add(this.opacityBreakLabel);
            this.viewSoundTabPage.Controls.Add(this.limeTile);
            this.viewSoundTabPage.Controls.Add(this.opacityTrackBar);
            this.viewSoundTabPage.Controls.Add(this.tealTile);
            this.viewSoundTabPage.Controls.Add(this.pinkTile);
            this.viewSoundTabPage.Controls.Add(this.styleLabel);
            this.viewSoundTabPage.Controls.Add(this.purpleTile);
            this.viewSoundTabPage.Controls.Add(this.themeLabel);
            this.viewSoundTabPage.Controls.Add(this.brownTile);
            this.viewSoundTabPage.Controls.Add(this.changeThemeTile);
            this.viewSoundTabPage.Controls.Add(this.magentaTile);
            this.viewSoundTabPage.Controls.Add(this.orangeTile);
            this.viewSoundTabPage.HorizontalScrollbarBarColor = true;
            this.viewSoundTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.viewSoundTabPage.HorizontalScrollbarSize = 10;
            this.viewSoundTabPage.Location = new System.Drawing.Point(4, 38);
            this.viewSoundTabPage.Name = "viewSoundTabPage";
            this.viewSoundTabPage.Size = new System.Drawing.Size(495, 231);
            this.viewSoundTabPage.TabIndex = 2;
            this.viewSoundTabPage.Text = "Wygląd i Dźwięk";
            this.viewSoundTabPage.VerticalScrollbarBarColor = true;
            this.viewSoundTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.viewSoundTabPage.VerticalScrollbarSize = 10;
            // 
            // soundLabel
            // 
            this.soundLabel.AutoSize = true;
            this.soundLabel.Location = new System.Drawing.Point(157, 3);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(52, 19);
            this.soundLabel.TabIndex = 80;
            this.soundLabel.Text = "Dźwięk:";
            // 
            // soundCheckBox
            // 
            this.soundCheckBox.AutoSize = true;
            this.soundCheckBox.Location = new System.Drawing.Point(157, 25);
            this.soundCheckBox.Name = "soundCheckBox";
            this.soundCheckBox.Size = new System.Drawing.Size(117, 15);
            this.soundCheckBox.TabIndex = 79;
            this.soundCheckBox.Text = "dźwięk wyłączony";
            this.soundCheckBox.UseSelectable = true;
            this.soundCheckBox.CheckedChanged += new System.EventHandler(this.soundCheckBox_CheckedChanged);
            // 
            // yellowTile
            // 
            this.yellowTile.ActiveControl = null;
            this.yellowTile.Location = new System.Drawing.Point(448, 121);
            this.yellowTile.Name = "yellowTile";
            this.yellowTile.Size = new System.Drawing.Size(30, 30);
            this.yellowTile.Style = MetroFramework.MetroColorStyle.Yellow;
            this.yellowTile.TabIndex = 71;
            this.yellowTile.UseSelectable = true;
            // 
            // saveViewSoundAllButton
            // 
            this.saveViewSoundAllButton.Location = new System.Drawing.Point(198, 204);
            this.saveViewSoundAllButton.Name = "saveViewSoundAllButton";
            this.saveViewSoundAllButton.Size = new System.Drawing.Size(136, 23);
            this.saveViewSoundAllButton.TabIndex = 78;
            this.saveViewSoundAllButton.Text = "Zapisz dla wszystkich";
            this.saveViewSoundAllButton.UseSelectable = true;
            this.saveViewSoundAllButton.Click += new System.EventHandler(this.saveViewSoundAllButton_Click);
            // 
            // saveViewSoundOneButton
            // 
            this.saveViewSoundOneButton.Location = new System.Drawing.Point(198, 164);
            this.saveViewSoundOneButton.Name = "saveViewSoundOneButton";
            this.saveViewSoundOneButton.Size = new System.Drawing.Size(75, 19);
            this.saveViewSoundOneButton.TabIndex = 77;
            this.saveViewSoundOneButton.Text = "Zapisz";
            this.saveViewSoundOneButton.UseSelectable = true;
            this.saveViewSoundOneButton.Click += new System.EventHandler(this.saveViewSoundOneButton_Click);
            // 
            // blackTile
            // 
            this.blackTile.ActiveControl = null;
            this.blackTile.Location = new System.Drawing.Point(16, 121);
            this.blackTile.Name = "blackTile";
            this.blackTile.Size = new System.Drawing.Size(30, 30);
            this.blackTile.Style = MetroFramework.MetroColorStyle.Black;
            this.blackTile.TabIndex = 59;
            this.blackTile.Tag = "";
            this.blackTile.UseSelectable = true;
            // 
            // silverTile
            // 
            this.silverTile.ActiveControl = null;
            this.silverTile.Location = new System.Drawing.Point(52, 121);
            this.silverTile.Name = "silverTile";
            this.silverTile.Size = new System.Drawing.Size(30, 30);
            this.silverTile.Style = MetroFramework.MetroColorStyle.Silver;
            this.silverTile.TabIndex = 60;
            this.silverTile.Tag = "";
            this.silverTile.UseSelectable = true;
            // 
            // saveViewSoundForAllLabel
            // 
            this.saveViewSoundForAllLabel.AutoSize = true;
            this.saveViewSoundForAllLabel.Location = new System.Drawing.Point(16, 204);
            this.saveViewSoundForAllLabel.Name = "saveViewSoundForAllLabel";
            this.saveViewSoundForAllLabel.Size = new System.Drawing.Size(170, 19);
            this.saveViewSoundForAllLabel.TabIndex = 76;
            this.saveViewSoundForAllLabel.Text = "Zapisz dla wszystkich profili:";
            // 
            // blueTile
            // 
            this.blueTile.ActiveControl = null;
            this.blueTile.Location = new System.Drawing.Point(88, 121);
            this.blueTile.Name = "blueTile";
            this.blueTile.Size = new System.Drawing.Size(30, 30);
            this.blueTile.Style = MetroFramework.MetroColorStyle.Blue;
            this.blueTile.TabIndex = 61;
            this.blueTile.UseSelectable = true;
            // 
            // saveViewSoundForOneLabel
            // 
            this.saveViewSoundForOneLabel.AutoSize = true;
            this.saveViewSoundForOneLabel.Location = new System.Drawing.Point(16, 164);
            this.saveViewSoundForOneLabel.Name = "saveViewSoundForOneLabel";
            this.saveViewSoundForOneLabel.Size = new System.Drawing.Size(179, 19);
            this.saveViewSoundForOneLabel.TabIndex = 75;
            this.saveViewSoundForOneLabel.Text = "Zapisz dla aktywnego profilu:";
            // 
            // greenTile
            // 
            this.greenTile.ActiveControl = null;
            this.greenTile.Location = new System.Drawing.Point(124, 121);
            this.greenTile.Name = "greenTile";
            this.greenTile.Size = new System.Drawing.Size(30, 30);
            this.greenTile.Style = MetroFramework.MetroColorStyle.Green;
            this.greenTile.TabIndex = 62;
            this.greenTile.UseSelectable = true;
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Location = new System.Drawing.Point(304, 51);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(20, 19);
            this.opacityLabel.TabIndex = 74;
            this.opacityLabel.Text = " 0";
            // 
            // redTile
            // 
            this.redTile.ActiveControl = null;
            this.redTile.Location = new System.Drawing.Point(412, 121);
            this.redTile.Name = "redTile";
            this.redTile.Size = new System.Drawing.Size(30, 30);
            this.redTile.Style = MetroFramework.MetroColorStyle.Red;
            this.redTile.TabIndex = 70;
            this.redTile.UseSelectable = true;
            // 
            // opacityBreakLabel
            // 
            this.opacityBreakLabel.AutoSize = true;
            this.opacityBreakLabel.Location = new System.Drawing.Point(304, 3);
            this.opacityBreakLabel.Name = "opacityBreakLabel";
            this.opacityBreakLabel.Size = new System.Drawing.Size(174, 19);
            this.opacityBreakLabel.TabIndex = 73;
            this.opacityBreakLabel.Text = "Widoczność okienka przerw:";
            // 
            // limeTile
            // 
            this.limeTile.ActiveControl = null;
            this.limeTile.Location = new System.Drawing.Point(160, 121);
            this.limeTile.Name = "limeTile";
            this.limeTile.Size = new System.Drawing.Size(30, 30);
            this.limeTile.Style = MetroFramework.MetroColorStyle.Lime;
            this.limeTile.TabIndex = 63;
            this.limeTile.UseSelectable = true;
            // 
            // opacityTrackBar
            // 
            this.opacityTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.opacityTrackBar.Location = new System.Drawing.Point(304, 25);
            this.opacityTrackBar.Name = "opacityTrackBar";
            this.opacityTrackBar.Size = new System.Drawing.Size(177, 23);
            this.opacityTrackBar.TabIndex = 72;
            this.opacityTrackBar.Text = "metroTrackBar1";
            this.opacityTrackBar.Value = 100;
            this.opacityTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.opacityTrackBar_Scroll);
            // 
            // tealTile
            // 
            this.tealTile.ActiveControl = null;
            this.tealTile.Location = new System.Drawing.Point(196, 121);
            this.tealTile.Name = "tealTile";
            this.tealTile.Size = new System.Drawing.Size(30, 30);
            this.tealTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.tealTile.TabIndex = 64;
            this.tealTile.UseSelectable = true;
            // 
            // pinkTile
            // 
            this.pinkTile.ActiveControl = null;
            this.pinkTile.Location = new System.Drawing.Point(304, 121);
            this.pinkTile.Name = "pinkTile";
            this.pinkTile.Size = new System.Drawing.Size(30, 30);
            this.pinkTile.Style = MetroFramework.MetroColorStyle.Pink;
            this.pinkTile.TabIndex = 67;
            this.pinkTile.UseSelectable = true;
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Location = new System.Drawing.Point(13, 99);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(57, 19);
            this.styleLabel.TabIndex = 58;
            this.styleLabel.Text = "Akcenty:";
            // 
            // purpleTile
            // 
            this.purpleTile.ActiveControl = null;
            this.purpleTile.Location = new System.Drawing.Point(376, 121);
            this.purpleTile.Name = "purpleTile";
            this.purpleTile.Size = new System.Drawing.Size(30, 30);
            this.purpleTile.Style = MetroFramework.MetroColorStyle.Purple;
            this.purpleTile.TabIndex = 69;
            this.purpleTile.UseSelectable = true;
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Location = new System.Drawing.Point(13, 3);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(30, 19);
            this.themeLabel.TabIndex = 57;
            this.themeLabel.Text = "Tło:";
            // 
            // brownTile
            // 
            this.brownTile.ActiveControl = null;
            this.brownTile.Location = new System.Drawing.Point(268, 121);
            this.brownTile.Name = "brownTile";
            this.brownTile.Size = new System.Drawing.Size(30, 30);
            this.brownTile.Style = MetroFramework.MetroColorStyle.Brown;
            this.brownTile.TabIndex = 66;
            this.brownTile.UseSelectable = true;
            // 
            // changeThemeTile
            // 
            this.changeThemeTile.ActiveControl = null;
            this.changeThemeTile.Location = new System.Drawing.Point(13, 25);
            this.changeThemeTile.Name = "changeThemeTile";
            this.changeThemeTile.Size = new System.Drawing.Size(112, 70);
            this.changeThemeTile.TabIndex = 56;
            this.changeThemeTile.Text = "Zmiana Tła";
            this.changeThemeTile.UseSelectable = true;
            this.changeThemeTile.Click += new System.EventHandler(this.changeThemeTile_Click);
            // 
            // magentaTile
            // 
            this.magentaTile.ActiveControl = null;
            this.magentaTile.Location = new System.Drawing.Point(340, 121);
            this.magentaTile.Name = "magentaTile";
            this.magentaTile.Size = new System.Drawing.Size(30, 30);
            this.magentaTile.Style = MetroFramework.MetroColorStyle.Magenta;
            this.magentaTile.TabIndex = 68;
            this.magentaTile.UseSelectable = true;
            // 
            // orangeTile
            // 
            this.orangeTile.ActiveControl = null;
            this.orangeTile.Location = new System.Drawing.Point(232, 121);
            this.orangeTile.Name = "orangeTile";
            this.orangeTile.Size = new System.Drawing.Size(30, 30);
            this.orangeTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.orangeTile.TabIndex = 65;
            this.orangeTile.UseSelectable = true;
            // 
            // isWorkingLabel
            // 
            this.isWorkingLabel.AutoSize = true;
            this.isWorkingLabel.Location = new System.Drawing.Point(320, 33);
            this.isWorkingLabel.Name = "isWorkingLabel";
            this.isWorkingLabel.Size = new System.Drawing.Size(71, 19);
            this.isWorkingLabel.TabIndex = 6;
            this.isWorkingLabel.Text = "Wyłączony";
            this.isWorkingLabel.UseStyleColors = true;
            // 
            // stopTile
            // 
            this.stopTile.ActiveControl = null;
            this.stopTile.Location = new System.Drawing.Point(463, 33);
            this.stopTile.Name = "stopTile";
            this.stopTile.Size = new System.Drawing.Size(60, 60);
            this.stopTile.TabIndex = 5;
            this.stopTile.Text = "STOP";
            this.stopTile.UseSelectable = true;
            this.stopTile.Click += new System.EventHandler(this.stopTile_Click);
            // 
            // startTile
            // 
            this.startTile.ActiveControl = null;
            this.startTile.Location = new System.Drawing.Point(397, 33);
            this.startTile.Name = "startTile";
            this.startTile.Size = new System.Drawing.Size(60, 60);
            this.startTile.TabIndex = 4;
            this.startTile.Text = "START";
            this.startTile.UseSelectable = true;
            this.startTile.Click += new System.EventHandler(this.startTile_Click);
            // 
            // msmMainWindow
            // 
            this.msmMainWindow.Owner = this;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ForYourEyes";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzForYourEyesToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.zamknijForYourEyesToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(186, 92);
            // 
            // otwórzForYourEyesToolStripMenuItem
            // 
            this.otwórzForYourEyesToolStripMenuItem.Name = "otwórzForYourEyesToolStripMenuItem";
            this.otwórzForYourEyesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.otwórzForYourEyesToolStripMenuItem.Text = "Otwórz ForYourEyes";
            this.otwórzForYourEyesToolStripMenuItem.Click += new System.EventHandler(this.otwórzForYourEyesToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // zamknijForYourEyesToolStripMenuItem
            // 
            this.zamknijForYourEyesToolStripMenuItem.Name = "zamknijForYourEyesToolStripMenuItem";
            this.zamknijForYourEyesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.zamknijForYourEyesToolStripMenuItem.Text = "Zamknij ForYourEyes";
            this.zamknijForYourEyesToolStripMenuItem.Click += new System.EventHandler(this.zamknijForYourEyesToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.isWorkingLabel);
            this.Controls.Add(this.stopTile);
            this.Controls.Add(this.startTile);
            this.Controls.Add(this.windowTabControl);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "ForYourEyes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.windowTabControl.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            this.breaksTabPage.ResumeLayout(false);
            this.breaksTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editBreakPictureBox)).EndInit();
            this.viewSoundTabPage.ResumeLayout(false);
            this.viewSoundTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMainWindow)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl windowTabControl;
        private MetroFramework.Controls.MetroTabPage settingsTabPage;
        private MetroFramework.Controls.MetroButton setDefaultButton;
        private MetroFramework.Controls.MetroButton saveSettingButton;
        private MetroFramework.Controls.MetroLabel settingInformationLabel;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel durationShortBreakLabel;
        private MetroFramework.Controls.MetroTextBox durationLongBreakTextBox;
        private MetroFramework.Controls.MetroLabel durationLongBreakLabel;
        private MetroFramework.Controls.MetroTextBox distanceLongBreakTextBox;
        private MetroFramework.Controls.MetroLabel distanceLongBreakLabel;
        private MetroFramework.Controls.MetroLabel quantityShortBreaksLabel;
        private MetroFramework.Controls.MetroTextBox durationShortBreakTextBox;
        private MetroFramework.Controls.MetroTextBox quantityShortBreaksTextBox;
        private MetroFramework.Controls.MetroButton addProfileButton;
        private MetroFramework.Controls.MetroTextBox addProfileTextBox;
        private MetroFramework.Controls.MetroButton deleteProfileButton;
        private MetroFramework.Controls.MetroButton showAddProfileButton;
        private MetroFramework.Controls.MetroComboBox profilesComboBox;
        private MetroFramework.Controls.MetroLabel profilLabel;
        private MetroFramework.Controls.MetroTabPage breaksTabPage;
        private MetroFramework.Controls.MetroButton nextPictureButton;
        private MetroFramework.Controls.MetroButton previousPictureButton;
        private MetroFramework.Controls.MetroLabel choosePictureLabel;
        private MetroFramework.Controls.MetroButton deleteBreakButton;
        private System.Windows.Forms.ListBox breaksListBox;
        private MetroFramework.Controls.MetroButton editBreakButton;
        private MetroFramework.Controls.MetroTextBox editBreakTextBox;
        private MetroFramework.Controls.MetroLabel editBreakLabel;
        private System.Windows.Forms.PictureBox editBreakPictureBox;
        private MetroFramework.Controls.MetroButton addNewBreakButton;
        private MetroFramework.Controls.MetroTextBox newBreakInstructionTextBox;
        private MetroFramework.Controls.MetroLabel newBreakLabel;
        private MetroFramework.Controls.MetroTabPage viewSoundTabPage;
        private MetroFramework.Controls.MetroLabel soundLabel;
        private MetroFramework.Controls.MetroCheckBox soundCheckBox;
        private MetroFramework.Controls.MetroTile yellowTile;
        private MetroFramework.Controls.MetroButton saveViewSoundAllButton;
        private MetroFramework.Controls.MetroButton saveViewSoundOneButton;
        private MetroFramework.Controls.MetroTile blackTile;
        private MetroFramework.Controls.MetroTile silverTile;
        private MetroFramework.Controls.MetroLabel saveViewSoundForAllLabel;
        private MetroFramework.Controls.MetroTile blueTile;
        private MetroFramework.Controls.MetroLabel saveViewSoundForOneLabel;
        private MetroFramework.Controls.MetroTile greenTile;
        private MetroFramework.Controls.MetroLabel opacityLabel;
        private MetroFramework.Controls.MetroTile redTile;
        private MetroFramework.Controls.MetroLabel opacityBreakLabel;
        private MetroFramework.Controls.MetroTile limeTile;
        private MetroFramework.Controls.MetroTrackBar opacityTrackBar;
        private MetroFramework.Controls.MetroTile tealTile;
        private MetroFramework.Controls.MetroTile pinkTile;
        private MetroFramework.Controls.MetroLabel styleLabel;
        private MetroFramework.Controls.MetroTile purpleTile;
        private MetroFramework.Controls.MetroLabel themeLabel;
        private MetroFramework.Controls.MetroTile brownTile;
        private MetroFramework.Controls.MetroTile changeThemeTile;
        private MetroFramework.Controls.MetroTile magentaTile;
        private MetroFramework.Controls.MetroTile orangeTile;
        private MetroFramework.Controls.MetroLabel isWorkingLabel;
        private MetroFramework.Controls.MetroTile stopTile;
        private MetroFramework.Controls.MetroTile startTile;
        private MetroFramework.Components.MetroStyleManager msmMainWindow;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroContextMenu contextMenu;
        private System.Windows.Forms.ToolStripMenuItem otwórzForYourEyesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijForYourEyesToolStripMenuItem;
        private MetroFramework.Controls.MetroCheckBox startWithWindowsCheckBox;
    }
}

