using ForYourEyes.CoreFunctionality;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace ForYourEyes
{
    public partial class BreakWindow : MetroForm
    {
        private int counter = 0;
        public BreakWindow()
        {
            InitializeComponent();
        }

        private void Initialize(string instruction, ApplicationLook applicationLook, Sound sound)
        {
            this.StyleManager = msmBreakWindow;
            this.Opacity = ((double)(applicationLook.WindowOpacity) / 100.0);
            msmBreakWindow.Theme = applicationLook.Theme;
            msmBreakWindow.Style = applicationLook.Style;
            counterLabel.Theme = applicationLook.Theme;
            counterLabel.Style = applicationLook.Style;
            if (sound.SoundEnabled)
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(@"Sounds\BreakWindow.wav");
                    player.Play();
                }
                catch
                {
                }
            }
            this.Text = instruction;

            if (((TextRenderer.MeasureText(this.Text, SystemFonts.CaptionFont).Width) * 2 + this.Padding.Horizontal) < this.Size.Width)
            {
                this.Width = this.Size.Width;
            }
            else this.Width = (TextRenderer.MeasureText(this.Text, SystemFonts.CaptionFont).Width) * 2 + this.Padding.Horizontal;
            breakPictureBox.Location = new Point(this.Width / 2 - breakPictureBox.Width / 2, breakPictureBox.Location.Y);
        }

        public BreakWindow(string instruction, string imagePath, int time, ApplicationLook applicationLook, Sound sound)
        {
            InitializeComponent();
            Initialize(instruction, applicationLook, sound);

            try
            {
                this.breakPictureBox.Image = Image.FromFile(@"Images\" + imagePath + ".gif");
            }
            catch
            {
                breakPictureBox.Image = null;
            }

            breakTimer.Interval = 1000 * time;
            breakTimer.Tick += new EventHandler(breakTimer_Tick);
            breakTimer.Start();
            counter = time;
            counterTimerWork();
        }

        public BreakWindow(string instruction, int time, ApplicationLook applicationLook, Sound sound)
        {
            InitializeComponent();
            Initialize(instruction, applicationLook, sound);

            try
            {
                breakPictureBox.Image = Image.FromFile(@"Images\0.gif");
            }
            catch
            {
                breakPictureBox.Image = null;
            }
            
            breakTimer.Interval = 60000 * time;
            breakTimer.Tick += new EventHandler(breakTimer_Tick);
            breakTimer.Start();
            counter = 60 * time;
            counterTimerWork();
        }

        void breakTimer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void counterTimerWork()
        {
            counterTimer.Tick += new EventHandler(timer2_Tick);
            counterTimer.Interval = 1000; // 1 second
            counterTimer.Start();
            counterLabel.Text = counter.ToString();
        }

        void timer2_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                breakPictureBox.Dispose();
                counterTimer.Stop();
            }
            counterLabel.Text = counter.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            breakTimer.Stop();
            this.Close();
        }
    }
}
