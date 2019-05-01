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
    public partial class Form4 : Form
    {

        public Form4()
        {

            InitializeComponent();

        }
        private void cbx_services_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void done_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=travel_agency;UID=travel;PASSWORD=password";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO travel_agency.services (service_name,departure_city,arrival_city,no_passengers,begin_date,end_date)VALUES(@services, @depart, @arrival, @passengers, @date1, @date2)", conn);

            cmd.Parameters.AddWithValue("@services", cbx_services.Text);
            cmd.Parameters.AddWithValue("@depart", cbx_depart.Text);
            cmd.Parameters.AddWithValue("@arrival", cbx_Arrival.Text);
            cmd.Parameters.AddWithValue("@passengers", txtPassengers.Text);
            cmd.Parameters.AddWithValue("@date1", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@date2", dateTimePicker2.Text);
            conn.Open();

            try
            {

                try
                {
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Service Recorded");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Service Not Recorded");
                    //MessageBox.Show(ex.Message);
                }
                conn.Close();
                cmd = new MySqlCommand("INSERT INTO flight (flight_class, Service_name) VALUES(@class, @services)", conn);
                cmd.Parameters.AddWithValue("@class", cbx_class.Text);
                cmd.Parameters.AddWithValue("@services", cbx_services.Text);
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Flight Booked");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Booking Failed");
                    //MessageBox.Show(ex.Message);
                }
                conn.Close();
                cmd = new MySqlCommand("INSERT INTO bus (Service_name) VALUES(@services)", conn);
                cmd.Parameters.AddWithValue("@services", cbx_services.Text);
                conn.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Flight Booked");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Booking Failed");
                    //MessageBox.Show(ex.Message);
                }
                conn.Close();

                cmd = new MySqlCommand("INSERT INTO train (train_class, Service_name) VALUES(@class, @services)", conn);
                cmd.Parameters.AddWithValue("@class", cbx_class.Text);
                cmd.Parameters.AddWithValue("@services", cbx_services.Text);
                conn.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Flight Booked");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Booking Failed");
                    //MessageBox.Show(ex.Message);
                }
                conn.Close();

                cmd = new MySqlCommand("INSERT INTO car (type,days, Service_name) VALUES(@type,@days, @services)", conn);
                cmd.Parameters.AddWithValue("@type", cbx_type.Text);
                cmd.Parameters.AddWithValue("@days", txtDays.Text);
                cmd.Parameters.AddWithValue("@services", cbx_services.Text);
                conn.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Flight Booked");
                }
                catch (Exception ex)
                {
                   
                }
                conn.Close();

                MessageBox.Show("Congrats, Your Trip Info Has Been Submitted!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Booking Failed");
                MessageBox.Show(ex.Message);
            }

        



            Form1 home = new Form1();
            home.Show();

            Form4 services = new Form4()
            {
                Visible = false
            };
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form3 package = new Form3();
            package.Show();

            Form4 services = new Form4()
            {
                Visible = false
            };
        }

        
    }
}
