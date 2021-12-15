
namespace buoi10
{
    partial class FrmWebCam
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
            this.p1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_OK = new System.Windows.Forms.Button();
            this.cbo_Frame = new System.Windows.Forms.ComboBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.Location = new System.Drawing.Point(12, 52);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(378, 346);
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(713, 415);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // cbo_Frame
            // 
            this.cbo_Frame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Frame.FormattingEnabled = true;
            this.cbo_Frame.Items.AddRange(new object[] {
            "Hi",
            "Hello",
            "Stream",
            "YourName"});
            this.cbo_Frame.Location = new System.Drawing.Point(568, 415);
            this.cbo_Frame.Name = "cbo_Frame";
            this.cbo_Frame.Size = new System.Drawing.Size(121, 21);
            this.cbo_Frame.TabIndex = 2;
            this.cbo_Frame.Text = "0";
            // 
            // p2
            // 
            this.p2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p2.Location = new System.Drawing.Point(396, 52);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(378, 346);
            this.p2.TabIndex = 0;
            this.p2.TabStop = false;
            // 
            // FrmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_Frame);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Name = "FrmWebCam";
            this.Text = "frmWebCam";
            this.Load += new System.EventHandler(this.FrmWebCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ComboBox cbo_Frame;
        private System.Windows.Forms.PictureBox p2;
    }
}