namespace YameStore.Screen.POS
{
    partial class PosForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.voucherDiscountTbox = new System.Windows.Forms.TextBox();
            this.totalAmountTbox = new System.Windows.Forms.TextBox();
            this.membersDiscountTbox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.subTotalTbox = new System.Windows.Forms.TextBox();
            this.totalDiscountTbox = new System.Windows.Forms.TextBox();
            this.cbb_loaithanhtoan = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.voucherTbox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.payBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hotennv = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView_chitiet = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.panel5 = new System.Windows.Forms.Panel();
            this.scanBtn = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.quantitySelector = new System.Windows.Forms.NumericUpDown();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(964, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(550, 744);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(4, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(546, 630);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.voucherDiscountTbox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.totalAmountTbox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.membersDiscountTbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.subTotalTbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.totalDiscountTbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbb_loaithanhtoan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.voucherTbox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 593);
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(4, 168);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 84);
            this.label12.TabIndex = 24;
            this.label12.Text = "Sub Total";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(4, 252);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 84);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total Discounts";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(4, 504);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 89);
            this.label17.TabIndex = 33;
            this.label17.Text = "Total Amount";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // voucherDiscountTbox
            // 
            this.voucherDiscountTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.voucherDiscountTbox.BackColor = System.Drawing.Color.Blue;
            this.voucherDiscountTbox.Enabled = false;
            this.voucherDiscountTbox.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.voucherDiscountTbox.ForeColor = System.Drawing.Color.Lime;
            this.voucherDiscountTbox.Location = new System.Drawing.Point(168, 429);
            this.voucherDiscountTbox.Margin = new System.Windows.Forms.Padding(0);
            this.voucherDiscountTbox.Name = "voucherDiscountTbox";
            this.voucherDiscountTbox.ReadOnly = true;
            this.voucherDiscountTbox.Size = new System.Drawing.Size(370, 66);
            this.voucherDiscountTbox.TabIndex = 32;
            this.voucherDiscountTbox.Text = "0";
            this.voucherDiscountTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalAmountTbox
            // 
            this.totalAmountTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totalAmountTbox.BackColor = System.Drawing.Color.Blue;
            this.totalAmountTbox.Enabled = false;
            this.totalAmountTbox.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalAmountTbox.ForeColor = System.Drawing.Color.Lime;
            this.totalAmountTbox.Location = new System.Drawing.Point(168, 515);
            this.totalAmountTbox.Margin = new System.Windows.Forms.Padding(0);
            this.totalAmountTbox.Name = "totalAmountTbox";
            this.totalAmountTbox.ReadOnly = true;
            this.totalAmountTbox.Size = new System.Drawing.Size(370, 66);
            this.totalAmountTbox.TabIndex = 34;
            this.totalAmountTbox.Text = "0";
            this.totalAmountTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // membersDiscountTbox
            // 
            this.membersDiscountTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.membersDiscountTbox.BackColor = System.Drawing.Color.White;
            this.membersDiscountTbox.Enabled = false;
            this.membersDiscountTbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.membersDiscountTbox.Location = new System.Drawing.Point(168, 106);
            this.membersDiscountTbox.Margin = new System.Windows.Forms.Padding(0);
            this.membersDiscountTbox.Name = "membersDiscountTbox";
            this.membersDiscountTbox.ReadOnly = true;
            this.membersDiscountTbox.Size = new System.Drawing.Size(370, 39);
            this.membersDiscountTbox.TabIndex = 38;
            this.membersDiscountTbox.TabStop = false;
            this.membersDiscountTbox.Text = "0";
            this.membersDiscountTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(4, 84);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 84);
            this.label19.TabIndex = 37;
            this.label19.Text = "Members";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subTotalTbox
            // 
            this.subTotalTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.subTotalTbox.BackColor = System.Drawing.Color.Blue;
            this.subTotalTbox.Enabled = false;
            this.subTotalTbox.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subTotalTbox.ForeColor = System.Drawing.Color.Lime;
            this.subTotalTbox.Location = new System.Drawing.Point(168, 177);
            this.subTotalTbox.Margin = new System.Windows.Forms.Padding(0);
            this.subTotalTbox.Name = "subTotalTbox";
            this.subTotalTbox.ReadOnly = true;
            this.subTotalTbox.Size = new System.Drawing.Size(370, 66);
            this.subTotalTbox.TabIndex = 19;
            this.subTotalTbox.Text = "0";
            this.subTotalTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalDiscountTbox
            // 
            this.totalDiscountTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totalDiscountTbox.BackColor = System.Drawing.Color.Blue;
            this.totalDiscountTbox.Enabled = false;
            this.totalDiscountTbox.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalDiscountTbox.ForeColor = System.Drawing.Color.Lime;
            this.totalDiscountTbox.Location = new System.Drawing.Point(168, 261);
            this.totalDiscountTbox.Margin = new System.Windows.Forms.Padding(0);
            this.totalDiscountTbox.Name = "totalDiscountTbox";
            this.totalDiscountTbox.ReadOnly = true;
            this.totalDiscountTbox.Size = new System.Drawing.Size(370, 66);
            this.totalDiscountTbox.TabIndex = 28;
            this.totalDiscountTbox.Text = "0";
            this.totalDiscountTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbb_loaithanhtoan
            // 
            this.cbb_loaithanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_loaithanhtoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_loaithanhtoan.FormattingEnabled = true;
            this.cbb_loaithanhtoan.Items.AddRange(new object[] {
            "Tiền mặt",
            "ATM"});
            this.cbb_loaithanhtoan.Location = new System.Drawing.Point(168, 22);
            this.cbb_loaithanhtoan.Margin = new System.Windows.Forms.Padding(0);
            this.cbb_loaithanhtoan.Name = "cbb_loaithanhtoan";
            this.cbb_loaithanhtoan.Size = new System.Drawing.Size(370, 40);
            this.cbb_loaithanhtoan.TabIndex = 46;
            this.cbb_loaithanhtoan.Text = "Cash";
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(4, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 84);
            this.label14.TabIndex = 47;
            this.label14.Text = "Methods";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // voucherTbox
            // 
            this.voucherTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.voucherTbox, 2);
            this.voucherTbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.voucherTbox.Location = new System.Drawing.Point(4, 358);
            this.voucherTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.voucherTbox.MaxLength = 18;
            this.voucherTbox.Name = "voucherTbox";
            this.voucherTbox.PlaceholderText = "Voucher Code";
            this.voucherTbox.Size = new System.Drawing.Size(530, 39);
            this.voucherTbox.TabIndex = 2;
            this.voucherTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(4, 420);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 84);
            this.label16.TabIndex = 31;
            this.label16.Text = "Voucher";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cancelBtn);
            this.panel4.Controls.Add(this.payBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(4, 630);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 114);
            this.panel4.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(0, 57);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(546, 57);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(70)))));
            this.payBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.payBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(0, 0);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(546, 57);
            this.payBtn.TabIndex = 0;
            this.payBtn.Text = "PAY";
            this.payBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 230);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 95);
            this.label1.TabIndex = 48;
            this.label1.Text = "SALES INVOICE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(272, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(692, 135);
            this.panel6.TabIndex = 50;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txt_hoten);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(4, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(688, 135);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VIP Members";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(501, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "checkin";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hoten.BackColor = System.Drawing.Color.White;
            this.txt_hoten.Enabled = false;
            this.txt_hoten.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_hoten.Location = new System.Drawing.Point(8, 59);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.ReadOnly = true;
            this.txt_hoten.Size = new System.Drawing.Size(486, 39);
            this.txt_hoten.TabIndex = 23;
            this.txt_hoten.TabStop = false;
            this.txt_hoten.Text = "Walk-in customer";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel3.Size = new System.Drawing.Size(272, 230);
            this.panel3.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_hotennv);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(272, 226);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cashier";
            // 
            // txt_hotennv
            // 
            this.txt_hotennv.BackColor = System.Drawing.Color.White;
            this.txt_hotennv.Enabled = false;
            this.txt_hotennv.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_hotennv.Location = new System.Drawing.Point(1, 164);
            this.txt_hotennv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_hotennv.Name = "txt_hotennv";
            this.txt_hotennv.ReadOnly = true;
            this.txt_hotennv.Size = new System.Drawing.Size(270, 39);
            this.txt_hotennv.TabIndex = 8;
            this.txt_hotennv.TabStop = false;
            this.txt_hotennv.Text = "Staff";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1, 61);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 39);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2024, 3, 29, 0, 0, 0, 0);
            // 
            // listView_chitiet
            // 
            this.listView_chitiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader3});
            this.listView_chitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_chitiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_chitiet.FullRowSelect = true;
            this.listView_chitiet.GridLines = true;
            this.listView_chitiet.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView_chitiet.LabelWrap = false;
            this.listView_chitiet.Location = new System.Drawing.Point(0, 295);
            this.listView_chitiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView_chitiet.Name = "listView_chitiet";
            this.listView_chitiet.Size = new System.Drawing.Size(964, 449);
            this.listView_chitiet.TabIndex = 40;
            this.listView_chitiet.UseCompatibleStateImageBehavior = false;
            this.listView_chitiet.View = System.Windows.Forms.View.Details;
            this.listView_chitiet.VirtualListSize = 4;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã Thanh Toán";
            this.columnHeader6.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sản Phẩm";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Size";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số Lượng";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 150;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.scanBtn);
            this.panel5.Controls.Add(this.addBtn);
            this.panel5.Controls.Add(this.quantitySelector);
            this.panel5.Controls.Add(this.reloadBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 230);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel5.Size = new System.Drawing.Size(964, 65);
            this.panel5.TabIndex = 3;
            // 
            // scanBtn
            // 
            this.scanBtn.BackColor = System.Drawing.Color.White;
            this.scanBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanBtn.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.scanBtn.Location = new System.Drawing.Point(97, 0);
            this.scanBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scanBtn.MaxLength = 10;
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.PlaceholderText = "Products Code";
            this.scanBtn.Size = new System.Drawing.Size(625, 61);
            this.scanBtn.TabIndex = 21;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(173)))), ((int)(((byte)(55)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(722, 0);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(121, 61);
            this.addBtn.TabIndex = 42;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // quantitySelector
            // 
            this.quantitySelector.BackColor = System.Drawing.SystemColors.Control;
            this.quantitySelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.quantitySelector.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantitySelector.Location = new System.Drawing.Point(0, 0);
            this.quantitySelector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantitySelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitySelector.Name = "quantitySelector";
            this.quantitySelector.Size = new System.Drawing.Size(97, 61);
            this.quantitySelector.TabIndex = 20;
            this.quantitySelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantitySelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.reloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.reloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reloadBtn.ForeColor = System.Drawing.Color.White;
            this.reloadBtn.Location = new System.Drawing.Point(843, 0);
            this.reloadBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(121, 61);
            this.reloadBtn.TabIndex = 44;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = false;
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1514, 744);
            this.Controls.Add(this.listView_chitiet);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1536, 800);
            this.Name = "PosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PosForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private GroupBox groupBox2;
        private Label label14;
        private TextBox totalAmountTbox;
        private TextBox voucherDiscountTbox;
        private ComboBox cbb_loaithanhtoan;
        private Label label19;
        private TextBox totalDiscountTbox;
        private Label label13;
        private TextBox membersDiscountTbox;
        private Label label12;
        private TextBox subTotalTbox;
        private TextBox voucherTbox;
        private Label label16;
        private Label label17;
        private Button payBtn;
        private Button cancelBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView listView_chitiet;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private Panel panel5;
        private NumericUpDown quantitySelector;
        private TextBox scanBtn;
        private Button addBtn;
        private Button reloadBtn;
        private GroupBox groupBox3;
        private TextBox txt_hoten;
        private Button button1;
        private Label label1;
        private Panel panel6;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox txt_hotennv;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
    }
}