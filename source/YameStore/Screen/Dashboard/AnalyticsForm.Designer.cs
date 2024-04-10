namespace YameStore.Screen.Dashboard
{
    partial class AnalyticsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.salesReportBtn = new System.Windows.Forms.Label();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.totalSalesChart = new ScottPlot.WinForms.FormsPlot();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartPanel1 = new System.Windows.Forms.Panel();
            this.chartPanel4 = new System.Windows.Forms.Panel();
            this.tempReportBtn = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.tempChart = new ScottPlot.WinForms.FormsPlot();
            this.chartPanel3 = new System.Windows.Forms.Panel();
            this.productsReportBtn = new System.Windows.Forms.Label();
            this.topProductsLabel = new System.Windows.Forms.Label();
            this.topProductsChart = new ScottPlot.WinForms.FormsPlot();
            this.chartPanel2 = new System.Windows.Forms.Panel();
            this.ordersReportBtn = new System.Windows.Forms.Label();
            this.totalOrdersLabel = new System.Windows.Forms.Label();
            this.totalOrdersChart = new ScottPlot.WinForms.FormsPlot();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.chartPanel1.SuspendLayout();
            this.chartPanel4.SuspendLayout();
            this.chartPanel3.SuspendLayout();
            this.chartPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 130);
            this.panel1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(43, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // salesReportBtn
            // 
            this.salesReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salesReportBtn.AutoSize = true;
            this.salesReportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salesReportBtn.Image = global::YameStore.Properties.Resources.icons8_analysis_32;
            this.salesReportBtn.Location = new System.Drawing.Point(576, 0);
            this.salesReportBtn.Name = "salesReportBtn";
            this.salesReportBtn.Size = new System.Drawing.Size(35, 32);
            this.salesReportBtn.TabIndex = 3;
            this.salesReportBtn.Text = "   ";
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalSalesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.totalSalesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.totalSalesLabel.Location = new System.Drawing.Point(40, 0);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(106, 28);
            this.totalSalesLabel.TabIndex = 5;
            this.totalSalesLabel.Text = "Total sales";
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalSalesChart
            // 
            this.totalSalesChart.DisplayScale = 1.5F;
            this.totalSalesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalSalesChart.Location = new System.Drawing.Point(0, 0);
            this.totalSalesChart.Name = "totalSalesChart";
            this.totalSalesChart.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.totalSalesChart.Size = new System.Drawing.Size(655, 286);
            this.totalSalesChart.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 130);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1322, 614);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // chartPanel1
            // 
            this.chartPanel1.Controls.Add(this.salesReportBtn);
            this.chartPanel1.Controls.Add(this.totalSalesLabel);
            this.chartPanel1.Controls.Add(this.totalSalesChart);
            this.chartPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel1.Location = new System.Drawing.Point(3, 3);
            this.chartPanel1.Name = "chartPanel1";
            this.chartPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.chartPanel1.Size = new System.Drawing.Size(655, 301);
            this.chartPanel1.TabIndex = 6;
            // 
            // chartPanel4
            // 
            this.chartPanel4.Controls.Add(this.tempReportBtn);
            this.chartPanel4.Controls.Add(this.tempLabel);
            this.chartPanel4.Controls.Add(this.tempChart);
            this.chartPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel4.Location = new System.Drawing.Point(664, 310);
            this.chartPanel4.Name = "chartPanel4";
            this.chartPanel4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.chartPanel4.Size = new System.Drawing.Size(655, 301);
            this.chartPanel4.TabIndex = 10;
            // 
            // tempReportBtn
            // 
            this.tempReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tempReportBtn.AutoSize = true;
            this.tempReportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempReportBtn.Image = global::YameStore.Properties.Resources.icons8_analysis_32;
            this.tempReportBtn.Location = new System.Drawing.Point(576, 15);
            this.tempReportBtn.Name = "tempReportBtn";
            this.tempReportBtn.Size = new System.Drawing.Size(35, 32);
            this.tempReportBtn.TabIndex = 3;
            this.tempReportBtn.Text = "   ";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.tempLabel.Location = new System.Drawing.Point(40, 15);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(62, 28);
            this.tempLabel.TabIndex = 5;
            this.tempLabel.Text = "Temp";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tempChart
            // 
            this.tempChart.DisplayScale = 1.5F;
            this.tempChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempChart.Location = new System.Drawing.Point(0, 15);
            this.tempChart.Name = "tempChart";
            this.tempChart.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tempChart.Size = new System.Drawing.Size(655, 286);
            this.tempChart.TabIndex = 4;
            // 
            // chartPanel3
            // 
            this.chartPanel3.Controls.Add(this.productsReportBtn);
            this.chartPanel3.Controls.Add(this.topProductsLabel);
            this.chartPanel3.Controls.Add(this.topProductsChart);
            this.chartPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel3.Location = new System.Drawing.Point(3, 310);
            this.chartPanel3.Name = "chartPanel3";
            this.chartPanel3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.chartPanel3.Size = new System.Drawing.Size(655, 301);
            this.chartPanel3.TabIndex = 9;
            // 
            // productsReportBtn
            // 
            this.productsReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productsReportBtn.AutoSize = true;
            this.productsReportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsReportBtn.Image = global::YameStore.Properties.Resources.icons8_analysis_32;
            this.productsReportBtn.Location = new System.Drawing.Point(576, 15);
            this.productsReportBtn.Name = "productsReportBtn";
            this.productsReportBtn.Size = new System.Drawing.Size(35, 32);
            this.productsReportBtn.TabIndex = 3;
            this.productsReportBtn.Text = "   ";
            // 
            // topProductsLabel
            // 
            this.topProductsLabel.AutoSize = true;
            this.topProductsLabel.BackColor = System.Drawing.Color.Transparent;
            this.topProductsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.topProductsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.topProductsLabel.Location = new System.Drawing.Point(40, 15);
            this.topProductsLabel.Name = "topProductsLabel";
            this.topProductsLabel.Size = new System.Drawing.Size(191, 28);
            this.topProductsLabel.TabIndex = 5;
            this.topProductsLabel.Text = "Top selling products";
            this.topProductsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topProductsChart
            // 
            this.topProductsChart.DisplayScale = 1.5F;
            this.topProductsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topProductsChart.Location = new System.Drawing.Point(0, 15);
            this.topProductsChart.Name = "topProductsChart";
            this.topProductsChart.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.topProductsChart.Size = new System.Drawing.Size(655, 286);
            this.topProductsChart.TabIndex = 4;
            // 
            // chartPanel2
            // 
            this.chartPanel2.Controls.Add(this.ordersReportBtn);
            this.chartPanel2.Controls.Add(this.totalOrdersLabel);
            this.chartPanel2.Controls.Add(this.totalOrdersChart);
            this.chartPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel2.Location = new System.Drawing.Point(664, 3);
            this.chartPanel2.Name = "chartPanel2";
            this.chartPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.chartPanel2.Size = new System.Drawing.Size(655, 301);
            this.chartPanel2.TabIndex = 8;
            // 
            // ordersReportBtn
            // 
            this.ordersReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersReportBtn.AutoSize = true;
            this.ordersReportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersReportBtn.Image = global::YameStore.Properties.Resources.icons8_analysis_32;
            this.ordersReportBtn.Location = new System.Drawing.Point(576, 0);
            this.ordersReportBtn.Name = "ordersReportBtn";
            this.ordersReportBtn.Size = new System.Drawing.Size(35, 32);
            this.ordersReportBtn.TabIndex = 3;
            this.ordersReportBtn.Text = "   ";
            // 
            // totalOrdersLabel
            // 
            this.totalOrdersLabel.AutoSize = true;
            this.totalOrdersLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalOrdersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.totalOrdersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.totalOrdersLabel.Location = new System.Drawing.Point(40, 0);
            this.totalOrdersLabel.Name = "totalOrdersLabel";
            this.totalOrdersLabel.Size = new System.Drawing.Size(119, 28);
            this.totalOrdersLabel.TabIndex = 5;
            this.totalOrdersLabel.Text = "Total orders";
            this.totalOrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalOrdersChart
            // 
            this.totalOrdersChart.DisplayScale = 1.5F;
            this.totalOrdersChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalOrdersChart.Location = new System.Drawing.Point(0, 0);
            this.totalOrdersChart.Name = "totalOrdersChart";
            this.totalOrdersChart.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.totalOrdersChart.Size = new System.Drawing.Size(655, 286);
            this.totalOrdersChart.TabIndex = 4;
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 688);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1322, 744);
            this.Name = "AnalyticsForm";
            this.Text = "Analytics";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.chartPanel1.ResumeLayout(false);
            this.chartPanel1.PerformLayout();
            this.chartPanel4.ResumeLayout(false);
            this.chartPanel4.PerformLayout();
            this.chartPanel3.ResumeLayout(false);
            this.chartPanel3.PerformLayout();
            this.chartPanel2.ResumeLayout(false);
            this.chartPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private ScottPlot.WinForms.FormsPlot totalSalesChart;
        private Panel chartPanel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label totalSalesLabel;
        private PictureBox pictureBox2;
        private Label salesReportBtn;
        private DateTimePicker dateTimePicker1;
        private Panel chartPanel4;
        private ScottPlot.WinForms.FormsPlot tempChart;
        private Label tempReportBtn;
        private Label tempLabel;
        private Panel chartPanel3;
        private ScottPlot.WinForms.FormsPlot topProductsChart;
        private Label productsReportBtn;
        private Label topProductsLabel;
        private Panel chartPanel2;
        private ScottPlot.WinForms.FormsPlot totalOrdersChart;
        private Label ordersReportBtn;
        private Label totalOrdersLabel;
        private DateTimePicker dateTimePicker2;
    }
}