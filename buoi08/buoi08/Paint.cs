using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi08
{
    public partial class Paint : Form
    {
        Graphics gr;
        Bitmap bm;
        bool paint = false;
        int X = 0, Y = 0;

        int sX = 0, sY = 0;
        
        int cX = 0, cY = 0;

        Pen pen = new Pen(Color.Black, 1);
        SolidBrush brush = new SolidBrush(Color.Black);


        public Paint()
        {
            InitializeComponent();
            bm = new Bitmap(pctPaint.Width, pctPaint.Height);
            gr = Graphics.FromImage(bm);
            pctPaint.Image = bm;
        }

        private void pctPaint_ClientSizeChanged(object sender, EventArgs e)
        {
            Bitmap temp_bm = new Bitmap(pctPaint.Width, pctPaint.Height);
            gr = Graphics.FromImage(temp_bm);
            gr.DrawImage(bm, 0, 0);

            gr = Graphics.FromImage(temp_bm);

            bm = temp_bm;
            //gr.Clear(Color.White);
            pctPaint.Image = bm;
            pctPaint.Refresh();
        }

        private void pctPaint_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            cX = e.X;
            cY = e.Y;
        }

        private void pctPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                X = e.X;
                Y = e.Y;
                sX = e.X - cX;
                sY = e.Y - cY;
            }
            pctPaint.Refresh();
        }

        private void Draw_paint(Graphics gr)
        {
            if (rdBtnLine.Checked)
            {
                gr.DrawLine(pen, cX, cY, X, Y);
            }
            if (rdButnEllipse.Checked)
            {
                gr.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (rdBtnRectangle.Checked)
            {
                gr.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (rdBtnString.Checked)
            {
                Font f = new Font("Microsoft Sans Serif, 10pt", pen.Width*10);
                gr.DrawString("Hello World!!", f, brush, new Point(cX, cY));
            }
            if (rdBtnEllipseF.Checked)
            {
                gr.FillEllipse(brush, cX, cY, sX, sY);
            }
            if (rdBtnRectangleF.Checked)
            {
                gr.FillRectangle(brush, cX, cY, sX, sY);
            }
        }

        private void pctPaint_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            Draw_paint(gr);
        }

        private void pctPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics _gr = e.Graphics;

            if (paint)
            {
                Draw_paint(_gr);
            }
        }

        private void btnPenColor_Click(object sender, EventArgs e)
        {
            colorDialogPen.ShowDialog();

            pen.Color = colorDialogPen.Color;
            brush.Color = colorDialogPen.Color;

            Button btn = (Button)sender;
            btn.BackColor = colorDialogPen.Color;
        }

        private void numPenWidth_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            pen.Width = Convert.ToInt32(num.Value);
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            string file_name = "";
            OpenFileDialog odlg = new OpenFileDialog();
            if (odlg.ShowDialog() == DialogResult.OK)
            {
                file_name = odlg.FileName;
            }
            try
            { 
                int img_x = Convert.ToInt32(txtX.Text);
                int img_y = Convert.ToInt32(txtY.Text);
                Image img = Image.FromFile(file_name);
                gr.DrawImage(img, new Point(img_x, img_y));
            }
            catch { }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.White);
            pctPaint.Refresh();
        }

        
    }
}
