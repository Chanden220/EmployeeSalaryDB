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
    public partial class EmployeeSalaryReport : Form
    {
        public EmployeeSalaryReport()
        {
            InitializeComponent();
        }

        private void EmployeeSalaryReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allEmployeeSalaryDataSet.EmployeeSalaryViews' table. You can move, or remove it, as needed.
            this.employeeSalaryViewsTableAdapter.Fill(this.allEmployeeSalaryDataSet.EmployeeSalaryViews);

            this.reportViewer1.RefreshReport();
        }
    }
}
