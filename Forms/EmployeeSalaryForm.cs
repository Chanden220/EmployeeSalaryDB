using EmployeeDB.Class;
using EmployeeDB.Forms;
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

namespace EmployeeDB
{
    public partial class EmployeeSalaryForm : Form
    {
        Employees employees = new Employees();
        public EmployeeSalaryForm()
        {
            InitializeComponent();
        }
        public EmployeeSalaryForm(int employeeId)
        {
            InitializeComponent();
            txtEmpNum.Text = employeeId.ToString();
            employees.EmpNo = int.Parse(txtEmpNum.Text);
            if (employees.GetSalayData())
            {
                txtEmpNum.Text = employees.EmpNo.ToString();
                txtBaseSala.Text = employees.BaseSalary.ToString();
                
                float Grossalary = employees.BaseSalary + employees.Allowance;
                txtGrossSala.Text = Grossalary.ToString();
                float Salary = 0.0f, Tax = 0.0f;
                Salary = employees.BaseSalary;

                //PROCESS
                if (Salary <= 500) Tax = 150f;
                else if (Salary <= 1000) Tax = 175f;
                else if (Salary <= 1250) Tax = 200f;
                else if (Salary <= 1500) Tax = 225f;
                else if (Salary <= 1750) Tax = 250f;
                else if (Salary <= 2000) Tax = 275f;
                else Tax = 0;
                txtTax.Text = Tax.ToString();
                txtNetSala.Text = (Grossalary - Tax).ToString();
            }
            else
            {
                MessageBox.Show("It is not found!");
            }
        }
        private void btnbilling_Click(object sender, EventArgs e)
        {
            EmployeeSalaryClass employeeSalary = new EmployeeSalaryClass();
            employeeSalary.EmpNo = Convert.ToInt16(txtEmpNum.Text);
            employees.EmpNo = int.Parse(txtEmpNum.Text);
            if (employees.Search())
            {
                employeeSalary.PositionNo = employees.PositionNo;
            }
            employeeSalary.RemitDate = remitdate.Value.ToString("dd-MMM-yyyy");
            employeeSalary.TimeWorkNo = allowanceCombo.SelectedValue.ToString();
            employeeSalary.GroosSalary = float.Parse(txtGrossSala.Text);
            employeeSalary.TaxDeducted = float.Parse(txtTax.Text);
            employeeSalary.NetSalary = float.Parse(txtNetSala.Text);
            employeeSalary.AccountantNo = AccCombo.SelectedValue.ToString();
            employeeSalary.StatusNo = statusCombo.SelectedValue.ToString();
            employeeSalary.PaymentNo = PayCOmbo.SelectedValue.ToString();

            if (employeeSalary.Insert())
            {
                MessageBox.Show("Insert successful!");
                txtEmpNum.Clear();
                txtBaseSala.Clear();
                txtGrossSala.Clear();
                txtTax.Clear();
                txtNetSala.Clear();
                txtEmpNum.Focus();

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Insert failed....!");
            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            AllEmployee main = new AllEmployee();
            main.Show();

        }

        private void btnEmp_Click_1(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();


        }

        private void txtBaseSala_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpNum.Text))
            {
                // EmpNo does not have a value, do nothing
                return;
            }
            employees.EmpNo = int.Parse(txtEmpNum.Text);

                if (employees.GetSalayData())
                {
                    txtEmpNum.Text = employees.EmpNo.ToString();
                    txtBaseSala.Text = employees.BaseSalary.ToString();
                
                   
                
                MessageBox.Show("It is found!");
                }
                else
                {
                    MessageBox.Show("It is not found!");
                }
        }

        private void EmployeeSalary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allEmployeeSalaryDataSet.EmployeeSalaryViews' table. You can move, or remove it, as needed.
            this.employeeSalaryViewsTableAdapter.Fill(this.allEmployeeSalaryDataSet.EmployeeSalaryViews);
            // TODO: This line of code loads data into the 'employeeSalaryDataSet1.Allowance' table. You can move, or remove it, as needed.
            this.allowanceTableAdapter.Fill(this.employeeSalaryDataSet1.Allowance);
            // TODO: This line of code loads data into the 'statuscomboDataSet.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.statuscomboDataSet.Status);
            // TODO: This line of code loads data into the 'accountantDataSet.Accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.accountantDataSet.Accountant);
            // TODO: This line of code loads data into the 'payment.Payment_Method' table. You can move, or remove it, as needed.
            this.payment_MethodTableAdapter.Fill(this.payment.Payment_Method);
            // TODO: This line of code loads data into the 'accountantDataSet2.Accountant' table. You can move, or remove it, as needed.
       



        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            EmployeeSalaryReport employeeSalaryReport = new EmployeeSalaryReport();
            employeeSalaryReport.Show();
         }

        private void txtGrossSala_Click(object sender, EventArgs e)
        {
            float Salary = 0.0f, Tax = 0.0f,Allowance = 0.0f, Grossalary = 0.0f;
            if (allowanceCombo.SelectedValue.ToString() == "AO1")
            {
                Allowance = 30;
                Grossalary = employees.BaseSalary + Allowance;
                Salary = employees.BaseSalary;

                txtGrossSala.Text = Grossalary.ToString();
                //PROCESS
                if (Salary <= 500) Tax = 150f;
                else if (Salary <= 1000) Tax = 175f;
                else if (Salary <= 1250) Tax = 200f;
                else if (Salary <= 1500) Tax = 225f;
                else if (Salary <= 1750) Tax = 250f;
                else if (Salary <= 2000) Tax = 275f;
                else Tax = 0;
                txtNetSala.Text = (Grossalary - Tax).ToString();
                txtTax.Text = Tax.ToString();
            }
            else
            {
                Allowance = 0;
                Grossalary = employees.BaseSalary + Allowance;
                Salary = employees.BaseSalary;

                txtGrossSala.Text = Grossalary.ToString(); 
                //PROCESS
                if (Salary <= 500) Tax = 150f;
                else if (Salary <= 1000) Tax = 175f;
                else if (Salary <= 1250) Tax = 200f;
                else if (Salary <= 1500) Tax = 225f;
                else if (Salary <= 1750) Tax = 250f;
                else if (Salary <= 2000) Tax = 275f;
                else Tax = 0;
                txtNetSala.Text = (Grossalary - Tax).ToString();
                txtTax.Text = Tax.ToString();
            }

        }

        private void allowanceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            float Salary = 0.0f, Tax = 0.0f, Allowance = 0.0f, Grossalary = 0.0f;
            if (allowanceCombo.SelectedValue.ToString() == "AO1")
            {
                Allowance = 30;
                Grossalary = employees.BaseSalary + Allowance;
                Salary = employees.BaseSalary;

                txtGrossSala.Text = Grossalary.ToString();
                //PROCESS
                if (Salary <= 500) Tax = 150f;
                else if (Salary <= 1000) Tax = 175f;
                else if (Salary <= 1250) Tax = 200f;
                else if (Salary <= 1500) Tax = 225f;
                else if (Salary <= 1750) Tax = 250f;
                else if (Salary <= 2000) Tax = 275f;
                else Tax = 0;
                txtNetSala.Text = (Grossalary - Tax).ToString();
                txtTax.Text = Tax.ToString();
            }
            else
            {
                Allowance = 0;
                Grossalary = employees.BaseSalary + Allowance;
                Salary = employees.BaseSalary;

                txtGrossSala.Text = Grossalary.ToString();
                //PROCESS
                if (Salary <= 500) Tax = 150f;
                else if (Salary <= 1000) Tax = 175f;
                else if (Salary <= 1250) Tax = 200f;
                else if (Salary <= 1500) Tax = 225f;
                else if (Salary <= 1750) Tax = 250f;
                else if (Salary <= 2000) Tax = 275f;
                else Tax = 0;
                txtNetSala.Text = (Grossalary - Tax).ToString();
                txtTax.Text = Tax.ToString();
            }
        }
    }
}

