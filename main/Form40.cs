using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using AxWMPLib;
using WMPLib;
using System.IO;


namespace main1
{
    public partial class Form40 : Form
    {
        private Form46 form46;
        private const int btnCount = 2;
        private List<Button> selectedButttons;
        private List<Button> selectedButttonsMin;
        private bool boatOnLeft = true;
        private int count = 0;
        private List<Button> wolfButtons = new List<Button>();
        private List<Button> chkButtons = new List<Button>();
        private int wolfleft;
        private int chkleft;
        private int wolfRight;
        private int chkright;
        WindowsMediaPlayer player =new WindowsMediaPlayer();
        private string videoPath;
        private string fontPath;
        Font font;
        public Form40()
        {

            InitializeComponent();
            videoPath = Path.Combine(Program.basePath, "Resources", "questionBGM.mp3");
            fontPath = Path.Combine(Program.basePath, "Resources", "Font1.ttf");
            this.ActiveControl = null;
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile(fontPath);
            font = new Font(privateFont.Families[0], 24f);
            this.selectedButttons = new List<Button>();
            this.selectedButttonsMin = new List<Button>();
            btn_go.Font = font;
            Btn_return.Font = font;
            lb_count.Font = font;
            lb_count_num.Font = font;
            wolfleft = 3;
            chkleft = 3;
            wolfRight = 0;
            chkright = 0;
            panel1.Visible = false;
            Pn_game2.Visible = false;
            wolfButtons.AddRange(new Button[] { btn_wolf_add1, btn_wolf_add2, btn_wolf_add3, Btn_wolf_min1, Btn_wolf_min2, Btn_wolf_min3 });
            chkButtons.AddRange(new Button[] { btn_chk_add1, btn_chk_add2, btn_add_chk3, Btn_chk_min1, Btn_chk_min2, Btn_chk_min3 });

        }
        public Form40(Form46 form46)
        {
            InitializeComponent();
            videoPath = Path.Combine(Program.basePath, "Resources", "questionBGM.mp3");
            fontPath = Path.Combine(Program.basePath, "Resources", "Font1.ttf");
            this.form46 = form46;
            this.ActiveControl = null;
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile(fontPath);
            font = new Font(privateFont.Families[0], 24f);
            this.selectedButttons = new List<Button>();
            this.selectedButttonsMin = new List<Button>();
            btn_go.Font = font;
            Btn_return.Font = font;
            lb_count.Font = font;
            lb_count_num.Font = font;
            wolfleft = 3;
            chkleft = 3;
            wolfRight = 0;
            chkright = 0;
            panel1.Visible = false;
            Pn_game2.Visible = false;
            wolfButtons.AddRange(new Button[] { btn_wolf_add1, btn_wolf_add2, btn_wolf_add3, Btn_wolf_min1, Btn_wolf_min2, Btn_wolf_min3 });
            chkButtons.AddRange(new Button[] { btn_chk_add1, btn_chk_add2, btn_add_chk3, Btn_chk_min1, Btn_chk_min2, Btn_chk_min3 });
        }
        private void btn_b2_Clicked(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Pn_game2.Visible = true;
            button8.Visible = false;
            button7.Visible = false;
            player.URL =videoPath;
            player.settings.setMode("loop", true);
            player.controls.play();

        }

        private void btn_b1_Clicked(object sender, System.EventArgs e)
        {
            panel1.Visible = true;
            Pn_game2.Visible = true;
            button8.Visible = false;
            button7.Visible = false;
            player.URL = videoPath;
            player.settings.setMode("loop", true);
            player.controls.play();
        }
        private void btn_wolf_add1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; //이벤트로 들어온 버튼 객체 확인
            if (selectedButttons.Contains(clickedButton))
            {
                selectedButttons.Remove(clickedButton);
                btn_wolf_add1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                btn_wolf_add1.FlatAppearance.BorderSize = 1;
                this.wolfleft += 1;
                this.wolfRight -= 1;
            }
            else
            {
                if (selectedButttons.Count >= btnCount)
                {
                    Button first = selectedButttons[0];
                    selectedButttons.RemoveAt(0);
                    first.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    this.wolfleft += 1;
                    this.wolfRight -= 1;
                }
                this.wolfleft -= 1;
                this.wolfRight += 1;
                selectedButttons.Add(clickedButton);
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;

            }
            btn_go.Enabled = selectedButttons.Count > 0;

        }
        private void btn_wolf_add2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; //이벤트로 들어온 버튼 객체 확인
            if (selectedButttons.Contains(clickedButton))
            {
                selectedButttons.Remove(clickedButton);
                btn_wolf_add2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                btn_wolf_add2.FlatAppearance.BorderSize = 1;
                this.wolfleft++;
                this.wolfRight--;
            }
            else
            {
                if (selectedButttons.Count >= btnCount)
                {
                    Button first = selectedButttons[0];
                    selectedButttons.RemoveAt(0);
                    first.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    this.wolfleft++;
                    this.wolfRight--;
                }
                selectedButttons.Add(clickedButton);
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;
                this.wolfleft--;
                this.wolfRight++;
            }
            btn_go.Enabled = selectedButttons.Count > 0;

        }
        private void btn_wolf_add3_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; //이벤트로 들어온 버튼 객체 확인
            if (selectedButttons.Contains(clickedButton))
            {
                //이미 선택한 버튼 다시 클릭하면 해제
                selectedButttons.Remove(clickedButton);
                btn_wolf_add3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                btn_wolf_add3.FlatAppearance.BorderSize = 1;
                this.wolfleft++;
                this.wolfRight--;

            }
            else
            {
                if (selectedButttons.Count >= btnCount)
                {
                    Button first = selectedButttons[0];
                    selectedButttons.RemoveAt(0);
                    first.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    this.wolfleft++;
                    this.wolfRight--;
                }
                selectedButttons.Add(clickedButton);
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;
                this.wolfleft--;
                this.wolfRight++;
            }
            btn_go.Enabled = selectedButttons.Count > 0;

        }
        private void btn_chk_add1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; //이벤트로 들어온 버튼 객체 확인
            if (this.selectedButttons.Contains(clickedButton))
            {
                this.selectedButttons.Remove(clickedButton);
                btn_chk_add1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                btn_chk_add1.FlatAppearance.BorderSize = 1;
                this.chkleft++;
                this.chkright--;
            }
            else
            {
                if (selectedButttons.Count >= btnCount)
                {
                    Button first = selectedButttons[0];
                    selectedButttons.RemoveAt(0);
                    first.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    chkleft++;
                    chkright--;
                }
                selectedButttons.Add(clickedButton);
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;
                this.chkleft--;
                this.chkright++;

            }
            btn_go.Enabled = selectedButttons.Count > 0;
        }

        private void btn_chk_add2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; //이벤트로 들어온 버튼 객체 확인
            if (selectedButttons.Contains(clickedButton))
            {
                selectedButttons.Remove(clickedButton);
                btn_chk_add2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                btn_chk_add2.FlatAppearance.BorderSize = 1;
                this.chkleft++;
                this.chkright--;
            }
            else
            {
                if (selectedButttons.Count >= btnCount)
                {
                    Button first = selectedButttons[0];
                    selectedButttons.RemoveAt(0);
                    first.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    this.chkleft++;
                    this.chkright--;
                }
                selectedButttons.Add(clickedButton);
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;
                this.chkleft--;
                this.chkright++;

            }
            btn_go.Enabled = selectedButttons.Count > 0;
        }
        private void btn_add_chk3_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; //이벤트로 들어온 버튼 객체 확인
            if (selectedButttons.Contains(clickedButton))
            {
                selectedButttons.Remove(clickedButton);
                btn_add_chk3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                btn_add_chk3.FlatAppearance.BorderSize = 1;
                this.chkleft++;
                this.chkright--;
            }
            else
            {
                if (selectedButttons.Count >= btnCount)
                {
                    Button first = selectedButttons[0];
                    selectedButttons.RemoveAt(0);
                    first.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    this.chkleft++;
                    this.chkright--;
                }
                selectedButttons.Add(clickedButton);
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;
                this.chkleft--;
                this.chkright++;

            }
            btn_go.Enabled = selectedButttons.Count > 0;
        }
        private void Btn_wolf_min1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (selectedButttonsMin.Contains(clickedButton))
            {
                //눌린게 이미 눌려있으면 다시 그걸 푸는거
                selectedButttonsMin.Remove(clickedButton);
                Btn_wolf_min1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                Btn_wolf_min1.FlatAppearance.BorderSize = 1;
                this.wolfRight += 1;
                this.wolfleft -= 1;
            }
            else
            {
                if (selectedButttonsMin.Count >= btnCount)
                {
                    //두마리 넘게 누르면 첫번째로 선택된 동물 해제
                    Button first = selectedButttonsMin[0];
                    selectedButttonsMin.RemoveAt(0);
                    first.FlatAppearance.BorderColor = Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    this.wolfRight += 1;
                    this.wolfleft -= 1;
                }
                selectedButttonsMin.Add(clickedButton);
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;
                this.wolfRight -= 1;
                this.wolfleft += 1;
            }
            Btn_return.Enabled = selectedButttonsMin.Count > 0;
        }
        private void Btn_wolf_min2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (selectedButttonsMin.Contains(clickedButton))
            {
                selectedButttonsMin.Remove(clickedButton);
                Btn_wolf_min2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                Btn_wolf_min2.FlatAppearance.BorderSize = 1;
                this.wolfRight++;
                this.wolfleft--;
            }
            else
            {
                if (selectedButttonsMin.Count >= btnCount)
                {
                    Button first = selectedButttonsMin[0];
                    selectedButttonsMin.RemoveAt(0);
                    first.FlatAppearance.BorderColor = Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    this.wolfRight++;
                    this.wolfleft--;
                }
                selectedButttonsMin.Add(clickedButton);
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;
                this.wolfRight--;
                this.wolfleft++;
            }
            Btn_return.Enabled = selectedButttonsMin.Count > 0;
        }
        private void Btn_wolf_min3_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (selectedButttonsMin.Contains(clickedButton))
            {
                selectedButttonsMin.Remove(clickedButton);
                Btn_wolf_min3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                Btn_wolf_min3.FlatAppearance.BorderSize = 1;
                this.wolfRight++;
                this.wolfleft--;
            }
            else
            {
                if (selectedButttonsMin.Count >= btnCount)
                {
                    Button first = selectedButttonsMin[0];
                    selectedButttonsMin.RemoveAt(0);
                    first.FlatAppearance.BorderColor = Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    this.wolfRight++;
                    this.wolfleft--;
                }
                selectedButttonsMin.Add(clickedButton);
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;
                this.wolfRight--;
                this.wolfleft++;
            }
            Btn_return.Enabled = selectedButttonsMin.Count > 0;
        }
        private void Btn_chk_min1_Click(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (selectedButttonsMin.Contains(clickedButton))
            {
                selectedButttonsMin.Remove(clickedButton);
                Btn_chk_min1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                Btn_chk_min1.FlatAppearance.BorderSize = 1;
                this.chkright++;
                this.chkleft--;
            }
            else
            {
                if (selectedButttonsMin.Count >= btnCount)
                {
                    Button first = selectedButttonsMin[0];
                    selectedButttonsMin.RemoveAt(0);
                    first.FlatAppearance.BorderColor = Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    this.chkright++;
                    this.chkleft--;
                }
                this.chkright--;
                this.chkleft++;
                selectedButttonsMin.Add(clickedButton);
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;

            }
            Btn_return.Enabled = selectedButttonsMin.Count > 0;
        }
        private void Btn_chk_min2_Click(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (selectedButttonsMin.Contains(clickedButton))
            {
                selectedButttonsMin.Remove(clickedButton);
                Btn_chk_min2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                Btn_chk_min2.FlatAppearance.BorderSize = 1;
                this.chkright++;
                this.chkleft--;
            }
            else
            {
                if (selectedButttonsMin.Count >= btnCount)
                {
                    Button first = selectedButttonsMin[0];
                    selectedButttonsMin.RemoveAt(0);
                    first.FlatAppearance.BorderColor = Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    chkright++;
                    chkleft--;
                }
                selectedButttonsMin.Add(clickedButton);
                this.chkright--;
                this.chkleft++;
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;

            }
            Btn_return.Enabled = selectedButttonsMin.Count > 0;
        }
        private void Btn_chk_min3_Click(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (selectedButttonsMin.Contains(clickedButton))
            {
                selectedButttonsMin.Remove(clickedButton);
                Btn_chk_min3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                Btn_chk_min3.FlatAppearance.BorderSize = 1;
                this.chkright++;
                this.chkleft--;
            }
            else
            {
                if (selectedButttonsMin.Count >= btnCount)
                {
                    Button first = selectedButttonsMin[0];
                    selectedButttonsMin.RemoveAt(0);
                    first.FlatAppearance.BorderColor = Color.Black;
                    first.FlatAppearance.BorderSize = 1;
                    this.chkright++;
                    this.chkleft--;
                }
                selectedButttonsMin.Add(clickedButton);
                this.chkright--;
                this.chkleft++;
                clickedButton.FlatAppearance.BorderColor = Color.Blue;
                clickedButton.FlatAppearance.BorderSize = 3;

            }
            Btn_return.Enabled = selectedButttonsMin.Count > 0;
        }



        private void btn_go_Click(object sender, EventArgs e)
        {
            if (boatOnLeft)
            {
                if (btn_wolf_add1.FlatAppearance.BorderSize == 3)
                {
                    btn_wolf_add1.Visible = false;
                    Btn_wolf_min1.Visible = true;
                }
                if (btn_wolf_add2.FlatAppearance.BorderSize == 3)
                {
                    btn_wolf_add2.Visible = false;
                    Btn_wolf_min2.Visible = true;
                }
                if (btn_wolf_add3.FlatAppearance.BorderSize == 3)
                {
                    btn_wolf_add3.Visible = false;
                    Btn_wolf_min3.Visible = true;
                }
                if (btn_chk_add1.FlatAppearance.BorderSize == 3)
                {
                    btn_chk_add1.Visible = false;
                    Btn_chk_min1.Visible = true;
                }
                if (btn_chk_add2.FlatAppearance.BorderSize == 3)
                {
                    btn_chk_add2.Visible = false;
                    Btn_chk_min2.Visible = true;
                }
                if (btn_add_chk3.FlatAppearance.BorderSize == 3)
                {
                    btn_add_chk3.Visible = false;
                    Btn_chk_min3.Visible = true;
                }
                fungo();
            }


        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            if (!boatOnLeft)
            {
                if (Btn_wolf_min1.FlatAppearance.BorderSize == 3)
                {

                    Btn_wolf_min1.Visible = false;
                    btn_wolf_add1.Visible = true;
                }
                if (Btn_wolf_min2.FlatAppearance.BorderSize == 3)
                {
                    Btn_wolf_min2.Visible = false;
                    btn_wolf_add2.Visible = true;
                }
                if (Btn_wolf_min3.FlatAppearance.BorderSize == 3)
                {
                    Btn_wolf_min3.Visible = false;
                    btn_wolf_add3.Visible = true;
                }
                if (Btn_chk_min1.FlatAppearance.BorderSize == 3)
                {
                    Btn_chk_min1.Visible = false;
                    btn_chk_add1.Visible = true;
                }
                if (Btn_chk_min2.FlatAppearance.BorderSize == 3)
                {
                    Btn_chk_min2.Visible = false;
                    btn_chk_add2.Visible = true;
                }
                if (Btn_chk_min3.FlatAppearance.BorderSize == 3)
                {
                    Btn_chk_min3.Visible = false;
                    btn_add_chk3.Visible = true;
                }
                funReturn();

            }

        }
        private void CheckWolfSheepCount()
        {
            if (wolfleft > chkleft && chkleft > 0)
            {
                MessageBox.Show("실패했습니다.");
                ResetGame();
            }
            if (wolfRight > chkright && chkright > 0)
            {
                MessageBox.Show("실패했습니다.");
                ResetGame();
            }

            if (wolfRight == 3 && chkright == 3)
            {
                Form41 sucess = new Form41(form46);
                player.controls.stop();
                sucess.Show();
                this.Hide();
            }

        }

        private void ResetGame()
        {
            // 모든 동물 버튼을 초기화 (Visible, BorderColor, BorderSize)
            foreach (Button btn in wolfButtons)
            {
                btn.Visible = true;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.BorderSize = 1;
                btn.Enabled = true;
            }

            foreach (Button btn in chkButtons)
            {
                btn.Visible = true;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.BorderSize = 1;
                btn.Enabled = true;
            }

            // Min 버튼도 초기화
            foreach (Button btn in new Button[] { Btn_wolf_min1, Btn_wolf_min2, Btn_wolf_min3, Btn_chk_min1, Btn_chk_min2, Btn_chk_min3 })
            {
                btn.Visible = false;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.BorderSize = 1;
                btn.Enabled = false;

            }
            wolfleft = 3;
            chkleft = 3;
            wolfRight = 0;
            chkright = 0;
            // 선택된 동물 리스트 초기화
            selectedButttons.Clear();
            selectedButttonsMin.Clear();

            // 버튼과 상태 초기화
            btn_go.Visible = true;
            btn_go.Enabled = false;
            Btn_return.Visible = false;
            Btn_return.Enabled = false;

            // 상태 변수 초기화
            boatOnLeft = true;
            count = 0;
            lb_count_num.Text = count.ToString();
        }
        private void fungo()
        {
            boatOnLeft = false;
            btn_go.Enabled = false;
            btn_go.Visible = false;
            Btn_return.Visible = true;
            btn_wolf_add1.FlatAppearance.BorderSize = 1;
            btn_wolf_add2.FlatAppearance.BorderSize = 1;
            btn_wolf_add3.FlatAppearance.BorderSize = 1;
            btn_chk_add1.FlatAppearance.BorderSize = 1;
            btn_chk_add2.FlatAppearance.BorderSize = 1;
            btn_add_chk3.FlatAppearance.BorderSize = 1;
            btn_wolf_add1.Enabled = false;
            btn_wolf_add2.Enabled = false;
            btn_wolf_add3.Enabled = false;
            btn_chk_add1.Enabled = false;
            btn_chk_add2.Enabled = false;
            btn_add_chk3.Enabled = false;
            Btn_wolf_min1.Enabled = true;
            Btn_wolf_min2.Enabled = true;
            Btn_wolf_min3.Enabled = true;
            Btn_chk_min1.Enabled = true;
            Btn_chk_min2.Enabled = true;
            Btn_chk_min3.Enabled = true;
            btn_wolf_add1.FlatAppearance.BorderColor = Color.Black;
            btn_wolf_add2.FlatAppearance.BorderColor = Color.Black;
            btn_wolf_add3.FlatAppearance.BorderColor = Color.Black;
            btn_chk_add1.FlatAppearance.BorderColor = Color.Black;
            btn_chk_add2.FlatAppearance.BorderColor = Color.Black;
            btn_add_chk3.FlatAppearance.BorderColor = Color.Black;
            selectedButttons.Clear();
            count++;
            lb_count_num.Text = count.ToString();
            CheckWolfSheepCount();
        }
        private void funReturn()
        {
            Btn_wolf_min1.FlatAppearance.BorderSize = 1;
            Btn_wolf_min2.FlatAppearance.BorderSize = 1;
            Btn_wolf_min3.FlatAppearance.BorderSize = 1;
            Btn_chk_min1.FlatAppearance.BorderSize = 1;
            Btn_chk_min2.FlatAppearance.BorderSize = 1;
            Btn_chk_min3.FlatAppearance.BorderSize = 1;
            btn_wolf_add1.Enabled = true;
            btn_wolf_add2.Enabled = true;
            btn_wolf_add3.Enabled = true;
            btn_chk_add1.Enabled = true;
            btn_chk_add2.Enabled = true;
            btn_add_chk3.Enabled = true;
            Btn_wolf_min1.Enabled = false;
            Btn_wolf_min2.Enabled = false;
            Btn_wolf_min3.Enabled = false;
            Btn_chk_min1.Enabled = false;
            Btn_chk_min2.Enabled = false;
            Btn_chk_min3.Enabled = false;
            boatOnLeft = true;
            btn_go.Visible = true;
            btn_go.Enabled = false;
            Btn_return.Visible = false;
            Btn_return.Enabled = false;
            count++;
            selectedButttonsMin.Clear();
            lb_count_num.Text = count.ToString();
            CheckWolfSheepCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void GotoHint_Click(object sender, EventArgs e)
        {
            Form42 hint4 = new Form42(this);
            this.Hide();
            hint4.Show();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            form46.Show();
            this.Close();
        }
    }
}
