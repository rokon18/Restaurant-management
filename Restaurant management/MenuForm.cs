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
        public MenuForm()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void label108_Click(object sender, EventArgs e)
        {

        }

        private void label72_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void LunchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GoCart1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartPage cartPage = new CartPage();
            cartPage.Show();
        }

        private void GoCart2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartPage cartPage = new CartPage();
            cartPage.Show();
        }

        private void NavBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
