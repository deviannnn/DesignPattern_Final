using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YameStore.Screen.Initial
{
    public partial class InitialScreen : Form
    {
        readonly static LoginForm login = new();
        readonly static ForgotPasswordForm forgotPassword = new();

        public InitialScreen()
        {
            InitializeComponent();
            SetupLoginForm();
        }

        private void SetupLoginForm()
        {
            SetupForm(login);
            login.ForgotPasswordClicked += Trigger_ForgotPasswordClicked;
            login.SuccessfulLogin += Trigger_LoginSuccess;
        }

        private void SetupForgotPasswordForm()
        {
            SetupForm(forgotPassword);
            forgotPassword.BackLoginClicked += Trigger_BackLoginClicked;
        }

        private void SetupForm(Form form)
        {
            form.TopLevel = false;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
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
            Hide();
        }
    }
}