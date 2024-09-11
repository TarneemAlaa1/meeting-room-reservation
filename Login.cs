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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text.Trim().Length == 0 || passwordTxtBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Username/Password is empty " + '\n' + "Please Try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = usernameTxtBox.Text;
                string password = passwordTxtBox.Text;

                string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                string query = "SELECT username,empID FROM Login WHERE username=@user AND pass=@pass;";

                //bool flag = false;


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // add parameters and set their values
                    cmd.Parameters.Add("@user", SqlDbType.VarChar, 20).Value = usernameTxtBox.Text;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20).Value = passwordTxtBox.Text;
                    // open connection
                    conn.Open();
                    // establish data reader
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // if at least one row is returned....   
                        if (dr.Read())
                        {
                            string employeeName = "";
                            string name = "SELECT empName FROM Employee WHERE empID = @empID";
                            using (SqlCommand names = new SqlCommand(name, conn))
                            {
                                // add parameters and set their values
                                names.Parameters.Add("@empID", SqlDbType.Int).Value = dr.GetValue(1);
                                // establish data reader
                                using (SqlDataReader dr2 = names.ExecuteReader())
                                {
                                    // if at least one row is returned....   
                                    if (dr2.Read())
                                    {
                                        employeeName = dr2.GetString(0);
                                    }
                                }

                            }
                            MainPage mp = new MainPage(username);
                            mp.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dr.Close();
                    }
                }
            }
        }
    }
}
