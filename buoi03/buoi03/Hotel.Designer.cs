
namespace buoi03
{
    partial class Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel));
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.radioBtnFull = new System.Windows.Forms.RadioButton();
            this.radioBtnEmpty = new System.Windows.Forms.RadioButton();
            this.cBoxTypeRoom = new System.Windows.Forms.ComboBox();
            this.numricDay = new System.Windows.Forms.NumericUpDown();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.txtIDRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlService = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDltRoom = new System.Windows.Forms.Button();
            this.btnOrderRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.pctBoxHotel = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstViewOrder = new System.Windows.Forms.ListView();
            this.imgLstRoom = new System.Windows.Forms.ImageList(this.components);
            this.pnlInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricDay)).BeginInit();
            this.pnlService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInformation
            // 
            this.pnlInformation.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlInformation.Controls.Add(this.radioBtnFull);
            this.pnlInformation.Controls.Add(this.radioBtnEmpty);
            this.pnlInformation.Controls.Add(this.cBoxTypeRoom);
            this.pnlInformation.Controls.Add(this.numricDay);
            this.pnlInformation.Controls.Add(this.txtRoomRate);
            this.pnlInformation.Controls.Add(this.txtIDRoom);
            this.pnlInformation.Controls.Add(this.label6);
            this.pnlInformation.Controls.Add(this.label5);
            this.pnlInformation.Controls.Add(this.label4);
            this.pnlInformation.Controls.Add(this.label3);
            this.pnlInformation.Controls.Add(this.label2);
            this.pnlInformation.Controls.Add(this.label1);
            this.pnlInformation.Location = new System.Drawing.Point(8, 11);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(292, 264);
            this.pnlInformation.TabIndex = 1;
            // 
            // radioBtnFull
            // 
            this.radioBtnFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnFull.AutoSize = true;
            this.radioBtnFull.BackColor = System.Drawing.Color.PeachPuff;
            this.radioBtnFull.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnFull.ForeColor = System.Drawing.Color.MediumBlue;
            this.radioBtnFull.Location = new System.Drawing.Point(184, 171);
            this.radioBtnFull.Name = "radioBtnFull";
            this.radioBtnFull.Size = new System.Drawing.Size(56, 22);
            this.radioBtnFull.TabIndex = 5;
            this.radioBtnFull.Text = "Đầy";
            this.radioBtnFull.UseVisualStyleBackColor = false;
            // 
            // radioBtnEmpty
            // 
            this.radioBtnEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnEmpty.AutoSize = true;
            this.radioBtnEmpty.BackColor = System.Drawing.Color.PeachPuff;
            this.radioBtnEmpty.Checked = true;
            this.radioBtnEmpty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEmpty.ForeColor = System.Drawing.Color.MediumBlue;
            this.radioBtnEmpty.Location = new System.Drawing.Point(184, 143);
            this.radioBtnEmpty.Name = "radioBtnEmpty";
            this.radioBtnEmpty.Size = new System.Drawing.Size(76, 22);
            this.radioBtnEmpty.TabIndex = 5;
            this.radioBtnEmpty.TabStop = true;
            this.radioBtnEmpty.Text = "Trống";
            this.radioBtnEmpty.UseVisualStyleBackColor = false;
            // 
            // cBoxTypeRoom
            // 
            this.cBoxTypeRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxTypeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTypeRoom.FormattingEnabled = true;
            this.cBoxTypeRoom.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cBoxTypeRoom.Location = new System.Drawing.Point(184, 73);
            this.cBoxTypeRoom.Name = "cBoxTypeRoom";
            this.cBoxTypeRoom.Size = new System.Drawing.Size(100, 28);
            this.cBoxTypeRoom.TabIndex = 4;
            this.cBoxTypeRoom.Text = "A";
            this.cBoxTypeRoom.SelectedIndexChanged += new System.EventHandler(this.cBoxTypeRoom_SelectedIndexChanged);
            // 
            // numricDay
            // 
            this.numricDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numricDay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numricDay.Location = new System.Drawing.Point(184, 221);
            this.numricDay.Name = "numricDay";
            this.numricDay.Size = new System.Drawing.Size(100, 26);
            this.numricDay.TabIndex = 3;
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomRate.Location = new System.Drawing.Point(184, 103);
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.Size = new System.Drawing.Size(100, 26);
            this.txtRoomRate.TabIndex = 1;
            this.txtRoomRate.Text = "150000";
            // 
            // txtIDRoom
            // 
            this.txtIDRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDRoom.Location = new System.Drawing.Point(184, 45);
            this.txtIDRoom.Name = "txtIDRoom";
            this.txtIDRoom.ReadOnly = true;
            this.txtIDRoom.Size = new System.Drawing.Size(100, 26);
            this.txtIDRoom.TabIndex = 1;
            this.txtIDRoom.Text = "A1";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PeachPuff;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 230);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số ngày ở:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PeachPuff;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tình trạng phòng:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PeachPuff;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá phòng :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại phòng :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phòng";
            // 
            // pnlService
            // 
            this.pnlService.BackColor = System.Drawing.Color.White;
            this.pnlService.Controls.Add(this.btnPay);
            this.pnlService.Controls.Add(this.btnDltRoom);
            this.pnlService.Controls.Add(this.btnOrderRoom);
            this.pnlService.Controls.Add(this.btnAddRoom);
            this.pnlService.Controls.Add(this.pctBoxHotel);
            this.pnlService.Controls.Add(this.label7);
            this.pnlService.Location = new System.Drawing.Point(8, 281);
            this.pnlService.Name = "pnlService";
            this.pnlService.Size = new System.Drawing.Size(292, 198);
            this.pnlService.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(152, 155);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(129, 35);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDltRoom
            // 
            this.btnDltRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDltRoom.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDltRoom.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltRoom.ForeColor = System.Drawing.Color.White;
            this.btnDltRoom.Location = new System.Drawing.Point(152, 114);
            this.btnDltRoom.Name = "btnDltRoom";
            this.btnDltRoom.Size = new System.Drawing.Size(129, 35);
            this.btnDltRoom.TabIndex = 1;
            this.btnDltRoom.Text = "Hủy phòng";
            this.btnDltRoom.UseVisualStyleBackColor = false;
            this.btnDltRoom.Click += new System.EventHandler(this.btnDltRoom_Click);
            // 
            // btnOrderRoom
            // 
            this.btnOrderRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderRoom.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnOrderRoom.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderRoom.ForeColor = System.Drawing.Color.White;
            this.btnOrderRoom.Location = new System.Drawing.Point(152, 73);
            this.btnOrderRoom.Name = "btnOrderRoom";
            this.btnOrderRoom.Size = new System.Drawing.Size(129, 35);
            this.btnOrderRoom.TabIndex = 1;
            this.btnOrderRoom.Text = "Đặt phòng";
            this.btnOrderRoom.UseVisualStyleBackColor = false;
            this.btnOrderRoom.Click += new System.EventHandler(this.btnOrderRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoom.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAddRoom.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(152, 32);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(129, 35);
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = "Thêm phòng";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // pctBoxHotel
            // 
            this.pctBoxHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoxHotel.BackgroundImage = global::buoi03.Properties.Resources.motel;
            this.pctBoxHotel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxHotel.Location = new System.Drawing.Point(9, 32);
            this.pctBoxHotel.Name = "pctBoxHotel";
            this.pctBoxHotel.Size = new System.Drawing.Size(137, 158);
            this.pctBoxHotel.TabIndex = 0;
            this.pctBoxHotel.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(6, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chức năng";
            // 
            // lstViewOrder
            // 
            this.lstViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstViewOrder.BackColor = System.Drawing.Color.White;
            this.lstViewOrder.HideSelection = false;
            this.lstViewOrder.Location = new System.Drawing.Point(306, 11);
            this.lstViewOrder.Name = "lstViewOrder";
            this.lstViewOrder.Size = new System.Drawing.Size(1037, 679);
            this.lstViewOrder.TabIndex = 3;
            this.lstViewOrder.UseCompatibleStateImageBehavior = false;
            this.lstViewOrder.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstViewOrder_ItemSelectionChanged);
            // 
            // imgLstRoom
            // 
            this.imgLstRoom.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstRoom.ImageStream")));
            this.imgLstRoom.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstRoom.Images.SetKeyName(0, "Room.png");
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1355, 696);
            this.Controls.Add(this.lstViewOrder);
            this.Controls.Add(this.pnlService);
            this.Controls.Add(this.pnlInformation);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricDay)).EndInit();
            this.pnlService.ResumeLayout(false);
            this.pnlService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlService;
        private System.Windows.Forms.TextBox txtRoomRate;
        private System.Windows.Forms.TextBox txtIDRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pctBoxHotel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDltRoom;
        private System.Windows.Forms.Button btnOrderRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.NumericUpDown numricDay;
        private System.Windows.Forms.ComboBox cBoxTypeRoom;
        private System.Windows.Forms.RadioButton radioBtnFull;
        private System.Windows.Forms.RadioButton radioBtnEmpty;
        private System.Windows.Forms.ListView lstViewOrder;
        private System.Windows.Forms.ImageList imgLstRoom;
    }
}