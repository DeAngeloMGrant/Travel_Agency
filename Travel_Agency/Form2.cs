using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Travel_Agency
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 welcome = new Form1();
            welcome.Show();

            Form2 new_customer = new Form2()
            {
                Visible = false
            };
        }

        private void Package_Click(object sender, EventArgs e)
        {
            Form3 package = new Form3();
            package.Show();

            Form2 new_customer = new Form2()
            {
                Visible = false
            };
        }

        private void Insert_Click(object sender, EventArgs e)
        {
   


                string connectionString = "SERVER=localhost;PORT=3306;DATABASE=travel_agency;UID=travel;PASSWORD=password";
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand("INSERT INTO travel_agency.customer (cust_firstname,cust_lastname,phone_no,nationality,age)VALUES ('" + txtf_name.Text + "','" + txtl_name.Text + "','" + txtphone.Text + "',  '" + cbx_nationality.Text + "', " + txtAge.Text + ")", conn);
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

                //cmd.Parameters.AddWithValue("@fName", txtf_name.Text);
                //cmd.Parameters.AddWithValue("@lName", txtl_name.Text);
                //cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                //cmd.Parameters.AddWithValue("@nation", cbx_nationality.Text);
                //cmd.Parameters.AddWithValue("@age", txtAge.Text);

                //try
                //{
                //    conn.Open();
                //    Console.WriteLine("Open");
                //    Console.ReadLine();
                //    cmd.ExecuteNonQuery();
                //    conn.Close();
                //}
                //catch (MySqlException ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
            
    }

    }

//AND UPDATE address SET address = @address, city = @city, state = @state, zip = @zip WHERE address_id = addressid  