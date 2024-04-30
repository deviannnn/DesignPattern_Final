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
    public partial class InitialScreen : Form
    {
        private static InitialScreen? instance;
        public static InitialScreen Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InitialScreen();
                }
                return instance;
            }
        }

        private InitialScreen()
        {
            InitializeComponent();
            SetupLoginForm();
        }

        private void SetupLoginForm()
        {
            LoginForm login = new();
            SetupForm(login);
            LoginForm.ForgotPasswordClicked += Trigger_ForgotPasswordClicked;
            AccountController.SuccessfulLogin += Trigger_LoginSuccess;
            AccountController.ActiveLogin += Trigger_ActiveLogin;
        }

        private void SetupForgotPasswordForm()
        {
            ForgotPasswordForm forgotPassword = new();
            SetupForm(forgotPassword);
            forgotPassword.BackLoginClicked += Trigger_BackLoginClicked;
        }

        private void SetupActiveForm()
        {
            ActiveForm activeForm = new();
            SetupForm(activeForm);
            activeForm.lblName.Text = UserSession.Instance.Account.Name;
            activeForm.BackLoginClicked += Trigger_BackLoginClicked;
        }

        private void SetupForm(Form form)
        {
            form.TopLevel = false;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void Trigger_ActiveLogin(object sender, EventArgs e)
        {
            SetupActiveForm();
        }

        private void Trigger_ForgotPasswordClicked(object sender, EventArgs e)
        {
            SetupForgotPasswordForm();
        }

        private void Trigger_BackLoginClicked(object sender, EventArgs e)
        {
            SetupLoginForm();
        }

        private void Trigger_LoginSuccess(object sender, EventArgs e)
        {
            new MainScreen().Show();
            SetupLoginForm();
            Hide();
        }

        public void LogoutAndShow()
        {
            UserSession.Instance.Logout();
            Show();
        }
    }
}