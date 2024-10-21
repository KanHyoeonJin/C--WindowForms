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
    public partial class Form41 : Form
    {
        private Form46 form46;
        private WindowsMediaPlayer player=new WindowsMediaPlayer();
        private Timer timer;
        private Image[] successImages;
        private string imgPath;
        private string imgPath2;
        private string imgPath3;
        private string imgPath4;
        private string videoPath;
        private int index;
        public Form41()
        {
            InitializeComponent();
        }
        public Form41(Form46 form46)
        {
            InitializeComponent();
            videoPath = Path.Combine(Program.basePath, "Resources", "correct.mp3");
            imgPath = Path.Combine(Program.basePath, "Resources","sucess1.png");
            imgPath2 = Path.Combine(Program.basePath, "Resources", "sucess2.png");
            imgPath3 = Path.Combine(Program.basePath, "Resources", "sucess3.png");
            imgPath4 = Path.Combine(Program.basePath, "Resources", "sucess4.png");
            this.form46 = form46;
            successImages = new Image[]
            {
                Image.FromFile(imgPath),
                Image.FromFile(imgPath2),
                Image.FromFile(imgPath3),
                Image.FromFile(imgPath4),
            };
            index = 0;
            timer = new Timer();
            timer.Interval = 750;
            timer.Tick += Timer_Tick;
            timer.Start();
            player = new WindowsMediaPlayer();
            player.URL = videoPath;
            player.settings.setMode("loop",false);
            player.controls.play();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            this.BackgroundImage = successImages[index];
            index++;
            if (index >= successImages.Length)
            {
                timer.Stop();
                Timer delayTimer = new Timer();
                delayTimer.Interval = 2000;
                delayTimer.Tick += (s, args) =>
                {
                    delayTimer.Stop();
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Close();
                };
                delayTimer.Start();
            }
        }
    }
}
