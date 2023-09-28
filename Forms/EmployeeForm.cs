using EmployeeDB.Class;
using EmployeeDB.Forms;
using OrderSystemProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OrderSystemProject.Classes.Employees;

namespace EmployeeDB
{
    public partial class EmployeeForm : Form
    {
        Employees employees = new Employees();
        public EmployeeForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            dataGridViewEmployee.Rows.Clear();
            List<Employee> allEmployees = employees.Searchall();
            foreach (Employee e in allEmployees)
            {
                dataGridViewEmployee.Rows.Add(new object[] { e.EmpNo, e.EmpName, e.Sex, e.Job, e.DOB, e.Locations });
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text == "" || txtEmpName.Text == "" || txtsex.SelectedItem.ToString() == "" || txtLocation.Text == "" || txtJob.Text == "" || txtDOB.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                employees.EmpNo = int.Parse(txtEmpNo.Text);
                employees.EmpName = txtEmpName.Text;
                employees.Sex = txtsex.SelectedItem.ToString();
                employees.Locations = txtLocation.Text;
                employees.Job = txtJob.Text;
                employees.DOB = txtDOB.Text;
                if (employees.Insert())
                {
                    MessageBox.Show("Insert successful!");
                    RefreshData();
                }
                else
                    MessageBox.Show("Insert failed....!");
            }
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text == "" || txtEmpName.Text == "" || txtsex.SelectedItem.ToString() == "" || txtLocation.Text == "" || txtJob.Text == "" || txtDOB.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                employees.EmpNo = int.Parse(txtEmpNo.Text);
                employees.EmpName = txtEmpName.Text;
                employees.Sex = txtsex.SelectedItem.ToString();
                employees.Locations = txtLocation.Text;
                employees.DOB = txtDOB.Text;
                employees.Job = txtJob.Text;
                if (employees.Update())
                {
                    MessageBox.Show("Updated successful!");
                    RefreshData();
                }
                else
                    MessageBox.Show("Update failed....!");
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text == "")
            {
                MessageBox.Show("No EmpNo input");
            }
            else
            {
                employees.EmpNo = int.Parse(txtEmpNo.Text);
                if (employees.Delete())
                {
                    MessageBox.Show("Delete successful!");
                    RefreshData();
                }
                else
                    MessageBox.Show("Delete failed....!");
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text == "")
            {
                MessageBox.Show("No EmpNo input");
            }
            else
            {
                employees.EmpNo = int.Parse(txtEmpNo.Text);
                if (employees.Search())
                {
                    txtEmpNo.Text = employees.EmpNo.ToString();
                    txtEmpName.Text = employees.EmpName;
                    txtsex.Text = employees.Sex;
                    txtLocation.Text = employees.Locations;
                    txtDOB.Text = employees.DOB;
                    txtJob.Text = employees.Job;

                    MessageBox.Show("It is found!");
                }
                else
                {
                    MessageBox.Show("It is not found!");
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            EmployeeReportView employeeReportView = new EmployeeReportView();
            employeeReportView.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AllEmployee allEmployee = new AllEmployee();
            allEmployee.Show();
            this.Close();
        }
    }
}