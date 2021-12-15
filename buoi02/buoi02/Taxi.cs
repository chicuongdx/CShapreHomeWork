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
    public partial class Taxi : Form
    {
        public Taxi()
        {
            InitializeComponent();
        }

        private void Taxi_Load(object sender, EventArgs e)
        {

        }

        private void pctBoxCalculator_Click(object sender, EventArgs e)
        {
            int Sokm = Int32.Parse(TextBoxKm.Text);
            int Sale = Convert.ToInt32(TextBoxSale.Text);

            int result = 0;
            if (Sokm < 5)
                result = Sokm * 14000;
            if (Sokm < 26 && Sokm >= 4)
                result = 14000 * 4 + (Sokm - 4) * 16000;
            if (Sokm >= 26)
                result = 4 * 14000 + 21 * 16000 + 12000 * (Sokm - 25);

            int myMoney = result - result * Sale / 100;

            TextBoxTT.Text = string.Format("{0:N}", myMoney).Replace(".00", "");

        }
    }
}
