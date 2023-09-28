using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDB.Forms
{
    public partial class EmployeeReportView : Form
    {
        public EmployeeReportView()
        {
            InitializeComponent();
        }

        private void EmployeeReportView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSalaryDataSet.EmployeeSalary' table. You can move, or remove it, as needed.
            this.employeeSalaryTableAdapter.Fill(this.employeeSalaryDataSet.EmployeeSalary);
            // TODO: This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

            this.reportViewer1.RefreshReport();
        }
    }
}
