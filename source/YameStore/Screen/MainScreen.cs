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
using YameStore.Screen.Members;

namespace YameStore.Screen
{
    public partial class MainScreen : Form
    {
        readonly static LookupsForm lookups = new();
        readonly static MembersForm members = new();
        readonly static AnalyticsForm analytics = new();
        readonly static ReportsForm reports = new();

        public MainScreen()
        {
            InitializeComponent();
        }

        private void SetupLookupsForm()
        {
            SetupForm(lookups);
        }

        private void SetupMembersForm()
        {
            SetupForm(members);
        }

        private void SetupAnalyticsForm()
        {
            SetupForm(analytics);
        }

        private void SetupReportsForm()
        {
            SetupForm(reports);
        }

        private void SetupForm(Form form)
        {
            form.TopLevel = false;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void lookupsBtn_Click(object sender, EventArgs e)
        {
            SetupLookupsForm();
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            SetupMembersForm();
        }

        private void analyticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupAnalyticsForm();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupReportsForm();
        }
    }
}
