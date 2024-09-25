using PMS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
               
                string query = "SELECT Firstname, lastname, Username, email, Contactno FROM SignupTable WHERE Role = 'Customer'";
                DataTable dt = con.GetData(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                   
                    Console.WriteLine("Number of rows fetched: " + dt.Rows.Count);


                    dataGridView1.DataSource = dt;
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
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.GridColor = Color.Black;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Login.stack.Count > 0)
            {
                Form previousForm = Login.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }
    }
}
