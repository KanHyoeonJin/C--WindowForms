using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private int index;
        public Form41()
        {
            InitializeComponent();
        }
        public Form41(Form46 form46)
        {
            InitializeComponent();
            this.form46 = form46;
            successImages = new Image[]
            {
                Image.FromFile("C:\\Users\\이대한\\Desktop\\main1\\Resources\\sucess1.png"),
                Image.FromFile("C:\\Users\\이대한\\Desktop\\main1\\Resources\\sucess2.png"),
                Image.FromFile("C:\\Users\\이대한\\Desktop\\main1\\Resources\\sucess3.png"),
                Image.FromFile("C:\\Users\\이대한\\Desktop\\main1\\Resources\\sucess4.png"),
            };
            index = 0;
            timer = new Timer();
            timer.Interval = 750;
            timer.Tick += Timer_Tick;
            timer.Start();
            player = new WindowsMediaPlayer();
            player.URL = @"C:\Users\이대한\Desktop\main1\Resources\correct.mp3";
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
