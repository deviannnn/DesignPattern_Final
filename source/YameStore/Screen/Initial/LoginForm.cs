using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public static event EventHandler? ForgotPasswordClicked;
       

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

            if (!AccountController.Authenticate(username, password)) tbxPassword.Text = null;
        }
    }
}
