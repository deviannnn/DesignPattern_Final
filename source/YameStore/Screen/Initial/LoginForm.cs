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
    public partial class LoginForm : Form
    {
        public static bool singleHided = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void forgotPasswordBtn_Click(object sender, EventArgs e)
        {
            if (singleHided) Close(); else Hide(); singleHided = true;
            new ForgotPasswordForm().Show();
        }
    }
}
