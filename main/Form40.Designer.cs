using System;
using main1.Properties;

namespace main1
{
    partial class Form40
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            Pn_game2 = new System.Windows.Forms.Panel();
            Btn_back = new System.Windows.Forms.Button();
            GotoHint = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            Btn_return = new System.Windows.Forms.Button();
            lb_count_num = new System.Windows.Forms.Label();
            lb_count = new System.Windows.Forms.Label();
            btn_go = new System.Windows.Forms.Button();
            Btn_chk_min2 = new System.Windows.Forms.Button();
            Btn_chk_min1 = new System.Windows.Forms.Button();
            btn_chk_add1 = new System.Windows.Forms.Button();
            Btn_wolf_min1 = new System.Windows.Forms.Button();
            btn_add_chk3 = new System.Windows.Forms.Button();
            Btn_wolf_min2 = new System.Windows.Forms.Button();
            btn_wolf_add2 = new System.Windows.Forms.Button();
            Btn_chk_min3 = new System.Windows.Forms.Button();
            btn_wolf_add1 = new System.Windows.Forms.Button();
            Btn_wolf_min3 = new System.Windows.Forms.Button();
            btn_chk_add2 = new System.Windows.Forms.Button();
            btn_wolf_add3 = new System.Windows.Forms.Button();
            PB_game1 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            Pn_game2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_game1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button7
            // 
            button7.BackgroundImage = Resources.늑대와_병아리;
            button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button7.Location = new System.Drawing.Point(0, 0);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(435, 472);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn_b1_Clicked;
            // 
            // button8
            // 
            button8.BackgroundImage = Resources.KakaoTalk_20241015_104325742;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button8.Location = new System.Drawing.Point(0, 468);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(435, 420);
            button8.TabIndex = 6;
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn_b2_Clicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(Pn_game2);
            panel1.Controls.Add(PB_game1);
            panel1.Location = new System.Drawing.Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(431, 890);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // Pn_game2
            // 
            Pn_game2.BackgroundImage = Resources.오른쪽;
            Pn_game2.Controls.Add(Btn_back);
            Pn_game2.Controls.Add(GotoHint);
            Pn_game2.Controls.Add(button1);
            Pn_game2.Controls.Add(Btn_return);
            Pn_game2.Controls.Add(lb_count_num);
            Pn_game2.Controls.Add(lb_count);
            Pn_game2.Controls.Add(btn_go);
            Pn_game2.Controls.Add(Btn_chk_min2);
            Pn_game2.Controls.Add(Btn_chk_min1);
            Pn_game2.Controls.Add(btn_chk_add1);
            Pn_game2.Controls.Add(Btn_wolf_min1);
            Pn_game2.Controls.Add(btn_add_chk3);
            Pn_game2.Controls.Add(Btn_wolf_min2);
            Pn_game2.Controls.Add(btn_wolf_add2);
            Pn_game2.Controls.Add(Btn_chk_min3);
            Pn_game2.Controls.Add(btn_wolf_add1);
            Pn_game2.Controls.Add(Btn_wolf_min3);
            Pn_game2.Controls.Add(btn_chk_add2);
            Pn_game2.Controls.Add(btn_wolf_add3);
            Pn_game2.Location = new System.Drawing.Point(2, 435);
            Pn_game2.Name = "Pn_game2";
            Pn_game2.Size = new System.Drawing.Size(431, 453);
            Pn_game2.TabIndex = 4;
            // 
            // Btn_back
            // 
            Btn_back.BackColor = System.Drawing.Color.Transparent;
            Btn_back.BackgroundImage = Resources.KakaoTalk_20241016_143440839_01;
            Btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            Btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_back.Location = new System.Drawing.Point(103, 376);
            Btn_back.Name = "Btn_back";
            Btn_back.Size = new System.Drawing.Size(73, 63);
            Btn_back.TabIndex = 8;
            Btn_back.UseVisualStyleBackColor = false;
            Btn_back.Click += Btn_back_Click;
            // 
            // GotoHint
            // 
            GotoHint.BackColor = System.Drawing.Color.Transparent;
            GotoHint.BackgroundImage = Resources.힌트;
            GotoHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            GotoHint.Location = new System.Drawing.Point(23, 381);
            GotoHint.Name = "GotoHint";
            GotoHint.Size = new System.Drawing.Size(66, 51);
            GotoHint.TabIndex = 9;
            GotoHint.UseVisualStyleBackColor = false;
            GotoHint.Click += GotoHint_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(274, 381);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(63, 51);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Btn_return
            // 
            Btn_return.BackgroundImage = Resources.뗏목;
            Btn_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_return.Enabled = false;
            Btn_return.FlatAppearance.BorderSize = 0;
            Btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_return.ForeColor = System.Drawing.SystemColors.ButtonFace;
            Btn_return.Location = new System.Drawing.Point(161, 208);
            Btn_return.Name = "Btn_return";
            Btn_return.Size = new System.Drawing.Size(107, 68);
            Btn_return.TabIndex = 7;
            Btn_return.Text = "<--";
            Btn_return.UseVisualStyleBackColor = true;
            Btn_return.Visible = false;
            Btn_return.Click += Btn_return_Click;
            // 
            // lb_count_num
            // 
            lb_count_num.AutoSize = true;
            lb_count_num.BackColor = System.Drawing.Color.Transparent;
            lb_count_num.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_count_num.ForeColor = System.Drawing.Color.Red;
            lb_count_num.Location = new System.Drawing.Point(355, 5);
            lb_count_num.Name = "lb_count_num";
            lb_count_num.Size = new System.Drawing.Size(25, 30);
            lb_count_num.TabIndex = 6;
            lb_count_num.Text = "0";
            // 
            // lb_count
            // 
            lb_count.AutoSize = true;
            lb_count.BackColor = System.Drawing.Color.Transparent;
            lb_count.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_count.Location = new System.Drawing.Point(304, 9);
            lb_count.Name = "lb_count";
            lb_count.Size = new System.Drawing.Size(54, 24);
            lb_count.TabIndex = 5;
            lb_count.Text = "횟수:";
            // 
            // btn_go
            // 
            btn_go.BackColor = System.Drawing.Color.Transparent;
            btn_go.BackgroundImage = Resources.뗏목;
            btn_go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_go.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_go.Enabled = false;
            btn_go.FlatAppearance.BorderSize = 0;
            btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_go.Font = new System.Drawing.Font("함초롬돋움", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_go.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btn_go.Location = new System.Drawing.Point(161, 209);
            btn_go.Name = "btn_go";
            btn_go.Size = new System.Drawing.Size(107, 68);
            btn_go.TabIndex = 4;
            btn_go.Text = "-->";
            btn_go.UseVisualStyleBackColor = false;
            btn_go.Click += btn_go_Click;
            // 
            // Btn_chk_min2
            // 
            Btn_chk_min2.BackgroundImage = Resources.진짜병아리;
            Btn_chk_min2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Btn_chk_min2.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_chk_min2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_chk_min2.Location = new System.Drawing.Point(402, 227);
            Btn_chk_min2.Name = "Btn_chk_min2";
            Btn_chk_min2.Size = new System.Drawing.Size(30, 30);
            Btn_chk_min2.TabIndex = 3;
            Btn_chk_min2.UseVisualStyleBackColor = true;
            Btn_chk_min2.Visible = false;
            Btn_chk_min2.Click += Btn_chk_min2_Click;
            // 
            // Btn_chk_min1
            // 
            Btn_chk_min1.BackgroundImage = Resources.진짜병아리;
            Btn_chk_min1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Btn_chk_min1.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_chk_min1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_chk_min1.Location = new System.Drawing.Point(402, 263);
            Btn_chk_min1.Name = "Btn_chk_min1";
            Btn_chk_min1.Size = new System.Drawing.Size(30, 30);
            Btn_chk_min1.TabIndex = 3;
            Btn_chk_min1.UseVisualStyleBackColor = true;
            Btn_chk_min1.Visible = false;
            Btn_chk_min1.Click += Btn_chk_min1_Click;
            // 
            // btn_chk_add1
            // 
            btn_chk_add1.BackColor = System.Drawing.SystemColors.Control;
            btn_chk_add1.BackgroundImage = Resources.진짜병아리;
            btn_chk_add1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_chk_add1.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_chk_add1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_chk_add1.Location = new System.Drawing.Point(40, 191);
            btn_chk_add1.Name = "btn_chk_add1";
            btn_chk_add1.Size = new System.Drawing.Size(30, 30);
            btn_chk_add1.TabIndex = 3;
            btn_chk_add1.UseVisualStyleBackColor = false;
            btn_chk_add1.Click += btn_chk_add1_Click;
            // 
            // Btn_wolf_min1
            // 
            Btn_wolf_min1.BackgroundImage = Resources.진짜늑대;
            Btn_wolf_min1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Btn_wolf_min1.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_wolf_min1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_wolf_min1.Location = new System.Drawing.Point(366, 263);
            Btn_wolf_min1.Name = "Btn_wolf_min1";
            Btn_wolf_min1.Size = new System.Drawing.Size(30, 30);
            Btn_wolf_min1.TabIndex = 3;
            Btn_wolf_min1.UseVisualStyleBackColor = true;
            Btn_wolf_min1.Visible = false;
            Btn_wolf_min1.Click += Btn_wolf_min1_Click;
            // 
            // btn_add_chk3
            // 
            btn_add_chk3.BackColor = System.Drawing.SystemColors.Control;
            btn_add_chk3.BackgroundImage = Resources.진짜병아리;
            btn_add_chk3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_add_chk3.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_add_chk3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_add_chk3.Location = new System.Drawing.Point(39, 277);
            btn_add_chk3.Name = "btn_add_chk3";
            btn_add_chk3.Size = new System.Drawing.Size(30, 30);
            btn_add_chk3.TabIndex = 3;
            btn_add_chk3.UseVisualStyleBackColor = false;
            btn_add_chk3.Click += btn_add_chk3_Click;
            // 
            // Btn_wolf_min2
            // 
            Btn_wolf_min2.BackgroundImage = Resources.진짜늑대;
            Btn_wolf_min2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Btn_wolf_min2.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_wolf_min2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_wolf_min2.Location = new System.Drawing.Point(366, 227);
            Btn_wolf_min2.Name = "Btn_wolf_min2";
            Btn_wolf_min2.Size = new System.Drawing.Size(30, 30);
            Btn_wolf_min2.TabIndex = 3;
            Btn_wolf_min2.UseVisualStyleBackColor = true;
            Btn_wolf_min2.Visible = false;
            Btn_wolf_min2.Click += Btn_wolf_min2_Click;
            // 
            // btn_wolf_add2
            // 
            btn_wolf_add2.BackColor = System.Drawing.Color.Transparent;
            btn_wolf_add2.BackgroundImage = Resources.진짜늑대;
            btn_wolf_add2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_wolf_add2.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_wolf_add2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_wolf_add2.Location = new System.Drawing.Point(4, 232);
            btn_wolf_add2.Name = "btn_wolf_add2";
            btn_wolf_add2.Size = new System.Drawing.Size(30, 30);
            btn_wolf_add2.TabIndex = 3;
            btn_wolf_add2.UseVisualStyleBackColor = false;
            btn_wolf_add2.Click += btn_wolf_add2_Click;
            // 
            // Btn_chk_min3
            // 
            Btn_chk_min3.BackgroundImage = Resources.진짜병아리;
            Btn_chk_min3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Btn_chk_min3.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_chk_min3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_chk_min3.Location = new System.Drawing.Point(402, 191);
            Btn_chk_min3.Name = "Btn_chk_min3";
            Btn_chk_min3.Size = new System.Drawing.Size(30, 30);
            Btn_chk_min3.TabIndex = 3;
            Btn_chk_min3.UseVisualStyleBackColor = true;
            Btn_chk_min3.Visible = false;
            Btn_chk_min3.Click += Btn_chk_min3_Click;
            // 
            // btn_wolf_add1
            // 
            btn_wolf_add1.BackColor = System.Drawing.Color.Transparent;
            btn_wolf_add1.BackgroundImage = Resources.진짜늑대;
            btn_wolf_add1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_wolf_add1.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_wolf_add1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_wolf_add1.Location = new System.Drawing.Point(4, 191);
            btn_wolf_add1.Name = "btn_wolf_add1";
            btn_wolf_add1.Size = new System.Drawing.Size(30, 30);
            btn_wolf_add1.TabIndex = 3;
            btn_wolf_add1.UseVisualStyleBackColor = false;
            btn_wolf_add1.Click += btn_wolf_add1_Click;
            // 
            // Btn_wolf_min3
            // 
            Btn_wolf_min3.BackgroundImage = Resources.진짜늑대;
            Btn_wolf_min3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Btn_wolf_min3.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_wolf_min3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_wolf_min3.Location = new System.Drawing.Point(366, 191);
            Btn_wolf_min3.Name = "Btn_wolf_min3";
            Btn_wolf_min3.Size = new System.Drawing.Size(30, 30);
            Btn_wolf_min3.TabIndex = 3;
            Btn_wolf_min3.UseVisualStyleBackColor = true;
            Btn_wolf_min3.Visible = false;
            Btn_wolf_min3.Click += Btn_wolf_min3_Click;
            // 
            // btn_chk_add2
            // 
            btn_chk_add2.BackColor = System.Drawing.SystemColors.Control;
            btn_chk_add2.BackgroundImage = Resources.진짜병아리;
            btn_chk_add2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_chk_add2.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_chk_add2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_chk_add2.Location = new System.Drawing.Point(40, 232);
            btn_chk_add2.Name = "btn_chk_add2";
            btn_chk_add2.Size = new System.Drawing.Size(30, 30);
            btn_chk_add2.TabIndex = 3;
            btn_chk_add2.UseVisualStyleBackColor = false;
            btn_chk_add2.Click += btn_chk_add2_Click;
            // 
            // btn_wolf_add3
            // 
            btn_wolf_add3.BackColor = System.Drawing.Color.Transparent;
            btn_wolf_add3.BackgroundImage = Resources.진짜늑대;
            btn_wolf_add3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_wolf_add3.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_wolf_add3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btn_wolf_add3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_wolf_add3.Location = new System.Drawing.Point(3, 277);
            btn_wolf_add3.Name = "btn_wolf_add3";
            btn_wolf_add3.Size = new System.Drawing.Size(30, 30);
            btn_wolf_add3.TabIndex = 3;
            btn_wolf_add3.UseVisualStyleBackColor = false;
            btn_wolf_add3.Click += btn_wolf_add3_Click;
            // 
            // PB_game1
            // 
            PB_game1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            PB_game1.Image = Resources.question4;
            PB_game1.Location = new System.Drawing.Point(2, 3);
            PB_game1.Name = "PB_game1";
            PB_game1.Size = new System.Drawing.Size(431, 432);
            PB_game1.TabIndex = 2;
            PB_game1.TabStop = false;
            // 
            // Form40
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(435, 891);
            Controls.Add(panel1);
            Controls.Add(button8);
            Controls.Add(button7);
            Name = "Form40";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            Pn_game2.ResumeLayout(false);
            Pn_game2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_game1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PB_game1;
        private System.Windows.Forms.Button btn_add_chk3;
        private System.Windows.Forms.Button btn_wolf_add2;
        private System.Windows.Forms.Button btn_chk_add2;
        private System.Windows.Forms.Button btn_chk_add1;
        private System.Windows.Forms.Button btn_wolf_add1;
        private System.Windows.Forms.Button btn_wolf_add3;
        private System.Windows.Forms.Panel Pn_game2;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label lb_count_num;
        private System.Windows.Forms.Button Btn_chk_min2;
        private System.Windows.Forms.Button Btn_chk_min1;
        private System.Windows.Forms.Button Btn_wolf_min1;
        private System.Windows.Forms.Button Btn_wolf_min2;
        private System.Windows.Forms.Button Btn_chk_min3;
        private System.Windows.Forms.Button Btn_wolf_min3;
        private System.Windows.Forms.Button Btn_return;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GotoHint;
        private System.Windows.Forms.Button Btn_back;
    }
}
