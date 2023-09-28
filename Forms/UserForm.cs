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
    public partial class UserForm : Form
    {
        User user = new User();
        public UserForm()
        {
            InitializeComponent();
        }
        public UserForm(int selectId)
        {
            InitializeComponent();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtUserid.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                user.Id = int.Parse(txtUserid.Text);
                user.UserName = txtUsername.Text;
                user.Password = txtPassword.Text;

                if (user.Insert())
                {
                    MessageBox.Show("Insert successful!");
                    
                }
                else
                    MessageBox.Show("Insert failed....!");
            }
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtUserid.Text =="")
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                user.Id = int.Parse(txtUserid.Text);
                user.UserName = txtUsername.Text;
                user.Password = txtPassword.Text;

                if (user.Update())
                {
                    MessageBox.Show("Modify successful!");

                }
                else
                    MessageBox.Show("Modify failed....!");
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (txtUserid.Text == "")
            {
                MessageBox.Show("No ID input");
            }
            else
            {
                user.Id = int.Parse(txtUserid.Text);

                if (user.Delete())
                {
                    MessageBox.Show("Delete successful!");
                   
                }
                else
                    MessageBox.Show("Delete failed....!");
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtUserid.Text == "")
            {
                MessageBox.Show("No Id input");
            }
            else
            {
                user.Id = int.Parse(txtUserid.Text);
                if (user.Search())
                {
                    txtUserid.Text = user.Id.ToString();
                    txtUsername.Text = user.UserName;
                    txtPassword.Text = user.Password;
                    
                    MessageBox.Show("It is found!");
                }
                else
                {
                    MessageBox.Show("It is not found!");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AllUser allUser = new AllUser();
            allUser.Show();
            this.Close();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            UserReportView userReportView = new UserReportView();
            userReportView.Show();
        }
    }
}
