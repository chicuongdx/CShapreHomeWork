
namespace buoi11
{
    partial class FrmMic
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
            this.pctVoice = new System.Windows.Forms.PictureBox();
            this.lbAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoice)).BeginInit();
            this.SuspendLayout();
            // 
            // pctVoice
            // 
            this.pctVoice.BackgroundImage = global::buoi11.Properties.Resources._1055024_mic_audio_microphone_icon;
            this.pctVoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctVoice.Location = new System.Drawing.Point(25, 26);
            this.pctVoice.Name = "pctVoice";
            this.pctVoice.Size = new System.Drawing.Size(40, 40);
            this.pctVoice.TabIndex = 0;
            this.pctVoice.TabStop = false;
            this.pctVoice.Click += new System.EventHandler(this.pctVoice_Click);
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.BackColor = System.Drawing.Color.Transparent;
            this.lbAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(57)))), ((int)(((byte)(17)))));
            this.lbAbout.Location = new System.Drawing.Point(71, 41);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(164, 15);
            this.lbAbout.TabIndex = 1;
            this.lbAbout.Text = "Hello It\'s AnimeSub.com";
            // 
            // FrmMic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(248, 92);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.pctVoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice";
            ((System.ComponentModel.ISupportInitialize)(this.pctVoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctVoice;
        private System.Windows.Forms.Label lbAbout;
    }
}