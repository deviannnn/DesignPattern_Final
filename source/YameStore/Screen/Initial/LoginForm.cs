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
using YameStore.Models;

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
            string username = tbxUsername.Text.Trim();
            string password = tbxPassword.Text.Trim();
            try
            {
                Account? account = AccountController.Authenticate(username, password);
                if (account != null)
                {
                    UserSession.Instance.Login(account);
                    SuccessfulLogin?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
