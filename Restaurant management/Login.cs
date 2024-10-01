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
       
       

        
        public Login()
        {
            InitializeComponent();
        }

        private void SignuplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sign = new Signup();
           
            this.Hide();
            sign.Show();
        }

        private void showpasscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordtextBox.UseSystemPasswordChar = !showpasscheckBox.Checked;
        }

      
        string conStr = "Data Source=MSI;Initial Catalog=RMS;Integrated Security=True; ";

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string username = usertextBox.Text;
            Session.CurrentUsername = username ;

            if (usertextBox.Text != "" && passwordtextBox.Text != "")
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                
                    SqlCommand cmd = new SqlCommand("SELECT Firstname, Lastname, Email, Contactno, Role, Status FROM SignupTable WHERE Username = @Username AND Password = @Password", con);
                  cmd.Parameters.AddWithValue("@Username", usertextBox.Text);
                  cmd.Parameters.AddWithValue("@Password", passwordtextBox.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        
                        int status = Convert.ToInt32(dr["Status"]);

                        // Check active/not
                        if (status == 1) 
                        {
                            string Firstname = dr["Firstname"].ToString();
                            string Lastname = dr["Lastname"].ToString();
                            string Email = dr["Email"].ToString();
                            string Role = dr["Role"].ToString();
                            string Contactno = dr["Contactno"].ToString();

                            if (Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                AdminDashboard adminDashboard = new AdminDashboard(Firstname, Email, Contactno);
                              
                                this.Hide();
                                adminDashboard.Show();
                            }

                            else if (Role.Equals("Manager", StringComparison.OrdinalIgnoreCase))
                            {
                                ManagerDashboard manDashboard = new ManagerDashboard(Firstname,Lastname, Email, Contactno);
                               
                                this.Hide();
                                manDashboard.Show();
                            }
                            else
                            {
                                userDashboard dashboard = new userDashboard(Firstname, Lastname, Email, Contactno);
                              
                                this.Hide();
                                dashboard.Show();
                            }
                        }
                        else 
                        {
                            MessageBox.Show("Your account is inactive. Please contact the administrator.", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
