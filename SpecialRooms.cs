using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Room_Reservation
{
    public partial class SpecialRooms : Form
    {
        public int roomID;
        public string username;
        public string userFullName;
        public SpecialRooms(string user)
        {
            InitializeComponent();
            username = user;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            string empName = "SELECT empName FROM Employee WHERE username = @username";

            using (SqlCommand empNames = new SqlCommand(empName, conn))
            {
                empNames.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
                // establish data reader
                using (SqlDataReader dr = empNames.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        userFullName = dr.GetString(0);
                    }
                }
            }
            usernameStrptxtBx.Text = userFullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            roomID = 7;
            ReservationForm f1 = new ReservationForm(roomID, username);
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            roomID = 9;
            ReservationForm f1 = new ReservationForm(roomID, username);
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            roomID = 8;
            ReservationForm f1 = new ReservationForm(roomID, username);
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            roomID = 10;
            ReservationForm f1 = new ReservationForm(roomID, username);
            f1.Show();
            this.Hide();
        }
    }
}
