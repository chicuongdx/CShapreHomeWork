
namespace buoi05
{
    partial class Exam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam));
            this.richTxtTest = new System.Windows.Forms.RichTextBox();
            this.richTxtKey = new System.Windows.Forms.RichTextBox();
            this.pnlImport = new System.Windows.Forms.Panel();
            this.pctImportKey = new System.Windows.Forms.PictureBox();
            this.pctImportQiz = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTest = new System.Windows.Forms.Panel();
            this.lbFalse = new System.Windows.Forms.Label();
            this.lbTrue = new System.Windows.Forms.Label();
            this.lstViewRes = new System.Windows.Forms.ListView();
            this.rdBtnC = new System.Windows.Forms.RadioButton();
            this.rdBtnD = new System.Windows.Forms.RadioButton();
            this.rdBtnB = new System.Windows.Forms.RadioButton();
            this.rdBtnA = new System.Windows.Forms.RadioButton();
            this.lbQuiz = new System.Windows.Forms.Label();
            this.pctQuiz = new System.Windows.Forms.PictureBox();
            this.pctNext = new System.Windows.Forms.PictureBox();
            this.pctBack = new System.Windows.Forms.PictureBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.imgLstView = new System.Windows.Forms.ImageList(this.components);
            this.pnlImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImportKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImportQiz)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // richTxtTest
            // 
            this.richTxtTest.Location = new System.Drawing.Point(127, 12);
            this.richTxtTest.Name = "richTxtTest";
            this.richTxtTest.Size = new System.Drawing.Size(558, 301);
            this.richTxtTest.TabIndex = 1;
            this.richTxtTest.Text = "";
            // 
            // richTxtKey
            // 
            this.richTxtKey.Location = new System.Drawing.Point(127, 346);
            this.richTxtKey.Name = "richTxtKey";
            this.richTxtKey.Size = new System.Drawing.Size(558, 209);
            this.richTxtKey.TabIndex = 1;
            this.richTxtKey.Text = "";
            // 
            // pnlImport
            // 
            this.pnlImport.Controls.Add(this.pctImportKey);
            this.pnlImport.Controls.Add(this.richTxtTest);
            this.pnlImport.Controls.Add(this.pctImportQiz);
            this.pnlImport.Controls.Add(this.richTxtKey);
            this.pnlImport.Location = new System.Drawing.Point(206, 0);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(696, 567);
            this.pnlImport.TabIndex = 3;
            // 
            // pctImportKey
            // 
            this.pctImportKey.BackgroundImage = global::buoi05.Properties.Resources.ImportKey;
            this.pctImportKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctImportKey.Location = new System.Drawing.Point(46, 346);
            this.pctImportKey.Name = "pctImportKey";
            this.pctImportKey.Size = new System.Drawing.Size(75, 75);
            this.pctImportKey.TabIndex = 2;
            this.pctImportKey.TabStop = false;
            this.pctImportKey.Click += new System.EventHandler(this.pctImportKey_Click);
            // 
            // pctImportQiz
            // 
            this.pctImportQiz.BackgroundImage = global::buoi05.Properties.Resources.ImportQuestion;
            this.pctImportQiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctImportQiz.Location = new System.Drawing.Point(46, 12);
            this.pctImportQiz.Name = "pctImportQiz";
            this.pctImportQiz.Size = new System.Drawing.Size(75, 75);
            this.pctImportQiz.TabIndex = 2;
            this.pctImportQiz.TabStop = false;
            this.pctImportQiz.Click += new System.EventHandler(this.pctImportQiz_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMenu.Controls.Add(this.btnClose);
            this.pnlMenu.Controls.Add(this.btnTest);
            this.pnlMenu.Controls.Add(this.btnImport);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 567);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Peru;
            this.btnClose.BackgroundImage = global::buoi05.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageKey = "Test.png";
            this.btnClose.Location = new System.Drawing.Point(0, 508);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(200, 59);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTest.BackgroundImage = global::buoi05.Properties.Resources.Test;
            this.btnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.ImageKey = "Test.png";
            this.btnTest.Location = new System.Drawing.Point(0, 230);
            this.btnTest.Name = "btnTest";
            this.btnTest.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTest.Size = new System.Drawing.Size(200, 66);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImport.BackgroundImage = global::buoi05.Properties.Resources.Import;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.ImageKey = "(none)";
            this.btnImport.Location = new System.Drawing.Point(0, 161);
            this.btnImport.Name = "btnImport";
            this.btnImport.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnImport.Size = new System.Drawing.Size(200, 63);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::buoi05.Properties.Resources.Exam;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(51, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTest
            // 
            this.pnlTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTest.Controls.Add(this.lbFalse);
            this.pnlTest.Controls.Add(this.lbTrue);
            this.pnlTest.Controls.Add(this.lstViewRes);
            this.pnlTest.Controls.Add(this.rdBtnC);
            this.pnlTest.Controls.Add(this.rdBtnD);
            this.pnlTest.Controls.Add(this.rdBtnB);
            this.pnlTest.Controls.Add(this.rdBtnA);
            this.pnlTest.Controls.Add(this.lbQuiz);
            this.pnlTest.Controls.Add(this.pctQuiz);
            this.pnlTest.Controls.Add(this.pctNext);
            this.pnlTest.Controls.Add(this.pctBack);
            this.pnlTest.Controls.Add(this.btnRes);
            this.pnlTest.Location = new System.Drawing.Point(203, 3);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(696, 567);
            this.pnlTest.TabIndex = 4;
            this.pnlTest.Visible = false;
            // 
            // lbFalse
            // 
            this.lbFalse.AutoSize = true;
            this.lbFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFalse.ForeColor = System.Drawing.Color.Red;
            this.lbFalse.Location = new System.Drawing.Point(124, 522);
            this.lbFalse.Name = "lbFalse";
            this.lbFalse.Size = new System.Drawing.Size(73, 20);
            this.lbFalse.TabIndex = 6;
            this.lbFalse.Text = "False: 0";
            // 
            // lbTrue
            // 
            this.lbTrue.AutoSize = true;
            this.lbTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbTrue.Location = new System.Drawing.Point(22, 522);
            this.lbTrue.Name = "lbTrue";
            this.lbTrue.Size = new System.Drawing.Size(65, 20);
            this.lbTrue.TabIndex = 6;
            this.lbTrue.Text = "True: 0";
            // 
            // lstViewRes
            // 
            this.lstViewRes.HideSelection = false;
            this.lstViewRes.Location = new System.Drawing.Point(49, 343);
            this.lstViewRes.Name = "lstViewRes";
            this.lstViewRes.Size = new System.Drawing.Size(621, 167);
            this.lstViewRes.TabIndex = 5;
            this.lstViewRes.UseCompatibleStateImageBehavior = false;
            this.lstViewRes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstViewRes_ItemSelectionChanged);
            // 
            // rdBtnC
            // 
            this.rdBtnC.AutoSize = true;
            this.rdBtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnC.Location = new System.Drawing.Point(396, 115);
            this.rdBtnC.Name = "rdBtnC";
            this.rdBtnC.Size = new System.Drawing.Size(42, 24);
            this.rdBtnC.TabIndex = 4;
            this.rdBtnC.TabStop = true;
            this.rdBtnC.Text = "C.";
            this.rdBtnC.UseVisualStyleBackColor = true;
            this.rdBtnC.CheckedChanged += new System.EventHandler(this.rdBtnC_CheckedChanged);
            // 
            // rdBtnD
            // 
            this.rdBtnD.AutoSize = true;
            this.rdBtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnD.Location = new System.Drawing.Point(396, 168);
            this.rdBtnD.Name = "rdBtnD";
            this.rdBtnD.Size = new System.Drawing.Size(43, 24);
            this.rdBtnD.TabIndex = 4;
            this.rdBtnD.TabStop = true;
            this.rdBtnD.Text = "D.";
            this.rdBtnD.UseVisualStyleBackColor = true;
            this.rdBtnD.CheckedChanged += new System.EventHandler(this.rdBtnD_CheckedChanged);
            // 
            // rdBtnB
            // 
            this.rdBtnB.AutoSize = true;
            this.rdBtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnB.Location = new System.Drawing.Point(49, 168);
            this.rdBtnB.Name = "rdBtnB";
            this.rdBtnB.Size = new System.Drawing.Size(42, 24);
            this.rdBtnB.TabIndex = 4;
            this.rdBtnB.TabStop = true;
            this.rdBtnB.Text = "B.";
            this.rdBtnB.UseVisualStyleBackColor = true;
            this.rdBtnB.CheckedChanged += new System.EventHandler(this.rdBtnB_CheckedChanged);
            // 
            // rdBtnA
            // 
            this.rdBtnA.AutoSize = true;
            this.rdBtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnA.Location = new System.Drawing.Point(49, 115);
            this.rdBtnA.Name = "rdBtnA";
            this.rdBtnA.Size = new System.Drawing.Size(42, 24);
            this.rdBtnA.TabIndex = 4;
            this.rdBtnA.TabStop = true;
            this.rdBtnA.Text = "A.";
            this.rdBtnA.UseVisualStyleBackColor = true;
            this.rdBtnA.CheckedChanged += new System.EventHandler(this.rdBtnA_CheckedChanged);
            // 
            // lbQuiz
            // 
            this.lbQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuiz.AutoSize = true;
            this.lbQuiz.BackColor = System.Drawing.SystemColors.Control;
            this.lbQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuiz.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbQuiz.Location = new System.Drawing.Point(124, 12);
            this.lbQuiz.Name = "lbQuiz";
            this.lbQuiz.Size = new System.Drawing.Size(90, 20);
            this.lbQuiz.TabIndex = 3;
            this.lbQuiz.Text = "Question 1:";
            this.lbQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctQuiz
            // 
            this.pctQuiz.BackgroundImage = global::buoi05.Properties.Resources.Question;
            this.pctQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctQuiz.Location = new System.Drawing.Point(14, 12);
            this.pctQuiz.Name = "pctQuiz";
            this.pctQuiz.Size = new System.Drawing.Size(80, 80);
            this.pctQuiz.TabIndex = 2;
            this.pctQuiz.TabStop = false;
            // 
            // pctNext
            // 
            this.pctNext.BackgroundImage = global::buoi05.Properties.Resources.Next;
            this.pctNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctNext.Location = new System.Drawing.Point(570, 218);
            this.pctNext.Name = "pctNext";
            this.pctNext.Size = new System.Drawing.Size(100, 75);
            this.pctNext.TabIndex = 0;
            this.pctNext.TabStop = false;
            this.pctNext.Click += new System.EventHandler(this.pctNext_Click);
            // 
            // pctBack
            // 
            this.pctBack.BackgroundImage = global::buoi05.Properties.Resources.Back;
            this.pctBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBack.Location = new System.Drawing.Point(49, 218);
            this.pctBack.Name = "pctBack";
            this.pctBack.Size = new System.Drawing.Size(92, 75);
            this.pctBack.TabIndex = 0;
            this.pctBack.TabStop = false;
            this.pctBack.Click += new System.EventHandler(this.pctBack_Click);
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRes.BackgroundImage = global::buoi05.Properties.Resources.Result;
            this.btnRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.ForeColor = System.Drawing.Color.White;
            this.btnRes.ImageKey = "(none)";
            this.btnRes.Location = new System.Drawing.Point(258, 264);
            this.btnRes.Name = "btnRes";
            this.btnRes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRes.Size = new System.Drawing.Size(200, 63);
            this.btnRes.TabIndex = 1;
            this.btnRes.Text = "Result Board";
            this.btnRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // imgLstView
            // 
            this.imgLstView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstView.ImageStream")));
            this.imgLstView.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstView.Images.SetKeyName(0, "False.png");
            this.imgLstView.Images.SetKeyName(1, "True.png");
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 567);
            this.Controls.Add(this.pnlTest);
            this.Controls.Add(this.pnlImport);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exam";
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Exam_Load);
            this.pnlImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctImportKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImportQiz)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTest.ResumeLayout(false);
            this.pnlTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox richTxtTest;
        private System.Windows.Forms.RichTextBox richTxtKey;
        private System.Windows.Forms.PictureBox pctImportQiz;
        private System.Windows.Forms.PictureBox pctImportKey;
        private System.Windows.Forms.Panel pnlImport;
        private System.Windows.Forms.Panel pnlTest;
        private System.Windows.Forms.PictureBox pctNext;
        private System.Windows.Forms.PictureBox pctBack;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.PictureBox pctQuiz;
        private System.Windows.Forms.Label lbQuiz;
        private System.Windows.Forms.RadioButton rdBtnC;
        private System.Windows.Forms.RadioButton rdBtnD;
        private System.Windows.Forms.RadioButton rdBtnB;
        private System.Windows.Forms.RadioButton rdBtnA;
        private System.Windows.Forms.Label lbFalse;
        private System.Windows.Forms.Label lbTrue;
        private System.Windows.Forms.ListView lstViewRes;
        private System.Windows.Forms.ImageList imgLstView;
    }
}