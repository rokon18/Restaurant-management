using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Restaurant_management
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Login.stack.Count > 0)
            {
                Form previousForm = Login.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void Showpasscheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Showpasscheckbox.Checked)
            {
                newpasstxt.UseSystemPasswordChar = false;
                Confirmpasstxt.UseSystemPasswordChar = false;
            }
            else
            {
                newpasstxt.UseSystemPasswordChar = true;
                Confirmpasstxt.UseSystemPasswordChar = true;
            }
        }

        string constring = "Data Source=DESKTOP-46MR55N\\SQLEXPRESS;Integrated Security=True";
        string mailformat = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string phoneformat = @"^\d{11}$"; 

        private void signupbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Firstnametxt.Text))
            {
                Firstnametxt.Focus();
                errorProvider1.SetError(this.Firstnametxt, "Please fill First Name");
            }
            else if (string.IsNullOrEmpty(lastnametxt.Text))
            {
                lastnametxt.Focus();
                errorProvider2.SetError(this.lastnametxt, "Please fill Last Name");
            }
            else if (string.IsNullOrEmpty(usertxt.Text))
            {
                usertxt.Focus();
                errorProvider3.SetError(this.usertxt, "Please fill username");
            }
            else if (!Regex.IsMatch(emailtxt.Text, mailformat))
            {
                emailtxt.Focus();
                errorProvider4.SetError(this.emailtxt, "Invalid email");
            }
            else if (!Regex.IsMatch(contacttxt.Text, phoneformat))
            {
                contacttxt.Focus();
                errorProvider5.SetError(this.contacttxt, "Invalid contact number. Must be 11 digits.");
            }
            else if (roleComboBox.SelectedIndex == -1)
            {
                rolelbl.Focus();
                errorProvider6.SetError(this.rolelbl, "Please select a role.");
            }
            else if (string.IsNullOrEmpty(newpasstxt.Text))
            {
                newpasstxt.Focus();
                errorProvider7.SetError(this.newpasstxt, "Please fill password");
            }
            else if (string.IsNullOrEmpty(Confirmpasstxt.Text))
            {
                Confirmpasstxt.Focus();
                errorProvider8.SetError(this.Confirmpasstxt, "Please confirm password");
            }
            else if (Confirmpasstxt.Text != newpasstxt.Text)
            {
                errorProvider9.SetError(this.Confirmpasstxt, "Passwords do not match");
            }
            else
            {
               
                ClearErrorProviders();

                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    SqlCommand checkusername = new SqlCommand("SELECT COUNT(*) FROM SignupTable WHERE Username = @Username", con);
                    checkusername.Parameters.AddWithValue("@Username", usertxt.Text);
                    int user = (int)checkusername.ExecuteScalar();

                    if (user > 0)
                    {
                        MessageBox.Show("Username already exists. Choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usertxt.Focus();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO SignupTable (Firstname, Lastname, Username, Email, Role, Password, Contactno) VALUES (@Firstname, @Lastname, @Username, @Email, @Role, @Password, @Contactno)", con);
                        cmd.Parameters.AddWithValue("@Firstname", Firstnametxt.Text);
                        cmd.Parameters.AddWithValue("@Lastname", lastnametxt.Text);
                        cmd.Parameters.AddWithValue("@Username", usertxt.Text);
                        cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
                        cmd.Parameters.AddWithValue("@Role", roleComboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Contactno", contacttxt.Text);
                        cmd.Parameters.AddWithValue("@Password", Confirmpasstxt.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Sign Up Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Login loginForm = new Login(); 
                        loginForm.Show(); 
                        this.Hide(); 

                       
                        ClearInputFields();
                    }
                }
            }
        }

        private void ClearErrorProviders()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            errorProvider7.Clear();
            errorProvider8.Clear();
            errorProvider9.Clear();
        }

        private void ClearInputFields()
        {
            Firstnametxt.Clear();
            lastnametxt.Clear();
            usertxt.Clear();
            emailtxt.Clear();
            newpasstxt.Clear();
            Confirmpasstxt.Clear();
            contacttxt.Clear();
            roleComboBox.SelectedIndex = -1;
        }
    }
}
