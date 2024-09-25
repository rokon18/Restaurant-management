using PMS;
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
    public partial class Changepassword : Form
    {
        Functions con;
        public Changepassword()
        {
            InitializeComponent();
            con = new Functions();
        }

        private void Backpicture_Click(object sender, EventArgs e)
        {
            if(Login.stack.Count>0)
            {
                Form previousForm = Login.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void showpasswordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordcheckbox.Checked)
            {
                Currentpasswordtxt.UseSystemPasswordChar = false;
                Newpasswordtxt.UseSystemPasswordChar = false;
                Confirmpasswordtxt.UseSystemPasswordChar = false;
            }
            else
            {
                Currentpasswordtxt.UseSystemPasswordChar = true;
                Newpasswordtxt.UseSystemPasswordChar = true;
                Confirmpasswordtxt.UseSystemPasswordChar = true;
            }
        }




       
        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            string username = Usernametxt.Text;
            string currentPassword = Currentpasswordtxt.Text;
            string newPassword = Newpasswordtxt.Text;
            string confirmPassword = Confirmpasswordtxt.Text;

            if (validationInputs(username, currentPassword, newPassword, confirmPassword))
            {
                if (updatePassword(username, currentPassword ,newPassword))
                {
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    
                }
                else
                {
                    MessageBox.Show("Current Password is Incorrect !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private bool validationInputs(string username, string curPass, string newPass, string conPass)
        {
            
            if (username == "" || curPass == "" || newPass == "" || conPass == "")
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (newPass != conPass)
            {
                MessageBox.Show("New Password and Confirm Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }



        private bool updatePassword(string username, string curPass, string newPass)
        {
            string ValidationQuery = "SELECT Password FROM SignupTable WHERE Username = @username";
            var validationParameters = new Dictionary<string, object>
            {
                {"@username", username}

            };
            DataTable parametersResult = con.GetData(ValidationQuery, validationParameters);


            //Update Password
            if (parametersResult.Rows.Count > 0 && parametersResult.Rows[0][0].ToString() == curPass)
            {
                string updatePassQuery = "UPDATE SignupTable SET Password = @newPass WHERE Username = @username AND Password = @curPass";
                var updatePassParam = new Dictionary<string, object>
                {
                    {"@username",username},
                    {"@curPass", curPass},
                    {"@newPass", newPass}
                };
                int rowsAffected = con.setData(updatePassQuery, updatePassParam);
                return rowsAffected > 0;
            }
            return false;
        }
    }
}
