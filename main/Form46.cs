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
    public partial class Form46 : Form
    {
        private bool ques;
        WindowsMediaPlayer player;
        public Form46()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            player.URL = @"C:\Users\이대한\Desktop\main1\Resources\Town.mp3";
            player.settings.setMode("loop",true);
            player.controls.play();
            Script1.Visible = false;
            ques = false;
        }
        public bool Ques
        {
            set { this.ques = value; }
        }
        public Form46(bool ques)
        {
            InitializeComponent();
            this.ques = ques;
            player = new WindowsMediaPlayer();
            Script1.Visible = false;
            this.ques = ques;
        }

        private void Question2_Click(object sender, EventArgs e)
        {
            if(!ques)
            {
                Script1.Visible = true;
            }
            else
            {
                return;
            }
            
        }
        private void Script1_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            Form40 form40 = new Form40(this);
            form40.Show();
            Script1.Visible = false;
            this.Hide();


        }


    }
}
