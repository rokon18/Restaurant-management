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
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this application ?", "closing window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                Login log = new Login();
        
                this.Hide();
                log.Show();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
           Product_List PL = new Product_List();
            Login.stack.Push(this);
            this.Hide();
            PL.ShowDialog();

        }

        private void btnchgpass_Click(object sender, EventArgs e)
        {
          
            
                Changepassword ch = new Changepassword();
                Login.stack.Push(this);
                this.Hide();
                ch.Show();
            
        }

        private void btnupdateProduct_Click(object sender, EventArgs e)
        {
            Product_List PL = new Product_List();
            Login.stack.Push(this);
            this.Hide();
            PL.Show();
        }

        private void btndeProduct_Click(object sender, EventArgs e)
        {
            Product_List PL = new Product_List();
            Login.stack.Push(this);
            this.Hide();
            PL.Show();
        }
    }
}
