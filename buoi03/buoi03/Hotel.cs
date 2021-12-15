using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi03
{
    public partial class Hotel : Form
    {
        DataTable df = new DataTable();
        Dictionary<string, int> dicIDRoom = new Dictionary<string, int>();//sử dụng cho chức năng thêm phòng
        public Hotel()
        {
            InitializeComponent();
            df.Columns.Add("Ma", typeof(string));
            df.Columns.Add("Loai", typeof(string));
            df.Columns.Add("Gia", typeof(double));
            df.Columns.Add("TT", typeof(string));
            df.Columns.Add("Ngay", typeof(int));
            //get dictionary for IDRoom
            dicIDRoom.Add("A", 1);
            dicIDRoom.Add("B", 1);
            dicIDRoom.Add("C", 1);
            btnDltRoom.Enabled = false;
            btnOrderRoom.Enabled = false;
            btnPay.Enabled = false;
        }

        void AddRoom(string IDRoom)
        {
            lstViewOrder.Items.Add(IDRoom, 0);
            lstViewOrder.LargeImageList = imgLstRoom;
            lstViewOrder.View = View.LargeIcon;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                string code, typeRoom;
                int day = Convert.ToInt32(numricDay.Value);
                double money;
                typeRoom = cBoxTypeRoom.Text;
                code = typeRoom + dicIDRoom[typeRoom];
                money = Convert.ToDouble(txtRoomRate.Text);
                day = Convert.ToInt32(numricDay.Text);
                //status = Empty/Full khi phong Trong/Day
                string status = (radioBtnEmpty.Checked == true) ? "Empty" : "Full";
                AddRoom(code);
                df.Rows.Add(code, typeRoom, money, status, day);
                string curType = code.Substring(0, 1);
                txtIDRoom.Text = curType + dicIDRoom[curType].ToString();

                int number = dicIDRoom[curType] + 1;
                dicIDRoom[curType] = number;

                df.Rows.Add(code, typeRoom, money, status, day);
            }
            catch { MessageBox.Show("Dữ liệu nhập vào lỗi!!"); }

        }

        private void cBoxTypeRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDRoom.Text = cBoxTypeRoom.Text + dicIDRoom[cBoxTypeRoom.Text].ToString();
        }

        private void lstViewOrder_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string s = "Ma ='" + e.Item.Text + "'";
            DataRow[] drow = df.Select(s);
            txtIDRoom.Text = drow[0]["Ma"].ToString();
            cBoxTypeRoom.Text = drow[0]["Loai"].ToString();
            txtRoomRate.Text = drow[0]["Gia"].ToString();
            numricDay.Value = Convert.ToInt32(drow[0]["Ngay"].ToString());
            if (drow[0]["TT"].ToString() == "Full")
            {
                radioBtnFull.Checked = true;
            }
            else
            {
                radioBtnEmpty.Checked = true;
            }
            if (drow[0]["TT"].ToString() == "Empty")
            {
                btnOrderRoom.Enabled = true;
                btnDltRoom.Enabled = false;
                btnPay.Enabled = false;
                lstViewOrder.Items[e.ItemIndex].BackColor = Color.White;
            }
            else
            {
                btnOrderRoom.Enabled = false;
                btnDltRoom.Enabled = true;
                btnPay.Enabled = true;
                lstViewOrder.Items[e.ItemIndex].BackColor = Color.White;
            }
        }

        private void btnOrderRoom_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem sel = lstViewOrder.SelectedItems[0];
                string s = "Ma ='" + sel.Text + "'";
                DataRow[] row = df.Select(s);
                if (numricDay.Value > 0)
                {
                    radioBtnFull.Checked = true;
                    df.Rows[df.Rows.IndexOf(row[0])]["TT"] = "Full";
                    df.Rows[df.Rows.IndexOf(row[0])]["Ngay"] = numricDay.Value;
                    //thay đổi màu và fontstyle để phân biệt phòng đã đặt và chưa đặt
                    sel.ForeColor = Color.Red;
                    sel.Font = new Font(sel.Font, FontStyle.Bold);
                    MessageBox.Show("Đặt phòng thành công!!!");
                }
                else
                {
                    MessageBox.Show("Ngày nhập không hợp lệ!!!");
                }
            }
            catch { MessageBox.Show("Vui lòng chọn phòng!!"); }
        }

        private void btnDltRoom_Click(object sender, EventArgs e)
        {
            ListViewItem sel = lstViewOrder.SelectedItems[0];
            string s = "Ma ='" + sel.Text + "'";
            DataRow[] row = df.Select(s);
            radioBtnEmpty.Checked = true;
            df.Rows[df.Rows.IndexOf(row[0])]["TT"] = "Empty";
            df.Rows[df.Rows.IndexOf(row[0])]["Ngay"] = 0;
            numricDay.Value = 0;
            //thay đổi màu và fontstyle để phân biệt phòng đã đặt và chưa đặt
            sel.ForeColor = Color.Black;
            sel.Font = new Font(sel.Font, FontStyle.Regular);
            MessageBox.Show("Hủy phòng thành công!!!");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int pay = Convert.ToInt32(numricDay.Value) * Convert.ToInt32(txtRoomRate.Text);
            ListViewItem sel = lstViewOrder.SelectedItems[0];
            string s = "Ma ='" + sel.Text + "'";
            DataRow[] row = df.Select(s);
            radioBtnEmpty.Checked = true;
            df.Rows[df.Rows.IndexOf(row[0])]["TT"] = "Empty";
            df.Rows[df.Rows.IndexOf(row[0])]["Ngay"] = 0;
            numricDay.Value = 0;
            //thay đổi màu và fontstyle để phân biệt phòng đã đặt và chưa đặt
            sel.ForeColor = Color.Black;
            sel.Font = new Font(sel.Font, FontStyle.Regular);
            //Tính tiền luôn
            string myMoney = string.Format("{0:N}", pay).Replace(".00", "");
            MessageBox.Show("Số tiền cần thanh toán: " + myMoney);
        }
    }
}
