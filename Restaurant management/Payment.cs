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
        public Payment(decimal grandTotal, CartPage cartPage) 
        {
            InitializeComponent();
            InitializePanels();


            string formattedTotal = grandTotal.ToString("0.00");
            texbxamount.Text = formattedTotal;
            texbxamount2.Text = formattedTotal;
            _cartPage = cartPage;
        }

        private void InitializePanels()
        {
           
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
          
            if (radioButton1.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false; 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioButton2.Checked)
            {
                panel2.Visible = true;
                panel1.Visible = false; 
            }
        }

        private void buttonconbks_Click(object sender, EventArgs e)
        {
          
            string accno = textBoxaccno.Text;
          
            string password = textBoxbkspass.Text;

            
            string phoneFormat = @"^\d{11}$";  

            // Validate the phone number
            if (Regex.IsMatch(accno, phoneFormat))
            {
               
                if (!string.IsNullOrWhiteSpace(password))
                {
                   
                    MessageBox.Show("Payment Successfull!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxaccno.Clear();
                    textBoxbkspass.Clear();
                    _cartPage.ClearCart();
                    paymentSuccess = true;
                    
                    
                  
                   
                }
                else
                {
                  
                    MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                
                MessageBox.Show("Please enter a valid phone number (11 digits).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncanbks_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the payment?", "Cancel Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
             
                textBoxaccno.Clear();
                textBoxbkspass.Clear();

                this.Close();
            }
        }

        private void buttoncardcon_Click(object sender, EventArgs e)
        {
            string cardnum = textBox2.Text;
           
            string cvv = textBox4.Text;

           
            string phoneFormat = @"^\d{16}$";  
            string CVV = @"^\d{3}$";
            // Validate the card number
            if (Regex.IsMatch(cardnum, phoneFormat))
            {
                
                if (Regex.IsMatch(cvv, CVV))
                {
                    
                    MessageBox.Show("Payment Successfull!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Clear();
                    textBox4.Clear();


                    paymentSuccess = true;

                   
                }
                else
                {

                    MessageBox.Show("CVV number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
             
                MessageBox.Show("Please enter a valid Card number(16 digits).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttoncancard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the payment?", "Cancel Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          
            if (result == DialogResult.Yes)
            {
              
                textBox2.Clear();
                textBox4.Clear();

              
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

              
                document.Open();

                
                document.Add(new Paragraph("Homemade Restaurant"));
                document.Add(new Paragraph("Payment Receipt"));
                document.Add(new Paragraph("--------------------------------------------------"));
                document.Add(new Paragraph($"Payment Method: {paymentMethod}"));
                document.Add(new Paragraph($"Amount: {amount}"));
                document.Add(new Paragraph("--------------------------------------------------"));
                document.Add(new Paragraph($"Date: {DateTime.Now}"));
                document.Add(new Paragraph("Thank you for your payment!"));

               
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
              string paymentMethod = radioButton1.Checked ? "Bkash" : "Card"; 
                string amount = texbxamount.Text;
           
            if (paymentSuccess)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"; 
                saveFileDialog.Title = "Save Payment Receipt";
                saveFileDialog.FileName = "PaymentReceipt.pdf"; 

                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    
                   
                    this.Close();
                }
                else
                {  
                    string filePath = saveFileDialog.FileName;
                    GeneratePDFReceipt(paymentMethod, amount, filePath);

                   
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
