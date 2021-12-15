
namespace buoi11
{
    partial class FrmFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilm));
            this.WMDFilm = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlayListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pctAddMusic = new System.Windows.Forms.PictureBox();
            this.pctAddPlayList = new System.Windows.Forms.PictureBox();
            this.lstBoxMusic = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewPlayList = new System.Windows.Forms.ListView();
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WMDFilm)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddPlayList)).BeginInit();
            this.SuspendLayout();
            // 
            // WMDFilm
            // 
            this.WMDFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WMDFilm.Enabled = true;
            this.WMDFilm.Location = new System.Drawing.Point(0, 24);
            this.WMDFilm.Name = "WMDFilm";
            this.WMDFilm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMDFilm.OcxState")));
            this.WMDFilm.Size = new System.Drawing.Size(576, 531);
            this.WMDFilm.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createPlayListToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fIleToolStripMenuItem.Text = "Home";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // createPlayListToolStripMenuItem
            // 
            this.createPlayListToolStripMenuItem.Name = "createPlayListToolStripMenuItem";
            this.createPlayListToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.createPlayListToolStripMenuItem.Text = "Create PlayList";
            this.createPlayListToolStripMenuItem.Click += new System.EventHandler(this.createPlayListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMenu.Controls.Add(this.pctAddMusic);
            this.pnlMenu.Controls.Add(this.pctAddPlayList);
            this.pnlMenu.Controls.Add(this.lstBoxMusic);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lstViewPlayList);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(577, 24);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(223, 531);
            this.pnlMenu.TabIndex = 2;
            // 
            // pctAddMusic
            // 
            this.pctAddMusic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctAddMusic.BackgroundImage = global::buoi11.Properties.Resources._32378_add_plus_icon;
            this.pctAddMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctAddMusic.Location = new System.Drawing.Point(176, 275);
            this.pctAddMusic.Name = "pctAddMusic";
            this.pctAddMusic.Size = new System.Drawing.Size(35, 35);
            this.pctAddMusic.TabIndex = 3;
            this.pctAddMusic.TabStop = false;
            this.pctAddMusic.Click += new System.EventHandler(this.pctAddMusic_Click);
            // 
            // pctAddPlayList
            // 
            this.pctAddPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctAddPlayList.BackgroundImage = global::buoi11.Properties.Resources._32378_add_plus_icon;
            this.pctAddPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctAddPlayList.Location = new System.Drawing.Point(176, 3);
            this.pctAddPlayList.Name = "pctAddPlayList";
            this.pctAddPlayList.Size = new System.Drawing.Size(35, 35);
            this.pctAddPlayList.TabIndex = 3;
            this.pctAddPlayList.TabStop = false;
            this.pctAddPlayList.Click += new System.EventHandler(this.pctAddPlayList_Click);
            // 
            // lstBoxMusic
            // 
            this.lstBoxMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxMusic.FormattingEnabled = true;
            this.lstBoxMusic.Location = new System.Drawing.Point(3, 316);
            this.lstBoxMusic.Name = "lstBoxMusic";
            this.lstBoxMusic.Size = new System.Drawing.Size(217, 212);
            this.lstBoxMusic.TabIndex = 2;
            this.lstBoxMusic.SelectedIndexChanged += new System.EventHandler(this.lstBoxMusic_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Video";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PlayList";
            // 
            // lstViewPlayList
            // 
            this.lstViewPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstViewPlayList.HideSelection = false;
            this.lstViewPlayList.Location = new System.Drawing.Point(3, 44);
            this.lstViewPlayList.Name = "lstViewPlayList";
            this.lstViewPlayList.Size = new System.Drawing.Size(217, 226);
            this.lstViewPlayList.TabIndex = 0;
            this.lstViewPlayList.UseCompatibleStateImageBehavior = false;
            this.lstViewPlayList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstViewPlayList_ItemSelectionChanged);
            // 
            // imgLst
            // 
            this.imgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst.ImageStream")));
            this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLst.Images.SetKeyName(0, "4105577_audio_melody_music_sound_icon.png");
            this.imgLst.Images.SetKeyName(1, "7857193_soundcloud_music_sound_audio_icon.png");
            // 
            // FrmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.WMDFilm);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.WMDFilm)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddPlayList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMDFilm;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlayListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ListView lstViewPlayList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxMusic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctAddPlayList;
        private System.Windows.Forms.PictureBox pctAddMusic;
        private System.Windows.Forms.ImageList imgLst;
    }
}