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

                    // Updated query to include the Status column
                    SqlCommand cmd = new SqlCommand("SELECT Firstname, Lastname, Email, Contactno, Role, Status FROM SignupTable WHERE Username = @Username AND Password = @Password", con);
                    cmd.Parameters.AddWithValue("@Username", usertextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordtextBox.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        // Retrieve Status value
                        int status = Convert.ToInt32(dr["Status"]);

                        // Check if the account is active
                        if (status == 1) // Account is active
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

                            else if (Role.Equals("Manager", StringComparison.OrdinalIgnoreCase))
                            {
                                ManagerDashboard adminDashboard = new ManagerDashboard();
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
                        else // Account is inactive
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
            // Additional functionality if required
        }
    }
}
