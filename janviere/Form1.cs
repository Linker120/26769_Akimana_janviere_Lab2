namespace janviere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {


            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" && password == "")
            {
                MessageBox.Show("Please enter your username and password.",
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (username == "")
            {
                MessageBox.Show("Please enter your username.",
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (password == "")
            {
                MessageBox.Show("Please enter your password.",
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Login successful!",
                    "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 form2 = new Form2();
                form2.Show();

                this.Hide();

                form2.FormClosed += (s, args) => this.Show();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                   "Are you sure you want to exit the application?",
                   "Confirm Exit",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
