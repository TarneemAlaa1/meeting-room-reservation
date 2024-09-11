using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Meeting_Room_Reservation
{
    public partial class MainPage : Form
    {
        public int roomID;
        public string usernameLogin;
        public string userFullName;
        public MainPage(string username)
        {
            InitializeComponent();
            usernameLogin = username;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            string empName = "SELECT empName FROM Employee WHERE username = @username";

            using (SqlCommand empNames = new SqlCommand(empName, conn))
            {
                empNames.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = usernameLogin;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            roomID = 1;
            ReservationForm f1 = new ReservationForm(roomID, usernameLogin);
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            roomID = 2;
            ReservationForm f1 = new ReservationForm(roomID, usernameLogin);
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            roomID = 3;
            ReservationForm f1 = new ReservationForm(roomID, usernameLogin);
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            roomID = 4;
            ReservationForm f1 = new ReservationForm(roomID, usernameLogin);
            f1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            roomID = 5;
            ReservationForm f1 = new ReservationForm(roomID, usernameLogin);
            f1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            roomID = 6;
            ReservationForm f1 = new ReservationForm(roomID, usernameLogin);
            f1.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            SpecialRooms f1 = new SpecialRooms(usernameLogin);
            f1.Show();
            this.Hide();
        }


        private void MainPage_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            string specialuser = "SELECT empID FROM Login WHERE username = @user";

            using (SqlCommand specialusers = new SqlCommand(specialuser, conn))
            {
                specialusers.Parameters.Add("@user", SqlDbType.VarChar).Value = usernameLogin;
                // establish data reader
                using (SqlDataReader dr = specialusers.ExecuteReader())
                {

                    if (dr.Read())
                    {
                        int empID = (int)dr.GetValue(0);
                        if (empID == 2)
                        {
                            button7.Enabled = false;
                        }
                    }
                }
            }
        }

        private void logoutStrpMenuItm_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void reservationsStrpMenuItm_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReservationReport myReserve = new ReservationReport(usernameLogin);
            myReserve.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SearchReservation searchReserve = new SearchReservation();
            searchReserve.Show();
        }
    }
}
