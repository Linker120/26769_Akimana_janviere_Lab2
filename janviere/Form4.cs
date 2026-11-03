using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace janviere
{
    public partial class Form4 : Form
    {
        private Form previousForm;

        public Form4(Form previous)
        {
            InitializeComponent();
            previousForm = previous;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblGills_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (var cmb in new[] { cmbGills, cmbForest, cmbRing, cmbConvexCup })
            {
                cmb.Items.Clear();
                cmb.Items.Add("Yes");
                cmb.Items.Add("No");
            }

            cmbGills.Enabled = true;        // new
            cmbForest.Enabled = true;       // new
            cmbConvexCup.Enabled = true;    // new
        }

        private void btnFindMushroom_Click(object sender, EventArgs e)
        {

            if (cmbRing.SelectedIndex < 0)
            {
                MessageBox.Show("Please answer the ring question.", "Mushroom guessing",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ring = cmbRing.SelectedItem.ToString() == "Yes";
            string result;

            if (ring)
            {
                if (cmbForest.SelectedIndex < 0)
                {
                    MessageBox.Show("Please answer the forest question.");
                    return;
                }

                if (cmbForest.SelectedItem.ToString() == "Yes")
                {
                    result = "Amanite tue-mouche";
                }
                else
                {
                    if (cmbConvexCup.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please answer the convex cup question.");
                        return;
                    }

                    result = cmbConvexCup.SelectedItem.ToString() == "Yes"
                        ? "Agaric Jaunissant"
                        : "Coprin chevelu";
                }
            }
            else
            {
                if (cmbGills.SelectedIndex < 0)
                {
                    MessageBox.Show("Please answer the gills question.");
                    return;
                }

                if (cmbGills.SelectedItem.ToString() == "No")
                {
                    result = "Cepe de Bordeaux";
                }
                else
                {
                    if (cmbConvexCup.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please answer the convex cup question.");
                        return;
                    }

                    result = cmbConvexCup.SelectedItem.ToString() == "Yes"
                        ? "Pied bleu"
                        : "Girolle";
                }
            }

            MessageBox.Show("Your mushroom is: " + result, "Result",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void cmbRing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRing_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbForest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
