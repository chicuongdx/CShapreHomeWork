using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;

namespace buoi12
{
    public partial class FrmMDL : Form
    {
        public string[] Story = File.ReadAllText(Application.StartupPath + "\\Story.txt").Split('\n');
        List<string> tile = new List<string>();
        List<string> body = new List<string>();
        public FrmMDL()
        {
            InitializeComponent();

            for (int idx = 0; idx < Story.Length; idx += 3)
            {
                tile.Add(Story[idx]);
            }
            for (int idx = 1; idx < Story.Length; idx += 3)
            {
                body.Add(Story[idx]);
            }
        }

        private void aBabyAndASockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA01.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - A Baby and a Sock";
            child.story = body[0];
            child.MdiParent = this;
            child.Show();
        }

        private void birdsAndABabyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA02.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - Birds and a Baby";
            child.story = body[1];
            child.MdiParent = this;
            child.Show();
        }

        private void aCatAndADogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA03.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - A Cat and a Dog";
            child.story = body[2];
            child.MdiParent = this;
            child.Show();
        }

        private void theBabyBearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA04.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - The Baby Bear";
            child.story = body[3];
            child.MdiParent = this;
            child.Show();
        }

        private void anApplePieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA05.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - An Apple Pie";
            child.story = body[4];
            child.MdiParent = this;
            child.Show();
        }

        private void theTopBunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA06.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - The Top Bunk";
            child.story = body[5];
            child.MdiParent = this;
            child.Show();
        }

        private void askSantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA07.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - Ask Santa";
            child.story = body[6];
            child.MdiParent = this;
            child.Show();
        }

        private void aBirthdayBikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA08.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - A Birthday Bike";
            child.story = body[7];
            child.MdiParent = this;
            child.Show();
        }

        private void inTheGardenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA09.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - In the Garden";
            child.story = body[8];
            child.MdiParent = this;
            child.Show();
        }

        private void todaysMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA10.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - Today's Mail";
            child.story = body[9];
            child.MdiParent = this;
            child.Show();
        }

        private void boysWillBeBoysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA11.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - Boys Will Be Boys";
            child.story = body[10];
            child.MdiParent = this;
            child.Show();
        }

        private void aGoodMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA12.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - A Good Meal";
            child.story = body[12];
            child.MdiParent = this;
            child.Show();
        }

        private void newShoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA13.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - New Shoes";
            child.story = body[13];
            child.MdiParent = this;
            child.Show();
        }

        private void noFriendsForMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(Application.StartupPath + "\\image\\TA14.jpg");
            FrmStory child = new FrmStory();
            child.pctStory.BackgroundImage = img;
            child.Text = "Story - No Friends for Me";
            child.story = body[14];
            child.MdiParent = this;
            child.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void myStoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Volume = 100;
            ss.Rate = -2;
            ss.SpeakAsync("Hello");
        }
    }
}
