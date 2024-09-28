using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Restaurant_management
{
    public partial class MenuList : Form
    {
        public MenuList()
        {
            InitializeComponent();
        }

        private void btnLunch_Click_1(object sender, EventArgs e)
        {
            LoadProductsByCategory("Lunch"); // Load lunch category products
        }

        private void btnDinner_Click_1(object sender, EventArgs e)
        {
            LoadProductsByCategory("Dinner"); // Load dinner category products
        }

        private void LoadProductsByCategory(string category)
        {
            // Clear existing products from the FlowLayoutPanel
            flowLayoutPanel.Controls.Clear();

            // Connection string to your database
            string connectionString = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // SQL query to fetch product data based on the selected category
                    string query = "SELECT ProductName, Price, Quantity, ProductImage FROM products WHERE Category = @Category";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Category", category);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Create a UI for each product fetched from the database
                        CreateProductItem(
                            reader["ProductName"].ToString(),
                            reader["Price"].ToString(),
                            reader["Quantity"].ToString(),
                            (byte[])reader["ProductImage"]
                        );
                    }
                }
                catch (Exception ex)
                {
                    // Display any errors encountered while fetching data
                    MessageBox.Show("Error fetching product data: " + ex.Message);
                }
            }
        }

        // Function to create and add a product item to the FlowLayoutPanel
        private void CreateProductItem(string productName, string price, string quantity, byte[] imageData)
        {
            // Create a new panel for each product
            Panel productPanel = new Panel();
            productPanel.Size = new Size(350, 150);
            productPanel.BorderStyle = BorderStyle.FixedSingle;

            // Product Image
            PictureBox productPictureBox = new PictureBox();
            productPictureBox.Location = new Point(10, 10);
            productPictureBox.Size = new Size(100, 100);
            productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                productPictureBox.Image = Image.FromStream(ms);
            }

            // Product Name Label
            Label productNameLabel = new Label();
            productNameLabel.Text = productName;
            productNameLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            productNameLabel.Location = new Point(120, 10);
            productNameLabel.Size = new Size(200, 30);

            // Price Label
            Label priceLabel = new Label();
            priceLabel.Text = "$" + price;
            priceLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            priceLabel.Location = new Point(120, 50);
            priceLabel.Size = new Size(80, 30);

            // Quantity Label
            Label quantityLabel = new Label();
            quantityLabel.Text = "Available: " + quantity;
            quantityLabel.Font = new Font("Arial", 10, FontStyle.Regular);
            quantityLabel.Location = new Point(120, 90);
            quantityLabel.Size = new Size(100, 30);

            // NumericUpDown to select quantity for cart
            NumericUpDown quantityNumericUpDown = new NumericUpDown();
            quantityNumericUpDown.Location = new Point(220, 50);
            quantityNumericUpDown.Minimum = 0;
            quantityNumericUpDown.Maximum = int.Parse(quantity); // Set the maximum quantity as the available stock

            // Add to Cart Button
            Button addToCartButton = new Button();
            addToCartButton.Text = "Add to Cart";
            addToCartButton.Location = new Point(220, 115);
            addToCartButton.Size = new Size(100, 30);
            addToCartButton.Click += (s, e) =>
            {
                int selectedQuantity = (int)quantityNumericUpDown.Value;
                if (selectedQuantity > 0)
                {
                    // Reduce quantity in the database and get new available quantity
                    int newQuantity = UpdateProductQuantity(productName, selectedQuantity);
                    if (newQuantity >= 0)
                    {
                        MessageBox.Show($"{selectedQuantity} of {productName} added to the cart.");
                        // Update the displayed available quantity
                        quantityLabel.Text = "Available: " + newQuantity;
                        quantityNumericUpDown.Maximum = newQuantity; // Update max quantity in NumericUpDown
                    }
                    else
                    {
                        MessageBox.Show("Not enough stock available.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a quantity greater than zero.");
                }
            };

            // Add controls to the product panel
            productPanel.Controls.Add(productPictureBox);
            productPanel.Controls.Add(productNameLabel);
            productPanel.Controls.Add(priceLabel);
            productPanel.Controls.Add(quantityLabel);
            productPanel.Controls.Add(quantityNumericUpDown);
            productPanel.Controls.Add(addToCartButton);

            // Add product panel to the FlowLayoutPanel
            flowLayoutPanel.Controls.Add(productPanel);
        }

        private int UpdateProductQuantity(string productName, int quantity)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                    connection.Open();
                    string query = "UPDATE products SET Quantity = Quantity - @Quantity WHERE ProductName = @ProductName AND Quantity >= @Quantity";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        int rowsAffected = command.ExecuteNonQuery();

                        return 0; // Return true if the quantity was successfully updated
                    }
                
               
            }
        }



    }
}
