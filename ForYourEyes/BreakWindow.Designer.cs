namespace ForYourEyes
{
    partial class BreakWindow
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
            this.counterLabel = new MetroFramework.Controls.MetroLabel();
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.breakPictureBox = new System.Windows.Forms.PictureBox();
            this.msmBreakWindow = new MetroFramework.Components.MetroStyleManager(this.components);
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            this.counterTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.breakPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmBreakWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // counterLabel
            // 
            this.counterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(6, 176);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(16, 19);
            this.counterLabel.TabIndex = 5;
            this.counterLabel.Text = "0";
            this.counterLabel.UseStyleColors = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(24, 151);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(167, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Wyłącz";
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // breakPictureBox
            // 
            this.breakPictureBox.Location = new System.Drawing.Point(23, 63);
            this.breakPictureBox.Name = "breakPictureBox";
            this.breakPictureBox.Size = new System.Drawing.Size(170, 75);
            this.breakPictureBox.TabIndex = 3;
            this.breakPictureBox.TabStop = false;
            // 
            // msmBreakWindow
            // 
            this.msmBreakWindow.Owner = null;
            // 
            // BreakWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 198);
            this.ControlBox = false;
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.breakPictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BreakWindow";
            this.Resizable = false;
            this.Text = "BreakWindow";
            ((System.ComponentModel.ISupportInitialize)(this.breakPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmBreakWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel counterLabel;
        private MetroFramework.Controls.MetroButton closeButton;
        private System.Windows.Forms.PictureBox breakPictureBox;
        private MetroFramework.Components.MetroStyleManager msmBreakWindow;
        private System.Windows.Forms.Timer breakTimer;
        private System.Windows.Forms.Timer counterTimer;
    }
}