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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnrental_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);

            form3.Show();

            this.Hide();
        }

        private void btnmush_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);

            form4.Show();

            this.Hide();
        }
    }
}
