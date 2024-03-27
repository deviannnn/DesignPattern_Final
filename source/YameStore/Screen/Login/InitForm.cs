using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YameStore.Screen.Login
{
    public partial class InitForm : Form
    {
        private LoginForm loginForm;
        private ForgotPasswordForm forgotPasswordForm;

        public InitForm()
        {
            InitializeComponent();
            loginForm = new LoginForm();
            forgotPasswordForm = new ForgotPasswordForm();

            loginForm.LabelClicked += HandleLoginFormLabelClicked;
            forgotPasswordForm.LabelClicked += HandleForgotPasswordFormLabelClicked;

            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            loginForm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(loginForm);
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;
            loginForm.usernameTbox.Clear();
            loginForm.passwordTbox.Clear();
            loginForm.Show();
        }

        private void ShowForgotPasswordForm()
        {
            forgotPasswordForm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(forgotPasswordForm);
            forgotPasswordForm.FormBorderStyle = FormBorderStyle.None;
            forgotPasswordForm.Dock = DockStyle.Fill;
            forgotPasswordForm.inputResetTbox.Clear();
            forgotPasswordForm.Show();
        }

        private void HandleLoginFormLabelClicked(object sender, EventArgs e)
        {
            ShowForgotPasswordForm();
        }

        private void HandleForgotPasswordFormLabelClicked(object sender, EventArgs e)
        {
            ShowLoginForm();
        }
    }
}
