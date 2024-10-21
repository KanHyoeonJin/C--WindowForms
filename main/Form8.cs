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
    public partial class Form8 : Form
    {
        private string videoPath;
        public Form8()
        {
            InitializeComponent();
            videoPath = Path.Combine(Program.basePath, "Resources", "sky.mp4");
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            axWindowsMediaPlayer1.URL = videoPath; // 비디오 파일 경로 경로 자기 경로로 맞추기
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }


        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                Form22 form22 = new Form22();
                form22.Show();
                this.Hide(); // 현재 폼 숨기기
            }
        }
    }
}
