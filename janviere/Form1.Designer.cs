namespace janviere
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            btnlogin = new Button();
            btnclose = new Button();
            txtUsername = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(301, 18);
            label1.Name = "label1";
            label1.Size = new Size(152, 38);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(251, 73);
            label2.Name = "label2";
            label2.Size = new Size(272, 31);
            label2.TabIndex = 1;
            label2.Text = "Please login to continue";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(123, 249);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(128, 329);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 3;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(301, 333);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(289, 27);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Lime;
            btnlogin.ForeColor = SystemColors.WindowText;
            btnlogin.Location = new Point(301, 424);
            btnlogin.Margin = new Padding(3, 4, 3, 4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 36);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.DeepPink;
            btnclose.Location = new Point(496, 424);
            btnclose.Margin = new Padding(3, 4, 3, 4);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(94, 36);
            btnclose.TabIndex = 7;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(301, 239);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(289, 27);
            txtUsername.TabIndex = 8;
            txtUsername.TextChanged += txtUsername_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(821, 609);
            Controls.Add(txtUsername);
            Controls.Add(btnclose);
            Controls.Add(btnlogin);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.IBeam;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private Button btnlogin;
        private Button btnclose;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
    }
}
