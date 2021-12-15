using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi05
{
    public partial class Exam : Form
    {
        DataTable dt = new DataTable();
        public static int idAns = 1;
        public static int idxMax = 1;

        public static string text = System.IO.File.ReadAllText("D:/CLOUDX/Courses/Nam3/C#/buoi05/file/TracNghiem_01.txt");
        string key = System.IO.File.ReadAllText("D:/CLOUDX/Courses/Nam3/C#/buoi05/file/DapAn_01.txt");
        public Exam()
        {
            InitializeComponent();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Quiz", typeof(string));
            dt.Columns.Add("A", typeof(string));
            dt.Columns.Add("B", typeof(string));
            dt.Columns.Add("C", typeof(string));
            dt.Columns.Add("D", typeof(string));
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Answer", typeof(string));
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            string[] lstQuiz = text.Split('\n');
            string[] lstKey = key.Split('\n');
            int idx = 0;
            for (int i=0; i<lstKey.Length; i++)
            {
                string Quiz = lstQuiz[idx];
                string[] ans = lstQuiz[idx + 1].Split('\t');
                dt.Rows.Add(i + 1, Quiz, ans[0], ans[1], ans[2], ans[3], lstKey[i][0].ToString(), "");
                idx += 2;
            }
        }

        private void Test_Show(int id)
        {
            string s = "ID='" + id.ToString() + "'";
            DataRow row = dt.Select(s)[0];
            lbQuiz.Text = row["Quiz"].ToString();
            rdBtnA.Text = row["A"].ToString();
            rdBtnB.Text = row["B"].ToString();
            rdBtnC.Text = row["C"].ToString();
            rdBtnD.Text = row["D"].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctImportKey_Click(object sender, EventArgs e)
        {
            
            string[] lst_text = key.Split('\n');
            int idx = 1;
            string res = "";
            foreach(var word in lst_text)
            {
                res += "Question " + idx.ToString() + ": " + word.ToString() + '\n';
                idx++;
            }
            richTxtKey.Text = res;
        }

        private void pctImportQiz_Click(object sender, EventArgs e)
        {
            richTxtTest.Text = text;      
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            pnlImport.Visible = true;
            pnlTest.Visible = false;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            pnlImport.Visible = false;
            pnlTest.Visible = true;
            Test_Show(1);
        }

        //next-back answer
        private void Add_res(int res)//res=0=false, res=1=true
        {
            if (idAns == idxMax)
            {
                string quiz = "Q" + idAns.ToString();
                lstViewRes.Items.Add(quiz, res);
                idxMax += 1;
            }
        }
        private void pctNext_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "ID='" + idAns.ToString() + "'";
                DataRow row = dt.Select(s)[0];
                //chose answer
                string choice = "";
                if (rdBtnA.Checked)
                    choice = "A";
                if (rdBtnB.Checked)
                    choice = "B";
                if (rdBtnC.Checked)
                    choice = "C";
                if (rdBtnD.Checked)
                    choice = "D";

                dt.Rows[dt.Rows.IndexOf(row)]["Answer"] = choice;
                // check answer
                string cor = row["Key"].ToString();
                string ans = row["Answer"].ToString();
                int res = cor == ans ? 1 : 0;
                Add_res(res);
                    
                //next question
                idAns += 1;
                Test_Show(idAns);
            }
            catch
            {
                idAns -= 1;
                MessageBox.Show("Bạn đã hoàn thành câu hỏi cuối cùng");
            }
        }

        private void pctBack_Click(object sender, EventArgs e)
        {
            try
            {
                idAns -= 1;
                Test_Show(idAns);
            }
            catch
            {
                idAns += 1;
                MessageBox.Show("Bạn hiện tại đang ở câu đầu tiên");
            }
        }

        //Answer the question
        private void rdBtnA_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdbtn = (RadioButton)sender;
            string s = "ID='" + idAns.ToString() + "'";
            int idx = dt.Rows.IndexOf(dt.Select(s)[0]);
            if (rdbtn.Checked == true)
                dt.Rows[idx]["Answer"] = "A";
        }

        private void rdBtnB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdbtn = (RadioButton)sender;
            string s = "ID='" + idAns.ToString() + "'";
            int idx = dt.Rows.IndexOf(dt.Select(s)[0]);
            if (rdbtn.Checked == true)
                dt.Rows[idx]["Answer"] = "B";
        }

        private void rdBtnC_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdbtn = (RadioButton)sender;
            string s = "ID='" + idAns.ToString() + "'";
            int idx = dt.Rows.IndexOf(dt.Select(s)[0]);
            if (rdbtn.Checked == true)
                dt.Rows[idx]["Answer"] = "C";
        }

        private void rdBtnD_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdbtn = (RadioButton)sender;
            string s = "ID='" + idAns.ToString() + "'";
            int idx = dt.Rows.IndexOf(dt.Select(s)[0]);
            if (rdbtn.Checked == true)
                dt.Rows[idx]["Answer"] = "D";
        }

        // result board
        private void btnRes_Click(object sender, EventArgs e)
        {
            lstViewRes.LargeImageList = imgLstView;
            lstViewRes.View = View.LargeIcon;
            rdBtnA.Enabled = false;
            rdBtnB.Enabled = false;
            rdBtnC.Enabled = false;
            rdBtnD.Enabled = false;
            int tr = 0;
            int fl = 0;
            for (int idx = 0; idx < lstViewRes.Items.Count; idx ++)
            {
                bool check = dt.Rows[idx]["Answer"].ToString() == dt.Rows[idx]["Key"].ToString();
                if (check)
                    tr++;
                else
                    fl++;
            }
            lbTrue.Text = "True " + tr.ToString();
            lbFalse.Text = "False" + fl.ToString();
        }

        // select item
        private void lstViewRes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string s = "";
            try
            {
                s = "ID='" + e.Item.Text[1] + e.Item.Text[2] + "'";
            }
            catch
            {
                s = "ID='" + e.Item.Text[1] + "'";
            }
            DataRow row = dt.Select(s)[0];
            lbQuiz.Text = row["Quiz"].ToString();
            rdBtnA.Text = row["A"].ToString();
            rdBtnB.Text = row["B"].ToString();
            rdBtnC.Text = row["C"].ToString();
            rdBtnD.Text = row["D"].ToString();
            string ans = row["Answer"].ToString();
            if (ans == "A")
                rdBtnA.Checked = true;
            if (ans == "B")
                rdBtnB.Checked = true;
            if (ans == "C")
                rdBtnC.Checked = true;
            if (ans == "D")
                rdBtnD.Checked = true;
            if (ans == "")
            {
                rdBtnA.Checked = false;
                rdBtnB.Checked = false;
                rdBtnC.Checked = false;
                rdBtnD.Checked = false;
            }
            idAns = Convert.ToInt32(e.Item.Text[1].ToString());
        }
    }
}
