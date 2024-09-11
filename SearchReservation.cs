using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Meeting_Room_Reservation
{
    public partial class SearchReservation : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-13AU99U;Initial Catalog=MeetingRoomsReservation;Integrated Security=True");
        public SearchReservation()
        {
            InitializeComponent();
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            comboBox1.SelectedIndex = -1;

            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataSet ds = new System.Data.DataSet();
            string sql = "Select * from MeetingRoom";
            SqlCommand sections = new SqlCommand(sql, connection);
            conn.Open();
            adapter.SelectCommand = sections;
            adapter.Fill(ds);
            adapter.Dispose();
            sections.Dispose();
            conn.Close();
            
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "roomID";
            comboBox1.DisplayMember = "roomName";
            comboBox1.SelectedIndex = -1;
        }

        private void SearchReservation_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                string sql = "Select * from MeetingDetails where meetingDate = @dateChosen";
                DateTime dateChosen = (DateTime)dateTimePicker1.Value;
                SqlCommand meetingDate = new SqlCommand(sql, connection);
                SqlDataAdapter meetingDateadapter = new SqlDataAdapter(meetingDate);
                DataTable dt = new DataTable();
                connection.Open();
                meetingDate.Parameters.Add("@dateChosen", SqlDbType.Date, 50).Value = dateChosen.Date; ;
                meetingDateadapter.Fill(dt);
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
            else
            {
                string sql2 = "Select * from MeetingDetails where meetingDate = @dateChosen and roomID = @roomID";
                DateTime dateChosen = (DateTime)dateTimePicker1.Value;
                SqlCommand meetingDate = new SqlCommand(sql2, connection);
                SqlDataAdapter meetingDateadapter = new SqlDataAdapter(meetingDate);
                DataTable dt = new DataTable();
                connection.Open();
                meetingDate.Parameters.Add("@dateChosen", SqlDbType.Date, 50).Value = dateChosen.Date;
                meetingDate.Parameters.Add("@roomID", SqlDbType.Int).Value = comboBox1.SelectedIndex + 1;
                meetingDateadapter.Fill(dt);
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
        }
            
     }
}


