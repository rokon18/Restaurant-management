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

namespace Restaurant_management
{
    public partial class CartPage : Form
    {


        public CartPage()
        {
            InitializeComponent();
            InitializeCartColumns();
        }
        public DataGridView DataGridViewCart
        {
            get { return dataGridViewCart; }
        }


        private void InitializeCartColumns()
        {

            // Clear existing columns just in case
            dataGridViewCart.Columns.Clear();

            // Define the columns
            dataGridViewCart.Columns.Add("ProductNameColumn", "Product Name");
            dataGridViewCart.Columns.Add("PriceColumn", "Price");
            dataGridViewCart.Columns.Add("QuantityColumn", "Quantity");
            dataGridViewCart.Columns.Add("TotalColumn", "Total");

            // Optional: set additional column properties, such as column types, widths, etc.
            dataGridViewCart.Columns["PriceColumn"].ValueType = typeof(decimal);
            dataGridViewCart.Columns["QuantityColumn"].ValueType = typeof(int);
            dataGridViewCart.Columns["TotalColumn"].ValueType = typeof(decimal);

            // Add a Remove button column
            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
            removeButtonColumn.Name = "RemoveColumn";
            removeButtonColumn.HeaderText = "";
            removeButtonColumn.Text = "Remove";
            removeButtonColumn.UseColumnTextForButtonValue = true;  // Shows the "Remove" text on the button

            dataGridViewCart.Columns.Add(removeButtonColumn);
        }


        // Method to add a product to the cart
        public void AddProductToCart(string productName, decimal price, int quantity)
        {
            // Ensure columns are set up
            if (dataGridViewCart.Columns.Count == 0)
            {
                InitializeCartColumns();
            }

            // Flag to check if the product is already in the cart
            bool productExists = false;

            // Loop through the DataGridView rows to check if the product already exists
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                if (row.Cells["ProductNameColumn"].Value != null &&
                    row.Cells["ProductNameColumn"].Value.ToString() == productName)
                {
                    // Product already exists, update the quantity and total price
                    int existingQuantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                    int newQuantity = existingQuantity + quantity; // Update the quantity
                    row.Cells["QuantityColumn"].Value = newQuantity;

                    // Update the total price for the updated quantity
                    row.Cells["TotalColumn"].Value = price * newQuantity;

                    productExists = true;
                    break;
                }
            }

            // If product doesn't exist, add a new row
            if (!productExists)
            {
                int rowIndex = dataGridViewCart.Rows.Add();
                dataGridViewCart.Rows[rowIndex].Cells["ProductNameColumn"].Value = productName;
                dataGridViewCart.Rows[rowIndex].Cells["PriceColumn"].Value = price;
                dataGridViewCart.Rows[rowIndex].Cells["QuantityColumn"].Value = quantity;
                dataGridViewCart.Rows[rowIndex].Cells["TotalColumn"].Value = price * quantity;
            }

            // Update the SubTotal after adding or updating the product
            UpdateSubTotal();

        }



        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Remove" column
            if (e.ColumnIndex == dataGridViewCart.Columns["RemoveColumn"].Index && e.RowIndex >= 0)
            {
                // Confirm if the user wants to remove the product
                DialogResult result = MessageBox.Show("Are you sure you want to remove this product?",  "Remove Product",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                // If user confirms, remove the row
                if (result == DialogResult.Yes)
                {
                    dataGridViewCart.Rows.RemoveAt(e.RowIndex);  // Remove the row from the DataGridView

                    // Update the SubTotal after removing the product
                    UpdateSubTotal();
                }
            }
        }


        private void dataGridViewCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed cell is in the Quantity column
            if (e.ColumnIndex == dataGridViewCart.Columns["QuantityColumn"].Index && e.RowIndex >= 0)
            {
                // Get the updated quantity and price
                int quantity = Convert.ToInt32(dataGridViewCart.Rows[e.RowIndex].Cells["QuantityColumn"].Value);
                float price = Convert.ToSingle(dataGridViewCart.Rows[e.RowIndex].Cells["PriceColumn"].Value);

                // Update the total for the row
                dataGridViewCart.Rows[e.RowIndex].Cells["TotalColumn"].Value = quantity * price;

                // Recalculate the SubTotal
                UpdateSubTotal();
            }
        }


        private void UpdateSubTotal()
        {
            float subTotal = 0;  // Use float for price calculations

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                // Get the total value for the current row
                float rowTotal = Convert.ToSingle(row.Cells["TotalColumn"].Value);

                // Add the row total to the subTotal
                subTotal += rowTotal;
            }


           SubTotal.Text = subTotal.ToString("0.00");

            GrandTotal.Text = subTotal.ToString("0.00");
        }

        private void ApplyDiscount(object sender, EventArgs e)
        {
            // Get the subtotal (already calculated in UpdateSubTotal)
            float subTotal = float.Parse(SubTotal.Text);  // Assuming SubTotal label already has the value in float format

            // Get the discount code entered by the user
            string discountCode = DiscountTextBox.Text.Trim();

            // Initialize the discount value
            float discountPercentage = 0;

            // Check the discount code and assign the discount percentage
            if (discountCode == "DISCOUNT10") // Example: 10% discount
            {
                discountPercentage = 10;
            }
            else if (discountCode == "DISCOUNT20") // Example: 20% discount
            {
                discountPercentage = 20;
            }
            else if (discountCode == "DISCOUNT30") // Example: 30% discount
            {
                discountPercentage = 30;
            }
            else
            {
                // Invalid or no discount code, show a message (optional)
                MessageBox.Show("Invalid discount code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Calculate the discount amount
            float discountAmount = (subTotal * discountPercentage) / 100;

            // Calculate the grand total after applying the discount
            float grandTotal = subTotal - discountAmount;

            // Update the GrandTotal label
            GrandTotal.Text = grandTotal.ToString("0.00");

            DiscountTextBox.Clear();
        }

        private void GoMenu_Click(object sender, EventArgs e)
        {
            {
                this.Hide();  // Hide the CartPage
                MenuList menulist = (MenuList)this.Tag;  // Retrieve the MenuList instance passed through Tag property
                menulist.Show();  // Show the MenuForm
            }
        }
        public void ClearCart()
        {
            dataGridViewCart.Rows.Clear();  // Clear all rows in the DataGridView
            UpdateSubTotal();  // Reset the subtotal and grand total labels
        }
        

        private void button9chkout_Click(object sender, EventArgs e)
        {
            

            // Assuming GrandTotal is a label that holds the grand total amount
            decimal grandTotal = decimal.Parse(GrandTotal.Text); // Get the grand total value
            Payment paymentForm = new Payment(grandTotal, this); ;
            paymentForm.Show(); // Show the Payment form
            // Show the payment form
            
        }
    }
}