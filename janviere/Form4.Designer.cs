namespace janviere
{
    partial class Form4
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
            lblGills = new Label();
            lblForest = new Label();
            lblRing = new Label();
            lblConvexCup = new Label();
            label8 = new Label();
            cmbGills = new ComboBox();
            cmbForest = new ComboBox();
            cmbRing = new ComboBox();
            cmbConvexCup = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lstMushrooms = new ListBox();
            btnFindMushroom = new Button();
            lblDisplayMushroom = new Label();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(248, 23);
            label1.Name = "label1";
            label1.Size = new Size(233, 31);
            label1.TabIndex = 0;
            label1.Text = "Mushroom guessing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 69);
            label2.Name = "label2";
            label2.Size = new Size(407, 20);
            label2.TabIndex = 1;
            label2.Text = "Think of one of the six mushrooms and answer the questions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 151);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 2;
            label3.Text = "Questions";
            // 
            // lblGills
            // 
            lblGills.AutoSize = true;
            lblGills.Location = new Point(37, 192);
            lblGills.Name = "lblGills";
            lblGills.Size = new Size(239, 20);
            lblGills.TabIndex = 3;
            lblGills.Text = "1. Does your mushroom have gills?";
            lblGills.Click += lblGills_Click;
            // 
            // lblForest
            // 
            lblForest.AutoSize = true;
            lblForest.Location = new Point(37, 232);
            lblForest.Name = "lblForest";
            lblForest.Size = new Size(186, 20);
            lblForest.TabIndex = 4;
            lblForest.Text = "2. Does it grow in a forest?";
            // 
            // lblRing
            // 
            lblRing.AutoSize = true;
            lblRing.Location = new Point(37, 266);
            lblRing.Name = "lblRing";
            lblRing.Size = new Size(155, 20);
            lblRing.TabIndex = 5;
            lblRing.Text = "3. Does it have a ring?";
            // 
            // lblConvexCup
            // 
            lblConvexCup.AutoSize = true;
            lblConvexCup.Location = new Point(37, 301);
            lblConvexCup.Name = "lblConvexCup";
            lblConvexCup.Size = new Size(203, 20);
            lblConvexCup.TabIndex = 6;
            lblConvexCup.Text = "4. Does it have a convex cup?";
            lblConvexCup.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Pink;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(572, 166);
            label8.Name = "label8";
            label8.Size = new Size(163, 23);
            label8.TabIndex = 7;
            label8.Text = "The six mushrooms";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbGills
            // 
            cmbGills.FormattingEnabled = true;
            cmbGills.Items.AddRange(new object[] { "Yes", "No" });
            cmbGills.Location = new Point(282, 189);
            cmbGills.Name = "cmbGills";
            cmbGills.Size = new Size(68, 28);
            cmbGills.TabIndex = 8;
            // 
            // cmbForest
            // 
            cmbForest.FormattingEnabled = true;
            cmbForest.Items.AddRange(new object[] { "Yes", "No" });
            cmbForest.Location = new Point(282, 223);
            cmbForest.Name = "cmbForest";
            cmbForest.Size = new Size(68, 28);
            cmbForest.TabIndex = 10;
            cmbForest.SelectedIndexChanged += cmbForest_SelectedIndexChanged;
            // 
            // cmbRing
            // 
            cmbRing.FormattingEnabled = true;
            cmbRing.Items.AddRange(new object[] { "Yes", "No" });
            cmbRing.Location = new Point(282, 258);
            cmbRing.Name = "cmbRing";
            cmbRing.Size = new Size(68, 28);
            cmbRing.TabIndex = 12;
            cmbRing.SelectedIndexChanged += cmbRing_SelectedIndexChanged_1;
            // 
            // cmbConvexCup
            // 
            cmbConvexCup.FormattingEnabled = true;
            cmbConvexCup.Items.AddRange(new object[] { "Yes", "No" });
            cmbConvexCup.Location = new Point(282, 293);
            cmbConvexCup.Name = "cmbConvexCup";
            cmbConvexCup.Size = new Size(68, 28);
            cmbConvexCup.TabIndex = 14;
            cmbConvexCup.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // lstMushrooms
            // 
            lstMushrooms.BackColor = Color.MistyRose;
            lstMushrooms.FormattingEnabled = true;
            lstMushrooms.Items.AddRange(new object[] { "Agaric Jaunissant", "Amanite tue-mouche", "Cepe de Bordeaux", "Coprin chevelu", "Girolle", "Pied bleu" });
            lstMushrooms.Location = new Point(555, 192);
            lstMushrooms.Name = "lstMushrooms";
            lstMushrooms.Size = new Size(198, 124);
            lstMushrooms.TabIndex = 15;
            lstMushrooms.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnFindMushroom
            // 
            btnFindMushroom.BackColor = Color.Lime;
            btnFindMushroom.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFindMushroom.Location = new Point(374, 356);
            btnFindMushroom.Name = "btnFindMushroom";
            btnFindMushroom.Size = new Size(151, 43);
            btnFindMushroom.TabIndex = 16;
            btnFindMushroom.Text = "Find mushroom";
            btnFindMushroom.UseVisualStyleBackColor = false;
            btnFindMushroom.Click += btnFindMushroom_Click;
            // 
            // lblDisplayMushroom
            // 
            lblDisplayMushroom.AutoSize = true;
            lblDisplayMushroom.Location = new Point(400, 402);
            lblDisplayMushroom.Name = "lblDisplayMushroom";
            lblDisplayMushroom.Size = new Size(0, 20);
            lblDisplayMushroom.TabIndex = 17;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Lime;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(182, 448);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 40);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DeepPink;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(572, 448);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 40);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 522);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(lblDisplayMushroom);
            Controls.Add(btnFindMushroom);
            Controls.Add(lstMushrooms);
            Controls.Add(cmbConvexCup);
            Controls.Add(cmbRing);
            Controls.Add(cmbForest);
            Controls.Add(cmbGills);
            Controls.Add(label8);
            Controls.Add(lblConvexCup);
            Controls.Add(lblRing);
            Controls.Add(lblForest);
            Controls.Add(lblGills);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Mushroom guessing";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblGills;
        private Label lblForest;
        private Label lblRing;
        private Label lblConvexCup;
        private Label label8;
        private ComboBox cmbGills;
        private ComboBox cmbForest;
        private ComboBox cmbRing;
        private ComboBox cmbConvexCup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox lstMushrooms;
        private Button btnFindMushroom;
        private Label lblDisplayMushroom;
        private Button btnBack;
        private Button btnLogout;
    }
}