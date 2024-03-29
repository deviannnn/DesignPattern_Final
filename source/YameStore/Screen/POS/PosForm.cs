using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YameStore.Screen.POS
{
    public partial class PosForm : Form
    {
        public PosForm()
        {
            InitializeComponent();
        }

        private void checkinBtn_Click(object sender, EventArgs e)
        {
            new CheckinForm().ShowDialog();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            new PayForm().ShowDialog();
        }
    }
}
