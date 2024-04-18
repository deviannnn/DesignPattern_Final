using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YameStore.Controllers;

namespace YameStore.Screen.Initial
{
    public partial class LoginForm : Form
    {
        public event EventHandler? ForgotPasswordClicked, SuccessfulLogin;

        public LoginForm()
        {
            InitializeComponent();        
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            ForgotPasswordClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            if (AccountController.Login(username, password))
            {
                SuccessfulLogin?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
