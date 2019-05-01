using MySql.Data.MySqlClient;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void services_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=travel_agency;UID=travel;PASSWORD=password";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO travel_agency.package (place,duration)VALUES ('" + cbx_destination.Text + "','" + cbx_duration.Text + "')", conn);
            conn.Open();


            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Form4 services = new Form4();
            services.Show();

            Form3 package = new Form3()
            {
                Visible = false
            };
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 new_customer = new Form2();
            new_customer.Show();

            Form3 package = new Form3()
            {
                Visible = false
            };
        }
    }
}
