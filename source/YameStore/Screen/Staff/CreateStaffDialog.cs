using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YameStore.Screen.Staff
{
    public partial class CreateStaffDialog : Form
    {
        public CreateStaffDialog()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string gender = tbxGender.Text;
            MessageBox.Show("Hi");
        }
    }
}
