using System;
using System.Windows.Forms;
using WMPLib;

namespace main1
{
    public partial class Form31 : Form
    {
        private Timer timer;
        private int currentImageIndex = 0;
        private int count;
        private int a;
        private WindowsMediaPlayer success = new WindowsMediaPlayer();
        private WindowsMediaPlayer failure = new WindowsMediaPlayer();
        public Form31()
        {
            InitializeComponent();

        }

        public Form31(int a, int count)
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval =750; // 0.75초
            timer.Tick += Timer_Tick;
            this.a = a;
            this.count = count;


            success.settings.setMode("loop", false);
            failure.settings.setMode("loop", false);
            if (a == 1 && count <=3)
            {
                timer.Interval = 850; // 0.75초
                success.URL = @"C:\Users\이대한\Desktop\main1\Resources\correct.mp3";
                success.controls.play();
            }
            else
            {
                timer.Interval = 1111; // 0.75초
                failure.URL = @"C:\Users\이대한\Desktop\main1\Resources\Wrong.mp3";
                failure.controls.play();
            }
            // 모든 PictureBox 숨기기
            HideAllPictures();

            // 첫 번째 이미지 보여주기
            ShowNextImage(); 
        }

        private void HideAllPictures()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

        }

        private void ShowNextImage()
        {
            // 현재 이미지 인덱스에 따라 이미지 보이기
            HideAllPictures(); // 먼저 모든 이미지 숨기기
            if (a == 1 && count <= 3) //이때만 성공 나머지는 실패
            {

                switch (currentImageIndex)
                {

                    case 0:

                        pictureBox7.Visible = true;
                        break;
                    case 1:
                        pictureBox1.Visible = true;
                        break;
                    case 2:
                        pictureBox2.Visible = true;
                        break;
                    case 3:
                        pictureBox3.Visible = true;
                        break;
                    case 4:
                        pictureBox6.Visible = true;
                        break;


                    default:
                        timer.Stop(); // 모든 이미지가 표시된 후 타이머 정지

                        break;
                }
                timer.Start(); // 타이머 시작
                if (pictureBox6.Visible == true)
                {

                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Close();
                  
                }
            }
            if (a == 1 && count > 3)
            {

                switch (currentImageIndex)
                {

                    case 0:

                        pictureBox7.Visible = true;
                        break;
                    case 1:
                        pictureBox1.Visible = true;
                        break;
                    case 2:
                        pictureBox4.Visible = true;
                        break;
                    case 3:
                        pictureBox5.Visible = true;
                        break;
                    case 4:
                        pictureBox6.Visible = true;
                        break;
                    default:
                        timer.Stop(); // 모든 이미지가 표시된 후 타이머 정지

                        break;
                }
                timer.Start(); // 타이머 시작
                if (pictureBox6.Visible == true)
                {

                    Form30 form1 = new Form30();
                    form1.Show();
                    this.Close();
                  
                }
            }
            if (a == 0)
            {

                switch (currentImageIndex)
                {

                    case 0:

                        pictureBox7.Visible = true;
                        break;
                    case 1:
                        pictureBox1.Visible = true;
                        break;
                    case 2:
                        pictureBox4.Visible = true;
                        break;
                    case 3:
                        pictureBox5.Visible = true;
                        break;
                    case 4:
                        pictureBox6.Visible = true;
                        break;
                    default:
                        timer.Stop(); // 모든 이미지가 표시된 후 타이머 정지

                        break;
                }
                timer.Start(); // 타이머 시작
                if (pictureBox6.Visible == true)
                {

                    Form30 form1 = new Form30();
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


    }
}
