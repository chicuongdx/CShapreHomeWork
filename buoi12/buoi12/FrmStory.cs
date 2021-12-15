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
    public partial class FrmStory : Form
    {
        public string story;
        SpeechSynthesizer ss = new SpeechSynthesizer();
        public FrmStory()
        {
            InitializeComponent();
        }

        private void pctVoice_Click(object sender, EventArgs e)
        {
            ss.Volume = 100;
            ss.Rate = -2;
            ss.SpeakAsync(story);
        }

        private void pctMute_Click(object sender, EventArgs e)
        {
            ss.Pause();
        }
    }
}
