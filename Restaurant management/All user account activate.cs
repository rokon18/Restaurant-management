using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Restaurant_management
{
    public partial class Customer : Form
    {
        Functions con;

        public Customer()
        {
            InitializeComponent();
            con = new Functions();
            showCustomers(); 
            ConfigureDataGridView(); 
        }

        public void showCustomers()
        {
            try
            {
                string query = "SELECT Username, Email, Contactno, Role, Status FROM SignupTable WHERE Role IN ('Admin', 'Manager', 'Customer')";
                DataTable dt = con.GetData(query);

              
                DataTable displayTable = new DataTable();
                displayTable.Columns.Add("Username");
                displayTable.Columns.Add("Email");
                displayTable.Columns.Add("Contactno");
                displayTable.Columns.Add("Role");
                displayTable.Columns.Add("Status");

                if (dt != null && dt.Rows.Count > 0)
                {
                 
                    foreach (DataRow row in dt.Rows)
                    {
                        
                        DataRow newRow = displayTable.NewRow();
                        newRow["Username"] = row["Username"];
                        newRow["Email"] = row["Email"];
                        newRow["Contactno"] = row["Contactno"];
                        newRow["Role"] = row["Role"];


                        newRow["Status"] = Convert.ToBoolean(row["Status"]) ? "True" : "False";

                   
                        displayTable.Rows.Add(newRow);
                    }

                    dataGridView1.DataSource = displayTable; 
                }
                else
                {
                    MessageBox.Show("No customer data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching customer data: " + ex.Message);
            }
        }

        private void ConfigureDataGridView()
        {
           

           
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Select";
            chk.Name = "chkSelect";
            chk.Width = 50;
            chk.TrueValue = true;
            chk.FalseValue = false;
            dataGridView1.Columns.Add(chk);
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                   
                    if (Convert.ToBoolean(row.Cells["chkSelect"].Value) == true)
                    {
                        string username = row.Cells["Username"].Value.ToString();
                        string query = "UPDATE SignupTable SET Status = 1 WHERE Username = @Username";
                        var parameters = new Dictionary<string, object>
                        {
                            { "@Username", username }
                        };
                        con.setData(query, parameters);
                    }
                }
                MessageBox.Show("Selected accounts have been activated.");
                showCustomers(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    
                    if (Convert.ToBoolean(row.Cells["chkSelect"].Value) == true)
                    {
                        string username = row.Cells["Username"].Value.ToString();
                        string query = "UPDATE SignupTable SET Status = 0 WHERE Username = @Username";
                        var parameters = new Dictionary<string, object>
                        {
                            { "@Username", username }
                        };
                        con.setData(query, parameters); 
                    }
                }
                MessageBox.Show("Selected accounts have been deactivated.");
                showCustomers(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form previousForm = Session.LastForm; 

            if (previousForm != null)
            {
                this.Hide();
                previousForm.Show();
            }
        }

       
    }
}
