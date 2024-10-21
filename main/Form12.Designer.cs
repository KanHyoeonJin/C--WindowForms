using System.Windows.Forms;
using System.Drawing;
namespace main1
{
    partial class Form12
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
            All1 = new PictureBox();
            All2 = new PictureBox();
            True1 = new PictureBox();
            True2 = new PictureBox();
            False1 = new PictureBox();
            False2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)All1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)All2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)True1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)True2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)False1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)False2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // All1
            // 
            All1.BackgroundImage = Properties.Resources.All1;
            All1.BackgroundImageLayout = ImageLayout.Stretch;
            All1.Location = new Point(0, -1);
            All1.Name = "All1";
            All1.Size = new Size(434, 893);
            All1.TabIndex = 0;
            All1.TabStop = false;
            All1.Click += All1_Click;
            // 
            // All2
            // 
            All2.BackgroundImage = Properties.Resources.All21;
            All2.BackgroundImageLayout = ImageLayout.Stretch;
            All2.Location = new Point(0, -1);
            All2.Name = "All2";
            All2.Size = new Size(434, 893);
            All2.TabIndex = 1;
            All2.TabStop = false;
            // 
            // True1
            // 
            True1.BackgroundImage = Properties.Resources.True1;
            True1.BackgroundImageLayout = ImageLayout.Stretch;
            True1.Location = new Point(0, -1);
            True1.Name = "True1";
            True1.Size = new Size(434, 893);
            True1.TabIndex = 2;
            True1.TabStop = false;
            // 
            // True2
            // 
            True2.BackgroundImage = Properties.Resources.True2;
            True2.BackgroundImageLayout = ImageLayout.Stretch;
            True2.Location = new Point(0, -1);
            True2.Name = "True2";
            True2.Size = new Size(434, 893);
            True2.TabIndex = 3;
            True2.TabStop = false;
            // 
            // False1
            // 
            False1.BackgroundImage = Properties.Resources.False1;
            False1.BackgroundImageLayout = ImageLayout.Stretch;
            False1.Location = new Point(0, -1);
            False1.Name = "False1";
            False1.Size = new Size(434, 893);
            False1.TabIndex = 4;
            False1.TabStop = false;
            // 
            // False2
            // 
            False2.BackgroundImage = Properties.Resources.False2;
            False2.BackgroundImageLayout = ImageLayout.Stretch;
            False2.Location = new Point(0, -1);
            False2.Name = "False2";
            False2.Size = new Size(434, 893);
            False2.TabIndex = 5;
            False2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 892);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 891);
            Controls.Add(pictureBox1);
            Controls.Add(False2);
            Controls.Add(False1);
            Controls.Add(True2);
            Controls.Add(True1);
            Controls.Add(All2);
            Controls.Add(All1);
            Name = "Form12";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)All1).EndInit();
            ((System.ComponentModel.ISupportInitialize)All2).EndInit();
            ((System.ComponentModel.ISupportInitialize)True1).EndInit();
            ((System.ComponentModel.ISupportInitialize)True2).EndInit();
            ((System.ComponentModel.ISupportInitialize)False1).EndInit();
            ((System.ComponentModel.ISupportInitialize)False2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox All1;
        private PictureBox All2;
        private PictureBox True1;
        private PictureBox True2;
        private PictureBox False1;
        private PictureBox False2;
        private PictureBox pictureBox1;
    }
}