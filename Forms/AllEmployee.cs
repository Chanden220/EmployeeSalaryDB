using OrderSystemProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using static OrderSystemProject.Classes.Employees;
namespace EmployeeDB
{
    public partial class AllEmployee : Form
    {
        Employees employees = new Employees();

        public AllEmployee()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            AllEmployeeDataGrid.Rows.Clear();
            List<Employee> allEmployees;

            if (string.IsNullOrEmpty(EmpIDtxt.Text))
            {
                allEmployees = employees.Searchall();
            }
            else
            {
                employees.EmpNo = int.Parse(EmpIDtxt.Text);
                allEmployees = employees.Searchone();
            }

            foreach (Employee e in allEmployees)
            {
                AllEmployeeDataGrid.Rows.Add(new object[] { e.EmpNo, e.EmpName, e.Sex, e.Job, e.DOB, e.Locations });
            }

            AttachCellClickEvent();
        }

        private void AttachCellClickEvent()
        {
            AllEmployeeDataGrid.CellClick -= AllEmployeeDataGrid_CellClick; // Remove the event handler if already attached
            AllEmployeeDataGrid.CellClick += AllEmployeeDataGrid_CellClick; // Attach the event handler
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (EmpIDtxt.Text == "")
            {
                MessageBox.Show("No EmpNo input");
            }
            else
            {
                RefreshData();
                if (AllEmployeeDataGrid.Rows.Count == 0)
                {
                    MessageBox.Show("It is not found!");
                }
                else
                {
                    MessageBox.Show("It is found!");
                }
            }
        }

        private void AllEmployeeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click was on a valid cell (not the header row or empty row)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the ID column (assuming it's the first column in the grid)
                int selectedId = (int)AllEmployeeDataGrid.Rows[e.RowIndex].Cells[0].Value;

                // Create an instance of the other form
                EmployeeSalaryForm employeeSalary = new EmployeeSalaryForm(selectedId);

                // Show the other form
                employeeSalary.Show();

                // Close the current form
                this.Close();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void AllEmployeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Close();
        }
    }
}
