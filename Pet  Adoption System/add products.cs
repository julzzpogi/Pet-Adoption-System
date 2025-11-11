using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pet__Adoption_System
{
    public partial class add_products : Form
    {
        string haha = @"Data Source=DESKTOP-RPJP9D9\SQLEXPRESS;Initial Catalog=julzz;Integrated Security=True;Trust Server Certificate=True";
        public add_products()
        {
            InitializeComponent();
            DisplayCategory();
            DisplaySex();
            

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_products_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(haha);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Pettable (Pet_Name, Pet_Category, Pet_Breed,  Pet_Sex, Pet_Age, Pet_Price, Pet_Quantity) VALUES(@name, @category, @breed, @sex, @age, @price, @quantity)", conn);
            sqlCommand.Parameters.AddWithValue("@name", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@category", comboBox1.SelectedItem);
            sqlCommand.Parameters.AddWithValue("@breed", comboBox4.SelectedItem);
            sqlCommand.Parameters.AddWithValue("@sex", comboBox2.SelectedItem);
            sqlCommand.Parameters.AddWithValue("@age", numericUpDown1.Text);
            sqlCommand.Parameters.AddWithValue("@price", numericUpDown3.Text);
            sqlCommand.Parameters.AddWithValue("@quantity", numericUpDown2.Text);

            sqlCommand.ExecuteNonQuery();
            conn.Close();


            MessageBoxIcon ikun = MessageBoxIcon.Information;
            MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, ikun);
        }
        public void DisplayCategory() {
            SqlConnection con = new SqlConnection(haha);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Pet_Category FROM Pettable", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Pet_Category"].ToString());
            }
            con.Close();
            
        }
        public void DisplaySex()
        {
            SqlConnection con = new SqlConnection(haha);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Pet_Sex FROM Pettable", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["Pet_Sex"].ToString());
            }
            con.Close();
        }
        public void DisplayBreeddog()
        {
            SqlConnection con = new SqlConnection(haha);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT  Pet_Breed FROM Pettable where Pet_Category = @category", con);
            string selectedCategory = comboBox1.SelectedItem?.ToString();
            cmd.Parameters.AddWithValue("@category", selectedCategory);
            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox4.Items.Add(reader["Pet_Breed"].ToString());
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            DisplayBreeddog();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
