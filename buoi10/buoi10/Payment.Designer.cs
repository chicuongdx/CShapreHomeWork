
namespace buoi10
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePrint = new System.Windows.Forms.DateTimePicker();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewData = new System.Windows.Forms.DataGridView();
            this.txt_TToan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnPrint = new DotNetSkin.SkinControls.SkinButton();
            this.pctWebcam = new System.Windows.Forms.PictureBox();
            this.pctTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWebcam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(145, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "SIÊU THỊ KHÁNH AN";
            // 
            // dateTimePrint
            // 
            this.dateTimePrint.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePrint.Location = new System.Drawing.Point(107, 228);
            this.dateTimePrint.Name = "dateTimePrint";
            this.dateTimePrint.Size = new System.Drawing.Size(129, 20);
            this.dateTimePrint.TabIndex = 18;
            // 
            // txtReceipt
            // 
            this.txtReceipt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtReceipt.Location = new System.Drawing.Point(107, 203);
            this.txtReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.Size = new System.Drawing.Size(129, 20);
            this.txtReceipt.TabIndex = 14;
            // 
            // txtStaff
            // 
            this.txtStaff.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtStaff.Location = new System.Drawing.Point(107, 179);
            this.txtStaff.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(129, 20);
            this.txtStaff.TabIndex = 15;
            // 
            // txtCustom
            // 
            this.txtCustom.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtCustom.Location = new System.Drawing.Point(107, 155);
            this.txtCustom.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(129, 20);
            this.txtCustom.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(9, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày in:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(9, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(9, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Khách hàng:";
            // 
            // gridViewData
            // 
            this.gridViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewData.BackgroundColor = System.Drawing.Color.White;
            this.gridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewData.GridColor = System.Drawing.Color.Orange;
            this.gridViewData.Location = new System.Drawing.Point(10, 267);
            this.gridViewData.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.RowTemplate.Height = 28;
            this.gridViewData.Size = new System.Drawing.Size(746, 228);
            this.gridViewData.TabIndex = 9;
            // 
            // txt_TToan
            // 
            this.txt_TToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_TToan.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_TToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_TToan.Location = new System.Drawing.Point(107, 564);
            this.txt_TToan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TToan.Name = "txt_TToan";
            this.txt_TToan.Size = new System.Drawing.Size(129, 20);
            this.txt_TToan.TabIndex = 25;
            this.txt_TToan.Text = "0";
            this.txt_TToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 566);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Thanh toán:";
            // 
            // txt_KM
            // 
            this.txt_KM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_KM.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_KM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_KM.Location = new System.Drawing.Point(107, 544);
            this.txt_KM.Margin = new System.Windows.Forms.Padding(2);
            this.txt_KM.Name = "txt_KM";
            this.txt_KM.Size = new System.Drawing.Size(129, 20);
            this.txt_KM.TabIndex = 26;
            this.txt_KM.Text = "0";
            this.txt_KM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(9, 546);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Khuyến mãi %:";
            // 
            // txt_TT
            // 
            this.txt_TT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_TT.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TT.Location = new System.Drawing.Point(107, 523);
            this.txt_TT.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TT.Name = "txt_TT";
            this.txt_TT.Size = new System.Drawing.Size(129, 20);
            this.txt_TT.TabIndex = 27;
            this.txt_TT.Text = "0";
            this.txt_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(9, 525);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tổng tiền:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(675, 517);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 64);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // pctWebcam
            // 
            this.pctWebcam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctWebcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctWebcam.Location = new System.Drawing.Point(406, 6);
            this.pctWebcam.Name = "pctWebcam";
            this.pctWebcam.Size = new System.Drawing.Size(350, 256);
            this.pctWebcam.TabIndex = 20;
            this.pctWebcam.TabStop = false;
            // 
            // pctTitle
            // 
            this.pctTitle.BackgroundImage = global::buoi10.Properties.Resources.Report;
            this.pctTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctTitle.Location = new System.Drawing.Point(9, 12);
            this.pctTitle.Name = "pctTitle";
            this.pctTitle.Size = new System.Drawing.Size(130, 130);
            this.pctTitle.TabIndex = 17;
            this.pctTitle.TabStop = false;
            this.pctTitle.Click += new System.EventHandler(this.pctTitle_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(764, 591);
            this.Controls.Add(this.txt_TToan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_KM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pctWebcam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePrint);
            this.Controls.Add(this.pctTitle);
            this.Controls.Add(this.txtReceipt);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.txtCustom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridViewData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWebcam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctWebcam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePrint;
        private System.Windows.Forms.PictureBox pctTitle;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewData;
        private System.Windows.Forms.TextBox txt_TToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_KM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TT;
        private System.Windows.Forms.Label label2;
        private DotNetSkin.SkinControls.SkinButton btnPrint;
        private System.Windows.Forms.Timer timer;
    }
}