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
        private string Firstname;
        private string Lastname;
        private string Email;
        private string Contactno;
        public ManagerDashboard(string Firstname, string Lastname, string Email, string Contactno)
        {
            InitializeComponent();
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.Contactno = Contactno;
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
            Session.LastForm = this;
            this.Hide();
            PL.Show();

        }

        private void btnchgpass_Click(object sender, EventArgs e)
        {


            Session.LastForm = this; 
            Changepassword ch = new Changepassword();
            this.Hide();
            ch.Show();
        }

        private void btnupdateProduct_Click(object sender, EventArgs e)
        {
            Product_List PL = new Product_List();
            Session.LastForm = this;
            this.Hide();
            PL.Show();
        }

        private void btndeProduct_Click(object sender, EventArgs e)
        {
            Product_List PL = new Product_List();
            Session.LastForm = this;
            this.Hide();
            PL.Show();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
          textBox1.Text = $"{Firstname} {Lastname}";
            textBox2.Text = Contactno;
            textBox3.Text = Email;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
