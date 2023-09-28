using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace EmployeeDB.Class
{
    internal class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool CheckUser()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(@"SELECT [Id] FROM [dbo].[User]" +
                      " WHERE Username = @UserName and [Password]=@Password;", conn);

                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    check = true;
                else
                    check = false;
                reader.Close();
            }
            return check;
        }
        public List<User> Searchall()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(@"SELECT [Id],[Username],[Password]" +
                                 "FROM[dbo].[User]", conn);

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                SqlDataReader sqlDr = cmd.ExecuteReader();
                while (sqlDr.Read())
                {
                    User user = new User();
                    user.Id = int.Parse(sqlDr.GetValue(0).ToString());
                    user.UserName= sqlDr.GetValue(1).ToString();
                    user.Password = sqlDr.GetValue(2).ToString();
                    users.Add(user);
                }
                sqlDr.Close();
            }
            return users;
        }
        public List<User> Searchone()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(@"SELECT [Id],[Username],[Password]" +
                                 "FROM[dbo].[User] where Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", Id);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                SqlDataReader sqlDr = cmd.ExecuteReader();
                while (sqlDr.Read())
                {
                    User user = new User();
                    user.Id = int.Parse(sqlDr.GetValue(0).ToString());
                    user.UserName = sqlDr.GetValue(1).ToString();
                    user.Password = sqlDr.GetValue(2).ToString();
                    users.Add(user);
                }
                sqlDr.Close();
            }
            return users;
        }
        public bool Insert()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[User] (Id,Username,Password) VALUES" +
                    "(@id,@Username,@Password)", conn);

                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@Username", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
               

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
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[User]
                                                           SET [Username] = @Username,
                                                                [Password]=@Password
                                                               
                                                           
                                                         WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@Username", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@id", Id);
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
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[User]
                                                  WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", Id);
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
                                 "FROM[dbo].[User] Where Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", Id);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                SqlDataReader sqlDr = cmd.ExecuteReader();
                sqlDr.Read();
                if (sqlDr.HasRows)
                {
                    UserName = sqlDr.GetValue(1).ToString();
                    Password = sqlDr.GetValue(2).ToString();
                   
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
