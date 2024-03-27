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
    public partial class LoginForm : Form
    {
        public event EventHandler LabelClicked;

        public LoginForm()
        {
            InitializeComponent();
        }


        private void forgotPasswordBtn_Click(object sender, EventArgs e)
        {
            LabelClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
