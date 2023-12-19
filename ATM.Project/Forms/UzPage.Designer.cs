namespace ATM.Project.Forms
{
    partial class UzPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UzPage));
            labelParol = new Label();
            textBoxParol = new TextBox();
            buttonParol = new Button();
            SuspendLayout();
            // 
            // labelParol
            // 
            labelParol.AutoSize = true;
            labelParol.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelParol.Location = new Point(71, 89);
            labelParol.Name = "labelParol";
            labelParol.Size = new Size(161, 24);
            labelParol.TabIndex = 0;
            labelParol.Text = "Parolni kiriting";
            // 
            // textBoxParol
            // 
            textBoxParol.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxParol.Location = new Point(71, 136);
            textBoxParol.Name = "textBoxParol";
            textBoxParol.Size = new Size(353, 25);
            textBoxParol.TabIndex = 1;
            textBoxParol.TextChanged += textBoxParol_TextChanged;
            // 
            // buttonParol
            // 
            buttonParol.BackColor = Color.FromArgb(224, 224, 224);
            buttonParol.Font = new Font("Cambria", 11F, FontStyle.Bold);
            buttonParol.Location = new Point(262, 206);
            buttonParol.Name = "buttonParol";
            buttonParol.Size = new Size(162, 36);
            buttonParol.TabIndex = 2;
            buttonParol.Text = "Kiyingisi";
            buttonParol.UseVisualStyleBackColor = false;
            buttonParol.Click += buttonParol_Click;
            // 
            // UzPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(498, 342);
            Controls.Add(buttonParol);
            Controls.Add(textBoxParol);
            Controls.Add(labelParol);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UzPage";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelParol;
        private TextBox textBoxParol;
        private Button buttonParol;
    }
}