using ForYourEyes.CoreFunctionality;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.IO;

namespace ForYourEyes
{
    public partial class MainWindow : MetroForm
    {
        List<Profile> Profiles = new List<Profile>();
        List<Break> Breaks = new List<Break>();
        ProfileFileManager pfm = new ProfileFileManager();
        FullScreen fs = new FullScreen();
        Random rnd = new Random();
        const int PictureCount = 4; //ilosc dostepnych obrazkow
        int PictureEditShow = 0; //obrazek w edit
        int Counter = 0;
        int ActiveProfileNumber = 0;
        bool IsWorking = false;

        public MainWindow()
        {
            pfm = pfm.Read();
            ActiveProfileNumber = pfm.ActiveProfileNumber;
            Profiles = pfm.Profiles;

            InitializeComponent();
            InitializeStartWithWindows();
            InitializeMetroComboBox();
            InitializeMetroTextBoxes();
            InitializeApplicationLook();
            notifyIcon.Visible = false;
            this.mainTimer.Tick += (object s, EventArgs a) => mainTimer_Tick(s, a, Profiles[ActiveProfileNumber]);
            StartForYourEyes(Profiles[ActiveProfileNumber]);
        }

        #region Settings

        private void InitializeMetroTextBoxes()
        {
            this.quantityShortBreaksTextBox.TextChanged += new System.EventHandler(quantityShortBreaksTextBox_TextChanged);
            this.durationShortBreakTextBox.TextChanged += new System.EventHandler(quantityShortBreaksTextBox_TextChanged);
            this.distanceLongBreakTextBox.TextChanged += new System.EventHandler(quantityShortBreaksTextBox_TextChanged);
            this.durationLongBreakTextBox.TextChanged += new System.EventHandler(quantityShortBreaksTextBox_TextChanged);
        }

        private void quantityShortBreaksTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckSetting();
        }

        private void CheckSetting()
        {
            int myInt;
            if ((int.TryParse(quantityShortBreaksTextBox.Text, out myInt) && (myInt > 0)) &&
                (int.TryParse(durationShortBreakTextBox.Text, out myInt) && (myInt > 0)) &&
                (int.TryParse(distanceLongBreakTextBox.Text, out myInt) && (myInt > 0)) &&
                (int.TryParse(durationLongBreakTextBox.Text, out myInt) && (myInt > 0)))
            {
                if ((Convert.ToInt32(quantityShortBreaksTextBox.Text) + 1) * Convert.ToInt32(durationShortBreakTextBox.Text) > Convert.ToInt32(distanceLongBreakTextBox.Text) * 60)
                {
                    settingInformationLabel.Text = "Za krótki czas oczekiwania na długą przerwę!";
                    saveSettingButton.Enabled = false;
                }
                else
                {
                    saveSettingButton.Enabled = true;
                    settingInformationLabel.Text = "";
                }
            }
            else
            {
                settingInformationLabel.Text = "Źle uzupełnione wartości";
                saveSettingButton.Enabled = false;
            }
        }

        void SettingsRefresh()
        {
            quantityShortBreaksTextBox.Text = Profiles[ActiveProfileNumber].Settings.QuantityShortBreaks.ToString();
            durationShortBreakTextBox.Text = Profiles[ActiveProfileNumber].Settings.DurationShortBreak.ToString();
            distanceLongBreakTextBox.Text = Profiles[ActiveProfileNumber].Settings.DistanceLongBreak.ToString();
            durationLongBreakTextBox.Text = Profiles[ActiveProfileNumber].Settings.DurationLongBreak.ToString();
        }

        private void saveSettingButton_Click(object sender, EventArgs e)
        {
            Profiles[ActiveProfileNumber].Settings.QuantityShortBreaks = Convert.ToInt32(quantityShortBreaksTextBox.Text);
            Profiles[ActiveProfileNumber].Settings.DurationShortBreak = Convert.ToInt32(durationShortBreakTextBox.Text);
            Profiles[ActiveProfileNumber].Settings.DistanceLongBreak = Convert.ToInt32(distanceLongBreakTextBox.Text);
            Profiles[ActiveProfileNumber].Settings.DurationLongBreak = Convert.ToInt32(durationLongBreakTextBox.Text);
            pfm.Save(ActiveProfileNumber, Profiles);
            StopForYourEyes();
            StartForYourEyes(Profiles[ActiveProfileNumber]);
        }
        #endregion

        #region Profiles

        private void InitializeMetroComboBox()
        {
            profilesComboBox.DataSource = null;
            profilesComboBox.Items.Clear();
            foreach (var item in Profiles)
            {
                profilesComboBox.Items.Add(item.Name);
            }
            profilesComboBox.SelectedIndex = ActiveProfileNumber;
            AllTabsRefresh();
            this.profilesComboBox.SelectedIndexChanged += new System.EventHandler(profilesComboBox_SelectedIndexChanged);
        }

        void AllTabsRefresh()
        {
            SettingsRefresh();
            BreaksRefresh();
            ApplicationViewSoundRefresh();
        }

        private void profilesComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            StopForYourEyes();
            ActiveProfileNumber = profilesComboBox.SelectedIndex;
            AllTabsRefresh();
            CheckSetting();
        }

        private void showAddProfileButton_Click(object sender, EventArgs e)
        {
            if (addProfileTextBox.Visible == false)
                ShowAddProfile();
            else HideAddProfile();
        }

        private void ShowAddProfile()
        {
            addProfileTextBox.Visible = true;
            addProfileButton.Visible = true;
        }

        private void HideAddProfile()
        {
            addProfileTextBox.Visible = false;
            addProfileButton.Visible = false;
        }

        private void addProfileButton_Click(object sender, EventArgs e)
        {
            Profiles.Add(new Profile(addProfileTextBox.Text,
                new Settings(4, 10, 55, 5),
                new List<Break>{
                    new Break("Zamknij oczy.", "1"), 
                    new Break("Przesuwaj oczy w prawo i lewo.", "2"),
                    new Break("Zamrugaj kilka razy.", "3"),
                    new Break("Skoncentruj wzrok na dalekim obiekcie (np. za oknem)", "4")},
                new ApplicationLook(MetroThemeStyle.Light, MetroColorStyle.Blue, 75),
                new Sound(true)));
            HideAddProfile();
            InitializeMetroComboBox();
            profilesComboBox.SelectedIndex = Profiles.Count - 1;
        }

        private void deleteProfileButton_Click(object sender, EventArgs e)
        {
            if (profilesComboBox.SelectedIndex != 0)
            {
                Profiles.RemoveAt(profilesComboBox.SelectedIndex);
                profilesComboBox.SelectedIndex = 0;
                InitializeMetroComboBox();
            }
            else MetroMessageBox.Show(this, "Nie możesz usunąć profilu domyślnego.", "ForYourEyes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            pfm.Save(ActiveProfileNumber, Profiles);
        }

        private void setDefaultButton_Click(object sender, EventArgs e)
        {
            Profiles[ActiveProfileNumber].Settings.QuantityShortBreaks = 4;
            Profiles[ActiveProfileNumber].Settings.DurationShortBreak = 10;
            Profiles[ActiveProfileNumber].Settings.DistanceLongBreak = 55;
            Profiles[ActiveProfileNumber].Settings.DurationLongBreak = 5;
            Profiles[ActiveProfileNumber].Breaks.Clear();
            Profiles[ActiveProfileNumber].Breaks.Add(new Break("Zamknij oczy.", "1"));
            Profiles[ActiveProfileNumber].Breaks.Add(new Break("Przesuwaj oczy w prawo i lewo.", "2"));
            Profiles[ActiveProfileNumber].Breaks.Add(new Break("Zamrugaj kilka razy.", "3"));
            Profiles[ActiveProfileNumber].Breaks.Add(new Break("Skoncentruj wzrok na dalekim obiekcie (np. za oknem)", "4"));
            Profiles[ActiveProfileNumber].ApplicationLook.Theme = MetroThemeStyle.Light;
            Profiles[ActiveProfileNumber].ApplicationLook.Style = MetroColorStyle.Blue;
            Profiles[ActiveProfileNumber].ApplicationLook.WindowOpacity = 75;
            Profiles[ActiveProfileNumber].Sound.SoundEnabled = true;

            AllTabsRefresh();
        }

        #endregion

        #region Breaks

        public void BreaksRefresh()
        {
            breaksListBox.Items.Clear();
            foreach (var item in Profiles[ActiveProfileNumber].Breaks)
            {
                breaksListBox.Items.Add(item.Instruction);
            }
        }

        private void breaksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PictureEditShow = Convert.ToInt32(Profiles[ActiveProfileNumber].Breaks[breaksListBox.SelectedIndex].ImagePath);
                editBreakTextBox.Text = breaksListBox.SelectedItem.ToString();
                editBreakPictureBox.Image = Image.FromFile(@"Images\" + Profiles[ActiveProfileNumber].Breaks[breaksListBox.SelectedIndex].ImagePath + ".gif");
            }
            catch
            {
                editBreakPictureBox.Image = null;
            }
        }

        private void previousPictureButton_Click(object sender, EventArgs e)
        {
            if (breaksListBox.SelectedItems.Count == 1)
            {
                if (PictureEditShow == 0)
                {
                    PictureEditShow = PictureCount;
                    editBreakPictureShow(PictureEditShow);
                }
                else
                {
                    PictureEditShow -= 1;
                    editBreakPictureShow(PictureEditShow);
                }
            }
        }

        private void nextPictureButton_Click(object sender, EventArgs e)
        {
            if (breaksListBox.SelectedItems.Count == 1)
            {
                if (PictureEditShow == PictureCount)
                {
                    PictureEditShow = 0;
                    editBreakPictureShow(PictureEditShow);
                }
                else
                {
                    PictureEditShow += 1;
                    editBreakPictureShow(PictureEditShow);
                }
            }
        }

        private void editBreakPictureShow(int PictureEditShow)
        {
            try
            {
                editBreakPictureBox.Image = Image.FromFile(@"Images\" + PictureEditShow.ToString() + ".gif");
            }
            catch
            {
                editBreakPictureBox.Image = null;
            }
        }

        private void editBreakButton_Click(object sender, EventArgs e)
        {
            if (breaksListBox.SelectedItems.Count == 1)
            {
                Profiles[ActiveProfileNumber].Breaks[breaksListBox.SelectedIndex].Instruction = editBreakTextBox.Text;
                Profiles[ActiveProfileNumber].Breaks[breaksListBox.SelectedIndex].ImagePath = PictureEditShow.ToString();
                editBreakTextBox.Text = "";
                BreaksRefresh();
                PictureEditShow = 0;
                pfm.Save(ActiveProfileNumber, Profiles);
            }
        }

        private void addNewBreakButton_Click(object sender, EventArgs e)
        {
            if (newBreakInstructionTextBox.Text != "")
            {
                Profiles[ActiveProfileNumber].Breaks.Add(new Break(newBreakInstructionTextBox.Text, "0"));
                newBreakInstructionTextBox.Text = "";
                editBreakTextBox.Text = "";
                BreaksRefresh();
                pfm.Save(ActiveProfileNumber, Profiles);
            }
            else MetroMessageBox.Show(this, "Brak tekstu instrukcji.", "ForYourEyes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deleteBreakButton_Click(object sender, EventArgs e)
        {
            if (breaksListBox.SelectedItems.Count == 1 && Profiles[ActiveProfileNumber].Breaks.Count != 1)
            {
                Profiles[ActiveProfileNumber].Breaks.RemoveAt(breaksListBox.SelectedIndex);
                pfm.Save(ActiveProfileNumber, Profiles);
                editBreakTextBox.Text = "";
                BreaksRefresh();
            }
            else
            {
                if (breaksListBox.SelectedIndex == 0)
                {
                    MetroMessageBox.Show(this, "Nie możesz usunąć wszystkich przerw!", "ForYourEyes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MetroMessageBox.Show(this, "Musisz wybrać przerwę by ją usunąć", "ForYourEyes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region ApplicationLookAndSound

        public void InitializeApplicationLook()
        {
            this.StyleManager = msmMainWindow;

            opacityTrackBar.Value = Profiles[ActiveProfileNumber].ApplicationLook.WindowOpacity;
            opacityLabel.Text = opacityTrackBar.Value.ToString() + " %";

            SoundCheck();

            blackTile.Click += new EventHandler(MyButtonClick);
            silverTile.Click += new EventHandler(MyButtonClick);
            blueTile.Click += new EventHandler(MyButtonClick);
            greenTile.Click += new EventHandler(MyButtonClick);
            limeTile.Click += new EventHandler(MyButtonClick);
            tealTile.Click += new EventHandler(MyButtonClick);
            orangeTile.Click += new EventHandler(MyButtonClick);
            brownTile.Click += new EventHandler(MyButtonClick);
            pinkTile.Click += new EventHandler(MyButtonClick);
            magentaTile.Click += new EventHandler(MyButtonClick);
            purpleTile.Click += new EventHandler(MyButtonClick);
            redTile.Click += new EventHandler(MyButtonClick);
            yellowTile.Click += new EventHandler(MyButtonClick);
        }

        private void SoundCheck()
        {
            if (Profiles[ActiveProfileNumber].Sound.SoundEnabled)
            {
                soundCheckBox.CheckState = CheckState.Checked;
                soundCheckBox.Text = "Dźwięk włączony";
            }
            else
            {
                soundCheckBox.CheckState = CheckState.Unchecked;
                soundCheckBox.Text = "Dźwięk wyłączony";
            }
        }

        Dictionary<string, MetroColorStyle> Styles = new Dictionary<string, MetroColorStyle>()
            {
                {"blackTile",MetroColorStyle.Black },
                {"silverTile",MetroColorStyle.Silver },
                {"blueTile",MetroColorStyle.Blue },
                {"greenTile",MetroColorStyle.Green},
                {"limeTile",MetroColorStyle.Lime },
                {"tealTile",MetroColorStyle.Teal},
                {"orangeTile",MetroColorStyle.Orange},
                {"brownTile",MetroColorStyle.Brown},
                {"pinkTile",MetroColorStyle.Pink},
                {"magentaTile",MetroColorStyle.Magenta},
                {"purpleTile",MetroColorStyle.Purple},
                {"redTile",MetroColorStyle.Red},
                {"yellowTile",MetroColorStyle.Yellow},
            };

        public void MyButtonClick(object sender, EventArgs e)
        {
            msmMainWindow.Style = Styles[(sender as Button).Name];
        }

        public void ApplicationViewSoundRefresh()
        {
            msmMainWindow.Theme = Profiles[ActiveProfileNumber].ApplicationLook.Theme;
            msmMainWindow.Style = Profiles[ActiveProfileNumber].ApplicationLook.Style;
            opacityTrackBar.Value = Profiles[ActiveProfileNumber].ApplicationLook.WindowOpacity;
            opacityLabel.Text = opacityTrackBar.Value.ToString();
            SoundCheck();
        }

        private void changeThemeTile_Click(object sender, EventArgs e)
        {
            msmMainWindow.Theme = msmMainWindow.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }

        private void saveViewSoundOneButton_Click(object sender, EventArgs e)
        {
            Profiles[ActiveProfileNumber].ApplicationLook.Theme = msmMainWindow.Theme;
            Profiles[ActiveProfileNumber].ApplicationLook.Style = msmMainWindow.Style;
            Profiles[ActiveProfileNumber].ApplicationLook.WindowOpacity = opacityTrackBar.Value;
            Profiles[ActiveProfileNumber].Sound.SoundEnabled = soundCheckBox.Checked;
            pfm.Save(ActiveProfileNumber, Profiles);
        }

        private void saveViewSoundAllButton_Click(object sender, EventArgs e)
        {
            foreach (var item in Profiles)
            {
                item.ApplicationLook.Theme = msmMainWindow.Theme;
                item.ApplicationLook.Style = msmMainWindow.Style;
                item.ApplicationLook.WindowOpacity = opacityTrackBar.Value;
                item.Sound.SoundEnabled = soundCheckBox.Checked;
            }
            pfm.Save(ActiveProfileNumber, Profiles);
        }

        private void opacityTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            opacityLabel.Text = opacityTrackBar.Value.ToString() + " %";
        }

        private void soundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (soundCheckBox.CheckState == CheckState.Checked)
            {
                soundCheckBox.Text = "Dźwięk włączony";
            }
            else
            {
                soundCheckBox.Text = "Dźwięk wyłączony";
            }
        }

        #endregion

        #region ForYourEyes

        private void StartForYourEyes(Profile activeProfile)
        {
            if (!IsWorking)
            {
                IsWorking = true;
                Counter = 0;
                //1s = 1000ms 
                mainTimer.Interval = (activeProfile.Settings.DistanceLongBreak * 60 / (activeProfile.Settings.QuantityShortBreaks + 1)) * 1000;
                mainTimer.Enabled = true;

                isWorkingLabel.Text = "Włączony";
            }
        }

        private void mainTimer_Tick(object sender, System.EventArgs e, Profile activeProfile)
        {
            if (!fs.isFullScreen())
            {
                if (Counter == 0)
                {
                    mainTimer.Interval = (activeProfile.Settings.DistanceLongBreak * 60 / (activeProfile.Settings.QuantityShortBreaks + 1)) * 1000;
                    int NumberBreak = rnd.Next(0, activeProfile.Breaks.Count);
                    BreakWindow breakWindow = new BreakWindow(activeProfile.Breaks[NumberBreak].Instruction, activeProfile.Breaks[NumberBreak].ImagePath, activeProfile.Settings.DurationShortBreak, activeProfile.ApplicationLook, activeProfile.Sound);
                    breakWindow.TopMost = true;
                    breakWindow.Show();
                    Counter = Counter + 1;
                }
                else
                {
                    if (Counter == activeProfile.Settings.QuantityShortBreaks)
                    {
                        mainTimer.Interval += activeProfile.Settings.DurationLongBreak * 60000;
                        BreakWindow breakWindow = new BreakWindow("DŁUGA PRZERWA", activeProfile.Settings.DurationLongBreak, activeProfile.ApplicationLook, activeProfile.Sound);
                        breakWindow.TopMost = true;
                        breakWindow.Show();
                        Counter = 0;
                    }
                    else
                    {
                        int NumberBreak = rnd.Next(0, activeProfile.Breaks.Count);
                        BreakWindow breakWindow = new BreakWindow(activeProfile.Breaks[NumberBreak].Instruction, activeProfile.Breaks[NumberBreak].ImagePath, activeProfile.Settings.DurationShortBreak, activeProfile.ApplicationLook, activeProfile.Sound);
                        breakWindow.TopMost = true;
                        breakWindow.Show();
                        Counter = Counter + 1;
                    }
                }
            }
        }

        private void StopForYourEyes()
        {
            if (IsWorking)
            {
                IsWorking = false;
                Counter = 0;
                this.mainTimer.Stop();
                if (Application.OpenForms.OfType<BreakWindow>().Any())
                {
                    Application.OpenForms.OfType<BreakWindow>().First().Close();
                }
                isWorkingLabel.Text = "Wyłączony";
            }
        }

        #endregion

        #region Tray

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
                this.Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void otwórzForYourEyesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartForYourEyes(Profiles[ActiveProfileNumber]);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopForYourEyes();
        }

        private void zamknijForYourEyesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            try
            {
                Application.Exit();
            }
            catch
            {
            }
            

        }
        private void CloseForYourEyes()
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MetroMessageBox.Show(this, "Nastąpi wyłączenie aplikacji", "Czy na pewno chcesz wyjść?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region StartStopAtWindow

        private void startTile_Click(object sender, EventArgs e)
        {
            StartForYourEyes(Profiles[ActiveProfileNumber]);
        }

        private void stopTile_Click(object sender, EventArgs e)
        {
            StopForYourEyes();
        }

        #endregion

        #region StartWithWindows

        public void InitializeStartWithWindows()
        {
            string folderAutostart = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string shortcutAddress = folderAutostart + @"\ForYorEyes.lnk";
            if (System.IO.File.Exists(shortcutAddress))
                startWithWindowsCheckBox.CheckState = CheckState.Checked;
            else
                startWithWindowsCheckBox.CheckState = CheckState.Unchecked;

        }

        private void SetStartWithWindows()
        {
            try
            {
                string folderAutostart = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                WshShell shell = new WshShell();
                string shortcutAddress = folderAutostart + @"\ForYorEyes.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.WorkingDirectory = Application.StartupPath; // katalog roboczy
                shortcut.TargetPath = Application.ExecutablePath; // ścieżka do pliku exe
                shortcut.Save();
            }
            catch { }
        }
        private void DeleteStartWithWindows()
        {
            try
            {
                string folderAutostart = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                string shortcutAddress = folderAutostart + @"\ForYorEyes.lnk"; // nazwa naszego skrótu
                if(System.IO.File.Exists(shortcutAddress)) 
                 System.IO.File.Delete(shortcutAddress);

            }
            catch { }
        }
        
        private void startWithWindowsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (startWithWindowsCheckBox.CheckState == CheckState.Checked)
                SetStartWithWindows();
            else
                DeleteStartWithWindows();
        }

        #endregion





    }
}
