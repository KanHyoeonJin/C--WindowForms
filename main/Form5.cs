using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace main1
{
    public partial class Form5 : Form
    {
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string videoPath;
        public Form5()
        {
            InitializeComponent();
            videoPath = Path.Combine(Program.basePath, "Resources", "Town.mp3");
            player.URL = videoPath;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            player.controls.stop();
            form21.Show();
            this.Close();
        }
    }
}
