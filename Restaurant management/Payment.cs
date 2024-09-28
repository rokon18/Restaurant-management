using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Restaurant_management
{
    public partial class Payment : Form
    {
        private CartPage _cartPage;
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
                    
                    // Close the payment form
                    this.Close();
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
                    _cartPage.ClearCart();
                   
                    // Close the payment form
                    this.Close();
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
    }
}
