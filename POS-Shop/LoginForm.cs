using POS_Shop.DB;
using POS_Shop.Models;
using POS_Shop.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop
{
    public partial class LoginForm : Form
    {
        public bool IsLogin { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            onLogin();
        }


        private void onLogin()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "")
            {
                txtUsername.Focus();
                MessageBox.Show("Please enter your username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password == "")
            {
                txtPassword.Focus();
                MessageBox.Show("Please enter your password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserLogin login = new UserLogin(username, password);
                
                if (login.Login())
                {
                    var employee = new Employee().getEmployeeByUsername(txtUsername.Text.Trim());
                    IsLogin = true;
                    Properties.Settings.Default.username = txtUsername.Text;
                    Properties.Settings.Default.password = txtPassword.Text;
                    Properties.Settings.Default.isLogin = true;
                    Properties.Settings.Default.position = employee.Position;
                    Properties.Settings.Default.Save();
                    this.Close();
                }
                else
                {
                    txtUsername.Focus();
                    MessageBox.Show("Your password or username is invalid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            onLogin();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar == 13)
            {
                onLogin();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
