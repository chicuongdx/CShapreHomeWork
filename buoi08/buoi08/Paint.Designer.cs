
namespace buoi08
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.btnClean = new System.Windows.Forms.Button();
            this.rdButnEllipse = new System.Windows.Forms.RadioButton();
            this.rdBtnString = new System.Windows.Forms.RadioButton();
            this.rdBtnRectangle = new System.Windows.Forms.RadioButton();
            this.rdBtnLine = new System.Windows.Forms.RadioButton();
            this.numPenWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPenColor = new System.Windows.Forms.Button();
            this.grBoxTool = new System.Windows.Forms.GroupBox();
            this.grBoxImage = new System.Windows.Forms.GroupBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.grBoxDraw = new System.Windows.Forms.GroupBox();
            this.rdBtnEllipseF = new System.Windows.Forms.RadioButton();
            this.rdBtnRectangleF = new System.Windows.Forms.RadioButton();
            this.colorDialogPen = new System.Windows.Forms.ColorDialog();
            this.pctPaint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).BeginInit();
            this.grBoxTool.SuspendLayout();
            this.grBoxImage.SuspendLayout();
            this.grBoxDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPaint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClean.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClean.Location = new System.Drawing.Point(19, 259);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(265, 42);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // rdButnEllipse
            // 
            this.rdButnEllipse.AutoSize = true;
            this.rdButnEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButnEllipse.Location = new System.Drawing.Point(141, 66);
            this.rdButnEllipse.Name = "rdButnEllipse";
            this.rdButnEllipse.Size = new System.Drawing.Size(67, 21);
            this.rdButnEllipse.TabIndex = 5;
            this.rdButnEllipse.Text = "Ellipse";
            this.rdButnEllipse.UseVisualStyleBackColor = true;
            // 
            // rdBtnString
            // 
            this.rdBtnString.AutoSize = true;
            this.rdBtnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnString.Location = new System.Drawing.Point(141, 32);
            this.rdBtnString.Name = "rdBtnString";
            this.rdBtnString.Size = new System.Drawing.Size(63, 21);
            this.rdBtnString.TabIndex = 5;
            this.rdBtnString.Text = "String";
            this.rdBtnString.UseVisualStyleBackColor = true;
            // 
            // rdBtnRectangle
            // 
            this.rdBtnRectangle.AutoSize = true;
            this.rdBtnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnRectangle.Location = new System.Drawing.Point(16, 66);
            this.rdBtnRectangle.Name = "rdBtnRectangle";
            this.rdBtnRectangle.Size = new System.Drawing.Size(90, 21);
            this.rdBtnRectangle.TabIndex = 5;
            this.rdBtnRectangle.Text = "Rectangle";
            this.rdBtnRectangle.UseVisualStyleBackColor = true;
            // 
            // rdBtnLine
            // 
            this.rdBtnLine.AutoSize = true;
            this.rdBtnLine.Checked = true;
            this.rdBtnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnLine.Location = new System.Drawing.Point(16, 32);
            this.rdBtnLine.Name = "rdBtnLine";
            this.rdBtnLine.Size = new System.Drawing.Size(53, 21);
            this.rdBtnLine.TabIndex = 5;
            this.rdBtnLine.TabStop = true;
            this.rdBtnLine.Text = "Line";
            this.rdBtnLine.UseVisualStyleBackColor = true;
            // 
            // numPenWidth
            // 
            this.numPenWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPenWidth.Location = new System.Drawing.Point(95, 194);
            this.numPenWidth.Name = "numPenWidth";
            this.numPenWidth.Size = new System.Drawing.Size(158, 23);
            this.numPenWidth.TabIndex = 4;
            this.numPenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPenWidth.ValueChanged += new System.EventHandler(this.numPenWidth_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pen Width";
            // 
            // btnPenColor
            // 
            this.btnPenColor.BackColor = System.Drawing.Color.Black;
            this.btnPenColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenColor.ForeColor = System.Drawing.Color.White;
            this.btnPenColor.Location = new System.Drawing.Point(13, 135);
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.Size = new System.Drawing.Size(240, 42);
            this.btnPenColor.TabIndex = 2;
            this.btnPenColor.Text = "Pen Color";
            this.btnPenColor.UseVisualStyleBackColor = false;
            this.btnPenColor.Click += new System.EventHandler(this.btnPenColor_Click);
            // 
            // grBoxTool
            // 
            this.grBoxTool.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grBoxTool.Controls.Add(this.grBoxImage);
            this.grBoxTool.Controls.Add(this.grBoxDraw);
            this.grBoxTool.Controls.Add(this.btnClean);
            this.grBoxTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.grBoxTool.Location = new System.Drawing.Point(502, 0);
            this.grBoxTool.Name = "grBoxTool";
            this.grBoxTool.Size = new System.Drawing.Size(298, 461);
            this.grBoxTool.TabIndex = 3;
            this.grBoxTool.TabStop = false;
            // 
            // grBoxImage
            // 
            this.grBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxImage.BackColor = System.Drawing.Color.CadetBlue;
            this.grBoxImage.Controls.Add(this.txtY);
            this.grBoxImage.Controls.Add(this.txtX);
            this.grBoxImage.Controls.Add(this.label7);
            this.grBoxImage.Controls.Add(this.btnLoadImage);
            this.grBoxImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grBoxImage.Location = new System.Drawing.Point(19, 318);
            this.grBoxImage.Name = "grBoxImage";
            this.grBoxImage.Size = new System.Drawing.Size(265, 132);
            this.grBoxImage.TabIndex = 5;
            this.grBoxImage.TabStop = false;
            this.grBoxImage.Text = "Image";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(179, 48);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(72, 23);
            this.txtY.TabIndex = 4;
            this.txtY.Text = "100";
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(93, 47);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(72, 23);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "100";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Point X, Y";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.ForeColor = System.Drawing.Color.White;
            this.btnLoadImage.Location = new System.Drawing.Point(11, 74);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(240, 42);
            this.btnLoadImage.TabIndex = 2;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // grBoxDraw
            // 
            this.grBoxDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxDraw.BackColor = System.Drawing.Color.CadetBlue;
            this.grBoxDraw.Controls.Add(this.rdBtnEllipseF);
            this.grBoxDraw.Controls.Add(this.rdButnEllipse);
            this.grBoxDraw.Controls.Add(this.rdBtnRectangleF);
            this.grBoxDraw.Controls.Add(this.rdBtnString);
            this.grBoxDraw.Controls.Add(this.rdBtnRectangle);
            this.grBoxDraw.Controls.Add(this.rdBtnLine);
            this.grBoxDraw.Controls.Add(this.numPenWidth);
            this.grBoxDraw.Controls.Add(this.label6);
            this.grBoxDraw.Controls.Add(this.btnPenColor);
            this.grBoxDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxDraw.Location = new System.Drawing.Point(19, 19);
            this.grBoxDraw.Name = "grBoxDraw";
            this.grBoxDraw.Size = new System.Drawing.Size(265, 225);
            this.grBoxDraw.TabIndex = 6;
            this.grBoxDraw.TabStop = false;
            this.grBoxDraw.Text = "Draw";
            // 
            // rdBtnEllipseF
            // 
            this.rdBtnEllipseF.AutoSize = true;
            this.rdBtnEllipseF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnEllipseF.Location = new System.Drawing.Point(141, 100);
            this.rdBtnEllipseF.Name = "rdBtnEllipseF";
            this.rdBtnEllipseF.Size = new System.Drawing.Size(88, 21);
            this.rdBtnEllipseF.TabIndex = 5;
            this.rdBtnEllipseF.Text = "Fill Ellipse";
            this.rdBtnEllipseF.UseVisualStyleBackColor = true;
            // 
            // rdBtnRectangleF
            // 
            this.rdBtnRectangleF.AutoSize = true;
            this.rdBtnRectangleF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnRectangleF.Location = new System.Drawing.Point(16, 100);
            this.rdBtnRectangleF.Name = "rdBtnRectangleF";
            this.rdBtnRectangleF.Size = new System.Drawing.Size(111, 21);
            this.rdBtnRectangleF.TabIndex = 5;
            this.rdBtnRectangleF.Text = "Fill Rectangle";
            this.rdBtnRectangleF.UseVisualStyleBackColor = true;
            // 
            // pctPaint
            // 
            this.pctPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctPaint.BackColor = System.Drawing.Color.White;
            this.pctPaint.Location = new System.Drawing.Point(1, 1);
            this.pctPaint.Name = "pctPaint";
            this.pctPaint.Size = new System.Drawing.Size(503, 455);
            this.pctPaint.TabIndex = 4;
            this.pctPaint.TabStop = false;
            this.pctPaint.ClientSizeChanged += new System.EventHandler(this.pctPaint_ClientSizeChanged);
            this.pctPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pctPaint_Paint);
            this.pctPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctPaint_MouseDown);
            this.pctPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctPaint_MouseMove);
            this.pctPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctPaint_MouseUp);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.pctPaint);
            this.Controls.Add(this.grBoxTool);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paint";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).EndInit();
            this.grBoxTool.ResumeLayout(false);
            this.grBoxImage.ResumeLayout(false);
            this.grBoxImage.PerformLayout();
            this.grBoxDraw.ResumeLayout(false);
            this.grBoxDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPaint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnPenColor;
        private System.Windows.Forms.NumericUpDown numPenWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdButnEllipse;
        private System.Windows.Forms.RadioButton rdBtnString;
        private System.Windows.Forms.RadioButton rdBtnRectangle;
        private System.Windows.Forms.RadioButton rdBtnLine;
        private System.Windows.Forms.GroupBox grBoxTool;
        private System.Windows.Forms.GroupBox grBoxImage;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.GroupBox grBoxDraw;
        private System.Windows.Forms.ColorDialog colorDialogPen;
        private System.Windows.Forms.PictureBox pctPaint;
        private System.Windows.Forms.RadioButton rdBtnEllipseF;
        private System.Windows.Forms.RadioButton rdBtnRectangleF;
    }
}