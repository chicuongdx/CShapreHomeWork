
namespace buoi12
{
    partial class FrmStory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStory));
            this.pnlVoice = new System.Windows.Forms.Panel();
            this.pctMute = new System.Windows.Forms.PictureBox();
            this.pctVoice = new System.Windows.Forms.PictureBox();
            this.pctStory = new System.Windows.Forms.PictureBox();
            this.pnlVoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctStory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVoice
            // 
            this.pnlVoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(75)))), ((int)(((byte)(81)))));
            this.pnlVoice.Controls.Add(this.pctMute);
            this.pnlVoice.Controls.Add(this.pctVoice);
            this.pnlVoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVoice.Location = new System.Drawing.Point(0, 0);
            this.pnlVoice.Name = "pnlVoice";
            this.pnlVoice.Size = new System.Drawing.Size(416, 50);
            this.pnlVoice.TabIndex = 0;
            // 
            // pctMute
            // 
            this.pctMute.BackgroundImage = global::buoi12.Properties.Resources.UnMic;
            this.pctMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctMute.Dock = System.Windows.Forms.DockStyle.Right;
            this.pctMute.Location = new System.Drawing.Point(366, 0);
            this.pctMute.Name = "pctMute";
            this.pctMute.Size = new System.Drawing.Size(50, 50);
            this.pctMute.TabIndex = 1;
            this.pctMute.TabStop = false;
            this.pctMute.Click += new System.EventHandler(this.pctMute_Click);
            // 
            // pctVoice
            // 
            this.pctVoice.BackgroundImage = global::buoi12.Properties.Resources.mic;
            this.pctVoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctVoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctVoice.Location = new System.Drawing.Point(0, 0);
            this.pctVoice.Name = "pctVoice";
            this.pctVoice.Size = new System.Drawing.Size(50, 50);
            this.pctVoice.TabIndex = 0;
            this.pctVoice.TabStop = false;
            this.pctVoice.Click += new System.EventHandler(this.pctVoice_Click);
            // 
            // pctStory
            // 
            this.pctStory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctStory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctStory.Location = new System.Drawing.Point(0, 50);
            this.pctStory.Name = "pctStory";
            this.pctStory.Size = new System.Drawing.Size(416, 182);
            this.pctStory.TabIndex = 1;
            this.pctStory.TabStop = false;
            // 
            // FrmStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 232);
            this.Controls.Add(this.pctStory);
            this.Controls.Add(this.pnlVoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStory";
            this.Text = "FrmStory";
            this.pnlVoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctStory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVoice;
        private System.Windows.Forms.PictureBox pctVoice;
        private System.Windows.Forms.PictureBox pctMute;
        public System.Windows.Forms.PictureBox pctStory;
    }
}