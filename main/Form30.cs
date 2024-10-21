using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace main1
{
    public partial class Form30 : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private PictureBox currentPictureBox = null;
        private Point[] originalPositions; // 원래 위치 배열
        private PictureBox[] targetPictureBoxes; // 복사할 PictureBox 배열
        private PictureBox[] p; // 드래그할 PictureBox 배열
        private Image original_image;
        private int count = 0;
        private int a = 0;
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string videoPath;


        public Form30()
        {
            InitializeComponent();
            videoPath = Path.Combine(Program.basePath, "Resources", "questionBGM.mp3");
            player.settings.setMode("loop", true);


            targetPictureBoxes = new PictureBox[] { p11, p12, p13, p14, p15, p16, p17, p18 };
            p = new PictureBox[] { p1, p2, p3, p4, p5, p6, p7, p8, p9 };

            original_image = p11.Image;

            // 원래 위치 배열 초기화
            originalPositions = new Point[p.Length];
            for (int i = 0; i < p.Length; i++)
            {
                originalPositions[i] = p[i].Location;
            }
            for (int i = 0; i < 9; i++)
            {
                p[i].Tag = 1;
            }
            for (int i = 0; i < 8; i++)
            {
                targetPictureBoxes[i].Tag = 0;
            }

            p2.Tag = 0.5;



            // 모든 PictureBox에 동일한 이벤트 핸들러 추가
            foreach (var pictureBox in p)
            {
                pictureBox.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
                pictureBox.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
                pictureBox.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
            }
        }
        public Form30(int a)
        {
            InitializeComponent();
            player.settings.setMode("loop", true);
            player.URL = videoPath;
            player.controls.play();
            
            targetPictureBoxes = new PictureBox[] { p11, p12, p13, p14, p15, p16, p17, p18 };
            p = new PictureBox[] { p1, p2, p3, p4, p5, p6, p7, p8, p9 };

            original_image = p11.Image;

            // 원래 위치 배열 초기화
            originalPositions = new Point[p.Length];
            for (int i = 0; i < p.Length; i++)
            {
                originalPositions[i] = p[i].Location;
            }
            for (int i = 0; i < 9; i++)
            {
                p[i].Tag = 1;
            }
            for (int i = 0; i < 8; i++)
            {
                targetPictureBoxes[i].Tag = 0;
            }

            p2.Tag = 0.5;



            // 모든 PictureBox에 동일한 이벤트 핸들러 추가
            foreach (var pictureBox in p)
            {
                pictureBox.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
                pictureBox.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
                pictureBox.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
            }
            button1.Visible = false;
            button2.Visible = false;
            panel1.Visible = true;
            panel2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            player.URL = videoPath;
            player.controls.play();
            foreach (var target in targetPictureBoxes)
            {
                target.Visible = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6_hint1.Visible = false;
            panel6_hint33.Visible = false;
            panel6_hint2.Visible = false;
            panel6_hinttitle.Visible = false;
            label7.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            player.URL = videoPath;
            player.controls.play();
            foreach (var target in targetPictureBoxes)
            {
                target.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            player.URL = videoPath;
            player.controls.play();
            foreach (var target in targetPictureBoxes)
            {
                target.Visible = true;
            }
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
            bool isPlaced = false;
            if (currentPictureBox != null)
            {

                // 모든 targetPictureBox에 대해 위치 확인
                foreach (var target in targetPictureBoxes)
                {
                    if (target.Bounds.IntersectsWith(currentPictureBox.Bounds))
                    {
                        target.Image = currentPictureBox.Image; // 이미지 복사
                        currentPictureBox.Visible = false; // 드래그한 PictureBox 숨김
                        target.Tag = 1;
                        if (currentPictureBox.Image == p2.Image)
                            target.Tag = 0.5;
                        target.Visible = true; // 타겟 PictureBox 보이기
                        isPlaced = true;
                        break; // 복사 후 루프 종료
                    }
                }
            }
            if (!isPlaced)
            {
                currentPictureBox.Location = originalPositions[Array.IndexOf(p, currentPictureBox)];
                currentPictureBox.Visible = true; // 보이게 설정
            }

            currentPictureBox = null; // 현재 PictureBox 초기화
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            // 원래 위치로 되돌리기
            for (int i = 0; i < p.Length; i++)
            {
                p[i].Location = originalPositions[i];
                p[i].Visible = true; // 원래 PictureBox 보이기
            }
            foreach (var target in targetPictureBoxes)
            {
                target.Image = original_image;
                target.Visible = true;
            }
            for (int i = 0; i < 9; i++)
            {
                p[i].Tag = 1;
            }
            for (int i = 0; i < 8; i++)
            {
                targetPictureBoxes[i].Tag = 0;
            }

            p2.Tag = 0.5;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            if ((targetPictureBoxes[0].Tag.ToString() == "0" && targetPictureBoxes[1].Tag.ToString() == "0" &&
                targetPictureBoxes[2].Tag.ToString() == "0" && targetPictureBoxes[3].Tag.ToString() == "0") ||
                (targetPictureBoxes[4].Tag.ToString() == "0" && targetPictureBoxes[5].Tag.ToString() == "0" &&
                targetPictureBoxes[6].Tag.ToString() == "0" && targetPictureBoxes[7].Tag.ToString() == "0"))
            {

                label1.Text = "왼쪽 또는 오른쪽이 비어있습니다. 다시 올려주세요.";

            }
            double leftSum = double.Parse(targetPictureBoxes[0].Tag.ToString()) +
                  double.Parse(targetPictureBoxes[1].Tag.ToString()) +
                  double.Parse(targetPictureBoxes[2].Tag.ToString()) +
                  double.Parse(targetPictureBoxes[3].Tag.ToString());

            double rightSum = double.Parse(targetPictureBoxes[4].Tag.ToString()) +
                               double.Parse(targetPictureBoxes[5].Tag.ToString()) +
                               double.Parse(targetPictureBoxes[6].Tag.ToString()) +
                               double.Parse(targetPictureBoxes[7].Tag.ToString());
            if ((leftSum == rightSum) && (leftSum != 0) && (rightSum != 0))
            {
                label1.Text = "무게가 같습니다.";
                count++;
            }
            if ((leftSum == 0) && (rightSum == 0))
            {
                label1.Text = "추를 올려주세요!";

            }
            else if ((leftSum == 0) || (rightSum == 0))
            {
                label1.Text = "한쪽에 추가 올라가있지 않습니다.";

            }



            if (leftSum < rightSum && leftSum > 0 && rightSum > 0)
            {
                label1.Text = "오른쪽으로 기울었습니다.";

                panel2.Visible = true;
                panel3.Visible = false;
                pp1.Image = p11.Image;
                pp2.Image = p12.Image;
                pp3.Image = p13.Image;
                pp4.Image = p14.Image;
                pp5.Image = p15.Image;
                pp6.Image = p16.Image;
                pp7.Image = p17.Image;
                pp8.Image = p18.Image;
                count++;

            }
            if (leftSum > rightSum && leftSum > 0 && rightSum > 0)
            {
                label1.Text = "왼쪽으로 기울었습니다.";

                panel3.Visible = true;
                panel2.Visible = false;
                ppp1.Image = p11.Image;
                ppp2.Image = p12.Image;
                ppp3.Image = p13.Image;
                ppp4.Image = p14.Image;
                ppp5.Image = p15.Image;
                ppp6.Image = p16.Image;
                ppp7.Image = p17.Image;
                ppp8.Image = p18.Image;
                count++;
            }


            label7.Text = count.ToString();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            a = 0;
            Form31 form2 = new Form31(a, count);
            form2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            a = 0;
            Form31 form2 = new Form31(a, count);
            form2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            a = 0;
            Form31 form2 = new Form31(a, count);
            form2.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            player.controls.stop();
            a = 0;
            Form31 form2 = new Form31(a, count);
            form2.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            a = 0;
            Form31 form2 = new Form31(a, count);
            form2.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = 0;
            player.controls.stop();
            Form31 form2 = new Form31(a, count);
            form2.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = 0;
            player.controls.stop();
            Form31 form2 = new Form31(a, count);
            form2.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = 0;
            player.controls.stop();
            Form31 form2 = new Form31(a, count);
            form2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = 1;
            player.controls.stop();
            Form31 form2 = new Form31(a, count);
            form2.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btn_hintback_Click(object sender, EventArgs e)
        {
            panel6_hinttitle.Visible = false;
            panel6_hint1.Visible = false;
            panel6_hint2.Visible = false;
            panel6_hint33.Visible = false;
        }

        private void btn_1hint_Click(object sender, EventArgs e)
        {
            panel6_hint2.Visible = true;
            panel6_hint1.Visible = false;
            panel6_hint33.Visible = false;
        }

        private void btn_2hint_Click(object sender, EventArgs e)
        {
            if (count >= 1)
            {
                panel6_hint1.Visible = true;
                panel6_hint2.Visible = false;
                panel6_hint33.Visible = false;
            }
            else
            {
                MessageBox.Show("저울을 1번 이상 사용하여야 \n힌트를 이용할 수 있습니다.");
            }
        }

        private void btn_3hint_Click(object sender, EventArgs e)
        {
            if (count >= 2)
            {
                panel6_hint33.Visible = true;
                panel6_hint1.Visible = false;
                panel6_hint2.Visible = false;

            }
            else
            {
                MessageBox.Show("저울을 2번 이상 사용하여야 \n힌트를 이용할 수 있습니다.");
            }
        }

        private void btn_hint_Click(object sender, EventArgs e)
        {
            panel6_hint2.Visible = true;
            panel6_hinttitle.Visible = true;
        }

        private void btn_memo_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("mspaint");
            }
            catch (Exception ex)
            {
                MessageBox.Show("그림판을 열 수 없습니다: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            player.controls.stop();
            form3.Show();
            this.Close();
        }
    }
}
