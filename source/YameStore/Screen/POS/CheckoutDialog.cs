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

namespace YameStore.Screen.POS
{
    public partial class CheckoutDialog : Form
    {
        private ICommand codeCommand;
        private ICommand phoneCommand;
        public Customer CheckoutCustomer { get; private set; }
        public CheckoutDialog()
        {
            InitializeComponent();
            codeCommand = new EnableControlCommand(tbxCode);
            phoneCommand = new EnableControlCommand(tbxPhone);
        }

        private void radCode_CheckedChanged(object sender, EventArgs e)
        {
            if (radCode.Checked)
            {
                codeCommand.On();
                phoneCommand.Off();
            }
        }

        private void radPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (radPhone.Checked)
            {
                phoneCommand.On();
                codeCommand.Off();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string identifier = radPhone.Checked ? tbxPhone.Text : tbxCode.Text;
            int type = radPhone.Checked ? 0 : 1;
            try
            {
                CheckoutCustomer = CustomerController.GetPercentDisount(identifier, type);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Checkout Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public interface ICommand
    {
        void On();
        void Off();
    }

    public class EnableControlCommand : ICommand
    {
        private Control control;

        public EnableControlCommand(Control control)
        {
            this.control = control;
        }

        public void On()
        {
            control.Enabled = true;
            control.BackColor = Color.White;
            control.Focus();
        }

        public void Off()
        {
            control.Enabled = false;
            control.BackColor = Color.LightGray;
            control.Text = null;
        }
    }
}
