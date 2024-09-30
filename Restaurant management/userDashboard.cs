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
    public partial class userDashboard : Form
    {
        private string Firstname;
        private string Lastname;
        private string Email;
        private string Contactno;

        public userDashboard(string Firstname, string Lastname, string Email, string Contactno)
        {
            InitializeComponent();
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.Contactno = Contactno;
        }

        private void userDashboard_Load(object sender, EventArgs e)
        {
         
            userfullnamelabel.Text = $"{Firstname} {Lastname}";
            labelphone.Text = Contactno;
            emaillabel.Text = Email;
        }

        private void Changepasswordbutton_Click(object sender, EventArgs e)
        {
            Session.LastForm = this; 
            Changepassword ch = new Changepassword();
            this.Hide();
            ch.Show();
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

        private void Orderbutton_Click(object sender, EventArgs e)
        {
            MenuList Ml = new MenuList();
            Session.LastForm = this;
            this.Hide();
            Ml.Show();

        }
    }
}
