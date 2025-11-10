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

namespace Pet__Adoption_System
{
    public partial class Form4 : Form
    {
        string haha = @"Data Source=DESKTOP-RPJP9D9\SQLEXPRESS;Initial Catalog=julzz;Integrated Security=True;Trust Server Certificate=True";
        public Form4()
        {
            InitializeComponent();
            StyleProductGrid();
            comboBox1.Items.Add("Dog");
            comboBox1.Items.Add("Cat");
            comboBox1.Items.Add("Bird");
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


            dataGridView1.Location = new Point(32, 234);
            dataGridView1.Size = new Size(850, 178);
        }
        private void DisplayProduct()
        {

            SqlConnection con = new SqlConnection(haha);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM product_table", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.Columns["productID"].Visible = false;
        }
        public void DeleteProduct(int ID)
        {
            using (SqlConnection con = new SqlConnection(haha))
            {
                // Use UPDATE instead of DELETE to soft delete
                using (SqlCommand cmd = new SqlCommand("dELETE product_table WHERE productID = @ID", con))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
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

            SqlConnection conn = new SqlConnection(haha);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into product_table (productName, productCategory, productQuantity,  productPrice) VALUES(@name, @category, @quantity, @price)", conn);
            sqlCommand.Parameters.AddWithValue("@name", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@category", comboBox1.Text);
            sqlCommand.Parameters.AddWithValue("@quantity", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@price", textBox3.Text);

            sqlCommand.ExecuteNonQuery();
            conn.Close();

            DisplayProduct();
            MessageBoxIcon ikun = MessageBoxIcon.Information;
            MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, ikun);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(haha);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete from product_table where productID=@id");
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int selectedProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["productID"].Value);

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

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
