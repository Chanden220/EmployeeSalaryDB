using EmployeeDB.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemProject.Classes
{
    internal class Employees : Person
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public int BaseSalary { get; set; }
        public float Allowance { get; set; }
        public string PositionNo { get; set; }




        public bool Insert()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Employee] (EmpNo, FullName, Sex, DOB, Job, Locations,PositionNo) VALUES" +
                    "(@EmpNo,@EmpName, @Sex, @DOB,@Job,@Locations,@PositionNo)", conn);

                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                cmd.Parameters.AddWithValue("@EmpName", EmpName);
                cmd.Parameters.AddWithValue("@Sex", Sex);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Job", Job);
                cmd.Parameters.AddWithValue("@Locations", Locations);
                cmd.Parameters.AddWithValue("@PositionNo", PositionNo);
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
                conn.Close();
                return check;

            }
        }
        public bool Update()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Employee]
                                                           SET [FullName] = @EmpName
                                                              ,[Sex] = @Sex                                                              
                                                              ,[Locations] = @Location,
                                                               [DOB]=@DOB,[Job]=@Job,
                                                               [PositionNo]=@PositionNo
                                                         WHERE EmpNo = @EmpNo", conn);
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                cmd.Parameters.AddWithValue("@EmpName", EmpName);
                cmd.Parameters.AddWithValue("@Sex", Sex);
                cmd.Parameters.AddWithValue("@Location", Locations);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Job", Job);
                cmd.Parameters.AddWithValue("@PositionNo", PositionNo);

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
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Employee]
                                                  WHERE EmpNo = @EmpNo", conn);
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
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
                SqlCommand cmd = new SqlCommand(@"SELECT [EmpNo],[FullName],[Sex],[DOB],[Job],[Locations],[PositionNo]" +
                                 "FROM[dbo].[Employee] Where EmpNo = @EmpNo", conn);
                cmd.Parameters.AddWithValue("@EmpNo", @EmpNo);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                SqlDataReader sqlDr = cmd.ExecuteReader();
                sqlDr.Read();
                if (sqlDr.HasRows)
                {
                    EmpNo = int.Parse(sqlDr.GetValue(0).ToString());
                    EmpName = sqlDr.GetValue(1).ToString();
                    Sex = sqlDr.GetValue(2).ToString();
                    DOB = sqlDr.GetValue(3).ToString();
                    Job = sqlDr.GetValue(4).ToString();
                    PositionNo = sqlDr.GetValue(6).ToString();
                    Locations = sqlDr.GetValue(5).ToString();
                    check = true;
                }
                else
                {
                    check = false;
                }
                return check;
            }
        }
        public class Employee
        {
            public int EmpNo { get; set; }
            public string EmpName { get; set; }
            public string Sex { get; set; }
            public string DOB { get; set; }
            public string Locations { get; set; }
            public string Job { get; set; }
        }
        public List<Employee> Searchall()
        {
            List<Employee> employeesa = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(@"SELECT [EmpNo],[FullName],[Sex],[DOB],[Job],[Locations]" +
                                 "FROM[dbo].[Employee]", conn);

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                SqlDataReader sqlDr = cmd.ExecuteReader();
                while (sqlDr.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpNo = int.Parse(sqlDr.GetValue(0).ToString());
                    emp.EmpName = sqlDr.GetValue(1).ToString();
                    emp.Sex = sqlDr.GetValue(2).ToString();
                    emp.DOB = sqlDr.GetValue(3).ToString();
                    emp.Job = sqlDr.GetValue(4).ToString();
                    emp.Locations = sqlDr.GetValue(5).ToString();
                    employeesa.Add(emp);
                }
                sqlDr.Close();
            }
            return employeesa;
        }
        public List<Employee> Searchone()
        {
            List<Employee> employeesa = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(@"SELECT [EmpNo],[FullName],[Sex],[DOB],[Job],[Locations]" +
                                "FROM[dbo].[Employee] Where EmpNo = @EmpNo", conn);
                cmd.Parameters.AddWithValue("@EmpNo", @EmpNo);

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                SqlDataReader sqlDr = cmd.ExecuteReader();
                while (sqlDr.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpNo = int.Parse(sqlDr.GetValue(0).ToString());
                    emp.EmpName = sqlDr.GetValue(1).ToString();
                    emp.Sex = sqlDr.GetValue(2).ToString();
                    emp.DOB = sqlDr.GetValue(3).ToString();
                    emp.Job = sqlDr.GetValue(4).ToString();
                    emp.Locations = sqlDr.GetValue(5).ToString();
                    employeesa.Add(emp);
                }
                sqlDr.Close();
                conn.Close();
            }
            return employeesa;
        }
        public bool GetSalayData()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(@"SELECT E.EmpNo, B.BaseSalary
                                      FROM Employee E
                                      INNER JOIN BaseSalary B ON E.PositionNo = B.PositionNo
                                      
                                      WHERE E.EmpNo = @EmpNo", conn);
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                SqlDataReader sqlDr = cmd.ExecuteReader();
                if (sqlDr.HasRows)
                {
                    sqlDr.Read();
                    EmpNo = int.Parse(sqlDr.GetValue(0).ToString());
                    BaseSalary = int.Parse(sqlDr.GetValue(1).ToString());
                    check = true;
                }
                else
                {
                    check = false;
                }
                return check;
                conn.Close();
            }
        }
    }
}
