using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void New_cust_Click(object sender, EventArgs e)
        {
            Form2 new_customer = new Form2();
            new_customer.Show();

            Form1 home = new Form1();
            home.Visible = false;
        }

        private void Curr_cust_Click(object sender, EventArgs e)
        {
            Form5 view_customers = new Form5();
            view_customers.Show();

            Form1 home = new Form1();
            home.Visible = false;
        }
    }
}
