using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace main1
{
    public partial class Form21 : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private PictureBox currentPictureBox = null;
        private Point[] originalPositions; // 원래 위치 배열
        private PictureBox[] targetPictureBoxes; // 복사할 PictureBox 배열
        private PictureBox[] p; // 드래그할 PictureBox 배열
        private bool[] targetUsed; // 타겟 PictureBox가 사용되었는지 여부
        private Image original_image;
        private Timer timer;
        private Timer hideTimer; // 숨기는 타이머 추가
        private int step = 0; // 그림 순서를 추적할 변수
        private bool result; // 곱 확인 결과를 저장할 변수
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer Wrong = new WindowsMediaPlayer();
        WindowsMediaPlayer correct = new WindowsMediaPlayer();
        private string videoCorrect;
        private string videoWrong;
        private string videoPath;
       
        
        public Form21()
        {
            InitializeComponent();
            targetPictureBoxes = new PictureBox[] { p11, p12, p13, p14, p15, p16, p17 };
            videoPath = Path.Combine(Program.basePath, "Resources", "susu.mp3");
            videoCorrect = Path.Combine(Program.basePath, "Resources", "correct.mp3");
            videoWrong = Path.Combine(Program.basePath, "Resources", "Wrong.mp3");
            player.URL = videoPath;
            
            
           
            p = new PictureBox[] { p1, p2, p3, p4, p5, p6, p7, p8, p9 };

            // 원래 위치 배열 초기화
            originalPositions = new Point[p.Length];
            for (int i = 0; i < p.Length; i++)
            {
                originalPositions[i] = p[i].Location;
            }

            // 타겟 PictureBox 사용 여부 배열 초기화
            targetUsed = new bool[targetPictureBoxes.Length];
            for (int i = 0; i < targetUsed.Length; i++)
            {
                targetUsed[i] = false; // 처음엔 모두 사용되지 않은 상태
            }

            // 각 PictureBox에 1부터 9까지의 값을 할당 (Tag 속성 사용)
            for (int i = 0; i < p.Length; i++)
            {
                p[i].Tag = i + 1; // p1에 1, p2에 2 ... p9에 9
            }

            // 모든 PictureBox에 동일한 이벤트 핸들러 추가
            foreach (var pictureBox in p)
            {
                pictureBox.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
                pictureBox.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
                pictureBox.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
            }

            // Timer 설정
            timer = new Timer();
            timer.Interval = 1000; // 0.5초 간격으로 설정
            timer.Tick += new EventHandler(OnTimerTick); // Timer의 Tick 이벤트 핸들러 추가

            // 시작 시 패널 숨기기
            foreach (Control control in this.Controls)
            {
                if (control is Panel && control != panel1 && control != panel2)
                {
                    control.Visible = false; // 패널1과 패널2를 제외한 모든 패널 숨기기
                }
            }

            // h1, h2, t1, t2, f1, f2 숨김
            h1.Visible = false;
            h2.Visible = false;
            t1.Visible = false;
            t2.Visible = false;
            f1.Visible = false;
            f2.Visible = false;

            // Form1 생성자 또는 초기화 메서드에 추가
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button6.Click += new System.EventHandler(this.button6_Click);

        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            currentPictureBox = sender as PictureBox;
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && currentPictureBox != null)
            {
                currentPictureBox.Left += e.X - startPoint.X;
                currentPictureBox.Top += e.Y - startPoint.Y;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            bool isDropped = false;

            if (currentPictureBox != null)
            {
                // 모든 targetPictureBox에 대해 위치 확인
                for (int i = 0; i < targetPictureBoxes.Length; i++)
                {
                    if (targetPictureBoxes[i].Bounds.IntersectsWith(currentPictureBox.Bounds) && !targetUsed[i])
                    {
                        targetPictureBoxes[i].Image = currentPictureBox.Image; // 이미지 복사
                        targetPictureBoxes[i].Tag = currentPictureBox.Tag; // Tag 값 복사
                        currentPictureBox.Visible = false; // 드래그한 PictureBox 숨김
                        targetPictureBoxes[i].Visible = true; // 타겟 PictureBox 보이기
                        targetUsed[i] = true; // 해당 타겟은 이제 사용됨
                        isDropped = true; // 드롭 성공
                    }
                }

                // 이미지 복사에 실패했을 경우 원래 위치로 복귀
                if (!isDropped)
                {
                    int index = Array.IndexOf(p, currentPictureBox);
                    if (index != -1)
                    {
                        currentPictureBox.Location = originalPositions[index]; // 원래 위치로 되돌리기
                    }
                }
            }

            currentPictureBox = null;
        }

        private bool CheckMultiplicationEquality()
        {
            // p11~p17의 PictureBox 배열 정의 (p14도 포함)
            PictureBox[] target = new PictureBox[] { p11, p12, p13, p14, p15, p16, p17 };

            // 각 PictureBox의 Tag 값을 가져와 숫자로 변환
            int[] values = new int[target.Length];
            for (int i = 0; i < target.Length; i++)
            {
                // Tag에 값이 없을 경우 0으로 처리
                values[i] = target[i].Tag != null ? (int)target[i].Tag : 0;
            }

            // 3가지 조합의 곱을 계산
            int product1 = values[0] * values[1] * values[2]; // p11 * p12 * p13
            int product2 = values[4] * values[5] * values[6]; // p15 * p16 * p17
            int product3 = values[1] * values[3] * values[5]; // p12 * p14 * p16

            // 곱의 결과를 확인하여 true 또는 false 반환
            if (product1 == 0 || product2 == 0 || product3 == 0)
            {
                return false;
            }
            else
            {
                return (product1 == product2) && (product2 == product3);
            }


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
            // 버튼 클릭 후 비활성화
            button1.Enabled = false;

            // h1과 h2를 숨김
            h1.Visible = false;
            h2.Visible = false;
            t1.Visible = false;
            t2.Visible = false;
            f1.Visible = false;
            f2.Visible = false;
            if (result)
            {
                
                correct.URL = videoCorrect;
               
            }
            else if (!result)
            {
                
                Wrong.URL = videoWrong;
            }
           
             
            
            // 곱이 모두 같은지 확인
            result = CheckMultiplicationEquality();

            // 타이머 시작 및 초기화
            step = 0;
            timer.Start(); // Timer 시작
        }


        private void OnTimerTick(object sender, EventArgs e)
        {
            // 그림 순차적으로 표시
            switch (step)
            {
                case 0:
                    h1.Visible = true; // 첫 번째 그림 표시
                    h1.BringToFront(); // h1을 제일 위로 가져옴
                    break;
                case 1:
                    h2.Visible = true; // 두 번째 그림 표시
                    h2.BringToFront(); // h2을 제일 위로 가져옴
                    break;
                case 2:
                    if (result) // 곱이 같을 경우
                    {
                        t1.Visible = true; // t1 표시 (정답)
                        t1.BringToFront(); // t1을 제일 위로 가져옴
                    }
                    else
                    {
                        f1.Visible = true; // f1 표시 (오답)
                        f1.BringToFront(); // f1을 제일 위로 가져옴
                    }
                    break;
                case 3:
                    if (!result) // 곱이 다를 경우
                    {
                        f2.Visible = true; // f2 표시 (정답)
                        f2.BringToFront(); // f2을 제일 위로 가져옴
                    }
                    else
                    {
                        t2.Visible = true; // t2 표시 (오답)
                        t2.BringToFront(); // t2을 제일 위로 가져옴
                    }
                    break;
                case 4:
                    // 모든 그림을 숨김
                    h1.Visible = false;
                    h2.Visible = false;
                    t1.Visible = false;
                    t2.Visible = false;
                    f1.Visible = false;
                    f2.Visible = false;

                    // 패널 3과 패널 4 보이기
                    panel3.Visible = true;
                    panel4.Visible = true;

                    // 타이머를 멈춤
                    timer.Stop();
                    button1.Enabled = true; // 버튼 다시 활성화
                    break;
            }
            step++; // 다음 단계로 이동

            // 모든 그림이 출력된 후 숨기는 로직 추가
            if (step == 5) // 모든 그림이 출력된 후 1초 후에 숨김
            {
                timer.Stop(); // 현재 타이머를 멈춤
                Timer hideTimer = new Timer();
                hideTimer.Interval = 1000; // 1초 후
                hideTimer.Tick += (s, args) =>
                {
                    // 모든 그림 숨김
                    h1.Visible = false;
                    h2.Visible = false;
                    t1.Visible = false;
                    t2.Visible = false;
                    f1.Visible = false;
                    f2.Visible = false;

                    // 패널 3과 패널 4 보이기
                    panel3.Visible = true;
                    panel4.Visible = true;

                    hideTimer.Stop(); // 숨기는 타이머 멈춤
                    hideTimer.Dispose(); // 자원 해제
                };
                hideTimer.Start(); // 숨기는 타이머 시작
                Form5 form = new Form5();
                form.Show();
                this.Close();
            }
        }



        private void btn_reset_Click(object sender, EventArgs e)
        {
            // 원래 위치로 되돌리기
            for (int i = 0; i < p.Length; i++)
            {
                p[i].Location = originalPositions[i];
                p[i].Visible = true; // 원래 PictureBox 보이기
            }
            for (int i = 0; i < targetPictureBoxes.Length; i++)
            {
                targetPictureBoxes[i].Image = null; // 이미지 초기화
                targetPictureBoxes[i].Tag = null; // Tag 초기화
                targetPictureBoxes[i].Visible = true;
                targetUsed[i] = false; // 리셋 시 타겟 사용 여부도 초기화
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 원래 위치로 되돌리기
            for (int i = 0; i < p.Length; i++)
            {
                p[i].Location = originalPositions[i]; // 원래 위치로 되돌리기
                p[i].Visible = true; // 드래그할 PictureBox 보이기
            }

            for (int i = 0; i < targetPictureBoxes.Length; i++)
            {
                targetPictureBoxes[i].Image = null; // 이미지 초기화
                targetPictureBoxes[i].Tag = null; // Tag 초기화
                targetPictureBoxes[i].Visible = true; // 타겟 PictureBox 보이기
                targetUsed[i] = false; // 리셋 시 타겟 사용 여부 초기화
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 그림판 실행
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;  // panel7를 보이도록 설정
            panel4.Visible = false; // panel5를 숨김
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;  // panel4를 보이도록 설정
            panel5.Visible = false; // panel5를 숨김
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;  // panel4를 보이도록 설정
            panel6.Visible = false; // panel6를 숨김
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;  // panel4를 보이도록 설정
            panel7.Visible = false; // panel7를 숨김
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;  // panel6를 보이도록 설정
            panel5.Visible = false; // panel5를 숨김
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;  // panel6를 보이도록 설정
            panel7.Visible = false; // panel5를 숨김
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;  // panel5를 보이도록 설정
            panel6.Visible = false; // panel6를 숨김
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;  // panel5를 보이도록 설정
            panel7.Visible = false; // panel7를 숨김
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;  // panel7를 보이도록 설정
            panel5.Visible = false; // panel5를 숨김
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;  // panel7를 보이도록 설정
            panel6.Visible = false; // panel6를 숨김
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;  // panel3를 보이도록 설정
            panel4.Visible = true;  // panel4를 보이도록 설정
            panel1.Visible = false; // panel1를 숨김
            panel2.Visible = false; // panel2를 숨김
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }
    }
}