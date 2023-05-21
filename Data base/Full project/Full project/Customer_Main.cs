using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_project
{
    public partial class Customer_Main : Form
    {
        public Customer_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main form = new Main();

            form.Show();

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer_signup form = new Customer_signup();

            form.Show();

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_login_form form = new Customer_login_form();
            form.Show();
            Close();
        }
    }
}
