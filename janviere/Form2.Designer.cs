namespace janviere
{
    partial class Form2
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
            label1 = new Label();
            btnrental = new Button();
            btnmush = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(218, 82);
            label1.Name = "label1";
            label1.Size = new Size(285, 28);
            label1.TabIndex = 0;
            label1.Text = "where do you want to proceed to?";
            // 
            // btnrental
            // 
            btnrental.BackColor = Color.Lime;
            btnrental.ForeColor = Color.Black;
            btnrental.Location = new Point(126, 214);
            btnrental.Name = "btnrental";
            btnrental.Size = new Size(184, 58);
            btnrental.TabIndex = 1;
            btnrental.Text = "Bicycle Rental";
            btnrental.UseVisualStyleBackColor = false;
            btnrental.Click += btnrental_Click;
            // 
            // btnmush
            // 
            btnmush.BackColor = Color.Lime;
            btnmush.Location = new Point(402, 214);
            btnmush.Name = "btnmush";
            btnmush.Size = new Size(186, 58);
            btnmush.TabIndex = 2;
            btnmush.Text = "mushroom Guessing";
            btnmush.UseVisualStyleBackColor = false;
            btnmush.Click += btnmush_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(742, 516);
            Controls.Add(btnmush);
            Controls.Add(btnrental);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Choose Application";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnrental;
        private Button btnmush;
    }
}