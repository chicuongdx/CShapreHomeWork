using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi11
{
    public partial class FrmFilm : Form
    {
        public DataTable playlist;
        public Dictionary<string, string> curDict;
        public ListViewItem curItem;
        public FrmFilm()
        {
            InitializeComponent();
            playlist = new DataTable();
            playlist.Columns.Add("Name", typeof(string));
            playlist.Columns.Add("ListFilm", typeof(Dictionary<string, string>));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string url = fdlg.FileName.Replace("\\", "/");
                try
                {
                    WMDFilm.URL = url;
                }
                catch { }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMic f = new FrmMic();
            f.Show();
        }

        // Create playlist, playlist
        private bool isLstView(string s)
        {
            foreach (ListViewItem item in lstViewPlayList.Items)
            {
                if (item.Text == s)
                    return true;
            }
            return false;
        }
        private void Add_PLIten(FrmPlayList f)
        {
            string name = f.txtName.Text;
            if (name != "" && !isLstView(name))
            {
                ListViewItem item = new ListViewItem(name, 0);
                lstViewPlayList.Items.Add(item);
            }

            Dictionary<string, string> film = new Dictionary<string, string>();
            playlist.Rows.Add(name, film);
        }
        private void createPlayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstViewPlayList.View = View.Details;
            lstViewPlayList.SmallImageList = imgLst;
            FrmPlayList f = new FrmPlayList();
            f.ShowDialog();

            Add_PLIten(f);
        }

        private void pctAddPlayList_Click(object sender, EventArgs e)
        {
            lstViewPlayList.View = View.LargeIcon;
            lstViewPlayList.LargeImageList = imgLst;
            FrmPlayList f = new FrmPlayList();
            f.ShowDialog();

            Add_PLIten(f);
        } 
        private void lstViewPlayList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lstBoxMusic.Items.Clear();
            e.Item.ImageIndex = 1;
            foreach (ListViewItem item in lstViewPlayList.Items)
            {
                if (item != e.Item)
                    item.ImageIndex = 0;
            }
            string s = "Name='" + e.Item.Text + "'";
            DataRow row = playlist.Select(s)[0];
            Dictionary<string, string> temp = (Dictionary<string, string>)row[1];
            
            foreach (KeyValuePair<string, string> pair in temp)
            {
                lstBoxMusic.Items.Add(pair.Key);
            }

            curDict = temp;
            curItem = e.Item;
        }


        // Add film in playlist, film
        private void lstBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lstBox = (ListBox)sender;
            string curItem = lstBox.SelectedItem.ToString();
            string url = curDict[curItem];

            if (curItem != "")
            {
                WMDFilm.URL = url;
            }
        }
        private void pctAddMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open Video";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string url = fdlg.FileName;
                string name = url.Split('\\')[url.Split('\\').Length-1];
                ListViewItem item = curItem;
                DataRow row = playlist.Select("Name='" + item.Text + "'")[0];
                Dictionary<string, string> dic = (Dictionary<string, string>)row["ListFilm"];
                dic.Add(name, url);
                row["ListFilm"] = dic;

                lstBoxMusic.Items.Add(name);
            }
        }
    }
}
