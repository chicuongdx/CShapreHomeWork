using System;
using System.Collections.Generic;
using System.Threading;
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
using ZXing;
using ZXing.QrCode;
using ZXing.Common;
using System.Drawing.Imaging;

namespace buoi10
{
    public partial class Payment : Form
    {

        private Capture cap;

        public static DataTable dt = new DataTable();

        private DataTable df = new DataTable();

        int index = 1;

        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            LoadData();
            //gridViewData.DataSource = dt;
            //int TT = 0;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //    TT = TT + Convert.ToInt32(dt.Rows[i]["TT"].ToString());
            //txt_TT.Text = TT.ToString();
            //txt_TToan.Text = TT.ToString();

            cap = new Capture(0);
            timer.Start();
        }
        void LoadData()
        {
            df.Columns.Add("STT", typeof(int));
            df.Columns.Add("MaSP", typeof(string));
            df.Columns.Add("TenSP", typeof(string));
            df.Columns.Add("SL", typeof(int));
            df.Columns.Add("Gia", typeof(int));
            df.Columns.Add("TT", typeof(int));

            //dt.Rows.Add("1", "001", "Dầu gội", 1, 99000, 99000);
            //dt.Rows.Add("2", "002", "Sữa tắm", 1, 135000, 135000);
            //dt.Rows.Add("3", "003", "Nước rửa chén", 1, 88000, 88000);
            //dt.Rows.Add("4", "004", "Gạo ST25", 1, 150000, 150000);
            //dt.Rows.Add("5", "005", "Nước suối lavie chai 1 lít", 10, 21000, 210000);
            //dt.Rows.Add("6", "006", "Nước tăng lực String", 5, 9000, 45000);
            //dt.Rows.Add("7", "007", "Dầu ăn Simply chai 5 lít", 1, 209000, 209000);
            //dt.Rows.Add("8", "008", "Kem Wall", 3, 11000, 33000);
            //dt.Rows.Add("9", "009", "Bánh gạo One One", 2, 18000, 36000);
            //dt.Rows.Add("10", "010", "Kẹo bạc hà", 10, 10000, 100000);

            dt.Columns.Add("MaSP", typeof(string));
            dt.Columns.Add("TenSp", typeof(string));
            dt.Columns.Add("Gia", typeof(int));
            dt.Columns.Add("QRCode", typeof(Image));

            dt.Rows.Add("001", "Dầu gội", 99000, QRCode("001", 32));
            dt.Rows.Add("002", "Sữa tắm", 135000, QRCode("002", 32));
            dt.Rows.Add("003", "Nước rửa chén", 88000, QRCode("003", 32));
            dt.Rows.Add("004", "Gạo ST25", 150000, QRCode("004", 32));
            dt.Rows.Add("005", "Nước suối lavie chai 1 lít", 21000, QRCode("005", 32));
            dt.Rows.Add("006", "Nước tăng lực String", 9000, QRCode("006", 32));
            dt.Rows.Add("007", "Dầu ăn Simply chai 5 lít", 209000, QRCode("007", 32));
            dt.Rows.Add("008", "Kem Wall", 11000, QRCode("008", 32));
            dt.Rows.Add("009", "Bánh gạo One One", 18000, QRCode("009", 32));
            dt.Rows.Add("010", "Kẹo bạc hà", 10000, QRCode("010", 32));
        }
        public static void SaveQrText(string s)
        {
            Image qr = QRCode(s, 512);
            qr.Save("D:\\CLOUDX\\Courses\\Nam3\\C#\\buoi10\\file\\Cam\\QR" + s + ".png");
        }   

        private void timer_Tick(object sender, EventArgs e)
        {
            Image<Bgr, byte> nextFrame = cap.QueryFrame();
            pctWebcam.BackgroundImage = nextFrame.ToBitmap();

            try
            {
                string s = QR2String((Bitmap)pctWebcam.BackgroundImage);
                Add_Data(s);
            }
            catch { }
        }



        private void pctTitle_Click(object sender, EventArgs e)
        {
            Product form = new Product();
            form.Show();
        }

        public static Bitmap QRCode(string code, int size)
        {
            QRCodeWriter writer = new QRCodeWriter();
            BitMatrix bitMatrix = writer.encode(code, BarcodeFormat.QR_CODE, size, size);

            int w = bitMatrix.Width;
            int h = bitMatrix.Height;
            Bitmap bmp = new Bitmap(w, h);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    bmp.SetPixel(i, j, bitMatrix[i, j] ? Color.Black : Color.White);
                }
            }

            return bmp;
        }
        public static string QR2String(Bitmap bmp)
        {
            string res = "";

            try
            {
                BarcodeReader reader = new BarcodeReader();

                Result result = reader.Decode(bmp);

                if (result != null)
                    res = result.ToString();
            }
            catch { res = ""; }

            Console.WriteLine(res);

            return res;
        }

        private bool ContainKey(DataTable table, DataRow row)
        {
            string key = row["MaSP"].ToString();
            foreach(DataRow dr in table.Rows)
            {
                string s = dr["MaSP"].ToString();
                if (s == key)
                    return true;
            }
            return false;
        }

        private void Add_Data(string s)
        {
            string key = "MaSp='" + s + "'";
            try
            {
                DataRow row = dt.Select(key)[0];

                if (ContainKey(df, row))
                {
                    DataRow temp = df.Select(key)[0];
                    int num = Convert.ToInt32(temp["SL"]) + 1;

                    df.Rows[df.Rows.IndexOf(temp)]["SL"] = num;
                    df.Rows[df.Rows.IndexOf(temp)]["TT"] = num * Convert.ToInt32(df.Rows[df.Rows.IndexOf(temp)]["Gia"]);
                }
                else
                {
                    string tensp = row["TenSp"].ToString();
                    int gia = Convert.ToInt32(row["Gia"]);
                    int TT = gia * 1;
                    df.Rows.Add(index, s, tensp, 1, gia, TT);
                    index += 1;
                }

                gridViewData.DataSource = df;

                int pay = 0;
                for (int i = 0; i < df.Rows.Count; i++)
                    pay = pay + Convert.ToInt32(df.Rows[i]["TT"].ToString());
                txt_TT.Text = pay.ToString();
                double payment = (pay * (1 - Convert.ToDouble(txt_KM.Text) / 100));
                txt_TToan.Text = payment.ToString();

                Thread.Sleep(1000);
            }
            catch { }
        }
    }
}
