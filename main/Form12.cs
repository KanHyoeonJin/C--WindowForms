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
    public partial class Form12 : Form
    {
        private System.Windows.Forms.Timer timer;
        private int currentImageIndex = 0;
        private WindowsMediaPlayer success = new WindowsMediaPlayer();
        private WindowsMediaPlayer failure = new WindowsMediaPlayer();
        private string videoSuccess;
        private string videoFailure;
        private bool result;
        public Form12(bool result)
        {
            InitializeComponent();
            this.result = result;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 3초
            timer.Tick += Timer_Tick;
            videoSuccess = Path.Combine(Program.basePath, "Resources", "correct.mp3");
            videoFailure = Path.Combine(Program.basePath, "Resources", "Wrong.mp3");
            success.settings.setMode("loop", false);
            failure.settings.setMode("loop", false);
            if (result)
            {
                timer.Interval = 850; // 0.75초
                success.URL = videoSuccess;
                success.controls.play();
            }
            else
            {
                timer.Interval = 1111; // 0.75초
                failure.URL = videoFailure;
                failure.controls.play();
            }
            HideAllPictures();

            ShowNextImage();
        }
        private void HideAllPictures()
        {
            All1.Visible = false;
            All2.Visible = false;
            True1.Visible = false;
            True2.Visible = false;
            False1.Visible = false;
            False2.Visible = false;
            pictureBox1.Visible = false;
        }

        private void ShowNextImage()
        {
            // 현재 이미지 인덱스에 따라 이미지 보이기
            HideAllPictures(); // 먼저 모든 이미지 숨기기
            if (result)
            {
                switch (currentImageIndex)
                {

                    case 0:
                        All1.Visible = true;
                        break;
                    case 1:
                        All2.Visible = true;
                        break;
                    case 2:
                        True1.Visible = true;
                        break;
                    case 3:
                        True2.Visible = true;
                        break;
                    case 4:
                        pictureBox1.Visible = true;
                        break;
                    default:
                        timer.Stop(); // 모든 이미지가 표시된 후 타이머 정지

                        break;
                }
                timer.Start(); // 타이머 시작
                if (pictureBox1.Visible == true)
                {

                    Form3 form1 = new Form3();
                    form1.Show();
                    this.Close();

                }
            }
            if (!result)
            {
                switch (currentImageIndex)
                {

                    case 0:
                        All1.Visible = true;
                        break;
                    case 1:
                        All2.Visible = true;
                        break;
                    case 2:
                        False1.Visible = true;
                        break;
                    case 3:
                        False2.Visible = true;
                        break;
                    case 4:
                        pictureBox1.Visible = true;
                        break;
                    default:
                        timer.Stop(); // 모든 이미지가 표시된 후 타이머 정지

                        break;
                }
                timer.Start(); // 타이머 시작
                if (pictureBox1.Visible == true)
                {

                    Form10 form1 = new Form10();
                    form1.Show();
                    this.Close();

                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // 현재 이미지 숨기기
            HideAllPictures();

            currentImageIndex++; // 다음 이미지로 이동

            // 다음 이미지 보여주기
            ShowNextImage();
        }

        private void All1_Click(object sender, EventArgs e)
        {

        }
    }
}
