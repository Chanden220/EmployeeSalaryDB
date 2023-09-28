using EmployeeDB.Class;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User Login = new User();
            Login.UserName = usertxt.Text;
            Login.Password = passtxt.Text;

            if (Login.CheckUser())
            {
                MessageBox.Show("Successful!");
                Main main = new Main();
                main.Show();
            }
            else
            {   //Output
                MessageBox.Show("Log in failed!");

            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
