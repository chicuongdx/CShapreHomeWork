using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi07
{
    public partial class Game : Form
    {
        int step = 0;
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            btnGame1.Select();
        }


        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                    return true;
            }
            return base.IsInputKey(keyData);
        }

        private void btnGame1_KeyDown(object sender, KeyEventArgs e)
        {

            base.OnKeyDown(e);
            

            Button btn = (Button)sender as Button;
            switch (e.KeyCode)
            { 
                case Keys.S:
                    btn.BackColor = btnGame4.BackColor;
                    btnGame4.BackColor = Color.White;
                    btnGame4.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.D:
                    btn.BackColor = btnGame2.BackColor;
                    btnGame2.BackColor = Color.White;
                    btnGame2.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
            }
        }

        private void btnGame2_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = (Button)sender as Button;
            switch (e.KeyCode)
            {
                case Keys.S:
                    btn.BackColor = btnGame5.BackColor;
                    btnGame5.BackColor = Color.White;
                    btnGame5.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.D:
                    btn.BackColor = btnGame3.BackColor;
                    btnGame3.BackColor = Color.White;
                    btnGame3.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.A:
                    btn.BackColor = btnGame1.BackColor;
                    btnGame1.BackColor = Color.White;
                    btnGame1.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
            }
        }

        private void btnGame3_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = (Button)sender as Button;
            switch (e.KeyCode)
            {
                case Keys.S:
                    btn.BackColor = btnGame6.BackColor;
                    btnGame6.BackColor = Color.White;
                    btnGame6.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.A:
                    btn.BackColor = btnGame2.BackColor;
                    btnGame2.BackColor = Color.White;
                    btnGame2.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
            }
        }

        private void btnGame4_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = (Button)sender as Button;
            switch (e.KeyCode)
            {
                case Keys.W:
                    btn.BackColor = btnGame1.BackColor;
                    btnGame1.BackColor = Color.White;
                    btnGame1.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.S:
                    btn.BackColor = btnGame7.BackColor;
                    btnGame7.BackColor = Color.White;
                    btnGame7.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.D:
                    btn.BackColor = btnGame5.BackColor;
                    btnGame5.BackColor = Color.White;
                    btnGame5.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
            }
        }

        private void btnGame5_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = (Button)sender as Button;
            switch (e.KeyCode)
            {
                case Keys.W:
                    btn.BackColor = btnGame2.BackColor;
                    btnGame2.BackColor = Color.White;
                    btnGame2.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.S:
                    btn.BackColor = btnGame8.BackColor;
                    btnGame8.BackColor = Color.White;
                    btnGame8.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.D:
                    btn.BackColor = btnGame6.BackColor;
                    btnGame6.BackColor = Color.White;
                    btnGame6.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.A:
                    btn.BackColor = btnGame4.BackColor;
                    btnGame4.BackColor = Color.White;
                    btnGame4.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
            }

        }

        private void btnGame6_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = (Button)sender as Button;
            switch (e.KeyCode)
            {
                case Keys.W:
                    btn.BackColor = btnGame3.BackColor;
                    btnGame3.BackColor = Color.White;
                    btnGame3.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.S:
                    btn.BackColor = btnGame9.BackColor;
                    btnGame9.BackColor = Color.White;
                    btnGame9.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.A:
                    btn.BackColor = btnGame5.BackColor;
                    btnGame5.BackColor = Color.White;
                    btnGame5.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
            }
        }

        private void btnGame7_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = (Button)sender as Button;
            switch (e.KeyCode)
            {
                case Keys.W:
                    btn.BackColor = btnGame4.BackColor;
                    btnGame4.BackColor = Color.White;
                    btnGame4.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.D:
                    btn.BackColor = btnGame8.BackColor;
                    btnGame8.BackColor = Color.White;
                    btnGame8.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
            }
        }

        private void btnGame8_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = (Button)sender as Button;
            switch (e.KeyCode)
            {
                case Keys.W:
                    btn.BackColor = btnGame5.BackColor;
                    btnGame5.BackColor = Color.White;
                    btnGame5.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.D:
                    btn.BackColor = btnGame9.BackColor;
                    btnGame9.BackColor = Color.White;
                    btnGame9.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.A:
                    btn.BackColor = btnGame7.BackColor;
                    btnGame7.BackColor = Color.White;
                    btnGame7.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
            }
        }

        private void btnGame9_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = (Button)sender as Button;
            switch (e.KeyCode)
            {
                case Keys.W:
                    btn.BackColor = btnGame6.BackColor;
                    btnGame6.BackColor = Color.White;
                    btnGame6.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
                case Keys.A:
                    btn.BackColor = btnGame8.BackColor;
                    btnGame8.BackColor = Color.White;
                    btnGame8.Focus();
                    step++;
                    lbStep.Text = step.ToString();
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int idx = rand.Next(imgLstExam.Images.Count);
            pctBoxExam.BackgroundImage = imgLstExam.Images[idx];
            btnGame1.Select();

            step = 0;
            lbStep.Text = step.ToString();

            //set color
            btnGame1.BackColor = Color.White;
            btnGame2.BackColor = Color.Red;
            btnGame3.BackColor = Color.Green;
            btnGame4.BackColor = Color.Blue;
            btnGame5.BackColor = Color.Green;
            btnGame6.BackColor = Color.Blue;
            btnGame7.BackColor = Color.Green;
            btnGame8.BackColor = Color.Blue;
            btnGame9.BackColor = Color.Red;
        }
    }
}
