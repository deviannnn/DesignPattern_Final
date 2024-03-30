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
            this.exitBtn = new System.Windows.Forms.Button();
            this.payBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.membersGbox = new System.Windows.Forms.GroupBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.infoGbox = new System.Windows.Forms.GroupBox();
            this.dateTbox = new System.Windows.Forms.TextBox();
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
            this.clearCartBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCartMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.newTransMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCardMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.reissueCardMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exchangesMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.paymentGbox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.membersGbox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.infoGbox.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.paymentGbox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(964, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(550, 711);
            this.panel1.TabIndex = 0;
            // 
            // paymentGbox
            // 
            this.paymentGbox.BackColor = System.Drawing.SystemColors.Control;
            this.paymentGbox.Controls.Add(this.tableLayoutPanel1);
            this.paymentGbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentGbox.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.paymentGbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.paymentGbox.Location = new System.Drawing.Point(4, 0);
            this.paymentGbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentGbox.Name = "paymentGbox";
            this.paymentGbox.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.paymentGbox.Size = new System.Drawing.Size(546, 597);
            this.paymentGbox.TabIndex = 1;
            this.paymentGbox.TabStop = false;
            this.paymentGbox.Text = "Payment";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 560);
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtotalLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.subtotalLabel.ForeColor = System.Drawing.Color.Black;
            this.subtotalLabel.Location = new System.Drawing.Point(4, 158);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(161, 79);
            this.subtotalLabel.TabIndex = 24;
            this.subtotalLabel.Text = "Sub Total";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discountLabel
            // 
            this.discountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.discountLabel.ForeColor = System.Drawing.Color.Black;
            this.discountLabel.Location = new System.Drawing.Point(4, 237);
            this.discountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(161, 79);
            this.discountLabel.TabIndex = 25;
            this.discountLabel.Text = "Total Discounts";
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalamountLabel
            // 
            this.totalamountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalamountLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.totalamountLabel.ForeColor = System.Drawing.Color.Black;
            this.totalamountLabel.Location = new System.Drawing.Point(4, 474);
            this.totalamountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalamountLabel.Name = "totalamountLabel";
            this.totalamountLabel.Size = new System.Drawing.Size(161, 86);
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
            this.voucherDiscountTbox.Location = new System.Drawing.Point(169, 401);
            this.voucherDiscountTbox.Margin = new System.Windows.Forms.Padding(0);
            this.voucherDiscountTbox.Name = "voucherDiscountTbox";
            this.voucherDiscountTbox.ReadOnly = true;
            this.voucherDiscountTbox.Size = new System.Drawing.Size(377, 66);
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
            this.totalAmountTbox.Location = new System.Drawing.Point(169, 484);
            this.totalAmountTbox.Margin = new System.Windows.Forms.Padding(0);
            this.totalAmountTbox.Name = "totalAmountTbox";
            this.totalAmountTbox.ReadOnly = true;
            this.totalAmountTbox.Size = new System.Drawing.Size(377, 66);
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
            this.membersDiscountTbox.Location = new System.Drawing.Point(169, 99);
            this.membersDiscountTbox.Margin = new System.Windows.Forms.Padding(0);
            this.membersDiscountTbox.Name = "membersDiscountTbox";
            this.membersDiscountTbox.ReadOnly = true;
            this.membersDiscountTbox.Size = new System.Drawing.Size(377, 39);
            this.membersDiscountTbox.TabIndex = 38;
            this.membersDiscountTbox.TabStop = false;
            this.membersDiscountTbox.Text = "0";
            this.membersDiscountTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // membersLabel
            // 
            this.membersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.membersLabel.ForeColor = System.Drawing.Color.Black;
            this.membersLabel.Location = new System.Drawing.Point(4, 79);
            this.membersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(161, 79);
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
            this.subTotalTbox.Location = new System.Drawing.Point(169, 164);
            this.subTotalTbox.Margin = new System.Windows.Forms.Padding(0);
            this.subTotalTbox.Name = "subTotalTbox";
            this.subTotalTbox.ReadOnly = true;
            this.subTotalTbox.Size = new System.Drawing.Size(377, 66);
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
            this.totalDiscountTbox.Location = new System.Drawing.Point(169, 243);
            this.totalDiscountTbox.Margin = new System.Windows.Forms.Padding(0);
            this.totalDiscountTbox.Name = "totalDiscountTbox";
            this.totalDiscountTbox.ReadOnly = true;
            this.totalDiscountTbox.Size = new System.Drawing.Size(377, 66);
            this.totalDiscountTbox.TabIndex = 28;
            this.totalDiscountTbox.Text = "0";
            this.totalDiscountTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // methodsPaySelector
            // 
            this.methodsPaySelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.methodsPaySelector.BackColor = System.Drawing.Color.White;
            this.methodsPaySelector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.methodsPaySelector.FormattingEnabled = true;
            this.methodsPaySelector.Items.AddRange(new object[] {
            "Cash",
            "Banking",
            "Momo",
            "ZaloPay"});
            this.methodsPaySelector.Location = new System.Drawing.Point(169, 19);
            this.methodsPaySelector.Margin = new System.Windows.Forms.Padding(0);
            this.methodsPaySelector.Name = "methodsPaySelector";
            this.methodsPaySelector.Size = new System.Drawing.Size(377, 40);
            this.methodsPaySelector.TabIndex = 46;
            this.methodsPaySelector.Text = "Cash";
            // 
            // methodsLabel
            // 
            this.methodsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodsLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.methodsLabel.ForeColor = System.Drawing.Color.Black;
            this.methodsLabel.Location = new System.Drawing.Point(4, 0);
            this.methodsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.methodsLabel.Name = "methodsLabel";
            this.methodsLabel.Size = new System.Drawing.Size(161, 79);
            this.methodsLabel.TabIndex = 47;
            this.methodsLabel.Text = "Methods";
            this.methodsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // voucherTbox
            // 
            this.voucherTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.voucherTbox.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.voucherTbox, 2);
            this.voucherTbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.voucherTbox.Location = new System.Drawing.Point(4, 336);
            this.voucherTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.voucherTbox.MaxLength = 18;
            this.voucherTbox.Name = "voucherTbox";
            this.voucherTbox.PlaceholderText = "Voucher Code";
            this.voucherTbox.Size = new System.Drawing.Size(538, 39);
            this.voucherTbox.TabIndex = 2;
            this.voucherTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // voucherLabel
            // 
            this.voucherLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voucherLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.voucherLabel.ForeColor = System.Drawing.Color.Black;
            this.voucherLabel.Location = new System.Drawing.Point(4, 395);
            this.voucherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.voucherLabel.Name = "voucherLabel";
            this.voucherLabel.Size = new System.Drawing.Size(161, 79);
            this.voucherLabel.TabIndex = 31;
            this.voucherLabel.Text = "Voucher";
            this.voucherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exitBtn);
            this.panel4.Controls.Add(this.payBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(4, 597);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 114);
            this.panel4.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(0, 57);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(546, 57);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "NEW";
            this.exitBtn.UseVisualStyleBackColor = false;
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
            this.panel2.Location = new System.Drawing.Point(4, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 230);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 117);
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
            this.panel6.Size = new System.Drawing.Size(688, 113);
            this.panel6.TabIndex = 50;
            // 
            // membersGbox
            // 
            this.membersGbox.BackColor = System.Drawing.SystemColors.Control;
            this.membersGbox.Controls.Add(this.txt_hoten);
            this.membersGbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersGbox.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.membersGbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.membersGbox.Location = new System.Drawing.Point(4, 0);
            this.membersGbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.membersGbox.Name = "membersGbox";
            this.membersGbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.membersGbox.Size = new System.Drawing.Size(684, 113);
            this.membersGbox.TabIndex = 47;
            this.membersGbox.TabStop = false;
            this.membersGbox.Text = "VIP Members";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hoten.BackColor = System.Drawing.Color.White;
            this.txt_hoten.Enabled = false;
            this.txt_hoten.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_hoten.ForeColor = System.Drawing.Color.Black;
            this.txt_hoten.Location = new System.Drawing.Point(8, 47);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.ReadOnly = true;
            this.txt_hoten.Size = new System.Drawing.Size(668, 39);
            this.txt_hoten.TabIndex = 23;
            this.txt_hoten.TabStop = false;
            this.txt_hoten.Text = "Walk-in customer";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.infoGbox);
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
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(272, 113);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cashier";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(8, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(256, 39);
            this.textBox1.TabIndex = 14;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Staff";
            // 
            // infoGbox
            // 
            this.infoGbox.BackColor = System.Drawing.SystemColors.Control;
            this.infoGbox.Controls.Add(this.dateTbox);
            this.infoGbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoGbox.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.infoGbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.infoGbox.Location = new System.Drawing.Point(0, 0);
            this.infoGbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoGbox.Name = "infoGbox";
            this.infoGbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoGbox.Size = new System.Drawing.Size(272, 113);
            this.infoGbox.TabIndex = 56;
            this.infoGbox.TabStop = false;
            this.infoGbox.Text = "Date";
            // 
            // dateTbox
            // 
            this.dateTbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTbox.BackColor = System.Drawing.Color.White;
            this.dateTbox.Enabled = false;
            this.dateTbox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTbox.ForeColor = System.Drawing.Color.Black;
            this.dateTbox.Location = new System.Drawing.Point(8, 47);
            this.dateTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTbox.Name = "dateTbox";
            this.dateTbox.ReadOnly = true;
            this.dateTbox.Size = new System.Drawing.Size(257, 39);
            this.dateTbox.TabIndex = 14;
            this.dateTbox.TabStop = false;
            this.dateTbox.Text = "Staff";
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
            this.detailsLView.Location = new System.Drawing.Point(4, 328);
            this.detailsLView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailsLView.Name = "detailsLView";
            this.detailsLView.Size = new System.Drawing.Size(960, 416);
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
            this.panel5.Controls.Add(this.clearCartBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(4, 263);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel5.Size = new System.Drawing.Size(960, 65);
            this.panel5.TabIndex = 3;
            // 
            // scanTbox
            // 
            this.scanTbox.BackColor = System.Drawing.Color.White;
            this.scanTbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanTbox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scanTbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.scanTbox.Location = new System.Drawing.Point(97, 0);
            this.scanTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scanTbox.MaxLength = 10;
            this.scanTbox.Name = "scanTbox";
            this.scanTbox.PlaceholderText = "Products Code";
            this.scanTbox.Size = new System.Drawing.Size(621, 61);
            this.scanTbox.TabIndex = 21;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(173)))), ((int)(((byte)(55)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(718, 0);
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
            // clearCartBtn
            // 
            this.clearCartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearCartBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.clearCartBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.clearCartBtn.ForeColor = System.Drawing.Color.White;
            this.clearCartBtn.Location = new System.Drawing.Point(839, 0);
            this.clearCartBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearCartBtn.Name = "clearCartBtn";
            this.clearCartBtn.Size = new System.Drawing.Size(121, 61);
            this.clearCartBtn.TabIndex = 44;
            this.clearCartBtn.Text = "Clear Cart";
            this.clearCartBtn.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.aToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.checkoutMenuBtn});
            this.menuStrip1.Location = new System.Drawing.Point(4, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1510, 33);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearCartMenuBtn,
            this.newTransMenuBtn,
            this.exitMenuBtn});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.settingToolStripMenuItem.Text = "S̲etting";
            // 
            // clearCartMenuBtn
            // 
            this.clearCartMenuBtn.Name = "clearCartMenuBtn";
            this.clearCartMenuBtn.ShortcutKeyDisplayString = "Ctrl+C";
            this.clearCartMenuBtn.Size = new System.Drawing.Size(306, 34);
            this.clearCartMenuBtn.Text = "C̲lear Cart";
            // 
            // newTransMenuBtn
            // 
            this.newTransMenuBtn.Name = "newTransMenuBtn";
            this.newTransMenuBtn.ShortcutKeyDisplayString = "Ctrl+N";
            this.newTransMenuBtn.Size = new System.Drawing.Size(306, 34);
            this.newTransMenuBtn.Text = "N̲ew Transaction";
            // 
            // exitMenuBtn
            // 
            this.exitMenuBtn.Name = "exitMenuBtn";
            this.exitMenuBtn.Size = new System.Drawing.Size(306, 34);
            this.exitMenuBtn.Text = "E̲xit";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuBtn,
            this.redoMenuBtn});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.aToolStripMenuItem.Text = "E̲dit";
            // 
            // undoMenuBtn
            // 
            this.undoMenuBtn.Name = "undoMenuBtn";
            this.undoMenuBtn.ShortcutKeyDisplayString = "Ctrl+Z";
            this.undoMenuBtn.Size = new System.Drawing.Size(219, 34);
            this.undoMenuBtn.Text = "U̲ndo";
            // 
            // redoMenuBtn
            // 
            this.redoMenuBtn.Name = "redoMenuBtn";
            this.redoMenuBtn.ShortcutKeyDisplayString = "Ctrl+Y";
            this.redoMenuBtn.Size = new System.Drawing.Size(219, 34);
            this.redoMenuBtn.Text = "R̲edo";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCardMenuBtn,
            this.reissueCardMenuBtn,
            this.toolStripSeparator1,
            this.exchangesMenuBtn});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.toolsToolStripMenuItem.Text = "T̲ools";
            // 
            // newCardMenuBtn
            // 
            this.newCardMenuBtn.Name = "newCardMenuBtn";
            this.newCardMenuBtn.Size = new System.Drawing.Size(287, 34);
            this.newCardMenuBtn.Text = "N̲ew Member Card";
            // 
            // reissueCardMenuBtn
            // 
            this.reissueCardMenuBtn.Name = "reissueCardMenuBtn";
            this.reissueCardMenuBtn.Size = new System.Drawing.Size(287, 34);
            this.reissueCardMenuBtn.Text = "R̲eissue Member Card";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(284, 6);
            // 
            // exchangesMenuBtn
            // 
            this.exchangesMenuBtn.Name = "exchangesMenuBtn";
            this.exchangesMenuBtn.Size = new System.Drawing.Size(287, 34);
            this.exchangesMenuBtn.Text = "E̲xchanges";
            this.exchangesMenuBtn.Click += new System.EventHandler(this.exchangesMenuBtn_Click);
            // 
            // checkoutMenuBtn
            // 
            this.checkoutMenuBtn.Name = "checkoutMenuBtn";
            this.checkoutMenuBtn.Size = new System.Drawing.Size(102, 29);
            this.checkoutMenuBtn.Text = "C̲heckout";
            this.checkoutMenuBtn.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1518, 744);
            this.Controls.Add(this.detailsLView);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1536, 800);
            this.Name = "PosForm";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.infoGbox.ResumeLayout(false);
            this.infoGbox.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button exitBtn;
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
        private Button clearCartBtn;
        private GroupBox membersGbox;
        private TextBox txt_hoten;
        private Label label1;
        private Panel panel6;
        private Panel panel3;
        private GroupBox infoGbox;
        private TextBox dateTbox;
        private ColumnHeader colLView5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem exchangesMenuBtn;
        private ToolStripMenuItem undoMenuBtn;
        private ToolStripMenuItem redoMenuBtn;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem clearCartMenuBtn;
        private ToolStripMenuItem newTransMenuBtn;
        private ToolStripMenuItem exitMenuBtn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem newCardMenuBtn;
        private ToolStripMenuItem reissueCardMenuBtn;
        private ToolStripMenuItem checkoutMenuBtn;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}