
namespace buoi10
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.gridViewData = new System.Windows.Forms.DataGridView();
            this.pctSave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSave)).BeginInit();
            this.SuspendLayout();
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
            this.gridViewData.Location = new System.Drawing.Point(1, 0);
            this.gridViewData.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.RowTemplate.Height = 28;
            this.gridViewData.Size = new System.Drawing.Size(359, 371);
            this.gridViewData.TabIndex = 10;
            // 
            // pctSave
            // 
            this.pctSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSave.BackgroundImage = global::buoi10.Properties.Resources.save;
            this.pctSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctSave.Location = new System.Drawing.Point(150, 376);
            this.pctSave.Name = "pctSave";
            this.pctSave.Size = new System.Drawing.Size(50, 50);
            this.pctSave.TabIndex = 11;
            this.pctSave.TabStop = false;
            this.pctSave.Click += new System.EventHandler(this.pctSave_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 443);
            this.Controls.Add(this.pctSave);
            this.Controls.Add(this.gridViewData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewData;
        private System.Windows.Forms.PictureBox pctSave;
    }
}