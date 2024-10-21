using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace main1
{
    public partial class Form22 : Form
    {
        private Timer timer;
        private int step;
        private bool isCorrect; // 값이 1인지 여부를 저장할 변수
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer Wrong = new WindowsMediaPlayer();
        WindowsMediaPlayer correct = new WindowsMediaPlayer();
        private string videoCorrect;
        private string videoWrong;
        private string videoPath;

        public Form22()
        {
            InitializeComponent();
            videoPath = Path.Combine(Program.basePath, "Resources", "questionBGM.mp3");
            videoCorrect = Path.Combine(Program.basePath, "Resources", "correct.mp3");
            videoWrong = Path.Combine(Program.basePath, "Resources", "Wrong.mp3");
            player.URL = videoPath;

            // 패널 초기 상태 설정: panel1과 panel2만 보이도록 설정
            panel1.Visible = true;
            panel2.Visible = true;

            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel9.Visible = false;


            h1.Visible = false;
            h2.Visible = false;
            t1.Visible = false;
            t2.Visible = false;
            f1.Visible = false;
            f2.Visible = false;
        }

        private void hint1_2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;  // 힌트2를 보이도록 설정
            panel3.Visible = false; // 힌트3를 숨김
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;  // 힌트3를 보이도록 설정
            panel3.Visible = false; // 힌트3를 숨김
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;  // 문제를 보이도록 설정
            panel3.Visible = false; // 힌트2를 숨김
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;  // 힌트1를 보이도록 설정
            panel4.Visible = false; // 힌트2를 숨김
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;  // 힌트3를 보이도록 설정
            panel4.Visible = false; // 힌트2를 숨김
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;  // 문제를 보이도록 설정
            panel4.Visible = false; // 힌트2를 숨김
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;  // 힌트1를 보이도록 설정
            panel5.Visible = false; // 힌트3을 숨김
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;  // 힌트2를 보이도록 설정
            panel5.Visible = false; // 힌트3을 숨김
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;  // 문제를 보이도록 설정
            panel5.Visible = false; // 힌트3을 숨김
        }

        private void bt_hint_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;  // 힌트1를 보이도록 설정
            panel6.Visible = false; // 문제를 숨김
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 그림판 실행
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // textBox1.Text가 "1"인지 확인
            isCorrect = (textBox1.Text == "1");

            // 타이머 초기화
            step = 0;
            timer = new Timer();
            timer.Interval = 500; // 0.5초 간격
            timer.Tick += OnTimerTick; // 타이머 틱 이벤트 설정
            timer.Start(); // 타이머 시작

            // panel7을 처음에는 숨김
            panel7.Visible = false;
            if (isCorrect)
            {

                correct.URL = videoCorrect;

            }
            else if (!isCorrect)
            {

                Wrong.URL = videoWrong;
            }

            player.URL = videoPath;
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            switch (step)
            {
                case 0:
                    h1.Visible = true;
                    h1.BringToFront(); // h1을 제일 위로 가져옴

                    break;
                case 1:
                    h2.Visible = true;
                    h2.BringToFront(); // h2을 제일 위로 가져옴

                    break;
                case 2:
                    if (isCorrect)
                    {
                        t1.Visible = true;
                        h1.Visible = false;
                        h2.Visible = false;// 값이 1일 경우
                        t1.BringToFront(); // t1을 제일 위로 가져옴

                    }
                    else
                    {
                        f1.Visible = true;
                        h1.Visible = false;
                        h2.Visible = false;// 값이 1이 아닐 경우
                        f1.BringToFront(); // f1을 제일 위로 가져옴

                    }
                    break;
                case 3:
                    if (!isCorrect)
                    {
                        f2.Visible = true; // 값이 1일 경우
                        f2.BringToFront(); // h1을 제일 위로 가져옴

                    }
                    else
                    {
                        t2.Visible = true; // 값이 1이 아닐 경우
                        t2.BringToFront(); // h1을 제일 위로 가져옴

                    }
                    break;
                case 4:
                    // 모든 그림 숨김
                    h1.Visible = false;
                    h2.Visible = false;
                    t1.Visible = false;
                    t2.Visible = false;
                    f1.Visible = false;
                    f2.Visible = false;

                    // panel7을 보이게 설정
                    if (isCorrect)
                    {
                        panel7.Visible = true; // 정답을 보이도록 설정
                        panel7.BringToFront(); // 패널7을 최상위로 이동
                    }
                    else
                    {
                        panel7.Visible = false;
                    }



                    // 타이머 중지
                    timer.Stop();
                    break;
            }
            step++;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;  // 문제를 보이도록 설정
            panel7.Visible = false; // 정답을 숨김
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;  // 문제를 보이도록 설정
            //panel9.Visible = false; // 초기화면을 숨김
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            // 패널 2번을 숨기고 패널 6번을 보이도록 설정
            panel2.Visible = false;
            panel6.Visible = true;
            panel9.Visible = true;

            // panel1을 숨김
            panel1.Visible = false;

            // 다른 패널도 숨김
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }
    }
}
