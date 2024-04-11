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

        private void payBtn_Click(object sender, EventArgs e)
        {
            new PayDialog().ShowDialog();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CheckoutDialog().ShowDialog();
        }

        private void exchangesMenuBtn_Click(object sender, EventArgs e)
        {
            new ScanInvoiceDialog().ShowDialog();
        }
    }
}
