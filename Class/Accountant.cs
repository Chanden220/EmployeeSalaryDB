using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB.Class
{
    internal class Accountant
    {
        public string AccNo { get; set; }
        public string AccName { get; set; }
        public string Sex { get; set; }
        public string DOB { get; set; }
        public string Location { get
                ; set; }
        public bool Insert()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Accountant] (AccountantNo, AccountantName,Sex,DOB,Locations) VALUES" +
                    "(@AccNo,@AccName,@Sex,@DOB,@Location)", conn);

                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccNo", AccNo);
                cmd.Parameters.AddWithValue("@AccName", AccName);
                cmd.Parameters.AddWithValue("@Sex", Sex);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Location", Location);

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    check = true;
                }
                catch (Exception)
                {
                    check = false;
                }

                return check;
            }
        }
        public bool Update()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Accountant]
                                                           SET [AccountantName] = @AccName,
                                                                [Sex]=@Sex,
                                                                [DOB]=@DOB,[Locations]=@Location
                                                           
                                                         WHERE AccountantNo = @AccNo", conn);
                cmd.Parameters.AddWithValue("@AccNo", AccNo);
                cmd.Parameters.AddWithValue("@AccName", AccName);
                cmd.Parameters.AddWithValue("@Sex", Sex);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Location", Location);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    check = true;
                }
                catch (Exception)
                {
                    check = false;
                }
                return check;
            }

        }
        public bool Delete()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Accountant]
                                                  WHERE AccountantNo = @AccNo", conn);
                cmd.Parameters.AddWithValue("@AccNo", AccNo);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    check = true;
                }
                catch (Exception)
                {
                    check = false;
                }
                return check;
            }
        }
        public bool Search()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(@"SELECT * " +
                                 "FROM[dbo].[Accountant] Where AccountantNo = @AccNo", conn);
                cmd.Parameters.AddWithValue("@AccNo", AccNo);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                SqlDataReader sqlDr = cmd.ExecuteReader();
                sqlDr.Read();
                if (sqlDr.HasRows)
                {
                    AccNo = sqlDr.GetValue(0).ToString();
                    AccName = sqlDr.GetValue(1).ToString();
                    Sex = sqlDr.GetValue(2).ToString();
                    DOB = sqlDr.GetValue(3).ToString();
                    Location = sqlDr.GetValue(4).ToString();
                    check = true;
                }
                else
                {
                    check = false;
                }
                return check;
            }
        }
    }
}
