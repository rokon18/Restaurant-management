using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Restaurant_management
{
    public partial class MenuList : Form
    {
        private CartPage cartPage;
       

       

        public MenuList()
        {
            InitializeComponent();

            cartPage = new CartPage();
            cartPage.Tag = this; 
              LoadProductsByCategory("Lunch");
            
           
             LoadProductsByCategory("Dinner");


        }

        private void btnLunch_Click_1(object sender, EventArgs e)
        {
            LoadProductsByCategory("Lunch"); 
        }

        private void btnDinner_Click_1(object sender, EventArgs e)
        {
            LoadProductsByCategory("Dinner"); 
        }

        private void LoadProductsByCategory(string category)
        {
           
            flowLayoutPanel.Controls.Clear();

            
            string connectionString = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                 
                    string query = " SELECT ProductName, Price, Quantity, ProductImage FROM products WHERE Category = @Category";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Category", category);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        
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
                   
                    MessageBox.Show("Error fetching product data: " + ex.Message);
                }
            }
        }

     
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
                    
                    int newQuantity = UpdateProductQuantity(productName, selectedQuantity);
                 
                    if (newQuantity >= 0)
                    {
                        
                        decimal priceValue = decimal.Parse(priceLabel.Text.Substring(1)); 
                      
                        cartPage.AddProductToCart(productName, priceValue, selectedQuantity);

                        MessageBox.Show($"{selectedQuantity} of {productName} added to the cart.");

                        quantityLabel.Text = "Available: " + newQuantity;
                    }
                    else
                    {
                        MessageBox.Show("Not enough stock available.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a quantity greater than zero or Not enough stock available");
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
                    string query = " UPDATE products SET Quantity = Quantity - @Quantity WHERE ProductName = @ProductName AND Quantity >= @Quantity";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        int rowsAffected = command.ExecuteNonQuery();

                    return 0; 
                    }
                
               
            }
        }

        private void GoCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            cartPage.Show();
        }

        private void GoProfile_Click(object sender, EventArgs e)
        {
            Form previousForm = Session.LastForm; 

            if (previousForm != null)
            {
                this.Hide();
                previousForm.Show();
            }

        }
    }
}
