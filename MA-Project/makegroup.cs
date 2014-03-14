using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MA_Project
{
    public partial class makegroup : Form
    {
        public makegroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mkAeen mka = new mkAeen();
            mka.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mkAhdaf mkah = new mkAhdaf();
            mkah.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mkvazayef mkv = new mkvazayef();
            mkv.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mktarh mkt = new mktarh();
            mkt.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mkjalasat mkj = new mkjalasat();
            mkj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mkAza mkaz = new mkAza();
            mkaz.Show();
        }
    }
}
