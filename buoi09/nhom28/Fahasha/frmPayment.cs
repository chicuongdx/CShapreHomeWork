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
            dt.Columns.Add("Ten", typeof(string));
            dt.Columns.Add("SL", typeof(int));
            dt.Columns.Add("TT", typeof(int));

            dt.Rows.Add("1", "Bách Khoa Toàn Thư Cho Bé - Rèn Luyện Ý Thức", 1, 58727);
            dt.Rows.Add("2", "Bé Tập Kể Chuyện - Những Tiếng Kêu Đáng Yêu", 1, 9592);
            dt.Rows.Add("3", "Sách Chuyển Động - Busy - Holiday - Kỳ Nghỉ", 1, 87112);
            dt.Rows.Add("4", "Sách Chuyển Động - Busy - Fire Station - Trạm Cứu Hỏa", 1, 87357);
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
            f.LoadReport(dt, txtKhachHang.Text, txtDiaChi.Text, txtSDT.Text); 
            f.Show();
        }
    }
}
