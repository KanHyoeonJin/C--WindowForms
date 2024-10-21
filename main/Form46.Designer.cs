namespace main1
{
    partial class Form46
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
            question2 = new System.Windows.Forms.Button();
            Script1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)Script1).BeginInit();
            SuspendLayout();
            // 
            // question2
            // 
            question2.BackColor = System.Drawing.Color.Transparent;
            question2.Cursor = System.Windows.Forms.Cursors.Hand;
            question2.FlatAppearance.BorderSize = 0;
            question2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            question2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            question2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            question2.Location = new System.Drawing.Point(105, 203);
            question2.Name = "question2";
            question2.Size = new System.Drawing.Size(62, 304);
            question2.TabIndex = 1;
            question2.UseVisualStyleBackColor = false;
            question2.Click += Question2_Click;
            // 
            // Script1
            // 
            Script1.BackgroundImage = Properties.Resources.script1_1;
            Script1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Script1.Location = new System.Drawing.Point(-1, 0);
            Script1.Name = "Script1";
            Script1.Size = new System.Drawing.Size(434, 892);
            Script1.TabIndex = 2;
            Script1.TabStop = false;
            Script1.Click += this.Script1_Click;
            // 
            // Form46
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bar;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(434, 891);
            Controls.Add(Script1);
            Controls.Add(question2);
            DoubleBuffered = true;
            Name = "Form46";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)Script1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button question2;
        private System.Windows.Forms.PictureBox Script1;
    }
}