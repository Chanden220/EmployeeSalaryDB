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
    public partial class AccountantReportView : Form
    {
        public AccountantReportView()
        {
            InitializeComponent();
        }

        private void AccountantReportView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountantDataSet.Accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.accountantDataSet.Accountant);

            this.reportViewer1.RefreshReport();
        }
    }
}
