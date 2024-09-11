using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace Meeting_Room_Reservation
{
    public partial class ReservationReport : Form
    {
        public string username;
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-13AU99U;Initial Catalog=MeetingRoomsReservation;Integrated Security=True");
        public ReservationReport(string user)
        {
            InitializeComponent();
            username = user;
            string sql = "Select * from MeetingDetails where emp_Account = @user";
            SqlCommand meetingDetails = new SqlCommand(sql, connection);
            SqlDataAdapter meetingDetailsadapter = new SqlDataAdapter(meetingDetails);
            DataTable dt = new DataTable();
            connection.Open();
            meetingDetails.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = username;
            meetingDetailsadapter.Fill(dt);
            connection.Close();
            SqlCommand meetingRooms = new SqlCommand("Select * from meetingRoom", connection);
            SqlDataAdapter meetingRoomsadapter = new SqlDataAdapter(meetingRooms);
            DataTable dt2 = new DataTable();
            meetingRoomsadapter.Fill(dt2);


            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            ReportDataSource source2 = new ReportDataSource("DataSet2", dt2);
            reportViewer1.LocalReport.ReportPath = "F:\\Meeting Room Reservation\\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.LocalReport.DataSources.Add(source2);
            reportViewer1.RefreshReport();
        }

        private void ReservationReport_Load(object sender, EventArgs e)
        {

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string sql = "Select * from MeetingDetails where emp_Account = @user";
            SqlCommand meetingDetails = new SqlCommand(sql, connection);
            SqlDataAdapter meetingDetailsadapter = new SqlDataAdapter(meetingDetails);
            DataTable dt = new DataTable();
            connection.Open();
            meetingDetails.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = username;
            meetingDetailsadapter.Fill(dt);
            connection.Close();
            SqlCommand meetingRooms = new SqlCommand("Select * from meetingRoom", connection);
            SqlDataAdapter meetingRoomsadapter = new SqlDataAdapter(meetingRooms);
            DataTable dt2 = new DataTable();
            meetingRoomsadapter.Fill(dt2);
            

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            ReportDataSource source2 = new ReportDataSource("DataSet2", dt2);
            reportViewer1.LocalReport.ReportPath = "F:\\Meeting Room Reservation\\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.LocalReport.DataSources.Add(source2);
            reportViewer1.RefreshReport();
            */
        }
    }
}
