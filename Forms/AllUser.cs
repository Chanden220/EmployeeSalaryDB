using EmployeeDB.Class;
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

namespace EmployeeDB.Forms
{
    public partial class AllUser : Form
    {
        User user = new User();
        public AllUser()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            AllEmployeeDataGrid.Rows.Clear();
            List<User> allUser;

            if (string.IsNullOrEmpty(useridtxt.Text))
            {
                allUser = user.Searchall();
            }
            else
            {
                user.Id = int.Parse(useridtxt.Text);
                allUser = user.Searchone();
            }

            foreach (User e in allUser)
            {
                AllEmployeeDataGrid.Rows.Add(new object[] { e.Id, e.UserName});
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
            if (useridtxt.Text == "")
            {
                MessageBox.Show("No UserNo input");
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
                UserForm useralary = new UserForm(selectedId);

                // Show the other form
                useralary.Show();

                // Close the current form
                this.Close();
            }
        }

        private void AllUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSalaryDataSet2.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.employeeSalaryDataSet2.User);

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
