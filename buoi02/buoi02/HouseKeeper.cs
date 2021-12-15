using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi02
{
    public partial class HouseKeeper : Form
    {
        public HouseKeeper()
        {
            InitializeComponent();
            pnlInfor.Visible = false;
        }

        private void pctBoxHome_Click(object sender, EventArgs e)
        {
            PictureBox picHome = sender as PictureBox;
            PictureBox picShop = pctBoxShop as PictureBox;

            if (picHome.BackColor != Color.White)
            {
                return;
            }
            else
            {
                picHome.BackColor = Color.ForestGreen;
                picShop.BackColor = Color.White;
                pnlInfor.Visible = false;
            }
        }

        private void pctBoxShop_Click(object sender, EventArgs e)
        {
            PictureBox picShop = sender as PictureBox;
            PictureBox picHome = pctBoxHome as PictureBox;

            if (picShop.BackColor != Color.White)
            {
                return;
            }
            else
            {
                picShop.BackColor = Color.ForestGreen;
                picHome.BackColor = Color.White;
                pnlInfor.Visible = true;
            }
        }

        private void btnWashing_Click(object sender, EventArgs e)
        {
            Button btnService = sender as Button;
            Color teal = Color.Teal;
            Color turquoise = Color.DarkTurquoise;
            if (btnService.BackColor == turquoise)
            {
                btnService.BackColor = teal;
                txtWashing.Text = string.Format("{0:N}", 100000).Replace(".00", "");
            }
            else
            {
                btnService.BackColor = turquoise;
                txtWashing.Text = 0.ToString();
            }
        }

        private void btnAir_Click(object sender, EventArgs e)
        {
            Button btnService = sender as Button;
            Color teal = Color.Teal;
            Color turquoise = Color.DarkTurquoise;
            if (btnService.BackColor == turquoise)
            {
                btnService.BackColor = teal;
                txtAir.Text = string.Format("{0:N}", 150000).Replace(".00", "");
            }
            else
            {
                btnService.BackColor = turquoise;
                txtAir.Text = 0.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Button btnService = sender as Button;
            Color teal = Color.Teal;
            Color turquoise = Color.DarkTurquoise;
            if (btnService.BackColor == turquoise)
            {
                btnService.BackColor = teal;
                txtClear.Text = string.Format("{0:N}", 200000).Replace(".00", "");
            }
            else
            {
                btnService.BackColor = turquoise;
                txtClear.Text = 0.ToString();
            }
        }

        private void btnSanitation_Click(object sender, EventArgs e)
        {
            Button btnService = sender as Button;
            Color teal = Color.Teal;
            Color turquoise = Color.DarkTurquoise;
            if (btnService.BackColor == turquoise)
            {
                btnService.BackColor = teal;
                txtSanitation.Text = string.Format("{0:N}", 400000).Replace(".00", "");
            }
            else
            {
                btnService.BackColor = turquoise;
                txtSanitation.Text = 0.ToString();
            }
        }

        private void btnCooking_Click(object sender, EventArgs e)
        {
            Button btnService = sender as Button;
            Color teal = Color.Teal;
            Color turquoise = Color.DarkTurquoise;
            if (btnService.BackColor == turquoise)
            {
                btnService.BackColor = teal;
                txtCooking.Text = string.Format("{0:N}", 300000).Replace(".00", "");
            }
            else
            {
                btnService.BackColor = turquoise;
                txtCooking.Text = 0.ToString();
            }
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            Button btnService = sender as Button;
            Color teal = Color.Teal;
            Color turquoise = Color.DarkTurquoise;
            if (btnService.BackColor == turquoise)
            {
                btnService.BackColor = teal;
                txtOther.Text = string.Format("{0:N}", 500000).Replace(".00", "");
            }
            else
            {
                btnService.BackColor = turquoise;
                txtOther.Text = 0.ToString();
            }
        }

        private void txtWashing_TextChanged(object sender, EventArgs e)
        {
            int washing = Int32.Parse(txtWashing.Text.Replace(",", ""));
            int air = Int32.Parse(txtAir.Text.Replace(",", ""));
            int clear = Int32.Parse(txtClear.Text.Replace(",", ""));
            int sanitation = Int32.Parse(txtSanitation.Text.Replace(",", ""));
            int cooking = Int32.Parse(txtCooking.Text.Replace(",", ""));
            int other = Int32.Parse(txtOther.Text.Replace(",", ""));

            int myMoney = washing + air + clear + sanitation + cooking + other;

            txtTotal.Text = string.Format("{0:N}", myMoney).Replace(".00", "");
        }

        private void txtCooking_TextChanged(object sender, EventArgs e)
        {
            int washing = Int32.Parse(txtWashing.Text.Replace(",", ""));
            int air = Int32.Parse(txtAir.Text.Replace(",", ""));
            int clear = Int32.Parse(txtClear.Text.Replace(",", ""));
            int sanitation = Int32.Parse(txtSanitation.Text.Replace(",", ""));
            int cooking = Int32.Parse(txtCooking.Text.Replace(",", ""));
            int other = Int32.Parse(txtOther.Text.Replace(",", ""));

            int myMoney = washing + air + clear + sanitation + cooking + other;

            txtTotal.Text = string.Format("{0:N}", myMoney).Replace(".00", "");
        }

        private void txtClear_TextChanged(object sender, EventArgs e)
        {
            int washing = Int32.Parse(txtWashing.Text.Replace(",", ""));
            int air = Int32.Parse(txtAir.Text.Replace(",", ""));
            int clear = Int32.Parse(txtClear.Text.Replace(",", ""));
            int sanitation = Int32.Parse(txtSanitation.Text.Replace(",", ""));
            int cooking = Int32.Parse(txtCooking.Text.Replace(",", ""));
            int other = Int32.Parse(txtOther.Text.Replace(",", ""));

            int myMoney = washing + air + clear + sanitation + cooking + other;

            txtTotal.Text = string.Format("{0:N}", myMoney).Replace(".00", "");
        }

        private void txtSanitation_TextChanged(object sender, EventArgs e)
        {
            int washing = Int32.Parse(txtWashing.Text.Replace(",", ""));
            int air = Int32.Parse(txtAir.Text.Replace(",", ""));
            int clear = Int32.Parse(txtClear.Text.Replace(",", ""));
            int sanitation = Int32.Parse(txtSanitation.Text.Replace(",", ""));
            int cooking = Int32.Parse(txtCooking.Text.Replace(",", ""));
            int other = Int32.Parse(txtOther.Text.Replace(",", ""));

            int myMoney = washing + air + clear + sanitation + cooking + other;

            txtTotal.Text = string.Format("{0:N}", myMoney).Replace(".00", "");
        }

        private void txtAir_TextChanged(object sender, EventArgs e)
        {
            int washing = Int32.Parse(txtWashing.Text.Replace(",", ""));
            int air = Int32.Parse(txtAir.Text.Replace(",", ""));
            int clear = Int32.Parse(txtClear.Text.Replace(",", ""));
            int sanitation = Int32.Parse(txtSanitation.Text.Replace(",", ""));
            int cooking = Int32.Parse(txtCooking.Text.Replace(",", ""));
            int other = Int32.Parse(txtOther.Text.Replace(",", ""));

            int myMoney = washing + air + clear + sanitation + cooking + other;

            txtTotal.Text = string.Format("{0:N}", myMoney).Replace(".00", "");
        }

        private void txtOther_TextChanged(object sender, EventArgs e)
        {
            int washing = Int32.Parse(txtWashing.Text.Replace(",", ""));
            int air = Int32.Parse(txtAir.Text.Replace(",", ""));
            int clear = Int32.Parse(txtClear.Text.Replace(",", ""));
            int sanitation = Int32.Parse(txtSanitation.Text.Replace(",", ""));
            int cooking = Int32.Parse(txtCooking.Text.Replace(",", ""));
            int other = Int32.Parse(txtOther.Text.Replace(",", ""));

            int myMoney = washing + air + clear + sanitation + cooking + other;

            txtTotal.Text = string.Format("{0:N}", myMoney).Replace(".00", "");
        }
    }
}
