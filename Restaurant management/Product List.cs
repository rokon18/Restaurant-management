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
            LoadProductData(); 

        }

        
        private void LoadProductData(string query = null, string searchTerm = null)
        {
            try
            {
                
                string connectionString = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                   
                    if (string.IsNullOrEmpty(query))
                    {
                        query = "SELECT ProductID, ProductName, Category, Quantity,Price,ProductImage FROM Products";
                    }
                    else if (!string.IsNullOrEmpty(searchTerm))
                    {
                       
                        query = "SELECT * FROM Products WHERE ProductName LIKE @ProductName";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@ProductName", "%" + searchTerm + "%");
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable Products= new DataTable();
                            adapter.Fill(Products);

                           
                            dataGridView1.DataSource = Products;
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
        
            if (string.IsNullOrWhiteSpace(textBoxpname.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                !float.TryParse(textBoxPRICE.Text, out float Price) ||
                !int.TryParse(textBox1.Text, out int quantity) ||
                quantity <= 0 ||
                pictureBox1.Image == null)
            {
                MessageBox.Show("Please fill all the fields and select an image.");
                return ;
            }

            try
            {
            
                byte[] imageBytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }

               
                string query = "INSERT INTO Products (ProductName, Category, Quantity,Price, ProductImage) " +
                               "VALUES (@ProductName, @Category, @Quantity,@price, @ProductImage)";

          
                string connectionString = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                   
                        cmd.Parameters.AddWithValue("@ProductName", textBoxpname.Text);
                        cmd.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", Price);
                        cmd.Parameters.AddWithValue("@ProductImage", imageBytes);

                        
                     

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Product added successfully with image!");
                          
                            textBoxpname.Clear();
                            textBoxPRICE.Clear();
                            comboBox1.SelectedIndex = -1;
                            textBox1.Text = "0";
                            pictureBox1.Image = null; 

                           
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
                pictureBox1.Image = Image.FromFile(selectedFilePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            string query;

            if (textBoxsearch.Text.Length > 0)
            {
               
                query = "SELECT * FROM Products WHERE ProductName LIKE @ProductName";
                LoadProductData(query, textBoxsearch.Text); 
            }
            else
            {
               
                LoadProductData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
   
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                
                textBoxpname.Text = selectedRow.Cells["ProductName"].Value.ToString();
                comboBox1.SelectedItem = selectedRow.Cells["Category"].Value.ToString();
                textBox1.Text = selectedRow.Cells["Quantity"].Value.ToString();
                textBoxPRICE.Text = selectedRow.Cells["Price"].Value.ToString();

                
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
                    pictureBox1.Image = null; 
                }
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
           
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

               
                string query = "UPDATE Products SET ProductName = @ProductName, Category = @Category, Quantity = @Quantity, Price = @Price WHERE ProductID = @ProductID";

                
                string connectionString = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        if (dataGridView1.CurrentRow != null)
                        {
                            int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

                           
                            cmd.Parameters.AddWithValue("@ProductName", textBoxpname.Text);
                            cmd.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@Price", price);
                          
                            cmd.Parameters.AddWithValue("@ProductID", productId);
                          
                           
                            int result = cmd.ExecuteNonQuery();

                           
                            if (result > 0)
                            {
                                MessageBox.Show("Product updated successfully!");
                                textBoxpname.Clear();
                                comboBox1.SelectedIndex = -1;
                                textBox1.Text = "1"; 
                                pictureBox1.Image = null; 
                                textBoxPRICE.Clear();
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
              
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void buttondel_Click(object sender, EventArgs e)
        {
            {
               
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a product to delete.");
                    return;
                }

                
                var confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult != DialogResult.Yes)
                {
                    return; 
                }

                
                    
                    int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

                   
                    string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                    
                    string connectionString = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True;";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            
                            cmd.Parameters.AddWithValue("@ProductID", productId);

                            
                           

                           
                            int result = cmd.ExecuteNonQuery();

                          
                            if (result > 0)
                            {
                                MessageBox.Show("Product deleted successfully!");
                               
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
            Form previousForm = Session.LastForm;

            if (previousForm != null)
            {
                this.Hide();
                previousForm.Show();
            }
        }

      
       
    }
}
