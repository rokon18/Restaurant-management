using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management
{
    public partial class Login : Form
    {
        // Stack from Data Structure
        public static Stack<Form> stack = new Stack<Form>();

        // Constructor
        public Login()
        {
            InitializeComponent();
        }

        private void SignuplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sign = new Signup();
            Login.stack.Push(this);
            this.Hide();
            sign.ShowDialog();
        }

        private void showpasscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordtextBox.UseSystemPasswordChar = !showpasscheckBox.Checked;
        }

        // Connection String 
        string conStr = "Data Source=LAPTOP-V6FVPVK1\\SQLEXPRESS;Initial Catalog=RMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            
            if (usertextBox.Text != "" && passwordtextBox.Text != "")
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    
                    SqlCommand cmd = new SqlCommand("SELECT Firstname, Lastname, Email,Contactno, Role FROM SignupTable WHERE Username = @Username AND Password = @Password", con);
                    cmd.Parameters.AddWithValue("@Username", usertextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordtextBox.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string Firstname = dr["Firstname"].ToString();
                        string Lastname = dr["Lastname"].ToString();
                        string Email = dr["Email"].ToString();
                        string Role = dr["Role"].ToString();
                        string Contactno = dr["Contactno"].ToString();

                        if (Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            AdminDashboard adminDashboard = new AdminDashboard(Firstname, Email, Contactno);
                            Login.stack.Push(this);
                            this.Hide();
                            adminDashboard.ShowDialog();
                        }
                        else
                        {
                            userDashboard dashboard = new userDashboard(Firstname, Lastname, Email, Contactno);
                            Login.stack.Push(this);
                            this.Hide();
                            dashboard.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
