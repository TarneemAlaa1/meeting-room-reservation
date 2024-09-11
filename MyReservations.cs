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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Meeting_Room_Reservation
{
    public partial class MyReservations : Form
    {
        public string username;
        public MyReservations(string user)
        {
            InitializeComponent();
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "Select * from MeetingDetails where emp_Account = @user";
          
            // My Reservations
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            
            SqlCommand reserve = new SqlCommand(sql, conn);
            conn.Open();
            reserve.Parameters.Add("@user", SqlDbType.VarChar , 50).Value = user;
            adapter.SelectCommand = reserve;
            adapter.Fill(ds);
            adapter.Dispose();
            reserve.Dispose();
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];
            
            /*
            conn.Open();
            using (SqlCommand myReserve = new SqlCommand(sql, conn))
            {
                myReserve.Parameters.Add("@user", SqlDbType.VarChar,50).Value = user;
                // establish data reader
                using (SqlDataReader dr = myReserve.ExecuteReader())
                {

                    if (dr.Read())
                    {
                        dataGridView1.DataSource = dr;
                    }

                }
            }
            conn.Close();
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MyReservations_Load(object sender, EventArgs e)
        {

        }
    }
}
