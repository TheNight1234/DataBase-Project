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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Main form = new Customer_Main();
           
            form.Show();

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_login_form form = new Admin_login_form();
        
            form.Show();

            Hide();
        }
    }
}
