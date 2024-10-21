namespace main1
{
    partial class Form47
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Go_question3 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Go_question3
            // 
            Go_question3.BackColor = System.Drawing.Color.Transparent;
            Go_question3.Cursor = System.Windows.Forms.Cursors.Hand;
            Go_question3.FlatAppearance.BorderSize = 0;
            Go_question3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            Go_question3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            Go_question3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Go_question3.Location = new System.Drawing.Point(141, 696);
            Go_question3.Name = "Go_question3";
            Go_question3.Size = new System.Drawing.Size(83, 74);
            Go_question3.TabIndex = 0;
            Go_question3.UseVisualStyleBackColor = false;
            Go_question3.Click += Go_question3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.hidden;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(430, 900);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form47
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.KakaoTalk_20241017_144008773;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(424, 891);
            Controls.Add(pictureBox1);
            Controls.Add(Go_question3);
            DoubleBuffered = true;
            Name = "Form47";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Go_question3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}