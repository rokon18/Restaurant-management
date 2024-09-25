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
    public partial class Adminaddmanger : Form
    {
        public Adminaddmanger()
        {
            InitializeComponent();
        }

        private void dobDtp_ValueChanged(object sender, EventArgs e)
        {

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
