
namespace buoi02
{
    partial class Taxi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctBoxCalculator = new System.Windows.Forms.PictureBox();
            this.TextBoxSale = new System.Windows.Forms.TextBox();
            this.TextBoxKm = new System.Windows.Forms.TextBox();
            this.labelTT = new System.Windows.Forms.Label();
            this.labelSale = new System.Windows.Forms.Label();
            this.labelKm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxTT = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCalculator)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pctBoxCalculator);
            this.panel2.Controls.Add(this.TextBoxTT);
            this.panel2.Controls.Add(this.TextBoxSale);
            this.panel2.Controls.Add(this.TextBoxKm);
            this.panel2.Controls.Add(this.labelTT);
            this.panel2.Controls.Add(this.labelSale);
            this.panel2.Controls.Add(this.labelKm);
            this.panel2.Location = new System.Drawing.Point(0, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 225);
            this.panel2.TabIndex = 1;
            // 
            // pctBoxCalculator
            // 
            this.pctBoxCalculator.BackgroundImage = global::buoi02.Properties.Resources.MicrosoftTeams_image;
            this.pctBoxCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxCalculator.Image = global::buoi02.Properties.Resources.MicrosoftTeams_image;
            this.pctBoxCalculator.Location = new System.Drawing.Point(290, 107);
            this.pctBoxCalculator.Name = "pctBoxCalculator";
            this.pctBoxCalculator.Size = new System.Drawing.Size(40, 40);
            this.pctBoxCalculator.TabIndex = 4;
            this.pctBoxCalculator.TabStop = false;
            this.pctBoxCalculator.Click += new System.EventHandler(this.pctBoxCalculator_Click);
            // 
            // TextBoxSale
            // 
            this.TextBoxSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSale.Location = new System.Drawing.Point(260, 79);
            this.TextBoxSale.Name = "TextBoxSale";
            this.TextBoxSale.Size = new System.Drawing.Size(100, 22);
            this.TextBoxSale.TabIndex = 3;
            this.TextBoxSale.Text = "0";
            this.TextBoxSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxKm
            // 
            this.TextBoxKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxKm.Location = new System.Drawing.Point(260, 42);
            this.TextBoxKm.Name = "TextBoxKm";
            this.TextBoxKm.Size = new System.Drawing.Size(100, 22);
            this.TextBoxKm.TabIndex = 2;
            this.TextBoxKm.Text = "0";
            this.TextBoxKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTT
            // 
            this.labelTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTT.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTT.Location = new System.Drawing.Point(113, 156);
            this.labelTT.Name = "labelTT";
            this.labelTT.Size = new System.Drawing.Size(100, 23);
            this.labelTT.TabIndex = 1;
            this.labelTT.Text = "Thanh toán:";
            // 
            // labelSale
            // 
            this.labelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSale.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelSale.Location = new System.Drawing.Point(113, 78);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(100, 23);
            this.labelSale.TabIndex = 1;
            this.labelSale.Text = "Khuyến mãi (%) :";
            // 
            // labelKm
            // 
            this.labelKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKm.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelKm.Location = new System.Drawing.Point(113, 45);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(71, 19);
            this.labelKm.TabIndex = 0;
            this.labelKm.Text = "Số km:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(482, 226);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(320, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "12.000/ 1km";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(320, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "16.000/ 1km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(320, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "14.000/ 1km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(111, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giá từ km thứ 26:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(111, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá km tiếp theo (dưới 26km):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(111, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá mở cửa (dưới 5km):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(109, 27);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(289, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "BẢNG GIÁ CƯỚC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxTT
            // 
            this.TextBoxTT.BackColor = System.Drawing.SystemColors.Info;
            this.TextBoxTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTT.ForeColor = System.Drawing.Color.Red;
            this.TextBoxTT.Location = new System.Drawing.Point(260, 153);
            this.TextBoxTT.Name = "TextBoxTT";
            this.TextBoxTT.ReadOnly = true;
            this.TextBoxTT.Size = new System.Drawing.Size(100, 22);
            this.TextBoxTT.TabIndex = 3;
            this.TextBoxTT.Text = "0";
            this.TextBoxTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Taxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Taxi";
            this.Text = "Taxi";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCalculator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.TextBox TextBoxSale;
        private System.Windows.Forms.TextBox TextBoxKm;
        private System.Windows.Forms.PictureBox pctBoxCalculator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTT;
        private System.Windows.Forms.TextBox TextBoxTT;
    }
}