using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace janviere
{
    public partial class Form3 : Form
    {
        private Form previousForm;

        public Form3(Form previous)
        {
            InitializeComponent();
            previousForm = previous;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntotal_Click(object sender, EventArgs e)
        {

            int start;
            int end;

            // Validate starting time
            if (!int.TryParse(txtStart.Text, out start))
            {
                MessageBox.Show("Please enter a valid whole number for starting time.");
                txtStart.Focus();
                return;
            }

            // Validate ending time
            if (!int.TryParse(txtEnd.Text, out end))
            {
                MessageBox.Show("Please enter a valid whole number for ending time.");
                txtEnd.Focus();
                return;
            }

            // Check starting time range
            if (start < 0 || start > 23)
            {
                MessageBox.Show("Starting time must be between 0 and 23.");
                txtStart.Focus();
                return;
            }

            // Check ending time range
            if (end < 1 || end > 24)
            {
                MessageBox.Show("Ending time must be between 1 and 24.");
                txtEnd.Focus();
                return;
            }

            // Check rental period
            if (start >= end)
            {
                MessageBox.Show("Starting time must be less than ending time.");
                txtStart.Focus();
                return;
            }

            int totalCost = 0;

            // Calculate rental cost
            for (int hour = start; hour < end; hour++)
            {
                int rate;

                if ((hour >= 0 && hour < 7) || (hour >= 21 && hour < 24))
                {
                    rate = 500;
                }
                else if ((hour >= 7 && hour < 14) || (hour >= 19 && hour < 21))
                {
                    rate = 1000;
                }
                else
                {
                    rate = 1500;
                }

                totalCost = totalCost + rate;
            }

            // Display rental cost
            lblPrice.Text = totalCost + " RWF";
            MessageBox.Show("Label text is: " + lblPrice.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Logout",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            // Reuse the login form if it is only hidden, otherwise create a new one
            Form login = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (login == null)
                login = new Form1();

            login.Show();

            // Close every other form (Form4, menu, etc.)
            foreach (Form f in Application.OpenForms.Cast<Form>().Where(x => x != login).ToList())
            {
                f.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

