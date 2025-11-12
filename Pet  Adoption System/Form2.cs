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
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Pet__Adoption_System
   
{
    public partial class Form2 : Form
    {
       string connectionString = @"Data Source=DESKTOP-RPJP9D9\SQLEXPRESS;Initial Catalog=julzz;Integrated Security=True;Trust Server Certificate=True"; 

        public Form2()
        {
            InitializeComponent();
            DisplayEmployee();
            LoadTotalSales();
            
        }
        private void LoadTotalSales()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(Order_Total) FROM Ordertbl";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                decimal totalSales = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                label13.Text = $"TOTAL SALES:\n ₱{totalSales:N2}";
            }
        }
        //private void LoadBestSellers()
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        // 🐾 BEST PET NAME
        //        string bestPetQuery = @"
        //    SELECT TOP 1 P.PetName, SUM(O.Quantity) AS TotalSold
        //    FROM Ordertbl O
        //    INNER JOIN Pettable P ON O.PetID = P.PetID
        //    GROUP BY P.PetName
        //    ORDER BY TotalSold DESC;";

        //        using (SqlCommand cmd = new SqlCommand(bestPetQuery, conn))
        //        {
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            if (reader.Read())
        //            {
        //                label12.Text = $"BEST PET: {reader["Pet_Name"]}";
        //            }
        //            else
        //            {
        //                label12.Text = "BEST PET: None yet";
        //            }
        //            reader.Close();
        //        }

        //        // 🐶 BEST CATEGORY
        //        string bestCategoryQuery = @"
        //    SELECT TOP 1 P.Category, SUM(O.Quantity) AS TotalSold
        //    FROM Ordertbl O
        //    INNER JOIN Pettable P ON O.PetID = P.PetID
        //    GROUP BY P.Category
        //    ORDER BY TotalSold DESC;";

        //        using (SqlCommand cmd2 = new SqlCommand(bestCategoryQuery, conn))
        //        {
        //            SqlDataReader reader2 = cmd2.ExecuteReader();
        //            if (reader2.Read())
        //            {
        //                label10.Text = $"BEST CATEGORY: {reader2["Category"]}";
        //            }
        //            else
        //            {
        //                label10.Text = "BEST CATEGORY: None yet";
        //            }
        //            reader2.Close();
        //        }

        //        conn.Close();
        //    }
        //}

        private void DisplayEmployee()
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ordertbl", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
           
            con.Close();

        }
        private void Form2_Load(object sender, EventArgs e)
        {





        }
    

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
//string connectionString = @"Data Source=DESKTOP-RPJP9D9\SQLEXPRESS;Initial Catalog=julzz;Integrated Security=True;Trust Server Certificate=True";
