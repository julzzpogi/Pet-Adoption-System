using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet__Adoption_System
{
    public partial class Form3 : Form
    {
        string haha = @"Data Source=DESKTOP-RPJP9D9\SQLEXPRESS;Initial Catalog=julzz;Integrated Security=True;Trust Server Certificate=True";
        public Form3()
        {
            InitializeComponent();

            StyleProductGrid();
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


            dataGridView1.Location = new Point(13, 39);
            dataGridView1.Size = new Size(889, 350);
        }
        private void DisplayEmployee()
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
        public void DeleteProduct(int ID)
        {
            using (SqlConnection con = new SqlConnection(haha))
            {
                // Use UPDATE instead of DELETE to soft delete
                using (SqlCommand cmd = new SqlCommand("dELETE Table_1 WHERE employeeid = @ID", con))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            DisplayEmployee();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* SqlConnection conn = new SqlConnection(haha);
             conn.Open();
             SqlCommand sqlCommand = new SqlCommand("Insert into Table_1 (employeename, employeeaddress, employeephonenumber,  employeeemail,employeepass) VALUES(@name, @address, @phonenumber, @email, @pass)", conn);
             sqlCommand.Parameters.AddWithValue("@name", textBox1.Text);
             sqlCommand.Parameters.AddWithValue("@address", richTextBox1.Text);
             sqlCommand.Parameters.AddWithValue("@phonenumber", textBox2.Text);
             sqlCommand.Parameters.AddWithValue("@email", richTextBox2.Text);
             sqlCommand.Parameters.AddWithValue("@pass", textBox3.Text);

             sqlCommand.ExecuteNonQuery();
             conn.Close();

             DisplayEmployee();
             MessageBoxIcon ikun = MessageBoxIcon.Information;
             MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, ikun);*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(haha);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete from Table_1 where employeeid=@id");
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int selectedProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["employeeid"].Value);

                if (MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DeleteProduct(selectedProductId);
                        DisplayEmployee();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
            //gawen mo dito ung inventory
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
