using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace main1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            axWindowsMediaPlayer1.URL = @"C:\Users\이대한\Desktop\main1\시작.mp4"; // 비디오 파일 경로 경로 자기 경로로 맞추기
            axWindowsMediaPlayer1.Ctlcontrols.play();


        }


        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                Form3 form3 = new Form3();
                form3.Show();
                this.Close(); // 현재 폼 숨기기
            }
        }

    }
}
