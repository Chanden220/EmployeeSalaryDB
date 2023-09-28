using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB.Class
{
    internal class AddConnection
    {
        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["EmployeeSalary"].ToString();
        }
    }
}
