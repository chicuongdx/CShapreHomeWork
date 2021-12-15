using System;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.ML;

namespace buoi10
{
    public partial class FrmWebCam : Form
    {
        public FrmWebCam()
        {
            InitializeComponent();
        }

        private Capture cap;

        private void FrmWebCam_Load(object sender, EventArgs e)
        {
            cap = new Capture(0);
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //tạo mot bien nextframe de chup anh
            Image<Bgr, byte> nextFrame = cap.QueryFrame();
            Image gray = ToolStripRenderer.CreateDisabledImage(nextFrame.ToBitmap());
            p1.Image = nextFrame.ToBitmap();
            p2.Image = gray;
        }

        private Bitmap screenBitmap;
        private Graphics screenGraphics;
        private void btn_OK_Click(object sender, EventArgs e)
        {
            screenBitmap = new Bitmap(p1.Width, p1.Height, PixelFormat.Format32bppArgb);
            screenGraphics = Graphics.FromImage(screenBitmap);
            screenGraphics.CopyFromScreen(new Point(p1.Left, p1.Top), Point.Empty, p1.Size);
            screenBitmap.Save("D:\\CLOUDX\\Courses\\Nam3\\C#\\buoi10\\file\\Cam\\Image" + cbo_Frame.Text + ".png",
            ImageFormat.Png);
        }
    }
}
