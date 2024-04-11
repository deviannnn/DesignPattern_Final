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

namespace YameStore.Screen
{
    public partial class MainScreen : Form
    {
        readonly static AnalyticsForm analytics = new();
        readonly static ReportsForm reports = new();
        readonly static PosForm pos = new();
        readonly static ProfileForm profile = new();
        readonly static LookupsForm lookups = new();
        readonly static CustomersForm members = new();
        readonly static InventoryForm inventory = new();
        readonly static StaffForm staff = new();

        public MainScreen()
        {
            InitializeComponent();
        }

        private void SetupAnalyticsForm()
        {
            SetupForm(analytics);
        }

        private void SetupReportsForm()
        {
            SetupForm(reports);
        }
        
        private void SetupProfileForm()
        {
            SetupForm(profile);
        }

        private void SetupLookupsForm()
        {
            SetupForm(lookups);
        }

        private void SetupCustomersForm()
        {
            SetupForm(members);
        }

        private void SetupInventoryForm()
        {
            SetupForm(inventory);
        }

        private void SetupStaffForm()
        {
            SetupForm(staff);
        }

        private void SetupForm(Form form)
        {
            form.TopLevel = false;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void analyticsTab_Click(object sender, EventArgs e)
        {
            SetupAnalyticsForm();
        }

        private void reportsTab_Click(object sender, EventArgs e)
        {
            SetupReportsForm();
        }

        private void posTab_Click(object sender, EventArgs e)
        {
            pos.Show();
        }

        private void profileTab_Click(object sender, EventArgs e)
        {
            SetupProfileForm();
        }

        private void lookupsTab_Click(object sender, EventArgs e)
        {
            SetupLookupsForm();
        }

        private void customersTab_Click(object sender, EventArgs e)
        {
            SetupCustomersForm();
        }

        private void inventoryTab_Click(object sender, EventArgs e)
        {
            SetupInventoryForm();
        }

        private void staffTab_Click(object sender, EventArgs e)
        {
            SetupStaffForm();
        }
    }
}
