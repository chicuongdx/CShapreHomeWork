namespace bt1.Buoi09
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_KM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TToan = new System.Windows.Forms.TextBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.picCam = new System.Windows.Forms.PictureBox();
            this.btnPrint = new DotNetSkin.SkinControls.SkinButton();
            this.txtKhachTra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Orange;
            this.dataGridView1.Location = new System.Drawing.Point(8, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(567, 228);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khách hàng:";
            // 
            // txt_TT
            // 
            this.txt_TT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_TT.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TT.Location = new System.Drawing.Point(106, 318);
            this.txt_TT.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TT.Name = "txt_TT";
            this.txt_TT.Size = new System.Drawing.Size(129, 20);
            this.txt_TT.TabIndex = 3;
            this.txt_TT.Text = "0";
            this.txt_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(8, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(8, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khuyến mãi %:";
            // 
            // txt_KM
            // 
            this.txt_KM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_KM.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_KM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_KM.Location = new System.Drawing.Point(106, 339);
            this.txt_KM.Margin = new System.Windows.Forms.Padding(2);
            this.txt_KM.Name = "txt_KM";
            this.txt_KM.Size = new System.Drawing.Size(129, 20);
            this.txt_KM.TabIndex = 3;
            this.txt_KM.Text = "0";
            this.txt_KM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(8, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thanh toán:";
            // 
            // txt_TToan
            // 
            this.txt_TToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_TToan.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_TToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_TToan.Location = new System.Drawing.Point(106, 359);
            this.txt_TToan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TToan.Name = "txt_TToan";
            this.txt_TToan.Size = new System.Drawing.Size(129, 20);
            this.txt_TToan.TabIndex = 3;
            this.txt_TToan.Text = "0";
            this.txt_TToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtKhachHang.Location = new System.Drawing.Point(106, 25);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(129, 20);
            this.txtKhachHang.TabIndex = 3;
            this.txtKhachHang.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(8, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhân Viên";
            // 
            // txtNV
            // 
            this.txtNV.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtNV.Location = new System.Drawing.Point(106, 45);
            this.txtNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(129, 20);
            this.txtNV.TabIndex = 3;
            this.txtNV.Text = "Administrator";
            // 
            // picCam
            // 
            this.picCam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCam.BackgroundImage")));
            this.picCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCam.Location = new System.Drawing.Point(493, 8);
            this.picCam.Margin = new System.Windows.Forms.Padding(2);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(75, 66);
            this.picCam.TabIndex = 4;
            this.picCam.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(493, 312);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 64);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtKhachTra
            // 
            this.txtKhachTra.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtKhachTra.Location = new System.Drawing.Point(318, 24);
            this.txtKhachTra.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhachTra.Name = "txtKhachTra";
            this.txtKhachTra.Size = new System.Drawing.Size(129, 20);
            this.txtKhachTra.TabIndex = 6;
            this.txtKhachTra.Text = " 40000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(248, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Khách trả:";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(583, 392);
            this.Controls.Add(this.txtKhachTra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picCam);
            this.Controls.Add(this.txt_TToan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_KM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNV);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.txt_TT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotNetSkin.SkinControls.SkinButton btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_KM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TToan;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.TextBox txtKhachTra;
        private System.Windows.Forms.Label label6;
    }
}