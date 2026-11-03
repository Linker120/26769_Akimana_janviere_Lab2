namespace janviere
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTotal = new Button();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnLogout = new Button();
            btnBack = new Button();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Pink;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(279, 25);
            label1.Name = "label1";
            label1.Size = new Size(166, 31);
            label1.TabIndex = 0;
            label1.Text = "Bicycle Rental";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(258, 94);
            label2.Name = "label2";
            label2.Size = new Size(215, 23);
            label2.TabIndex = 1;
            label2.Text = "Starting time (0-23)hour:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 164);
            label3.Name = "label3";
            label3.Size = new Size(208, 23);
            label3.TabIndex = 2;
            label3.Text = "Ending Time (1-24)hour:";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.Lime;
            txtTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(258, 253);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(169, 29);
            txtTotal.TabIndex = 3;
            txtTotal.Text = "Calculate Total";
            txtTotal.UseVisualStyleBackColor = false;
            txtTotal.Click += btntotal_Click;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(201, 120);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(307, 27);
            txtStart.TabIndex = 4;
            txtStart.TextChanged += textBox1_TextChanged;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(201, 190);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(307, 27);
            txtEnd.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DeepPink;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(414, 348);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 39);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Lime;
            btnBack.Location = new Point(201, 347);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 40);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(340, 299);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Click += lblPrice_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(749, 516);
            Controls.Add(lblPrice);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Bicycle Rental";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button txtTotal;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Button button1;
        private Button btnBack;
        private Label lblPrice;
        private Button btnLogout;
    }
}