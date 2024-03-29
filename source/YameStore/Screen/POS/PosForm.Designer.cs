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
            this.paymentGbox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.totalamountLabel = new System.Windows.Forms.Label();
            this.voucherDiscountTbox = new System.Windows.Forms.TextBox();
            this.totalAmountTbox = new System.Windows.Forms.TextBox();
            this.membersDiscountTbox = new System.Windows.Forms.TextBox();
            this.membersLabel = new System.Windows.Forms.Label();
            this.subTotalTbox = new System.Windows.Forms.TextBox();
            this.totalDiscountTbox = new System.Windows.Forms.TextBox();
            this.methodsPaySelector = new System.Windows.Forms.ComboBox();
            this.methodsLabel = new System.Windows.Forms.Label();
            this.voucherTbox = new System.Windows.Forms.TextBox();
            this.voucherLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.payBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.membersGbox = new System.Windows.Forms.GroupBox();
            this.checkinBtn = new System.Windows.Forms.Button();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.infoGbox = new System.Windows.Forms.GroupBox();
            this.dateTbox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cashierLabel = new System.Windows.Forms.Label();
            this.cashierTbox = new System.Windows.Forms.TextBox();
            this.detailsLView = new System.Windows.Forms.ListView();
            this.colLView0 = new System.Windows.Forms.ColumnHeader();
            this.colLView1 = new System.Windows.Forms.ColumnHeader();
            this.colLView2 = new System.Windows.Forms.ColumnHeader();
            this.colLView3 = new System.Windows.Forms.ColumnHeader();
            this.colLView4 = new System.Windows.Forms.ColumnHeader();
            this.colLView5 = new System.Windows.Forms.ColumnHeader();
            this.panel5 = new System.Windows.Forms.Panel();
            this.scanTbox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.quantitySelector = new System.Windows.Forms.NumericUpDown();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.paymentGbox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.membersGbox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.infoGbox.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.paymentGbox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(964, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(550, 744);
            this.panel1.TabIndex = 0;
            // 
            // paymentGbox
            // 
            this.paymentGbox.BackColor = System.Drawing.SystemColors.Control;
            this.paymentGbox.Controls.Add(this.tableLayoutPanel1);
            this.paymentGbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentGbox.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.paymentGbox.Location = new System.Drawing.Point(4, 0);
            this.paymentGbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentGbox.Name = "paymentGbox";
            this.paymentGbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentGbox.Size = new System.Drawing.Size(546, 630);
            this.paymentGbox.TabIndex = 1;
            this.paymentGbox.TabStop = false;
            this.paymentGbox.Text = "Payment";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.subtotalLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.discountLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.totalamountLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.voucherDiscountTbox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.totalAmountTbox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.membersDiscountTbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.membersLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.subTotalTbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.totalDiscountTbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.methodsPaySelector, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.methodsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.voucherTbox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.voucherLabel, 0, 5);
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
            // subtotalLabel
            // 
            this.subtotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtotalLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtotalLabel.Location = new System.Drawing.Point(4, 168);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(160, 84);
            this.subtotalLabel.TabIndex = 24;
            this.subtotalLabel.Text = "Sub Total";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discountLabel
            // 
            this.discountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.discountLabel.Location = new System.Drawing.Point(4, 252);
            this.discountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(160, 84);
            this.discountLabel.TabIndex = 25;
            this.discountLabel.Text = "Total Discounts";
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalamountLabel
            // 
            this.totalamountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalamountLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalamountLabel.Location = new System.Drawing.Point(4, 504);
            this.totalamountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalamountLabel.Name = "totalamountLabel";
            this.totalamountLabel.Size = new System.Drawing.Size(160, 89);
            this.totalamountLabel.TabIndex = 33;
            this.totalamountLabel.Text = "Total Amount";
            this.totalamountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // voucherDiscountTbox
            // 
            this.voucherDiscountTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.voucherDiscountTbox.BackColor = System.Drawing.Color.Blue;
            this.voucherDiscountTbox.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.voucherDiscountTbox.ForeColor = System.Drawing.Color.Lime;
            this.voucherDiscountTbox.Location = new System.Drawing.Point(168, 429);
            this.voucherDiscountTbox.Margin = new System.Windows.Forms.Padding(0);
            this.voucherDiscountTbox.Name = "voucherDiscountTbox";
            this.voucherDiscountTbox.ReadOnly = true;
            this.voucherDiscountTbox.Size = new System.Drawing.Size(370, 66);
            this.voucherDiscountTbox.TabIndex = 32;
            this.voucherDiscountTbox.Text = "None";
            this.voucherDiscountTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalAmountTbox
            // 
            this.totalAmountTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totalAmountTbox.BackColor = System.Drawing.Color.Blue;
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
            // membersLabel
            // 
            this.membersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.membersLabel.Location = new System.Drawing.Point(4, 84);
            this.membersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(160, 84);
            this.membersLabel.TabIndex = 37;
            this.membersLabel.Text = "Members %";
            this.membersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subTotalTbox
            // 
            this.subTotalTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.subTotalTbox.BackColor = System.Drawing.Color.Blue;
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
            // methodsPaySelector
            // 
            this.methodsPaySelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.methodsPaySelector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.methodsPaySelector.FormattingEnabled = true;
            this.methodsPaySelector.Items.AddRange(new object[] {
            "Cash",
            "Banking",
            "Momo",
            "ZaloPay"});
            this.methodsPaySelector.Location = new System.Drawing.Point(168, 22);
            this.methodsPaySelector.Margin = new System.Windows.Forms.Padding(0);
            this.methodsPaySelector.Name = "methodsPaySelector";
            this.methodsPaySelector.Size = new System.Drawing.Size(370, 40);
            this.methodsPaySelector.TabIndex = 46;
            this.methodsPaySelector.Text = "Cash";
            // 
            // methodsLabel
            // 
            this.methodsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodsLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.methodsLabel.Location = new System.Drawing.Point(4, 0);
            this.methodsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.methodsLabel.Name = "methodsLabel";
            this.methodsLabel.Size = new System.Drawing.Size(160, 84);
            this.methodsLabel.TabIndex = 47;
            this.methodsLabel.Text = "Methods";
            this.methodsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // voucherLabel
            // 
            this.voucherLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voucherLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.voucherLabel.Location = new System.Drawing.Point(4, 420);
            this.voucherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.voucherLabel.Name = "voucherLabel";
            this.voucherLabel.Size = new System.Drawing.Size(160, 84);
            this.voucherLabel.TabIndex = 31;
            this.voucherLabel.Text = "Voucher";
            this.voucherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
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
            this.panel6.Controls.Add(this.membersGbox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(272, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(692, 135);
            this.panel6.TabIndex = 50;
            // 
            // membersGbox
            // 
            this.membersGbox.BackColor = System.Drawing.SystemColors.Control;
            this.membersGbox.Controls.Add(this.checkinBtn);
            this.membersGbox.Controls.Add(this.txt_hoten);
            this.membersGbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersGbox.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.membersGbox.ForeColor = System.Drawing.Color.Black;
            this.membersGbox.Location = new System.Drawing.Point(4, 0);
            this.membersGbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.membersGbox.Name = "membersGbox";
            this.membersGbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.membersGbox.Size = new System.Drawing.Size(688, 135);
            this.membersGbox.TabIndex = 47;
            this.membersGbox.TabStop = false;
            this.membersGbox.Text = "VIP Members";
            // 
            // checkinBtn
            // 
            this.checkinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkinBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkinBtn.Location = new System.Drawing.Point(501, 59);
            this.checkinBtn.Name = "checkinBtn";
            this.checkinBtn.Size = new System.Drawing.Size(181, 39);
            this.checkinBtn.TabIndex = 24;
            this.checkinBtn.Text = "checkin";
            this.checkinBtn.UseVisualStyleBackColor = true;
            this.checkinBtn.Click += new System.EventHandler(this.checkinBtn_Click);
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
            this.panel3.Controls.Add(this.infoGbox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel3.Size = new System.Drawing.Size(272, 230);
            this.panel3.TabIndex = 49;
            // 
            // infoGbox
            // 
            this.infoGbox.BackColor = System.Drawing.SystemColors.Control;
            this.infoGbox.Controls.Add(this.dateTbox);
            this.infoGbox.Controls.Add(this.dateLabel);
            this.infoGbox.Controls.Add(this.cashierLabel);
            this.infoGbox.Controls.Add(this.cashierTbox);
            this.infoGbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoGbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoGbox.Location = new System.Drawing.Point(0, 0);
            this.infoGbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoGbox.Name = "infoGbox";
            this.infoGbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoGbox.Size = new System.Drawing.Size(272, 226);
            this.infoGbox.TabIndex = 56;
            this.infoGbox.TabStop = false;
            // 
            // dateTbox
            // 
            this.dateTbox.BackColor = System.Drawing.Color.White;
            this.dateTbox.Enabled = false;
            this.dateTbox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dateTbox.Location = new System.Drawing.Point(1, 59);
            this.dateTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTbox.Name = "dateTbox";
            this.dateTbox.ReadOnly = true;
            this.dateTbox.Size = new System.Drawing.Size(270, 39);
            this.dateTbox.TabIndex = 14;
            this.dateTbox.TabStop = false;
            this.dateTbox.Text = "Staff";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(1, 25);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(57, 28);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Date";
            // 
            // cashierLabel
            // 
            this.cashierLabel.AutoSize = true;
            this.cashierLabel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cashierLabel.Location = new System.Drawing.Point(1, 128);
            this.cashierLabel.Name = "cashierLabel";
            this.cashierLabel.Size = new System.Drawing.Size(82, 28);
            this.cashierLabel.TabIndex = 12;
            this.cashierLabel.Text = "Cashier";
            // 
            // cashierTbox
            // 
            this.cashierTbox.BackColor = System.Drawing.Color.White;
            this.cashierTbox.Enabled = false;
            this.cashierTbox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cashierTbox.Location = new System.Drawing.Point(1, 164);
            this.cashierTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierTbox.Name = "cashierTbox";
            this.cashierTbox.ReadOnly = true;
            this.cashierTbox.Size = new System.Drawing.Size(270, 39);
            this.cashierTbox.TabIndex = 8;
            this.cashierTbox.TabStop = false;
            this.cashierTbox.Text = "Staff";
            // 
            // detailsLView
            // 
            this.detailsLView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.detailsLView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLView0,
            this.colLView1,
            this.colLView2,
            this.colLView3,
            this.colLView4,
            this.colLView5});
            this.detailsLView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsLView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detailsLView.FullRowSelect = true;
            this.detailsLView.GridLines = true;
            this.detailsLView.HoverSelection = true;
            this.detailsLView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.detailsLView.LabelWrap = false;
            this.detailsLView.Location = new System.Drawing.Point(0, 295);
            this.detailsLView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailsLView.Name = "detailsLView";
            this.detailsLView.Size = new System.Drawing.Size(964, 449);
            this.detailsLView.TabIndex = 40;
            this.detailsLView.UseCompatibleStateImageBehavior = false;
            this.detailsLView.View = System.Windows.Forms.View.Details;
            this.detailsLView.VirtualListSize = 4;
            // 
            // colLView0
            // 
            this.colLView0.Text = "Code";
            this.colLView0.Width = 132;
            // 
            // colLView1
            // 
            this.colLView1.Text = "Name";
            this.colLView1.Width = 400;
            // 
            // colLView2
            // 
            this.colLView2.Text = "Size";
            this.colLView2.Width = 100;
            // 
            // colLView3
            // 
            this.colLView3.Text = "Quantity";
            this.colLView3.Width = 150;
            // 
            // colLView4
            // 
            this.colLView4.Text = "Unit Price";
            this.colLView4.Width = 150;
            // 
            // colLView5
            // 
            this.colLView5.Text = "Amount";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.scanTbox);
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
            // scanTbox
            // 
            this.scanTbox.BackColor = System.Drawing.Color.White;
            this.scanTbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanTbox.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.scanTbox.Location = new System.Drawing.Point(97, 0);
            this.scanTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scanTbox.MaxLength = 10;
            this.scanTbox.Name = "scanTbox";
            this.scanTbox.PlaceholderText = "Products Code";
            this.scanTbox.Size = new System.Drawing.Size(625, 61);
            this.scanTbox.TabIndex = 21;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(173)))), ((int)(((byte)(55)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.Controls.Add(this.detailsLView);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1536, 800);
            this.Name = "PosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PosForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.paymentGbox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.membersGbox.ResumeLayout(false);
            this.membersGbox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.infoGbox.ResumeLayout(false);
            this.infoGbox.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private GroupBox paymentGbox;
        private Label methodsLabel;
        private TextBox totalAmountTbox;
        private TextBox voucherDiscountTbox;
        private ComboBox methodsPaySelector;
        private Label membersLabel;
        private TextBox totalDiscountTbox;
        private Label discountLabel;
        private TextBox membersDiscountTbox;
        private Label subtotalLabel;
        private TextBox subTotalTbox;
        private TextBox voucherTbox;
        private Label voucherLabel;
        private Label totalamountLabel;
        private Button payBtn;
        private Button cancelBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView detailsLView;
        private ColumnHeader colLView0;
        private ColumnHeader colLView1;
        private ColumnHeader colLView2;
        private ColumnHeader colLView3;
        private ColumnHeader colLView4;
        private Panel panel5;
        private NumericUpDown quantitySelector;
        private TextBox scanTbox;
        private Button addBtn;
        private Button reloadBtn;
        private GroupBox membersGbox;
        private TextBox txt_hoten;
        private Button checkinBtn;
        private Label label1;
        private Panel panel6;
        private Panel panel3;
        private GroupBox infoGbox;
        private TextBox cashierTbox;
        private Label dateLabel;
        private Label cashierLabel;
        private TextBox dateTbox;
        private ColumnHeader colLView5;
    }
}