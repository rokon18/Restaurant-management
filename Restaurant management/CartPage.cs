using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
                DialogResult result = MessageBox.Show("Are you sure you want to remove this product?",
                                                      "Remove Product",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

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
            this.Hide();  // Hide the CartPage
            MenuList menulist = (MenuList)this.Tag;  // Retrieve the MenuList instance passed through Tag property
            menulist.Show();  // Show the MenuForm
        }

        private void ExportToPdfButton_Click(object sender, EventArgs e)
        {
            // Show save file dialog to get the file name and location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Call the export method and pass the chosen file name
                ExportDataGridViewToPDF(saveFileDialog.FileName);
            }
        }




        private void ExportDataGridViewToPDF(string fileName)
        {
            // Create a new PDF document
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

            try
            {
                // Create the PDF writer
                PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));

                // Open the PDF document
                pdfDoc.Open();

                // Create a font for the table text
                iTextSharp.text.Font font = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                // Create a table with the same number of columns as DataGridView, excluding the "Remove" button column
                PdfPTable pdfTable = new PdfPTable(dataGridViewCart.ColumnCount - 1); // Assuming RemoveColumn is the last one, so we exclude it
                pdfTable.WidthPercentage = 100;

                // Add headers to the table (skip the "Remove" button column)
                foreach (DataGridViewColumn column in dataGridViewCart.Columns)
                {
                    if (column.Name != "RemoveColumn") // Skip the "Remove" column
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, font))
                        {
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        pdfTable.AddCell(headerCell);
                    }
                }

                // Add DataGridView rows to the table (skip the "Remove" button column)
                foreach (DataGridViewRow row in dataGridViewCart.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (dataGridViewCart.Columns[cell.ColumnIndex].Name != "RemoveColumn") // Skip the "Remove" column
                        {
                            PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString(), font))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER
                            };
                            pdfTable.AddCell(pdfCell);
                        }
                    }
                }

                // Add the main product table to the document
                pdfDoc.Add(pdfTable);

                // Create a separate table for Subtotal, Discount, and Grand Total
                PdfPTable summaryTable = new PdfPTable(2); // 2 columns: one for labels and one for values
                summaryTable.WidthPercentage = 40; // Adjust the width of the summary table as needed
                summaryTable.HorizontalAlignment = Element.ALIGN_RIGHT; // Align it to the right side of the page

                // Add the Subtotal row
                PdfPCell subTotalLabelCell = new PdfPCell(new Phrase("Subtotal:", font))
                {
                    Border = iTextSharp.text.Rectangle.NO_BORDER,
                    HorizontalAlignment = Element.ALIGN_RIGHT
                };
                PdfPCell subTotalValueCell = new PdfPCell(new Phrase(SubTotal.Text, font))
                {
                    Border = iTextSharp.text.Rectangle.NO_BORDER,
                    HorizontalAlignment = Element.ALIGN_RIGHT
                };
                summaryTable.AddCell(subTotalLabelCell);
                summaryTable.AddCell(subTotalValueCell);

                // Add the Discount row
                PdfPCell discountLabelCell = new PdfPCell(new Phrase("Discount:", font))
                {
                    Border = iTextSharp.text.Rectangle.NO_BORDER,
                    HorizontalAlignment = Element.ALIGN_RIGHT
                };
                PdfPCell discountValueCell = new PdfPCell(new Phrase(DiscountTextBox.Text, font)) // Assuming DiscountTextBox.Text holds the discount amount
                {
                    Border = iTextSharp.text.Rectangle.NO_BORDER,
                    HorizontalAlignment = Element.ALIGN_RIGHT
                };
                summaryTable.AddCell(discountLabelCell);
                summaryTable.AddCell(discountValueCell);

                // Add the Grand Total row
                PdfPCell grandTotalLabelCell = new PdfPCell(new Phrase("Grand Total:", font))
                {
                    Border = iTextSharp.text.Rectangle.NO_BORDER,
                    HorizontalAlignment = Element.ALIGN_RIGHT
                };
                PdfPCell grandTotalValueCell = new PdfPCell(new Phrase(GrandTotal.Text, font))
                {
                    Border = iTextSharp.text.Rectangle.NO_BORDER,
                    HorizontalAlignment = Element.ALIGN_RIGHT
                };
                summaryTable.AddCell(grandTotalLabelCell);
                summaryTable.AddCell(grandTotalValueCell);

                // Add a border around the entire summary table
                PdfPCell summaryBoxCell = new PdfPCell(summaryTable)
                {
                    Colspan = 2,
                    Border = iTextSharp.text.Rectangle.BOX,
                    Padding = 10f
                };

                PdfPTable boxedSummaryTable = new PdfPTable(1); // 1 column to contain the summary table
                boxedSummaryTable.WidthPercentage = 40; // Adjust the width
                boxedSummaryTable.HorizontalAlignment = Element.ALIGN_RIGHT;
                boxedSummaryTable.AddCell(summaryBoxCell);

                // Add the boxed summary table to the document
                pdfDoc.Add(boxedSummaryTable);

                // Success message
                MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while exporting to PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the document
                pdfDoc.Close();
            }
        }




    }
}
