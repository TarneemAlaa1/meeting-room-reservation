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
    public partial class ReservationForm : Form
    {
        public int roomIDSelected;
        public string username;
        public ReservationForm(int roomID, string user)
        {
            InitializeComponent();
            roomIDSelected = roomID;
            username = user;
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            // Section
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "Select * from Section";
            SqlCommand sections = new SqlCommand(sql, conn);
            conn.Open();
            adapter.SelectCommand = sections;
            adapter.Fill(ds);
            adapter.Dispose();
            sections.Dispose();
            conn.Close();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "sectionID";
            comboBox1.DisplayMember = "sectionName";

            //Equipment
            DataSet ds3 = new DataSet();
            string equipment = "Select * from Equipment";
            SqlCommand equipments = new SqlCommand(equipment, conn);
            conn.Open();
            adapter.SelectCommand = equipments;
            adapter.Fill(ds3);
            adapter.Dispose();
            equipments.Dispose();
            conn.Close();
            checkedListBox1.DataSource = ds3.Tables[0];
            checkedListBox1.ValueMember = "equipmentID";
            checkedListBox1.DisplayMember = "equipmentName";

            //Meeting Type
            DataSet ds4 = new DataSet();
            string meetingType = "Select * from MeetingType";
            SqlCommand meetingTypes = new SqlCommand(meetingType, conn);
            conn.Open();
            adapter.SelectCommand = meetingTypes;
            adapter.Fill(ds4);
            adapter.Dispose();
            equipments.Dispose();
            conn.Close();
            comboBox6.DataSource = ds4.Tables[0];
            comboBox6.ValueMember = "typeNumber";
            comboBox6.DisplayMember = "typeName";

            // Validating Date not earlier than today.
            dateTimePicker1.MinDate = DateTime.Today;

            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            string roomName = "SELECT roomName FROM MeetingRoom WHERE roomID = @roomID";

            using (SqlCommand roomNames = new SqlCommand(roomName, conn))
            {
                roomNames.Parameters.Add("@roomID", SqlDbType.Int).Value = roomIDSelected;
                // establish data reader
                using (SqlDataReader dr = roomNames.ExecuteReader())
                {

                    if (dr.Read())
                    {
                        label5.Text = dr.GetString(0);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Department
            DataSet ds = new DataSet();
            string department = "select * FROM Department d where d.sectionID = @sectionID";
            SqlCommand departments = new SqlCommand(department, conn);
            int sectionID;
            bool parse = Int32.TryParse(comboBox1.SelectedValue.ToString(), out sectionID);
            departments.Parameters.Add(new SqlParameter("@sectionID", sectionID));
            conn.Open();
            adapter.SelectCommand = departments;
            adapter.Fill(ds);
            adapter.Dispose();
            departments.Dispose();
            conn.Close();
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.ValueMember = "departmentID";
            comboBox2.DisplayMember = "departmentName";



            // Timing
            SqlDataAdapter timingAdapter = new SqlDataAdapter();
            DataSet ds2 = new DataSet();
            string starttime = "select * from Timing";
            SqlCommand timings = new SqlCommand(starttime, conn);
            conn.Open();
            timingAdapter.SelectCommand = timings;
            timingAdapter.Fill(ds2);
            timingAdapter.Dispose();
            timings.Dispose();
            conn.Close();
            comboBox4.DataSource = ds2.Tables[0];
            comboBox4.DisplayMember = "starttime";
            comboBox4.ValueMember = "startTimeIndex";




            /*
            SqlDataAdapter timingAdapter2 = new SqlDataAdapter();
            DataSet ds4 = new DataSet();
            string endtime = "select endtime from Timing";
            SqlCommand endtiming = new SqlCommand(endtime, conn);
            conn.Open();
            timingAdapter2.SelectCommand = endtiming;
            timingAdapter2.Fill(ds4);
            timingAdapter2.Dispose();
            endtiming.Dispose();
            conn.Close();
            comboBox5.DataSource = ds4.Tables[0];
            comboBox5.DisplayMember = "endtime";
            comboBox5.ValueMember = "endtimeIndex";
            */

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Employee Names
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string employee = "select * FROM Employee e where e.sectionID = @sectionID AND e.departmentID = @departmentID";
            SqlCommand employees = new SqlCommand(employee, conn);
            int sectionID;
            bool parse1 = Int32.TryParse(comboBox1.SelectedValue.ToString(), out sectionID);
            int departmentID;
            bool parse2 = Int32.TryParse(comboBox2.SelectedValue.ToString(), out departmentID);
            employees.Parameters.Add(new SqlParameter("@sectionID", sectionID));
            employees.Parameters.Add(new SqlParameter("@departmentID", departmentID));
            conn.Open();
            adapter.SelectCommand = employees;
            adapter.Fill(ds);
            adapter.Dispose();
            employees.Dispose();
            conn.Close();
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.ValueMember = "empID";
            comboBox3.DisplayMember = "empName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null || comboBox3.SelectedValue == null ||
                comboBox4.SelectedValue == null || comboBox5.SelectedValue == null || comboBox6.SelectedValue == null ||
                numericUpDown1.Value == 0)
            {
                //button1.Enabled = false;
                MessageBox.Show("Some Fields are empty", "Reservation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                DateTime date = dateTimePicker1.Value;
                string startTime = comboBox4.Text.ToString();
                string endTime = comboBox5.Text.ToString();
                int meetingType = (int)comboBox6.SelectedValue;
                int sectionID = (int)comboBox1.SelectedValue;
                int departmentID = (int)comboBox2.SelectedValue;
                int employeeID = (int)comboBox3.SelectedValue;
                int equipmentID = (int)checkedListBox1.SelectedValue;
                int attendance = Convert.ToInt32(numericUpDown1.Value);
                string outsiders = textBox2.Text.ToString();

                SqlCommand addMeetingDetails = new SqlCommand("addMeetingDetails", conn);
                addMeetingDetails.CommandType = CommandType.StoredProcedure;

                conn.Open();
                addMeetingDetails.Parameters.Add(new SqlParameter("@roomNumber", roomIDSelected));
                addMeetingDetails.Parameters.Add(new SqlParameter("@meetingDate", date));
                addMeetingDetails.Parameters.Add(new SqlParameter("@startTime", startTime));
                addMeetingDetails.Parameters.Add(new SqlParameter("@endTime", endTime));
                addMeetingDetails.Parameters.Add(new SqlParameter("@meetingType", meetingType));
                addMeetingDetails.Parameters.Add(new SqlParameter("@sectionID", sectionID));
                addMeetingDetails.Parameters.Add(new SqlParameter("@departmentID", departmentID));
                addMeetingDetails.Parameters.Add(new SqlParameter("@employeeID", employeeID));
                addMeetingDetails.Parameters.Add(new SqlParameter("@equipment", equipmentID));
                addMeetingDetails.Parameters.Add(new SqlParameter("@attendanceNo", attendance));
                addMeetingDetails.Parameters.Add(new SqlParameter("@outsiderName", outsiders));
                addMeetingDetails.Parameters.Add(new SqlParameter("@username", username));

                addMeetingDetails.ExecuteNonQuery();

                MessageBox.Show("Added Successfully", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                ReservationForm rf = new ReservationForm(roomIDSelected, username);
                rf.Show();
                this.Hide();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string attendance = "SELECT capacity FROM MeetingRoom WHERE roomID = @roomID";
            using (SqlCommand attendanceNo = new SqlCommand(attendance, conn))
            {
                // add parameters and set their values
                attendanceNo.Parameters.Add("@roomID", SqlDbType.Int).Value = roomIDSelected;
                // open connection
                conn.Open();
                // establish data reader
                using (SqlDataReader dr = attendanceNo.ExecuteReader())
                {
                    // if at least one row is returned....   
                    if (dr.Read())
                    {
                        int capacity = (int)dr.GetValue(0);
                        if (numericUpDown1.Value > capacity)
                        {
                            MessageBox.Show($"You have exceeded the room capactiy!\nThe room capacity is {capacity}", "Capacity exceeded !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            numericUpDown1.Value = capacity;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            conn.Open();
            MainPage f1 = new MainPage(username);
            f1.Show();
            this.Hide();
        }
        int index = -1;
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            int index = comboBox4.SelectedIndex;
            if (dateTimePicker1.Value.Date == DateTime.Now)
            {
                for (int i = 0; i < comboBox4.Items.Count; i++)
                {
                    if ((comboBox4.Items[i].ToString()).CompareTo(DateTime.Now.Hour.ToString()) >= 0)
                    {
                        index++;
                        MessageBox.Show("Wrong time !", "Wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            */
            //int startTimeIndex = comboBox4.SelectedIndex;
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlDataAdapter timingAdapter2 = new SqlDataAdapter();
            DataSet ds4 = new DataSet();
            string endtime = "select * from Timing where endTimeIndex > @startTimeIndex";
            SqlCommand endtiming = new SqlCommand(endtime, conn);
            endtiming.Parameters.Add("@startTimeIndex", SqlDbType.Int).Value = index;
            conn.Open();
            timingAdapter2.SelectCommand = endtiming;
            timingAdapter2.Fill(ds4);
            timingAdapter2.Dispose();
            endtiming.Dispose();
            conn.Close();
            comboBox5.DataSource = ds4.Tables[0];
            comboBox5.DisplayMember = "endtime";
            comboBox5.ValueMember = "endtimeIndex";
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string inputStartTime = comboBox4.SelectedValue.ToString();
            string inputEndTime = comboBox5.SelectedValue.ToString();
            string inputDate = dateTimePicker1.Value.ToShortDateString();
            DateTime startTime, endTime;
            startTime = Convert.ToDateTime(inputDate + " " + inputStartTime);
            endTime = Convert.ToDateTime(inputDate + " " + inputEndTime);
            if (endTime <= startTime)
            {
                MessageBox.Show("Wrong time !", "Wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox4.Refresh();
                comboBox5.Refresh();
            }
            */

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date == DateTime.Now.Date)
            {
                for (int i = 0; i < comboBox4.Items.Count; i++)
                {
                    if ((comboBox4.Items[i].ToString()).CompareTo(DateTime.Now.Hour.ToString()) > 0)
                    {
                        index++;
                        //MessageBox.Show("Wrong time !", "Wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // Timing
                string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter timingAdapter = new SqlDataAdapter();
                DataSet ds2 = new DataSet();
                string starttime = "select * from Timing where startTimeIndex >= @index";
                SqlCommand timings = new SqlCommand(starttime, conn);

                conn.Open();
                timings.Parameters.Add("@index", SqlDbType.Int).Value = index;
                timingAdapter.SelectCommand = timings;
                timingAdapter.Fill(ds2);
                timingAdapter.Dispose();
                timings.Dispose();
                conn.Close();
                comboBox4.DataSource = ds2.Tables[0];
                comboBox4.DisplayMember = "starttime";
                comboBox4.ValueMember = "startTimeIndex";
            }
            else
            {
                index = 0;
                string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter timingAdapter = new SqlDataAdapter();
                DataSet ds2 = new DataSet();
                string starttime = "select * from Timing";
                SqlCommand timings = new SqlCommand(starttime, conn);

                conn.Open();
                timingAdapter.SelectCommand = timings;
                timingAdapter.Fill(ds2);
                timingAdapter.Dispose();
                timings.Dispose();
                conn.Close();
                comboBox4.DataSource = ds2.Tables[0];
                comboBox4.DisplayMember = "starttime";
                comboBox4.ValueMember = "startTimeIndex";
            }
        }
    }
}

