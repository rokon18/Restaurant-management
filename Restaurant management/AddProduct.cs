using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Restaurant_management
{

    

    public partial class AddProduct : Form
    {
        private MenuForm menuForm;

        public AddProduct()
        {
            InitializeComponent();
            //LoadProductTable();
            ConfigureDataGridView();
            menuForm = new MenuForm();

        }

        

        // Connection String 
        string conStr = "Data Source=DESKTOP-46MR55N\\SQLEXPRESS;Integrated Security=True";
        private Panel addedPanel;
        private void AddProductPanelButton_Click(object sender, EventArgs e, byte[] imageBytes)
        {


            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                // Create a SQL command to insert the image data
                SqlCommand command = new SqlCommand("use [RMS] INSERT INTO MenuItemTable (Name, Price, Category, Image) VALUES (@Name, @Price, @Category, @Image)", connection);

                
                // Add parameters to the command
                command.Parameters.AddWithValue("@Name", ProductNameBox.Text);
                command.Parameters.AddWithValue("@Price", PriceBox.Text);
                command.Parameters.AddWithValue("@Category", CategoryComboBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Image", imageBytes);


                // Execute the command
                command.ExecuteNonQuery();
            }



            // Create a new panel
            Panel newPanel = new Panel();
            newPanel.BackColor = Color.White;
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.Size = new Size(200, 100);

            // Add child controls to the panel (optional)
            // ...

            // Add the panel to MenuForm controls
            menuForm.Controls.Add(newPanel);

            // Store a reference to the panel
            addedPanel = newPanel;

            // Show MenuForm if not already visible
            if (!menuForm.Visible)
            {
                menuForm.Show();
            }
        }

        // Re-add the panel to a new MenuForm instance if needed
        private void ReAddPanel()
        {
            if (addedPanel != null)
            {
                menuForm = new MenuForm();
                menuForm.Controls.Add(addedPanel);
                menuForm.Show();
            }
        }

        private void ImageChoiceDialogButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png)|*.jpg; *.png;|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string fileName = openFileDialog.FileName;
                byte[] imageBytes = File.ReadAllBytes(fileName);


                try
                {
                    // Load the selected image into the PictureBox
                    ProductShowCase.Image = Image.FromFile(openFileDialog.FileName);
                    AddProductPanelButton_Click(sender, e, imageBytes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        

        //public void LoadProductTable()
        //{
        //    SqlConnection connection = new SqlConnection(conStr); 

        //    try
        //    {
        //        string query = "use [RMS] SELECT Name, Price, Category FROM MenuItemTable";
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt); 

        //        if (dt != null && dt.Rows.Count > 0)
        //        {
        //            Console.WriteLine("Number of rows fetched: " + dt.Rows.Count);
        //            MenuItemDataTable.DataSource = dt;
        //        }
        //        else
        //        {
        //            MessageBox.Show("No product data found.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while fetching product data: " + ex.Message);
        //    }
        //}


        private void ConfigureDataGridView()
        {
            MenuItemDataTable.EnableHeadersVisualStyles = false;
            MenuItemDataTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            MenuItemDataTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            MenuItemDataTable.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            MenuItemDataTable.GridColor = Color.Black;
            MenuItemDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MenuItemDataTable.RowHeadersVisible = false;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rMSDataSet3.MenuItemTable' table. 
            this.menuItemTableTableAdapter.Fill(this.rMSDataSet3.MenuItemTable);

        }



        private void BackButton_Click(object sender, EventArgs e)
        {
            ManagerDashboard mn = new ManagerDashboard("back", "back","back", "back");
            this.Hide();
            mn.ShowDialog();
        }

        
    }
    }

