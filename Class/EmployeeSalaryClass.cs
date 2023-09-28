using OrderSystemProject.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB.Class
{
    internal class EmployeeSalaryClass:Employees
    {
        public int EmpNo { get; set; }
        public string RemitDate { get; set; }
        public string PositionNo { get; set; }
        public string TimeWorkNo { get; set; }
        public float GroosSalary { get; set; }
        public float TaxDeducted { get; set; }
        public float NetSalary { get; set; }
        public string AccountantNo { get; set; }
        public string StatusNo { get; set; }
        public string PaymentNo { get; set; }
        public bool Insert()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[EmployeeSalary] (EmpNo, RemitDate, PositionNo, TimeworkNo, GrossSalary, TaxDeducted, NetSalary, AccountantNo, StatusNo, PaymentNo) VALUES" +
                    "(@EmpNo, @RemitDate, @PositionNo, @TimeWorkNo, @GrossSalary, @TaxDeducted, @NetSalary, @AccountantNo, @StatusNo, @PaymentNo)", conn);

                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                cmd.Parameters.AddWithValue("@RemitDate", RemitDate);
                cmd.Parameters.AddWithValue("@PositionNo", PositionNo);
                cmd.Parameters.AddWithValue("@TimeWorkNo", TimeWorkNo);
                cmd.Parameters.AddWithValue("@GrossSalary", GroosSalary);
                cmd.Parameters.AddWithValue("@TaxDeducted", TaxDeducted);
                cmd.Parameters.AddWithValue("@NetSalary", NetSalary);
                cmd.Parameters.AddWithValue("@AccountantNo", AccountantNo);
                cmd.Parameters.AddWithValue("@StatusNo", StatusNo);
                cmd.Parameters.AddWithValue("@PaymentNo", PaymentNo);
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
    }

}
