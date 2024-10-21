using AxWMPLib;
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


namespace main1
{
    public partial class Form1 : Form
    {
        string basePath;
        string videoFilePath;
        public Form1()
        {
            InitializeComponent();
            basePath = AppDomain.CurrentDomain.BaseDirectory;
            videoFilePath = Path.Combine(basePath,"Resources", "시작브금.mp3");
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = @"C:\Users\이대한\Desktop\main1\시작브금.mp3";
            axWindowsMediaPlayer1.URL = videoFilePath;
            axWindowsMediaPlayer1.settings.setMode("loop", true); // 반복 재생
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
