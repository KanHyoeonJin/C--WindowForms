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
    public partial class Form10 : Form
    {
        private string videoPath;
        public Form10()
        {
            InitializeComponent();
            moveTimer.Interval = 50;
            moveTimer.Tick += MoveCarAnimation;
            videoPath = Path.Combine(Program.basePath, "Resources", "susu.mp3");
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.settings.setMode("loop", true); // 반복 재생
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private System.Windows.Forms.Timer moveTimer = new System.Windows.Forms.Timer();
        private int targetX, targetY;
        private Car movingCar;

        private const int WidthBoundary = 199;  // 고정된 너비
        private const int HeightBoundary = 320; // 고정된 높이
        private const int boundaryLeft = 63;
        private const int boundaryTop = 496;
        int boundaryRight = boundaryLeft + WidthBoundary;
        int boundaryBottom = boundaryTop + HeightBoundary;

        private WindowsMediaPlayer player = new WindowsMediaPlayer();

        private int clickCount = 0;
        private Dictionary<Car, Point> initialPositions = new Dictionary<Car, Point>();
        private void Form10_Load(object sender, EventArgs e)
        {
            Car[] cars =
            {
                new Car("Car1", RedCar, RedCar.Location, new Size(2, 1), true),   // 가로
                new Car("Car2", carButton2, carButton2.Location, new Size(1, 2), false),  // 세로
                new Car("Car3", carButton3, carButton3.Location, new Size(2, 1), true),   // 가로
                new Car("Car4", carButton4, carButton4.Location, new Size(1, 2), true),   // 가로
                new Car("Car5", carButton5, carButton5.Location, new Size(2, 1), true),   // 가로
                new Car("Car6", carButton6, carButton6.Location, new Size(2, 1), true),   // 가로
                new Car("Car7", carButton7, carButton7.Location, new Size(2, 1), true),   // 가로
                new Car("Car8", carButton8, carButton8.Location, new Size(1, 2), false),  // 세로
                new Car("Car9", carButton9, carButton9.Location, new Size(1, 2), false),  // 세로
                new Car("Car10", carButton10, carButton10.Location, new Size(1, 2), false), // 세로
                new Car("Car11", carButton11, carButton11.Location, new Size(1, 2), false), // 세로
                new Car("Car12", carButton12, carButton12.Location, new Size(1, 2), false)  // 세로
            };

            foreach (var car in cars)
            {
                initialPositions[car] = car.CarButton.Location;
                car.CarButton.MouseDown += (s, ev) =>
                {
                    clickCount++;
                    label1.Text = clickCount.ToString();
                    if (car.IsHorizontal)
                    {
                        if (ev.Button == MouseButtons.Left)
                        {
                            MoveCar(car, -111, 0); // 왼쪽으로 이동, 이동 방향의 배수는 1로 설정하여 만날 때까지 계속 이동
                        }
                        else if (ev.Button == MouseButtons.Right)
                        {

                            MoveCar(car, 111, 0); // 오른쪽으로 이동
                        }
                    }
                    else
                    {
                        // 세로 방향 차 이동
                        if (ev.Button == MouseButtons.Left)
                        {
                            MoveCar(car, 0, -112); // 위쪽으로 이동
                        }
                        else if (ev.Button == MouseButtons.Right)
                        {
                            MoveCar(car, 0, 112); // 아래쪽으로 이동
                        }
                    }
                };
            }
            button4.Click += (sender, e) =>
            {
                foreach (var car in initialPositions.Keys)
                {
                    car.CarButton.Location = initialPositions[car];
                }

                clickCount = 0;
                label1.Text = "0";
            };
        }

        private void MoveCar(Car car, int distanceX, int distanceY)
        {
            movingCar = car;
            if (car.CarButton.Name == "RedCar")
            {
                targetX = car.CarButton.Location.X + distanceX; // 경계를 넘어가도록 설정
                targetY = car.CarButton.Location.Y + distanceY;
            }
            else
            {
                targetX = car.CarButton.Location.X + distanceX * 3;
                targetY = car.CarButton.Location.Y + distanceY * 3;
            }
            moveTimer.Start();
        }
        private bool IsWithinBounds(int x, int y)
        {
            if (movingCar.CarButton.Name == "RedCar")
            {
                return y >= boundaryTop && y + movingCar.CarButton.Height <= boundaryBottom; // 세로 경계만 검사
            }

            return x >= boundaryLeft && x + movingCar.CarButton.Width <= boundaryRight &&
                   y >= boundaryTop && y + movingCar.CarButton.Height <= boundaryBottom;
        }

        private bool IsColliding(Car movingCar, int targetX, int targetY)
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control != movingCar.CarButton)
                {
                    // 다른 차의 위치와 이동하려는 위치 비교
                    if (control.Bounds.IntersectsWith(
                        new Rectangle(targetX, targetY, movingCar.CarButton.Width, movingCar.CarButton.Height)))
                    {
                        return true; // 충돌 발생
                    }
                }
            }

            return false; // 충돌 없음
        }


        private void MoveCarAnimation(object sender, EventArgs e)
        {
            if (movingCar == null)
            {
                MessageBox.Show("No car is currently moving!");
                return;
            } // 애니메이션 시작 전 확인

            int currentX = movingCar.CarButton.Location.X;
            int currentY = movingCar.CarButton.Location.Y;

            // 목표 지점에 도착하지 않았을 경우
            if (currentX != targetX || currentY != targetY)
            {
                int deltaX = targetX - currentX;
                int deltaY = targetY - currentY;

                // 다음 위치를 계산 (한 번에 5씩 이동)
                int nextX = currentX + Math.Sign(deltaX) * Math.Min(6, Math.Abs(deltaX));
                int nextY = currentY + Math.Sign(deltaY) * Math.Min(6, Math.Abs(deltaY));

                // RedCar에 대해 경계 검사 및 탈출 처리
                if (movingCar.CarButton.Name == "RedCar" && nextX > boundaryRight)
                {
                    // 남은 거리만큼 한 번에 이동시키기
                    movingCar.CarButton.Location = new Point(boundaryRight + 1, currentY); // 경계를 넘어서 이동
                    moveTimer.Stop();
                    HandleEscape();
                    return;
                }

                // 충돌 검사
                if (IsColliding(movingCar, nextX, nextY))
                {
                    moveTimer.Stop(); // 충돌 발생 시 이동 중지
                    return;
                }

                // 경계 내에서 이동 가능한지 검사
                if (IsWithinBounds(nextX, nextY))
                {
                    movingCar.CarButton.Location = new Point(nextX, nextY);
                }
                else
                {
                    moveTimer.Stop(); // 경계 밖으로 나가면 이동 중지
                }
            }
            else
            {
                // 목표에 도달했을 때

                moveTimer.Stop();
            }
        }

        private void HandleEscape()
        {
            bool result = clickCount <= 15;

            Form12 form12 = new Form12(result);
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            form12.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel2.Visible = !panel2.Visible;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hint1_Text.Visible = true;
            Hint2_Text.Visible = false;
            Hint3_Text.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hint2_Text.Visible = true;
            Hint1_Text.Visible = false;
            Hint3_Text.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hint1_Text.Visible = false;
            Hint2_Text.Visible = false;
            Hint3_Text.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
