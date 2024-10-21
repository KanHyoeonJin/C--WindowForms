namespace main1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            home1 = new System.Windows.Forms.Button();
            home2 = new System.Windows.Forms.Button();
            home3 = new System.Windows.Forms.Button();
            home4 = new System.Windows.Forms.Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            home5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // home1
            // 
            home1.BackColor = System.Drawing.Color.Transparent;
            home1.FlatAppearance.BorderSize = 0;
            home1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            home1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            home1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            home1.ForeColor = System.Drawing.Color.Transparent;
            home1.Location = new System.Drawing.Point(86, 183);
            home1.Name = "home1";
            home1.Size = new System.Drawing.Size(98, 103);
            home1.TabIndex = 2;
            home1.UseVisualStyleBackColor = false;
            home1.Click += home1_Click;
            // 
            // home2
            // 
            home2.BackColor = System.Drawing.Color.Transparent;
            home2.FlatAppearance.BorderSize = 0;
            home2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            home2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            home2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            home2.ForeColor = System.Drawing.Color.Transparent;
            home2.Location = new System.Drawing.Point(187, 289);
            home2.Name = "home2";
            home2.Size = new System.Drawing.Size(162, 79);
            home2.TabIndex = 3;
            home2.UseVisualStyleBackColor = false;
            home2.Click += home2_Click;
            // 
            // home3
            // 
            home3.BackColor = System.Drawing.Color.Transparent;
            home3.FlatAppearance.BorderSize = 0;
            home3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            home3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            home3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            home3.ForeColor = System.Drawing.Color.Transparent;
            home3.Location = new System.Drawing.Point(345, 85);
            home3.Name = "home3";
            home3.Size = new System.Drawing.Size(96, 140);
            home3.TabIndex = 4;
            home3.UseVisualStyleBackColor = false;
            home3.Click += home3_Click;
            // 
            // home4
            // 
            home4.BackColor = System.Drawing.Color.Transparent;
            home4.FlatAppearance.BorderSize = 0;
            home4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            home4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            home4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            home4.ForeColor = System.Drawing.Color.Transparent;
            home4.Location = new System.Drawing.Point(567, 245);
            home4.Name = "home4";
            home4.Size = new System.Drawing.Size(79, 115);
            home4.TabIndex = 5;
            home4.UseVisualStyleBackColor = false;
            home4.Click += home4_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new System.Drawing.Size(1, 1);
            axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // home5
            // 
            home5.BackColor = System.Drawing.Color.Transparent;
            home5.FlatAppearance.BorderSize = 0;
            home5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            home5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            home5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            home5.ForeColor = System.Drawing.Color.Transparent;
            home5.Location = new System.Drawing.Point(531, 12);
            home5.Name = "home5";
            home5.Size = new System.Drawing.Size(190, 78);
            home5.TabIndex = 7;
            home5.UseVisualStyleBackColor = false;
            home5.Click += home5_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.중세시대;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(733, 407);
            Controls.Add(home5);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(home4);
            Controls.Add(home3);
            Controls.Add(home2);
            Controls.Add(home1);
            Name = "Form3";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button home1;
        private System.Windows.Forms.Button home2;
        private System.Windows.Forms.Button home3;
        private System.Windows.Forms.Button home4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button home5;
    }
}