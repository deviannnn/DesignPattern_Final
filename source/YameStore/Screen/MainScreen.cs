using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YameStore.Screen.Dashboard;
using YameStore.Screen.Lookups;
using YameStore.Screen.Customers;
using YameStore.Screen.POS;
using YameStore.Screen.Profile;
using YameStore.Screen.Inventory;
using YameStore.Screen.Staff;
using YameStore.Screen.Initial;
using System.Diagnostics;

namespace YameStore.Screen
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void SetupForm(Form form)
        {
            form.TopLevel = false;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void ChangeTab_Click(object sender, EventArgs e)
        {
            var type = int.Parse(((ToolStripItem)sender).Tag.ToString());
            if (type == 0)
                SetupForm(new AnalyticsForm());
            else if (type == 1)
                SetupForm(new ReportsForm());
            else if (type == 2)
                PosForm.Instance.Show();
            else if (type == 3)
                SetupForm(new ProfileForm());
            else if (type == 4)
                SetupForm(new LookupsForm());
            else if (type == 5)
                SetupForm(new CustomersForm());
            else if (type == 6)
                SetupForm(new InventoryForm());
            else if (type == 7)
                SetupForm(new StaffForm());
            else if (type == 8)
            {
                Close();
                InitialScreen.Instance.LogoutAndShow();
            }
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitialScreen.Instance.LogoutAndShow();
        }
    }
}
