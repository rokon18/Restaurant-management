using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Restaurant_management
{
    public partial class Payment : Form
    {
        private CartPage _cartPage;
        private bool paymentSuccess = false;
        public Payment(decimal grandTotal, CartPage cartPage) // Accept grand total and CartPage reference // Accept grand total as a decimal
        {
            InitializeComponent();
            InitializePanels();

            // Convert grand total to string for display in textboxes
            string formattedTotal = grandTotal.ToString("0.00");
            texbxamount.Text = formattedTotal;
            texbxamount2.Text = formattedTotal;
            _cartPage = cartPage;
        }

        private void InitializePanels()
        {
            // Initially hide both panels
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            // Show panel1 when radioButton1 is checked
            if (radioButton1.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false;  // Hide panel2
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Show panel2 when radioButton2 is checked
            if (radioButton2.Checked)
            {
                panel2.Visible = true;
                panel1.Visible = false;  // Hide panel1
            }
        }

        private void buttonconbks_Click(object sender, EventArgs e)
        {
            // Get the phone number from the TextBox
            string accno = textBoxaccno.Text;
            // Get the password from the TextBox
            string password = textBoxbkspass.Text;

            // Define the phone number format
            string phoneFormat = @"^\d{11}$";  // Regular expression for 11 digits

            // Validate the phone number
            if (Regex.IsMatch(accno, phoneFormat))
            {
                // Check if the password field is not empty
                if (!string.IsNullOrWhiteSpace(password))
                {
                    // Both phone number and password are valid
                    MessageBox.Show("Payment Successfull!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxaccno.Clear();
                    textBoxbkspass.Clear();
                    _cartPage.ClearCart();
                    paymentSuccess = true;
                    
                    // Close the payment form
                  
                    // Proceed with the next steps (e.g., payment processing, etc.)
                }
                else
                {
                    // Password is empty
                    MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Phone number is invalid
                MessageBox.Show("Please enter a valid phone number (11 digits).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncanbks_Click(object sender, EventArgs e)
        {
            // Confirm with the user if they really want to cancel the payment
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the payment?", "Cancel Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms, close the payment form and return to the previous form
            if (result == DialogResult.Yes)
            {
                // Optionally, clear any input fields if needed
                textBoxaccno.Clear();
                textBoxbkspass.Clear();

                // Close the payment form
                this.Close();
            }
        }

        private void buttoncardcon_Click(object sender, EventArgs e)
        {
            string cardnum = textBox2.Text;
            // Get the password from the TextBox
            string cvv = textBox4.Text;

            // Define the phone number format
            string phoneFormat = @"^\d{16}$";  // Regular expression for 11 digits
            string CVV = @"^\d{3}$";
            // Validate the phone number
            if (Regex.IsMatch(cardnum, phoneFormat))
            {
                // Check if the password field is not empty
                if (Regex.IsMatch(cvv, CVV))
                {
                    // Both phone number and password are valid
                    MessageBox.Show("Payment Successfull!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Clear();
                    textBox4.Clear();


                    paymentSuccess = true;

                    // Proceed with the next steps (e.g., payment processing, etc.)
                }
                else
                {

                    MessageBox.Show("CVV number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Phone number is invalid
                MessageBox.Show("Please enter a valid Card number(16 digits).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttoncancard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the payment?", "Cancel Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms, close the payment form and return to the previous form
            if (result == DialogResult.Yes)
            {
                // Optionally, clear any input fields if needed
                textBox2.Clear();
                textBox4.Clear();

                // Close the payment form
                this.Close();
            }
        }
      
            private void GeneratePDFReceipt(string paymentMethod, string amount, string filePath)
        {
            try
            {
                // Create a new PDF document
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Open the document to write
                document.Open();

                // Add content to the PDF
                document.Add(new Paragraph("Homemade Restaurant"));
                document.Add(new Paragraph("Payment Receipt"));
                document.Add(new Paragraph("--------------------------------------------------"));
                document.Add(new Paragraph($"Payment Method: {paymentMethod}"));
                document.Add(new Paragraph($"Amount: {amount}"));
                document.Add(new Paragraph("--------------------------------------------------"));
                document.Add(new Paragraph($"Date: {DateTime.Now}"));
      
                document.Add(new Paragraph("Thank you for your payment!"));

                // Close the document
                document.Close();

                MessageBox.Show("PDF Receipt generated successfully!", "PDF Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printbtn_Click(object sender, EventArgs e)
        {
              string paymentMethod = radioButton1.Checked ? "Bkash" : "Card"; // Adjust based on your logic
                string amount = texbxamount.Text;
            // Check if the payment was successful before generating the PDF
            if (paymentSuccess)
            {
                // Open a SaveFileDialog to let the user select where to save the PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";  // Only allow PDF files
                saveFileDialog.Title = "Save Payment Receipt";
                saveFileDialog.FileName = "PaymentReceipt.pdf";  // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    // Generate the PDF using the path selected by the user
                    string filePath = saveFileDialog.FileName;
                    

                    // Close the payment form
                    this.Close();
                }
                else
                {  // Generate the PDF using the path selected by the user
                    string filePath = saveFileDialog.FileName;
                    GeneratePDFReceipt(paymentMethod, amount, filePath);

                    // Close the payment form
                    this.Close();
                    _cartPage.ClearCart();
                }
            }
            else
            {
                MessageBox.Show("Payment has not been completed yet. Please complete the payment first.", "Payment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

   
       
    }
}
