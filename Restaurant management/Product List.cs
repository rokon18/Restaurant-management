using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Restaurant_management
{
    public partial class Product_List : Form
    {
        public Product_List()
        {
            InitializeComponent();
            LoadProductData(); // Load product data into DataGridView when the form loads

        }

        // Method to load data from Products table into the DataGridView
        private void LoadProductData(string query = null, string searchTerm = null)
        {
            try
            {
                // Connection string (replace with your actual database connection string)
                string connectionString = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Default query to fetch all products if no query is specified
                    if (string.IsNullOrEmpty(query))
                    {
                        query = "SELECT ProductID, ProductName, Category, Quantity,Price,ProductImage FROM Products";
                    }
                    else if (!string.IsNullOrEmpty(searchTerm))
                    {
                        // Modify the query to include the search term for filtering
                        query = "SELECT * FROM Products WHERE ProductName LIKE @ProductName";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add the parameter for the search term if applicable
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@ProductName", "%" + searchTerm + "%");
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable productsTable = new DataTable();
                            adapter.Fill(productsTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = productsTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading product data: " + ex.Message);
            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            // Check if any fields are empty
            if (string.IsNullOrWhiteSpace(textBoxpname.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                !float.TryParse(textBoxPRICE.Text, out float Price) ||
                !int.TryParse(textBox1.Text, out int quantity) ||
                quantity <= 0 ||
                pictureBox1.Image == null)
            {
                MessageBox.Show("Please fill all the fields and select an image.");
                return;
            }

            try
            {
                // Convert the image to a byte array
                byte[] imageBytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }

                // SQL query for inserting data (without ProductID)
                string query = "INSERT INTO Products (ProductName, Category, Quantity,Price, ProductImage) " +
                               "VALUES (@ProductName, @Category, @Quantity,@price, @ProductImage)";

                // Connection string (replace with your actual database connection string)
                string connectionString = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to SQL command
                        cmd.Parameters.AddWithValue("@ProductName", textBoxpname.Text);
                        cmd.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", Price);
                        cmd.Parameters.AddWithValue("@ProductImage", imageBytes);

                        // Open connection
                        conn.Open();

                        // Execute the query
                        int result = cmd.ExecuteNonQuery();

                        // Check if the data was inserted successfully
                        if (result > 0)
                        {
                            MessageBox.Show("Product added successfully with image!");
                            // Clear the form fields after adding the product
                            textBoxpname.Clear();
                            textBoxPRICE.Clear();
                            comboBox1.SelectedIndex = -1;
                            textBox1.Text = "1"; // Reset the quantity TextBox
                            pictureBox1.Image = null;  // Clear the picture box

                            // Reload the product data into DataGridView after adding a new product
                            LoadProductData();
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while adding the product.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Catch and display the actual exception for debugging
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(selectedFilePath); // Load the image
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            string query;

            if (textBoxsearch.Text.Length > 0)
            {
                // Use parameterized query to prevent SQL injection
                query = "SELECT * FROM Products WHERE ProductName LIKE @ProductName";
                LoadProductData(query, textBoxsearch.Text); // Pass the query and search text to your method
            }
            else
            {
                // Load all data when the search box is empty
                LoadProductData(); // This should load all products
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a valid data cell
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Fill the text boxes with the selected data
                textBoxpname.Text = selectedRow.Cells["ProductName"].Value.ToString();
                comboBox1.SelectedItem = selectedRow.Cells["Category"].Value.ToString();
                textBox1.Text = selectedRow.Cells["Quantity"].Value.ToString();
                textBoxPRICE.Text = selectedRow.Cells["Price"].Value.ToString();

                // Load the image if it exists
                byte[] imageBytes = (byte[])selectedRow.Cells["ProductImage"].Value;
                if (imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    pictureBox1.Image = null; // Clear the picture box if no image is found
                }
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            // Check if any fields are empty or invalid
            if (string.IsNullOrWhiteSpace(textBoxpname.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBoxPRICE.Text) ||
               !float.TryParse(textBoxPRICE.Text, out float price) ||
                !int.TryParse(textBox1.Text, out int quantity) ||
                quantity <= 0 ||
                pictureBox1.Image == null)
            {
                MessageBox.Show("Please fill all the fields correctly and select an image.");
                return;
            }

            try
            {
           
            // Convert the image to a byte array
            byte[] imageBytes = null;
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                imageBytes = ms.ToArray();
            }

            // SQL query for updating the product
            string query = "UPDATE Products SET ProductName = @ProductName, Category = @Category, Quantity = @Quantity, Price = @Price, ProductImage = @ProductImage WHERE ProductID = @ProductID";

                // Connection string (replace with your actual database connection string)
                string connectionString = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Get the ProductID from the selected row
                        if (dataGridView1.CurrentRow != null)
                        {
                            int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

                            // Add parameters to SQL command
                            cmd.Parameters.AddWithValue("@ProductName", textBoxpname.Text);
                            cmd.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@Price", price);
                            cmd.Parameters.AddWithValue("@ProductImage", imageBytes);
                            cmd.Parameters.AddWithValue("@ProductID", productId); // Ensure to include the ProductID in the update command
                            conn.Open();
                            // Execute the query
                            int result = cmd.ExecuteNonQuery();

                            // Check if the data was updated successfully
                            if (result > 0)
                            {
                                MessageBox.Show("Product updated successfully!");
                                // Clear the form fields after updating the product
                                textBoxpname.Clear();
                                comboBox1.SelectedIndex = -1;
                                textBox1.Text = "1"; // Reset the quantity TextBox
                                pictureBox1.Image = null;  // Clear the picture box
                                textBoxPRICE.Clear();
                                // Reload the product data into DataGridView after updating the product
                                LoadProductData();
                            }
                            else
                            {
                                MessageBox.Show("An error occurred while updating the product.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No product selected to update.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Catch and display the actual exception for debugging
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void buttondel_Click(object sender, EventArgs e)
        {
            {
                // Ensure that a product is selected
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a product to delete.");
                    return;
                }

                // Confirm the deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult != DialogResult.Yes)
                {
                    return; // Exit if the user does not confirm
                }

                
                    // Get the ProductID from the selected row
                    int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

                    // SQL query for deleting the product
                    string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                    // Connection string (replace with your actual database connection string)
                    string connectionString = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True;";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Add the ProductID parameter
                            cmd.Parameters.AddWithValue("@ProductID", productId);

                            // Open connection
                            conn.Open();

                            // Execute the query
                            int result = cmd.ExecuteNonQuery();

                            // Check if the data was deleted successfully
                            if (result > 0)
                            {
                                MessageBox.Show("Product deleted successfully!");
                                // Reload the product data into DataGridView after deleting the product
                                LoadProductData();
                            }
                            else
                            {
                                MessageBox.Show("An error occurred while deleting the product.");
                            }
                        }
                    }
                
              
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Login.stack.Count > 0)
            {
                Form previousForm = Login.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }
    }
}
