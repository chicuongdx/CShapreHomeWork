using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi10
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        //private void LoadData()
        //{
        //    Payment.dt.Columns.Add("MaSP", typeof(string));
        //    Payment.dt.Columns.Add("TenSp", typeof(string));
        //    Payment.dt.Columns.Add("Gia", typeof(int));

        //    Payment.dt.Rows.Add("001", "Dầu gội", 99000);
        //    Payment.dt.Rows.Add("002", "Sữa tắm", 135000);
        //    Payment.dt.Rows.Add("003", "Nước rửa chén", 88000);
        //    Payment.dt.Rows.Add("004", "Gạo ST25", 150000);
        //    Payment.dt.Rows.Add("005", "Nước suối lavie chai 1 lít", 21000);
        //    Payment.dt.Rows.Add("006", "Nước tăng lực String", 9000);
        //    Payment.dt.Rows.Add("007", "Dầu ăn Simply chai 5 lít", 209000);
        //    Payment.dt.Rows.Add("008", "Kem Wall", 11000);
        //    Payment.dt.Rows.Add("009", "Bánh gạo One One", 18000);
        //    Payment.dt.Rows.Add("010", "Kẹo bạc hà", 10000);
        //}
        private void Product_Load(object sender, EventArgs e)
        {
            //LoadData();
            gridViewData.DataSource = Payment.dt;
        }

        private void pctSave_Click(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            temp.Columns.Add("MaSP", typeof(string));
            temp.Columns.Add("TenSp", typeof(string));
            temp.Columns.Add("Gia", typeof(int));
            temp.Columns.Add("QRCode", typeof(Image));

            foreach (DataRow row in ((DataTable)gridViewData.DataSource).Rows)
            {
                string MaSp = row["MaSP"].ToString();
                string tenSP = row["TenSp"].ToString();
                int gia = Convert.ToInt32(row["Gia"]);
                Image qr = Payment.QRCode(MaSp, 32);
                temp.Rows.Add(MaSp, tenSP, gia, qr);
                //Payment.SaveQrText(MaSp);
            }
            
            Payment.dt = temp;
            MessageBox.Show("Save Success!");
        }
    }
}
