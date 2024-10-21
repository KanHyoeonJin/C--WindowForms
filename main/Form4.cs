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
    public partial class Form4 : Form
    {

        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form4()
        {
            InitializeComponent();
            player.URL = @"C:\Users\이대한\Desktop\main1\Resources\Town.mp3";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           Form11 form11 =  new Form11();
            player.controls.stop();
            form11.Show();
            this.Close();
            
        }
    }
}
