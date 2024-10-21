using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main1
{
    public partial class Form42 : Form
    {
        private Form40 form1;
        public Form42()
        {
            InitializeComponent();

        }
        public Form42(Form40 form)
        {
            InitializeComponent();
            Hint1.Visible = true;
            Hint2.Visible = false;
            Hint3.Visible = false;
            this.form1 = form;
        }

        private void Btn_hint1_Click(object sender, EventArgs e)
        {
            Hint1.Visible = true;
            Hint2.Visible = false;
            Hint3.Visible = false;
        }

        private void Btn_hint2_Click(object sender, EventArgs e)
        {
            Hint2.Visible = true;
            Hint3.Visible = false;
            Hint1.Visible = false;
        }

        private void Btn_hint3_Click(object sender, EventArgs e)
        {
            Hint3.Visible = true;
            Hint1.Visible = false;
            Hint2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
