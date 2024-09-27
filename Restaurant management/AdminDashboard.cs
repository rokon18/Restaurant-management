using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            Login.stack.Push(this);
            this.Hide();
            cus.ShowDialog();
        }

        private void Adminnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            if (Login.stack.Count > 0)
            {

                DialogResult result = MessageBox.Show("Do you want to close this application ?", "closing window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {


                    Login log = new Login();
                    Login.stack.Push(this);
                    this.Hide();
                    log.ShowDialog();
                }
            }
        }

        private void Addmanagerbutton_Click(object sender, EventArgs e)
        {
           // Adminaddmanger add = new Adminaddmanger();
            //Login.stack.Push(this);
           // this.Hide();
           // add.ShowDialog();

        }

        private void btnadminchangepasss_Click(object sender, EventArgs e)
        {
            Changepassword ch = new Changepassword();
            Login.stack.Push(this);
            this.Hide();
            ch.ShowDialog();
        }
    }
}
