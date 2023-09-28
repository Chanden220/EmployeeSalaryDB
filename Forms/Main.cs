using EmployeeDB.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            AllEmployee employee = new AllEmployee();
            employee.Show();
        }

        private void btnAccountant_Click(object sender, EventArgs e)
        {
            AccountantForm accountantForm = new AccountantForm();
            accountantForm.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AllUser allUser = new AllUser();
            allUser.Show();
        }

        private void btnEmployeeSalary_Click(object sender, EventArgs e)
        {
            EmployeeSalaryForm employeeSalary = new EmployeeSalaryForm();
            employeeSalary.Show();
        }



        private void DaskboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard daskBoard = new Dashboard();
            daskBoard.Show();
        }
    }
}
