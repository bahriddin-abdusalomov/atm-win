namespace ATM.Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            buttonUz = new Button();
            buttonRu = new Button();
            buttonEng = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 393);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonUz
            // 
            buttonUz.BackColor = Color.FromArgb(192, 192, 255);
            buttonUz.Font = new Font("Cambria", 15.2F, FontStyle.Bold);
            buttonUz.Location = new Point(263, 134);
            buttonUz.Name = "buttonUz";
            buttonUz.Size = new Size(241, 59);
            buttonUz.TabIndex = 1;
            buttonUz.Text = "O'zbekcha";
            buttonUz.UseVisualStyleBackColor = false;
            buttonUz.Click += buttonUz_Click;
            // 
            // buttonRu
            // 
            buttonRu.BackColor = Color.FromArgb(192, 192, 255);
            buttonRu.Font = new Font("Cambria", 15.2F, FontStyle.Bold);
            buttonRu.Location = new Point(263, 227);
            buttonRu.Name = "buttonRu";
            buttonRu.Size = new Size(241, 59);
            buttonRu.TabIndex = 2;
            buttonRu.Text = "Русскый";
            buttonRu.UseVisualStyleBackColor = false;
            // 
            // buttonEng
            // 
            buttonEng.BackColor = Color.FromArgb(192, 192, 255);
            buttonEng.Font = new Font("Cambria", 15.2F, FontStyle.Bold);
            buttonEng.Location = new Point(263, 315);
            buttonEng.Name = "buttonEng";
            buttonEng.Size = new Size(241, 59);
            buttonEng.TabIndex = 3;
            buttonEng.Text = "English";
            buttonEng.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(583, 485);
            Controls.Add(buttonEng);
            Controls.Add(buttonRu);
            Controls.Add(buttonUz);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ATM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonUz;
        private Button buttonRu;
        private Button buttonEng;
    }
}
