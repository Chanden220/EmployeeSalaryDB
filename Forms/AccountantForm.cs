using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeDB.Class;
using EmployeeDB.Forms;
using OrderSystemProject.Classes;

namespace EmployeeDB
{
    public partial class AccountantForm : Form
    {
        Accountant accountant = new Accountant();
        public AccountantForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            accountant.AccNo = txtAccNo.Text;
            accountant.AccName = txtAccName.Text;
            accountant.Sex = sexCombo.SelectedItem.ToString();
            accountant.DOB = txtDOB.Text;
            accountant.Location = txtLocation.Text;
            if (accountant.Insert())
            {
                MessageBox.Show("Insert sucessful!");
            }
            else
                MessageBox.Show("Insert failed....!");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            accountant.AccNo = txtAccNo.Text;
            accountant.AccName = txtAccName.Text;
            accountant.Sex = sexCombo.SelectedItem.ToString();
            accountant.DOB = txtDOB.Text;
            accountant.Location = txtLocation.Text;
            if (accountant.Update())
            {
                MessageBox.Show("Update sucessful!");
            }
            else
                MessageBox.Show("Update failed....!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            accountant.AccNo = txtAccNo.Text;
            
            if (accountant.Delete())
            {
                MessageBox.Show("Delete sucessful!");
            }
            else
                MessageBox.Show("Delete failed....!");
        }

        private void btnSearch_Click(object sender, EventArgs e)

        {
            accountant.AccNo = txtAccNo.Text;
            if (accountant.Search())
            {

                txtAccNo.Text = accountant.AccNo;
                txtAccName.Text = accountant.AccName;
                sexCombo.Text = accountant.Sex;
                txtDOB.Text = accountant.DOB;
                txtLocation.Text = accountant.Location;

                MessageBox.Show("It is found!");
            }
            else
            {
                MessageBox.Show("It is not found!");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            AccountantReportView accountantReportView = new AccountantReportView();
            accountantReportView.Show();
        }

        private void AccountantForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountantDataSet.Accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.accountantDataSet.Accountant);

        }
    }
}
