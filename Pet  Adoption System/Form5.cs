using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet__Adoption_System
{
    public partial class Form5 : Form
    {
        string haha = @"Data Source=DESKTOP-RPJP9D9\SQLEXPRESS;Initial Catalog=julzz;Integrated Security=True;Trust Server Certificate=True";
        public Form5()
        {
            InitializeComponent();
            StyleProductGrid();
            DisplayProduct();
            DisplayBreeddog();
        }
        private void StyleProductGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.LightGray;


            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219); // Blue header
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // Light blue
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Padding = new Padding(5, 3, 5, 3);
            dataGridView1.RowTemplate.Height = 35;


            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);


            dataGridView1.Location = new Point(20, 90);
            dataGridView1.Size = new Size(1158, 385);


        }
        public void DisplayBreeddog()
        {
            SqlConnection con = new SqlConnection(haha);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Distinct Pet_Category FROM Pettable", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Pet_Category"].ToString());
            }

            con.Close();


        }
        private void DisplayProduct()
        {

            SqlConnection con = new SqlConnection(haha);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pettable", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.Columns["Pet_ID"].Visible = false;
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_products ap = new add_products();
            ap.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }
        public void DisplayCategoryData()
        {
            SqlConnection con = new SqlConnection(haha);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pettable where Pet_Category = @category", con);
            string tite = comboBox1.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@category", tite);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            comboBox1.Items.Clear();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void display()
        {
            SqlConnection con = new SqlConnection(haha);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pettable  WHERE  Pet_Name like @name + '%' or Pet_Breed  like @name + '%'", con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayCategoryData();
            DisplayBreeddog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")
                {
                    DisplayProduct();
                }
                else
                {
                    display();
                }
            }
        }
    }
}
