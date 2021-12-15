using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace buoi11
{
    public partial class FrmMic : Form
    {
        public FrmMic()
        {
            InitializeComponent();
        }

        private void pctVoice_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Volume = 100;
            ss.Rate = -2;
            ss.SpeakAsync(lbAbout.Text);
        }
    }
}
