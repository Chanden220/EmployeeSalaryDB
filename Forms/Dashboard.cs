using EmployeeDB.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EmployeeDB.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void EmployeeCount()
        {
            //Declare
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader sdr;

            //Input
            using (conn = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand("Select count(*) from Employee;", conn);
                //Process
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                sdr = cmd.ExecuteReader();
                sdr.Read();
                //Output
                if (sdr.HasRows)
                    LblEmployee.Text = sdr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void AccountantCount()
        {
            //Declare
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader sdr;

            //Input
            using (conn = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand("Select count(*) from Accountant;", conn);
                //Process
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                sdr = cmd.ExecuteReader();
                sdr.Read();
                //Output
                if (sdr.HasRows)
                    Accountant.Text = sdr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void SalaryCount()
        {
            //Declare
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader sdr;

            //Input
            using (conn = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand("Select sum(NetSalary) from EmployeeSalary;", conn);
                //Process
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                sdr = cmd.ExecuteReader();
                sdr.Read();
                //Output
                if (sdr.HasRows)
                    lblEmployeeSalaryAll.Text = sdr.GetValue(0).ToString() + "$";
            }
            conn.Close();
        }
        private void UserCount()
        {
            //Declare
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader sdr;

            //Input
            using (conn = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand("SELECT count(*) FROM [EmployeeSalary].[dbo].[User]", conn);
                //Process
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                sdr = cmd.ExecuteReader();
                sdr.Read();
                //Output
                if (sdr.HasRows)
                    txtUser.Text = sdr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void PieChart()
        {
            //Declare
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds;

            //Input
            using (conn = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand("Select S.Status,count(E.StatusNo) as StatusCount from EmployeeSalary E left join Status S on  E.StatusNo=S.StatusNo  group by Status;", conn);
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();

                sda.Fill(ds);
                //Process
                chart1.DataSource = ds.Tables[0];
                chart1.Series[0].XValueMember = "Status";
                chart1.Series[0].YValueMembers = "StatusCount";

                //Output
                chart1.Series[0].ChartType = SeriesChartType.Doughnut;
            }
            conn.Close();
        }

        private void DataChart()
        {
            //Declare
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds;
            Title title;
            //Input
            using (conn = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand("Select RemitDate,sum(NetSalary) as NetSalary from EmployeeSalary group by RemitDate;", conn);
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();

                sda.Fill(ds);
                //Process
                chart2.DataSource = ds.Tables[0];
                chart2.Series[0].XValueMember = "RemitDate";
                chart2.Series[0].YValueMembers = "NetSalary";

                //Output
                chart2.Series[0].ChartType = SeriesChartType.Column;
                //Chart Title
                title = new Title();
                title.Font = new Font("Arial", 9, FontStyle.Bold);
                title.Text = "Salary By Month";
                title.ForeColor = Color.Gray;
                this.chart2.Titles.Add(title);

                chart2.Series[0].ChartType = SeriesChartType.Column;//Chart Type
                chart2.Series[0].IsValueShownAsLabel = true;    //Show value
                chart2.Series[0].LabelFormat = ("C");
                chart2.Legends[0].Docking = Docking.Bottom;
                chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                // Disable grid lines on the Y-axis
                chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                conn.Close();
            }
            conn.Close();
        }
        private void LineChart()
        {

            //Declare
            SqlConnection conn;  //Connect Database
            SqlCommand cmd;     //For sql language code
            SqlDataAdapter da;  //Transmit data from database
            DataSet ds;         //Store data table in memory
            Title title;

            //Input
            conn = new SqlConnection(AddConnection.GetConnection());
            conn.Open();
            cmd = new SqlCommand("SELECT SUBSTRING(DATENAME(MONTH, CreateDate), 1, 3) AS Month, COUNT(FullName) AS EmployeeCount FROM Employee GROUP BY DATENAME(MONTH, CreateDate); ", conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();

            //Process
            da.Fill(ds);
            chart3.DataSource = ds.Tables[0]; // Datasource = ds.Table


            //Output
            chart3.Series[0].XValueMember = "Month";       //Set title to Axis X
            chart3.Series[0].YValueMembers = "EmployeeCount";      //Set title to Coordinate Y
            //Chart Title
            title = new Title();
            title.Font = new Font("Arial", 9, FontStyle.Bold);
            title.Text = "New Employee By Month";
            title.ForeColor = Color.Gray;
            this.chart3.Titles.Add(title);

            chart3.Series[0].ChartType = SeriesChartType.Area;//Chart Typ
            chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Disable grid lines on the Y-axis
            chart3.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            conn.Close();
        }
        private void BarChart()
        {

            //Declare
            SqlConnection conn;  //Connect Database
            SqlCommand cmd;     //For sql language code
            SqlDataAdapter da;  //Transmit data from database
            DataSet ds;         //Store data table in memory
            Title title;

            //Input
            conn = new SqlConnection(AddConnection.GetConnection());
            conn.Open();
            cmd = new SqlCommand("select P.Position ,Count(E.PositionNo) as Num from Employee E left join BaseSalary P on E.PositionNo = P.PositionNo group by Position", conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();

            //Process
            da.Fill(ds);
            chart4.DataSource = ds.Tables[0]; // Datasource = ds.Table


            //Output
            chart4.Series[0].XValueMember = "Position";       //Set title to Axis X
            chart4.Series[0].YValueMembers = "Num";      //Set title to Coordinate Y
            //Chart Title
            title = new Title();
            title.Font = new Font("Arial", 9, FontStyle.Bold);
            title.Text = "Employee Position";
            title.ForeColor = Color.Gray;
            this.chart4.Titles.Add(title);

            chart4  .Series[0].ChartType = SeriesChartType.Bar;//Chart Typ
                chart4.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Disable grid lines on the Y-axis
            chart4.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            conn.Close();
        }
        private void DaskBoard_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jkab.EmployeeSalary' table. You can move, or remove it, as needed.
      
            EmployeeCount();
            AccountantCount();
            SalaryCount();
            UserCount();
            PieChart(); 
            DataChart();
            LineChart();
            BarChart();
        }
    }
}