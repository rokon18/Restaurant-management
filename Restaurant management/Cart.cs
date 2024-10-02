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

            
            dataGridViewCart.Columns.Clear();

           
            dataGridViewCart.Columns.Add("ProductNameColumn", "Product Name");
            dataGridViewCart.Columns.Add("PriceColumn", "Price");
            dataGridViewCart.Columns.Add("QuantityColumn", "Quantity");
            dataGridViewCart.Columns.Add("TotalColumn", "Total");

            
            dataGridViewCart.Columns["PriceColumn"].ValueType = typeof(decimal);
            dataGridViewCart.Columns["QuantityColumn"].ValueType = typeof(int);
            dataGridViewCart.Columns["TotalColumn"].ValueType = typeof(decimal);

           
            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
            removeButtonColumn.Name = "RemoveColumn";
            removeButtonColumn.HeaderText = "";
            removeButtonColumn.Text = "Remove";
            removeButtonColumn.UseColumnTextForButtonValue = true;  

            dataGridViewCart.Columns.Add(removeButtonColumn);
        }


        
        public void AddProductToCart(string productName, decimal price, int quantity)
        {
          
            if (dataGridViewCart.Columns.Count == 0)
            {
                InitializeCartColumns();
            }

            bool productExists = false;

           
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                if (row.Cells["ProductNameColumn"].Value != null &&
                    row.Cells["ProductNameColumn"].Value.ToString() == productName)
                {
                   
                    int existingQuantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                    int newQuantity = existingQuantity + quantity; // Update the quantity
                    row.Cells["QuantityColumn"].Value = newQuantity;

                   
                    row.Cells["TotalColumn"].Value = price * newQuantity;

                    productExists = true;
                    break;
                }
            }

          
            if (!productExists)
            {
                int rowIndex = dataGridViewCart.Rows.Add();
                dataGridViewCart.Rows[rowIndex].Cells["ProductNameColumn"].Value = productName;
                dataGridViewCart.Rows[rowIndex].Cells["PriceColumn"].Value = price;
                dataGridViewCart.Rows[rowIndex].Cells["QuantityColumn"].Value = quantity;
                dataGridViewCart.Rows[rowIndex].Cells["TotalColumn"].Value = price * quantity;
            }

         
            UpdateSubTotal();

        }



        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == dataGridViewCart.Columns["RemoveColumn"].Index && e.RowIndex >= 0)
            {
               
                DialogResult result = MessageBox.Show("Are you sure you want to remove this product?",  "Remove Product",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

              
                if (result == DialogResult.Yes)
                {
                    dataGridViewCart.Rows.RemoveAt(e.RowIndex);  
                    
                    UpdateSubTotal();
                }
            }
        }


        private void dataGridViewCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.ColumnIndex == dataGridViewCart.Columns["QuantityColumn"].Index && e.RowIndex >= 0)
            {
               
                int quantity = Convert.ToInt32(dataGridViewCart.Rows[e.RowIndex].Cells["QuantityColumn"].Value);
                float price = Convert.ToSingle(dataGridViewCart.Rows[e.RowIndex].Cells["PriceColumn"].Value);

                
                dataGridViewCart.Rows[e.RowIndex].Cells["TotalColumn"].Value = quantity * price;

                
                UpdateSubTotal();
            }
        }


        private void UpdateSubTotal()
        {
            float subTotal = 0; 

            
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
               
                float rowTotal = Convert.ToSingle(row.Cells["TotalColumn"].Value);

                
                subTotal += rowTotal;
            }


           SubTotal.Text = subTotal.ToString("0.00");

            GrandTotal.Text = subTotal.ToString("0.00");
        }

        private void ApplyDiscount(object sender, EventArgs e)
        {
           
            float subTotal = float.Parse(SubTotal.Text);  

           
            string discountCode = DiscountTextBox.Text.Trim();

            
            float discountPercentage = 0;

            
            if (discountCode == "DISCOUNT10") 
            {
                discountPercentage = 10;
            }
            else if (discountCode == "DISCOUNT20") 
            {
                discountPercentage = 20;
            }
            else if (discountCode == "DISCOUNT30") 
            {
                discountPercentage = 30;
            }
            else
            {
                
                MessageBox.Show("Invalid discount code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            float discountAmount = (subTotal * discountPercentage) / 100;

          
            float grandTotal = subTotal - discountAmount;

            
            GrandTotal.Text = grandTotal.ToString("0.00");

            DiscountTextBox.Clear();
        }

        private void GoMenu_Click(object sender, EventArgs e)
        {
            {
                this.Hide(); 
                MenuList menulist = (MenuList)this.Tag;  
                menulist.Show();  
            }
        }
        public void ClearCart()
        {
            dataGridViewCart.Rows.Clear();  
            UpdateSubTotal(); 
        }
        

        private void button9chkout_Click(object sender, EventArgs e)
        {
            

            
            decimal grandTotal = decimal.Parse(GrandTotal.Text);
            Payment paymentForm = new Payment(grandTotal, this); ;
            paymentForm.Show(); 
            
            
        }
    }
}