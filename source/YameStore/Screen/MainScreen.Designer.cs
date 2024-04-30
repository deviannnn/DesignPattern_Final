namespace YameStore.Screen
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navbar = new System.Windows.Forms.ToolStrip();
            this.dashboardTab = new System.Windows.Forms.ToolStripDropDownButton();
            this.analyticsTab = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsTab = new System.Windows.Forms.ToolStripMenuItem();
            this.posTab = new System.Windows.Forms.ToolStripButton();
            this.profileTab = new System.Windows.Forms.ToolStripButton();
            this.lookupsTab = new System.Windows.Forms.ToolStripButton();
            this.customersTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inventoryTab = new System.Windows.Forms.ToolStripButton();
            this.staffTab = new System.Windows.Forms.ToolStripButton();
            this.logoutTab = new System.Windows.Forms.ToolStripButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.navbar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardTab,
            this.posTab,
            this.profileTab,
            this.lookupsTab,
            this.customersTab,
            this.toolStripSeparator1,
            this.inventoryTab,
            this.staffTab,
            this.logoutTab});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Padding = new System.Windows.Forms.Padding(1);
            this.navbar.Size = new System.Drawing.Size(171, 744);
            this.navbar.TabIndex = 1;
            this.navbar.Text = "toolStrip1";
            // 
            // dashboardTab
            // 
            this.dashboardTab.BackColor = System.Drawing.SystemColors.Control;
            this.dashboardTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analyticsTab,
            this.reportsTab});
            this.dashboardTab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.dashboardTab.Image = global::YameStore.Properties.Resources.icons8_store_481;
            this.dashboardTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dashboardTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.dashboardTab.Size = new System.Drawing.Size(162, 52);
            this.dashboardTab.Text = "Dashboard";
            this.dashboardTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // analyticsTab
            // 
            this.analyticsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.analyticsTab.Image = global::YameStore.Properties.Resources.icons8_bar_chart_48;
            this.analyticsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analyticsTab.Name = "analyticsTab";
            this.analyticsTab.Padding = new System.Windows.Forms.Padding(0);
            this.analyticsTab.Size = new System.Drawing.Size(201, 32);
            this.analyticsTab.Tag = "0";
            this.analyticsTab.Text = "Analytics";
            this.analyticsTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analyticsTab.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.analyticsTab.Click += new System.EventHandler(this.ChangeTab_Click);
            // 
            // reportsTab
            // 
            this.reportsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.reportsTab.Image = global::YameStore.Properties.Resources.icons8_analysis_48;
            this.reportsTab.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Padding = new System.Windows.Forms.Padding(0);
            this.reportsTab.Size = new System.Drawing.Size(201, 32);
            this.reportsTab.Tag = "1";
            this.reportsTab.Text = "Reports";
            this.reportsTab.Click += new System.EventHandler(this.ChangeTab_Click);
            // 
            // posTab
            // 
            this.posTab.BackColor = System.Drawing.SystemColors.Control;
            this.posTab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.posTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.posTab.Image = global::YameStore.Properties.Resources.icons8_old_computer_48;
            this.posTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.posTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.posTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.posTab.Name = "posTab";
            this.posTab.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.posTab.Size = new System.Drawing.Size(162, 52);
            this.posTab.Tag = "2";
            this.posTab.Text = "Point of Sale";
            this.posTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.posTab.Click += new System.EventHandler(this.ChangeTab_Click);
            // 
            // profileTab
            // 
            this.profileTab.BackColor = System.Drawing.SystemColors.Control;
            this.profileTab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profileTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.profileTab.Image = global::YameStore.Properties.Resources.icons8_admin_settings_male_48;
            this.profileTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.profileTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.profileTab.Size = new System.Drawing.Size(162, 52);
            this.profileTab.Tag = "3";
            this.profileTab.Text = "Profile";
            this.profileTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileTab.Click += new System.EventHandler(this.ChangeTab_Click);
            // 
            // lookupsTab
            // 
            this.lookupsTab.BackColor = System.Drawing.SystemColors.Control;
            this.lookupsTab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lookupsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.lookupsTab.Image = global::YameStore.Properties.Resources.icons8_magnifying_glass_48;
            this.lookupsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lookupsTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lookupsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.lookupsTab.Name = "lookupsTab";
            this.lookupsTab.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.lookupsTab.Size = new System.Drawing.Size(162, 52);
            this.lookupsTab.Tag = "4";
            this.lookupsTab.Text = "Lookups";
            this.lookupsTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lookupsTab.Click += new System.EventHandler(this.ChangeTab_Click);
            // 
            // customersTab
            // 
            this.customersTab.BackColor = System.Drawing.SystemColors.Control;
            this.customersTab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customersTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.customersTab.Image = global::YameStore.Properties.Resources.icons8_person_48;
            this.customersTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customersTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.customersTab.Size = new System.Drawing.Size(162, 52);
            this.customersTab.Tag = "5";
            this.customersTab.Text = "Customers";
            this.customersTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersTab.Click += new System.EventHandler(this.ChangeTab_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // inventoryTab
            // 
            this.inventoryTab.BackColor = System.Drawing.SystemColors.Control;
            this.inventoryTab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventoryTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.inventoryTab.Image = global::YameStore.Properties.Resources.icons8_product_management_48;
            this.inventoryTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inventoryTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.inventoryTab.Size = new System.Drawing.Size(162, 52);
            this.inventoryTab.Tag = "6";
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryTab.ToolTipText = "Inventory";
            this.inventoryTab.Click += new System.EventHandler(this.ChangeTab_Click);
            // 
            // staffTab
            // 
            this.staffTab.BackColor = System.Drawing.SystemColors.Control;
            this.staffTab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staffTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.staffTab.Image = global::YameStore.Properties.Resources.icons8_people_48;
            this.staffTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.staffTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.staffTab.Name = "staffTab";
            this.staffTab.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.staffTab.Size = new System.Drawing.Size(162, 52);
            this.staffTab.Tag = "7";
            this.staffTab.Text = "Staff";
            this.staffTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffTab.ToolTipText = "Staff";
            this.staffTab.Click += new System.EventHandler(this.ChangeTab_Click);
            // 
            // logoutTab
            // 
            this.logoutTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.logoutTab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutTab.ForeColor = System.Drawing.Color.White;
            this.logoutTab.Image = global::YameStore.Properties.Resources.icons8_log_out_481;
            this.logoutTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logoutTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.logoutTab.Name = "logoutTab";
            this.logoutTab.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.logoutTab.Size = new System.Drawing.Size(162, 52);
            this.logoutTab.Tag = "8";
            this.logoutTab.Text = "Logout";
            this.logoutTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutTab.ToolTipText = "Log out";
            this.logoutTab.Click += new System.EventHandler(this.ChangeTab_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(171, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1343, 744);
            this.contentPanel.TabIndex = 2;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 744);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.navbar);
            this.MinimumSize = new System.Drawing.Size(1536, 800);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip navbar;
        private ToolStripDropDownButton dashboardTab;
        private ToolStripMenuItem analyticsTab;
        private ToolStripMenuItem reportsTab;
        private ToolStripButton posTab;
        private ToolStripButton profileTab;
        private ToolStripButton lookupsTab;
        private ToolStripButton customersTab;
        private Panel contentPanel;
        private ToolStripButton inventoryTab;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton staffTab;
        private ToolStripButton logoutTab;
    }
}