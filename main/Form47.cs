﻿using System;
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
    public partial class Form47 : Form
    {
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string videoPath;
        public Form47()
        {
            InitializeComponent();
            videoPath = Path.Combine(Program.basePath, "Resources", "Town.mp3");
            player.URL = videoPath;
        }
        public Form47(int a)
        {
            InitializeComponent();
            videoPath = Path.Combine(Program.basePath, "Resources", "Town.mp3");
            player.URL = videoPath;
            Go_question3.Enabled = false;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Go_question3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form30 form30 = new Form30();
            player.controls.stop();
            form30.Show();
            pictureBox1.Visible=false;
            this.Hide();
        }
    }
}
