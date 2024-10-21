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
using static System.Windows.Forms.DataFormats;

namespace main1
{
    public partial class Form3 : Form
    {
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string videoPath;
        public Form3()
        {
            InitializeComponent();
            videoPath = Path.Combine(Program.basePath, "Resources","home.mp3");
            player.URL = videoPath;
        }

        private void home1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); // Form4 인스턴스 생성
            player.controls.stop();
            form5.Show();              // Form4 창을 표시
            this.Hide();               // 현재 폼을 숨김
        }

        private void home2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // Form4 인스턴스 생성
            player.controls.stop();
            form4.Show();              // Form4 창을 표시
            this.Hide();               // 현재 폼을 숨김
        }

        private void home3_Click(object sender, EventArgs e)
        {
            Form46 form46 = new Form46(); // Form4 인스턴스 생성
            player.controls.stop();
            form46.Show();              // Form4 창을 표시
            this.Hide();               // 현재 폼을 숨김
        }

        private void home4_Click(object sender, EventArgs e)
        {
            Form47 form47 = new Form47(); // Form4 인스턴스 생성
            player.controls.stop();
            form47.Show();              // Form4 창을 표시
            this.Hide();               // 현재 폼을 숨김
        }

        private void home5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(); // Form4 인스턴스 생성
            player.controls.stop();
            form8.Show();              // Form4 창을 표시
            this.Hide();               // 현재 폼을 숨김
        }
    }
}
