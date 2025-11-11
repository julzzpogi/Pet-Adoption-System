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
using Microsoft.IdentityModel.Tokens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pet__Adoption_System
{
    public partial class Form4 : Form
    {
        string haha = @"Data Source=DESKTOP-RPJP9D9\SQLEXPRESS;Initial Catalog=julzz;Integrated Security=True;Trust Server Certificate=True";
        public Form4()
        {
            InitializeComponent();
            StyleProductGrid();
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


            dataGridView1.Location = new Point(9, 73);
            dataGridView1.Size = new Size(919, 340);
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

        }
        public void DeleteProduct(int ID)
        {
            using (SqlConnection con = new SqlConnection(haha))
            {
                // Use UPDATE instead of DELETE to soft delete
                using (SqlCommand cmd = new SqlCommand("dELETE Pettable WHERE Pet_ID = @ID", con))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void search()
        {
            //SqlConnection con = new SqlConnection(haha);
            //con.Open();

            //SqlCommand cmd = new SqlCommand("SELECT  * FROM Pettable where Pet_Name = @category", con);
            //string selectedCategory = comboBox1.SelectedItem?.ToString();
            //cmd.Parameters.AddWithValue("@category", selectedCategory);

            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    comboBox1.Items.Add(reader["Pet_Breed"].ToString());
            //}
            //con.Close();
            //DataTable dt = new DataTable();
            //dt.Load(reader);
            //dataGridView1.DataSource = dt;
            //con.Close();
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

        private void Form4_Load(object sender, EventArgs e)
        {
            DisplayProduct();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //SqlConnection conn = new SqlConnection(haha);
            //conn.Open();
            //SqlCommand sqlCommand = new SqlCommand("Insert into product_table (productName, productCategory, productQuantity,  productPrice) VALUES(@name, @category, @quantity, @price)", conn);
            //sqlCommand.Parameters.AddWithValue("@name", textBox1.Text);
            //sqlCommand.Parameters.AddWithValue("@category", comboBox1.Text);
            //sqlCommand.Parameters.AddWithValue("@quantity", textBox2.Text);
            //sqlCommand.Parameters.AddWithValue("@price", textBox3.Text);

            //sqlCommand.ExecuteNonQuery();
            //conn.Close();

            //DisplayProduct();
            //MessageBoxIcon ikun = MessageBoxIcon.Information;
            //MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, ikun);
        }



        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void TextBox1_SearchTextChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Billings bill = new Billings();
            bill.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayCategoryData();
            DisplayBreeddog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            add_products ap = new add_products();
            ap.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(haha);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete from Pettable where Pet_ID=@id");
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int selectedProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Pet_ID"].Value);

                if (MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DeleteProduct(selectedProductId);
                        DisplayProduct();
                        MessageBox.Show("Product deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting product: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}

