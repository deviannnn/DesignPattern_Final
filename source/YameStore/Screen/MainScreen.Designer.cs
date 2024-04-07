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
            this.dashboardBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.analyticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posBtn = new System.Windows.Forms.ToolStripButton();
            this.profileBtn = new System.Windows.Forms.ToolStripButton();
            this.lookupsBtn = new System.Windows.Forms.ToolStripButton();
            this.customersBtn = new System.Windows.Forms.ToolStripButton();
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
            this.dashboardBtn,
            this.posBtn,
            this.profileBtn,
            this.lookupsBtn,
            this.customersBtn});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Padding = new System.Windows.Forms.Padding(1);
            this.navbar.Size = new System.Drawing.Size(192, 744);
            this.navbar.TabIndex = 1;
            this.navbar.Text = "toolStrip1";
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.SystemColors.Control;
            this.dashboardBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analyticsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.dashboardBtn.Image = global::YameStore.Properties.Resources.icons8_store_481;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.dashboardBtn.Size = new System.Drawing.Size(183, 44);
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // analyticsToolStripMenuItem
            // 
            this.analyticsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.analyticsToolStripMenuItem.Image = global::YameStore.Properties.Resources.icons8_bar_chart_48;
            this.analyticsToolStripMenuItem.Name = "analyticsToolStripMenuItem";
            this.analyticsToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.analyticsToolStripMenuItem.Text = "Analytics";
            this.analyticsToolStripMenuItem.Click += new System.EventHandler(this.analyticsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.reportsToolStripMenuItem.Image = global::YameStore.Properties.Resources.icons8_analysis_48;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // posBtn
            // 
            this.posBtn.BackColor = System.Drawing.SystemColors.Control;
            this.posBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.posBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.posBtn.Image = global::YameStore.Properties.Resources.icons8_old_computer_48;
            this.posBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.posBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.posBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.posBtn.Name = "posBtn";
            this.posBtn.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.posBtn.Size = new System.Drawing.Size(183, 44);
            this.posBtn.Text = "POS";
            this.posBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.SystemColors.Control;
            this.profileBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.profileBtn.Image = global::YameStore.Properties.Resources.icons8_admin_settings_male_48;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.profileBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.profileBtn.Size = new System.Drawing.Size(183, 44);
            this.profileBtn.Text = "Profile";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lookupsBtn
            // 
            this.lookupsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lookupsBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lookupsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.lookupsBtn.Image = global::YameStore.Properties.Resources.icons8_magnifying_glass_48;
            this.lookupsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lookupsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lookupsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.lookupsBtn.Name = "lookupsBtn";
            this.lookupsBtn.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.lookupsBtn.Size = new System.Drawing.Size(183, 44);
            this.lookupsBtn.Text = "Lookups";
            this.lookupsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lookupsBtn.Click += new System.EventHandler(this.lookupsBtn_Click);
            // 
            // customersBtn
            // 
            this.customersBtn.BackColor = System.Drawing.SystemColors.Control;
            this.customersBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.customersBtn.Image = global::YameStore.Properties.Resources.icons8_person_48;
            this.customersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customersBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.customersBtn.Size = new System.Drawing.Size(183, 44);
            this.customersBtn.Text = "Customer";
            this.customersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(192, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1322, 744);
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
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip navbar;
        private ToolStripDropDownButton dashboardBtn;
        private ToolStripMenuItem analyticsToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripButton posBtn;
        private ToolStripButton profileBtn;
        private ToolStripButton lookupsBtn;
        private ToolStripButton customersBtn;
        private Panel contentPanel;
    }
}