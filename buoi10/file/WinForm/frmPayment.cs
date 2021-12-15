using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt1.Buoi09
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        void LoadData()
        {
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaSP", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SL", typeof(int));
            dt.Columns.Add("Gia", typeof(int));
            dt.Columns.Add("TT", typeof(int));

            dt.Rows.Add("1", "001", "Dầu gội", 1, 99000, 99000);
            dt.Rows.Add("2", "002", "Sữa tắm", 1, 135000, 135000);
            dt.Rows.Add("3", "003", "Nước rửa chén", 1, 88000, 88000);
            dt.Rows.Add("4", "004", "Gạo ST25", 1, 150000, 150000);
            dt.Rows.Add("5", "005", "Nước suối lavie chai 1 lít", 10, 21000, 210000);
            dt.Rows.Add("6", "006", "Nước tăng lực String", 5, 9000, 45000);
            dt.Rows.Add("7", "007", "Dầu ăn Simply chai 5 lít", 1, 209000, 209000);
            dt.Rows.Add("8", "008", "Kem Wall", 3, 11000, 33000);
            dt.Rows.Add("9", "009", "Bánh gạo One One", 2, 18000, 36000);
            dt.Rows.Add("10", "010", "Kẹo bạc hà", 10, 10000, 100000);
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.DataSource = dt;
            int TT = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
                TT = TT + Convert.ToInt32(dt.Rows[i]["TT"].ToString());
            txt_TT.Text = TT.ToString();
            txt_TToan.Text = TT.ToString();            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        { 
            frmReport f = new frmReport();
            f.LoadReport(dt, txtNhanVien.Text, txtKhachHang.Text); 
            f.Show();
        }

        private void picCam_Click(object sender, EventArgs e)
        {
            FrmWCam f = new FrmWCam(); 
            f.Show();
        }
    }
}
