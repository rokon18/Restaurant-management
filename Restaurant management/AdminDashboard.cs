using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;


namespace Restaurant_management
{
    public partial class AdminDashboard : Form
    {
        private string Name;
        private string Email;
        private string Contactno;

        public AdminDashboard(string Name,  string Email, string Contactno)
        {
            InitializeComponent();
            this.Name = Name;
            this.Email = Email;
            this.Contactno = Contactno;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            Adminnamelabel.Text = Name;
            phonelabel.Text = Contactno;
            emaillabel.Text = Email;
        }

        private void Customerbutton_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            Session.LastForm = this;
            this.Hide();
            cus.Show();
        }

        private void Adminnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
           
            

                DialogResult result = MessageBox.Show("Do you want to close this application ?", "closing window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {


                   Login log = new Login();
                    
                    this.Hide();
                    log.Show();
                }
            
        }



        private void btnadminchangepasss_Click(object sender, EventArgs e)
        {
            Session.LastForm = this; 
            Changepassword ch = new Changepassword();
            this.Hide();
            ch.Show();
        }
    }
}
