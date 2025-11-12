using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Pet__Adoption_System
{
    public partial class Form5 : Form
    {
        string connectionString = @"Data Source=DESKTOP-RPJP9D9\SQLEXPRESS;Initial Catalog=julzz;Integrated Security=True;Trust Server Certificate=True";

        // Global variables
        private DataTable orderItemsTable;
        private decimal totalAmount = 0;

        public Form5()
        {
            InitializeComponent();
            InitializeOrderTable();
            SetupDataGrids();
            DisplayProduct();
            DisplayBreeddog();

            // Set data source for dataGridView2
            dataGridView2.DataSource = orderItemsTable;

            // Add event handlers for buttons
            button2.Click += BtnAddToCart_Click;
            button3.Click += BtnRemoveItem_Click;
            button4.Click += BtnPay_Click;
        }

        private void InitializeOrderTable()
        {
            orderItemsTable = new DataTable();
            orderItemsTable.Columns.Add("Pet_ID", typeof(int));
            orderItemsTable.Columns.Add("Pet_Name", typeof(string));
            orderItemsTable.Columns.Add("Pet_Category", typeof(string));
            orderItemsTable.Columns.Add("Pet_Breed", typeof(string));
            orderItemsTable.Columns.Add("Order_Quantity", typeof(int));
            orderItemsTable.Columns.Add("Order_Price", typeof(decimal));
            orderItemsTable.Columns.Add("Order_Total", typeof(decimal));
        }

        private void SetupDataGrids()
        {
            // Style dataGridView1
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

            // Style dataGridView2
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.RowHeadersVisible = false;
        }

        // DISPLAY PRODUCTS FROM Pettable IN dataGridView1
        private void DisplayProduct()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Pettable WHERE Pet_Quantity > 0";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Hide Pet_ID column if you don't want to show it
                    if (dataGridView1.Columns.Contains("Pet_ID"))
                        dataGridView1.Columns["Pet_ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayBreeddog()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT DISTINCT Pet_Category FROM Pettable";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboBox1.Items.Clear();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Pet_Category"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ADD TO CART BUTTON
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a pet from the list first!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Get quantity from numericUpDown1
            int quantity = (int)numericUpDown1.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get pet details from dataGridView1
            int petId = Convert.ToInt32(selectedRow.Cells["Pet_ID"].Value);
            string petName = selectedRow.Cells["Pet_Name"].Value.ToString();
            string petCategory = selectedRow.Cells["Pet_Category"].Value.ToString();
            string petBreed = selectedRow.Cells["Pet_Breed"].Value.ToString();
            decimal price = Convert.ToDecimal(selectedRow.Cells["Pet_Price"].Value);
            int availableStock = Convert.ToInt32(selectedRow.Cells["Pet_Quantity"].Value);

            // Check stock availability
            if (quantity > availableStock)
            {
                MessageBox.Show($"Not enough stock available!\nOnly {availableStock} {petName} in stock.",
                    "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if pet already exists in cart
            bool petExists = false;
            foreach (DataRow row in orderItemsTable.Rows)
            {
                if (Convert.ToInt32(row["Pet_ID"]) == petId)
                {
                    petExists = true;
                    break;
                }
            }

            if (petExists)
            {
                MessageBox.Show("This pet is already in your cart!\nPlease remove it first to change quantity.",
                    "Already in Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Add to order table
            decimal totalPrice = price * quantity;
            DataRow newRow = orderItemsTable.NewRow();
            newRow["Pet_ID"] = petId;
            newRow["Pet_Name"] = petName;
            newRow["Pet_Category"] = petCategory;
            newRow["Pet_Breed"] = petBreed;
            newRow["Order_Quantity"] = quantity;
            newRow["Order_Price"] = price;
            newRow["Order_Total"] = totalPrice;

            orderItemsTable.Rows.Add(newRow);

            // Refresh dataGridView2
            RefreshDataGrid2();

            // Update total amount
            UpdateTotalAmount();

            MessageBox.Show($"Successfully added {petName} to cart!\nQuantity: {quantity}\nPrice: ${price:F2}",
                "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset quantity to 1
            numericUpDown1.Value = 1;
        }

        // REMOVE ITEM BUTTON
        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove from cart!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
            string petName = selectedRow.Cells["Pet_Name"].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to remove {petName} from your cart?",
                "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                orderItemsTable.Rows.RemoveAt(selectedRow.Index);
                RefreshDataGrid2();
                UpdateTotalAmount();

                MessageBox.Show($"{petName} has been removed from your cart.",
                    "Item Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // PAY BUTTON
        private void BtnPay_Click(object sender, EventArgs e)
        {
            string customerName = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter customer name!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (orderItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty! Please add items to cart first.", "Empty Cart",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // Insert into Ordertbl
                            string orderQuery = @"INSERT INTO Ordertbl (Customer_Name, Order_Date, Order_Total) 
                                         OUTPUT INSERTED.Order_ID 
                                         VALUES (@CustomerName, @OrderDate, @OrderTotal)";

                            int orderId;
                            using (SqlCommand cmd = new SqlCommand(orderQuery, con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                                cmd.Parameters.AddWithValue("@OrderTotal", totalAmount);
                                orderId = (int)cmd.ExecuteScalar();
                            }

                            // Insert into Orderd table (order details)
                            string detailQuery = @"INSERT INTO Orderd 
                                          (Order_ID, Pet_ID, Order_Quantity, Order_Price, Order_Total) 
                                          VALUES (@OrderID, @PetID, @Quantity, @Price, @Total)";

                            foreach (DataRow row in orderItemsTable.Rows)
                            {
                                using (SqlCommand cmd = new SqlCommand(detailQuery, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                                    cmd.Parameters.AddWithValue("@PetID", row["Pet_ID"]);
                                    cmd.Parameters.AddWithValue("@Quantity", row["Order_Quantity"]);
                                    cmd.Parameters.AddWithValue("@Price", row["Order_Price"]);
                                    cmd.Parameters.AddWithValue("@Total", row["Order_Total"]);
                                    cmd.ExecuteNonQuery();
                                }

                                // Update stock in Pettable
                                string updateStockQuery = @"UPDATE Pettable 
                                                   SET Pet_Quantity = Pet_Quantity - @Quantity 
                                                   WHERE Pet_ID = @PetID";
                                using (SqlCommand updateCmd = new SqlCommand(updateStockQuery, con, transaction))
                                {
                                    updateCmd.Parameters.AddWithValue("@Quantity", row["Order_Quantity"]);
                                    updateCmd.Parameters.AddWithValue("@PetID", row["Pet_ID"]);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();

                            // Show success message
                            MessageBox.Show($"Order created successfully!\n\nOrder ID: {orderId}\nCustomer: {customerName}\nTotal Amount: ${totalAmount:F2}",
                                "Order Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Show receipt
                            

                            // Reset form
                            ResetOrderForm();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error creating order: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGrid2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = orderItemsTable;
        }

        private void UpdateTotalAmount()
        {
            totalAmount = 0;
            foreach (DataRow row in orderItemsTable.Rows)
            {
                totalAmount += Convert.ToDecimal(row["Order_Total"]);
            }

            // Update label4 with total amount
            label4.Text = $"Total Amount: ${totalAmount:F2}";
        }

      ////  private void ShowReceipt(int orderId, string customerName)
      //  {
      //      // Create receipt form with order details
      //       Receipt receiptForm = new Receipt(orderId, customerName, totalAmount, orderItemsTable.Copy());
      //  receiptForm.Show();
      //  }

        private void ResetOrderForm()
        {
            // Clear order items
            orderItemsTable.Clear();
            RefreshDataGrid2();

            // Reset form controls
            textBox2.Clear();
            numericUpDown1.Value = 1;
            UpdateTotalAmount();

            // Refresh available pets
            DisplayProduct();
        }

        // EXISTING METHODS FROM YOUR CODE
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                DisplayProduct();
            }
            else
            {
                SearchProducts();
            }
        }

        private void SearchProducts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT * FROM Pettable 
                            WHERE Pet_Name LIKE @search + '%' 
                               OR Pet_Breed LIKE @search + '%' 
                               OR Pet_Category LIKE @search + '%'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@search", textBox1.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void FilterByCategory()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Pettable WHERE Pet_Category = @category";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@category", comboBox1.SelectedItem.ToString());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering products: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}