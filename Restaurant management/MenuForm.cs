using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management
{
    public partial class MenuForm : Form
    {

        private CartPage cartPage;
        private userDashboard user;

        private string Firstname;
        private string Lastname;
        private string Email;
        private string Contactno;

        public MenuForm(string Firstname, string Lastname, string Email, string Contactno)
        {
            InitializeComponent();
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.Contactno = Contactno;

            cartPage = new CartPage();
            cartPage.Tag = this;  // Pass the reference of MenuForm to CartPage

            user = new userDashboard(Firstname, Lastname, Email, Contactno);
            user.Tag = this; // Pass the reference of MenuForm to UserDashboard
        }



        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private Panel[] panels;
        private Label[] panelLabels;

        private void searchBoxMethod(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.Trim().ToLower();

         
            foreach (Panel panel in panels)
            {
                Button button = (Button)panel.Controls[0];
                string buttonText = button.Text.ToLower();

                if (buttonText.StartsWith(searchText))
                {
                    panel.Visible = true;
                }
                else
                {
                    panel.Visible = false;
                }
            }
        }

        private void Lunch_Click(object sender, EventArgs e)
        {
            LunchPanel.BringToFront();
        }

        private void Dinner_Click(object sender, EventArgs e)
        {
            DinnerPanel.BringToFront(); 
        }



        private void GoCart1_Click(object sender, EventArgs e)
        {
            this.Hide();
            cartPage.Show();  
        }

        private void GoCart2_Click(object sender, EventArgs e)
        {
            this.Hide();
            cartPage.Show();  
        }


        
        //Dinner Panel Add to Cart Buttons
        private void Apb1_Click(object sender, EventArgs e)
        {
            // Assuming the product details (name, price, and quantity) are within the panel controls
            Button addButton = (Button)sender;
            Panel productPanel = (Panel)addButton.Parent;  // Get the parent panel of the clicked button

            // Find the controls in the panel to retrieve the product details
            Label productNameLabel = (Label)productPanel.Controls["Nl1"];  // Assume the label for product name is "Nl1"
            Label productPriceLabel = (Label)productPanel.Controls["Pl1"];  // Assume the label for product price is "Pl1"
            NumericUpDown productQuantity = (NumericUpDown)productPanel.Controls["Ql1"];  // Assume quantity is selected using a NumericUpDown control

            string productName = productNameLabel.Text;
            decimal price = Convert.ToDecimal(productPriceLabel.Text);
            int quantity = Convert.ToInt32(productQuantity.Value);


            if (quantity > 0)
            {
                cartPage.AddProductToCart(productName, price, quantity);  // Add the product to the cart
                
            }
            else
            {
                MessageBox.Show("Quantity must be greater than 0.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Apb2_Click(object sender, EventArgs e)
        {
            // Assuming the product details (name, price, and quantity) are within the panel controls
            Button addButton = (Button)sender;
            Panel productPanel = (Panel)addButton.Parent;  // Get the parent panel of the clicked button

            // Find the controls in the panel to retrieve the product details
            Label productNameLabel = (Label)productPanel.Controls["Nl2"];  // Assume the label for product name is "Nl1"
            Label productPriceLabel = (Label)productPanel.Controls["Pl2"];  // Assume the label for product price is "Pl1"
            NumericUpDown productQuantity = (NumericUpDown)productPanel.Controls["Ql2"];  // Assume quantity is selected using a NumericUpDown control

            string productName = productNameLabel.Text;
            decimal price = Convert.ToDecimal(productPriceLabel.Text);
            int quantity = Convert.ToInt32(productQuantity.Value);


            if (quantity > 0)
            {
                cartPage.AddProductToCart(productName, price, quantity);  // Add the product to the cart
                
            }
            else
            {
                MessageBox.Show("Quantity must be greater than 0.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Apb3_Click(object sender, EventArgs e)
        {
            // Assuming the product details (name, price, and quantity) are within the panel controls
            Button addButton = (Button)sender;
            Panel productPanel = (Panel)addButton.Parent;  // Get the parent panel of the clicked button

            // Find the controls in the panel to retrieve the product details
            Label productNameLabel = (Label)productPanel.Controls["Nl3"];  // Assume the label for product name is "Nl1"
            Label productPriceLabel = (Label)productPanel.Controls["Pl3"];  // Assume the label for product price is "Pl1"
            NumericUpDown productQuantity = (NumericUpDown)productPanel.Controls["Ql3"];  // Assume quantity is selected using a NumericUpDown control

            string productName = productNameLabel.Text;
            decimal price = Convert.ToDecimal(productPriceLabel.Text);
            int quantity = Convert.ToInt32(productQuantity.Value);


            if (quantity > 0)
            {
                cartPage.AddProductToCart(productName, price, quantity);  // Add the product to the cart
                 
            }
            else
            {
                MessageBox.Show("Quantity must be greater than 0.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GoProfile_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the CartPage
            //MenuForm menuForm = (MenuForm)this.Tag;  // Retrieve the MenuForm instance passed through Tag property
            user.Show();
        }
    }
}
