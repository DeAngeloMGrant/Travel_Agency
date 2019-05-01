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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("SERVER=localhost;PORT=3306;DATABASE=travel_agency;UID=travel;PASSWORD=password");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM travel_agency.customer", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "customers");
                dataGridView1.DataSource = ds.Tables["customers"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
