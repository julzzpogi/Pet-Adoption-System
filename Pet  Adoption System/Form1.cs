using System;
using System.Drawing;

namespace Pet__Adoption_System
  
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show("Please enter both username and password", "Error", MessageBoxButtons.OK, icon);
            }

            else if (textBox1.Text.Equals("admin", StringComparison.OrdinalIgnoreCase) && textBox2.Text.Equals("password", StringComparison.OrdinalIgnoreCase))
            {
                MessageBoxIcon ikun = MessageBoxIcon.Information;
                MessageBox.Show("Welcome to Furry and Friends!!", "Information", MessageBoxButtons.OK, ikun);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();

            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show("Incorrect username/password pls try again!", "Error", MessageBoxButtons.OK, icon);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
