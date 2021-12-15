
namespace buoi05
{
    partial class File_Dir
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
            this.lstViewNofication = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFile = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDirFile = new System.Windows.Forms.TextBox();
            this.txtNameFile = new System.Windows.Forms.TextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.pnlFolder = new System.Windows.Forms.Panel();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.txtHardDrive = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlZip = new System.Windows.Forms.Panel();
            this.txtFileNen_1 = new System.Windows.Forms.TextBox();
            this.txtFolderNen_1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCheckFolder = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnDeleteAllFile = new System.Windows.Forms.Button();
            this.btnDeleteFolder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFileNen_2 = new System.Windows.Forms.TextBox();
            this.txtFolderNen_2 = new System.Windows.Forms.TextBox();
            this.btnNen = new System.Windows.Forms.Button();
            this.btnGiaiNen = new System.Windows.Forms.Button();
            this.pnlFile.SuspendLayout();
            this.pnlFolder.SuspendLayout();
            this.pnlZip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstViewNofication
            // 
            this.lstViewNofication.HideSelection = false;
            this.lstViewNofication.Location = new System.Drawing.Point(534, 50);
            this.lstViewNofication.Name = "lstViewNofication";
            this.lstViewNofication.Size = new System.Drawing.Size(262, 431);
            this.lstViewNofication.TabIndex = 0;
            this.lstViewNofication.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(534, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG BÁO";
            // 
            // pnlFile
            // 
            this.pnlFile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlFile.Controls.Add(this.btnReadFile);
            this.pnlFile.Controls.Add(this.txtNameFile);
            this.pnlFile.Controls.Add(this.txtDirFile);
            this.pnlFile.Controls.Add(this.label4);
            this.pnlFile.Controls.Add(this.label3);
            this.pnlFile.Controls.Add(this.label2);
            this.pnlFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFile.Location = new System.Drawing.Point(13, 12);
            this.pnlFile.Name = "pnlFile";
            this.pnlFile.Size = new System.Drawing.Size(515, 142);
            this.pnlFile.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đường dẫn file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên file";
            // 
            // txtDirFile
            // 
            this.txtDirFile.Location = new System.Drawing.Point(169, 38);
            this.txtDirFile.Name = "txtDirFile";
            this.txtDirFile.Size = new System.Drawing.Size(200, 23);
            this.txtDirFile.TabIndex = 1;
            // 
            // txtNameFile
            // 
            this.txtNameFile.Location = new System.Drawing.Point(169, 76);
            this.txtNameFile.Name = "txtNameFile";
            this.txtNameFile.Size = new System.Drawing.Size(200, 23);
            this.txtNameFile.TabIndex = 1;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(240, 105);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(75, 23);
            this.btnReadFile.TabIndex = 2;
            this.btnReadFile.Text = "Đọc file";
            this.btnReadFile.UseVisualStyleBackColor = true;
            // 
            // pnlFolder
            // 
            this.pnlFolder.BackColor = System.Drawing.Color.Turquoise;
            this.pnlFolder.Controls.Add(this.btnDeleteFolder);
            this.pnlFolder.Controls.Add(this.btnDeleteAllFile);
            this.pnlFolder.Controls.Add(this.btnCreateFolder);
            this.pnlFolder.Controls.Add(this.btnCheckFolder);
            this.pnlFolder.Controls.Add(this.txtFolder);
            this.pnlFolder.Controls.Add(this.txtHardDrive);
            this.pnlFolder.Controls.Add(this.label5);
            this.pnlFolder.Controls.Add(this.label6);
            this.pnlFolder.Controls.Add(this.label7);
            this.pnlFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFolder.Location = new System.Drawing.Point(13, 166);
            this.pnlFolder.Name = "pnlFolder";
            this.pnlFolder.Size = new System.Drawing.Size(515, 156);
            this.pnlFolder.TabIndex = 2;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(169, 76);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(200, 23);
            this.txtFolder.TabIndex = 1;
            // 
            // txtHardDrive
            // 
            this.txtHardDrive.Location = new System.Drawing.Point(169, 38);
            this.txtHardDrive.Name = "txtHardDrive";
            this.txtHardDrive.Size = new System.Drawing.Size(200, 23);
            this.txtHardDrive.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên thư mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ổ cứng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "THƯ MỤC";
            // 
            // pnlZip
            // 
            this.pnlZip.BackColor = System.Drawing.SystemColors.Control;
            this.pnlZip.Controls.Add(this.txtFolderNen_2);
            this.pnlZip.Controls.Add(this.btnGiaiNen);
            this.pnlZip.Controls.Add(this.btnNen);
            this.pnlZip.Controls.Add(this.txtFileNen_1);
            this.pnlZip.Controls.Add(this.txtFileNen_2);
            this.pnlZip.Controls.Add(this.label12);
            this.pnlZip.Controls.Add(this.txtFolderNen_1);
            this.pnlZip.Controls.Add(this.label11);
            this.pnlZip.Controls.Add(this.label8);
            this.pnlZip.Controls.Add(this.label9);
            this.pnlZip.Controls.Add(this.label10);
            this.pnlZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlZip.Location = new System.Drawing.Point(13, 339);
            this.pnlZip.Name = "pnlZip";
            this.pnlZip.Size = new System.Drawing.Size(515, 142);
            this.pnlZip.TabIndex = 2;
            // 
            // txtFileNen_1
            // 
            this.txtFileNen_1.Location = new System.Drawing.Point(140, 76);
            this.txtFileNen_1.Name = "txtFileNen_1";
            this.txtFileNen_1.Size = new System.Drawing.Size(98, 23);
            this.txtFileNen_1.TabIndex = 1;
            // 
            // txtFolderNen_1
            // 
            this.txtFolderNen_1.Location = new System.Drawing.Point(140, 38);
            this.txtFolderNen_1.Name = "txtFolderNen_1";
            this.txtFolderNen_1.Size = new System.Drawing.Size(98, 23);
            this.txtFolderNen_1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "File nén";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thư mục nén";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ZIP";
            // 
            // btnCheckFolder
            // 
            this.btnCheckFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckFolder.Location = new System.Drawing.Point(18, 114);
            this.btnCheckFolder.Name = "btnCheckFolder";
            this.btnCheckFolder.Size = new System.Drawing.Size(116, 23);
            this.btnCheckFolder.TabIndex = 2;
            this.btnCheckFolder.Text = "Kiểm tra thư mục";
            this.btnCheckFolder.UseVisualStyleBackColor = true;
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFolder.Location = new System.Drawing.Point(140, 114);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(116, 23);
            this.btnCreateFolder.TabIndex = 2;
            this.btnCreateFolder.Text = "Tạo thư mục";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAllFile
            // 
            this.btnDeleteAllFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllFile.Location = new System.Drawing.Point(262, 114);
            this.btnDeleteAllFile.Name = "btnDeleteAllFile";
            this.btnDeleteAllFile.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteAllFile.TabIndex = 2;
            this.btnDeleteAllFile.Text = "Xóa tất cả các file";
            this.btnDeleteAllFile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFolder.Location = new System.Drawing.Point(384, 114);
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteFolder.TabIndex = 2;
            this.btnDeleteFolder.Text = "Xóa thư mục";
            this.btnDeleteFolder.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(288, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "File nén";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(288, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Thư mục giải nén";
            // 
            // txtFileNen_2
            // 
            this.txtFileNen_2.Location = new System.Drawing.Point(384, 38);
            this.txtFileNen_2.Name = "txtFileNen_2";
            this.txtFileNen_2.Size = new System.Drawing.Size(98, 23);
            this.txtFileNen_2.TabIndex = 1;
            // 
            // txtFolderNen_2
            // 
            this.txtFolderNen_2.Location = new System.Drawing.Point(384, 76);
            this.txtFolderNen_2.Name = "txtFolderNen_2";
            this.txtFolderNen_2.Size = new System.Drawing.Size(98, 23);
            this.txtFolderNen_2.TabIndex = 1;
            // 
            // btnNen
            // 
            this.btnNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNen.Location = new System.Drawing.Point(87, 105);
            this.btnNen.Name = "btnNen";
            this.btnNen.Size = new System.Drawing.Size(88, 23);
            this.btnNen.TabIndex = 2;
            this.btnNen.Text = "Nén file";
            this.btnNen.UseVisualStyleBackColor = true;
            // 
            // btnGiaiNen
            // 
            this.btnGiaiNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiNen.Location = new System.Drawing.Point(332, 105);
            this.btnGiaiNen.Name = "btnGiaiNen";
            this.btnGiaiNen.Size = new System.Drawing.Size(88, 23);
            this.btnGiaiNen.TabIndex = 2;
            this.btnGiaiNen.Text = "Giải nén file";
            this.btnGiaiNen.UseVisualStyleBackColor = true;
            // 
            // File_Dir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.pnlZip);
            this.Controls.Add(this.pnlFolder);
            this.Controls.Add(this.pnlFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstViewNofication);
            this.Name = "File_Dir";
            this.Text = "File & Thư mục";
            this.pnlFile.ResumeLayout(false);
            this.pnlFile.PerformLayout();
            this.pnlFolder.ResumeLayout(false);
            this.pnlFolder.PerformLayout();
            this.pnlZip.ResumeLayout(false);
            this.pnlZip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewNofication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtNameFile;
        private System.Windows.Forms.TextBox txtDirFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.TextBox txtHardDrive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlZip;
        private System.Windows.Forms.TextBox txtFileNen_1;
        private System.Windows.Forms.TextBox txtFolderNen_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteFolder;
        private System.Windows.Forms.Button btnDeleteAllFile;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCheckFolder;
        private System.Windows.Forms.TextBox txtFolderNen_2;
        private System.Windows.Forms.Button btnGiaiNen;
        private System.Windows.Forms.Button btnNen;
        private System.Windows.Forms.TextBox txtFileNen_2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}