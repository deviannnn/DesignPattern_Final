using ControlUICustom;
using Microsoft.Office.Interop.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YameStore.Screen.Staff
{
    public partial class CreateStaffDialog : Form
    {
        public CreateStaffDialog()
        {
            InitializeComponent();
            tbxName.SetValidator(new NameValidator());
            tbxGmail.SetValidator(new GmailValidator());
            tbxPhone.SetValidator(new PhoneValidator());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxName.Check() && IsValidGender() && tbxGmail.Check() && tbxPhone.Check() && IsValidAddress())
                {
                    bool genderValue = (cbbGender.Text == "Male");

                    Account account = new Account
                    {
                        Gmail = tbxGmail.Text,
                        Phone = tbxPhone.Text,
                        Name = tbxName.Text,
                        Gender = genderValue,
                        Address = $"{tbxNum.Text}, {tbxAddress.Text}, {tbxWard.Text}, {tbxDistrict.Text}, {tbxCity.Text}"
                    };
                    bool result = AccountController.Create(account);
                    if (result)
                    {
                        MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Account created successfully! But the gmail system sent unsuccessfully", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create New Staff Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidAddress()
        {
            if (string.IsNullOrWhiteSpace(tbxNum.Text) || string.IsNullOrWhiteSpace(tbxAddress.Text)
                || string.IsNullOrWhiteSpace(tbxWard.Text) || string.IsNullOrWhiteSpace(tbxDistrict.Text)
                || string.IsNullOrWhiteSpace(tbxCity.Text))
            {
                throw new Exception("Address fields cannot be empty.");
            }
            return true;
        }

        private bool IsValidGender()
        {
            if (cbbGender.SelectedIndex == -1)
            {
                throw new Exception("Please select a gender.");
            }
            return true;
        }
    }
}
