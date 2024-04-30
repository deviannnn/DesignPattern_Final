namespace YameStore.Screen.POS
{
    partial class CheckoutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutDialog));
            this.nameLabel = new System.Windows.Forms.Label();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.dynamicGbox = new System.Windows.Forms.GroupBox();
            this.radPhone = new System.Windows.Forms.RadioButton();
            this.radCode = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCheckout = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCardMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.reissueCardMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckout = new YameStore.ColoringButton.ButtonGradientDark();
            this.dynamicGbox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(106, 226);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 28);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // tbxCode
            // 
            this.tbxCode.BackColor = System.Drawing.Color.White;
            this.tbxCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCode.ForeColor = System.Drawing.Color.Black;
            this.tbxCode.Location = new System.Drawing.Point(188, 57);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(430, 39);
            this.tbxCode.TabIndex = 2;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.ForeColor = System.Drawing.Color.Black;
            this.phoneLabel.Location = new System.Drawing.Point(31, 139);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(140, 28);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone number";
            // 
            // tbxPhone
            // 
            this.tbxPhone.BackColor = System.Drawing.Color.LightGray;
            this.tbxPhone.Enabled = false;
            this.tbxPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPhone.ForeColor = System.Drawing.Color.Black;
            this.tbxPhone.Location = new System.Drawing.Point(188, 134);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(430, 39);
            this.tbxPhone.TabIndex = 4;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.LightGray;
            this.tbxName.Enabled = false;
            this.tbxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxName.ForeColor = System.Drawing.Color.Black;
            this.tbxName.Location = new System.Drawing.Point(188, 221);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(430, 39);
            this.tbxName.TabIndex = 6;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.BackColor = System.Drawing.Color.Transparent;
            this.codeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.codeLabel.ForeColor = System.Drawing.Color.Black;
            this.codeLabel.Location = new System.Drawing.Point(114, 62);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(57, 28);
            this.codeLabel.TabIndex = 5;
            this.codeLabel.Text = "Code";
            // 
            // dynamicGbox
            // 
            this.dynamicGbox.Controls.Add(this.radPhone);
            this.dynamicGbox.Controls.Add(this.radCode);
            this.dynamicGbox.Controls.Add(this.tbxName);
            this.dynamicGbox.Controls.Add(this.tbxCode);
            this.dynamicGbox.Controls.Add(this.codeLabel);
            this.dynamicGbox.Controls.Add(this.nameLabel);
            this.dynamicGbox.Controls.Add(this.tbxPhone);
            this.dynamicGbox.Controls.Add(this.phoneLabel);
            this.dynamicGbox.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dynamicGbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.dynamicGbox.Location = new System.Drawing.Point(12, 78);
            this.dynamicGbox.Name = "dynamicGbox";
            this.dynamicGbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dynamicGbox.Size = new System.Drawing.Size(720, 308);
            this.dynamicGbox.TabIndex = 8;
            this.dynamicGbox.TabStop = false;
            this.dynamicGbox.Text = "Scan to Checkout";
            // 
            // radPhone
            // 
            this.radPhone.AutoSize = true;
            this.radPhone.Location = new System.Drawing.Point(653, 143);
            this.radPhone.Name = "radPhone";
            this.radPhone.Size = new System.Drawing.Size(21, 20);
            this.radPhone.TabIndex = 8;
            this.radPhone.UseVisualStyleBackColor = true;
            this.radPhone.CheckedChanged += new System.EventHandler(this.radPhone_CheckedChanged);
            // 
            // radCode
            // 
            this.radCode.AutoSize = true;
            this.radCode.Checked = true;
            this.radCode.Location = new System.Drawing.Point(651, 66);
            this.radCode.Name = "radCode";
            this.radCode.Size = new System.Drawing.Size(21, 20);
            this.radCode.TabIndex = 7;
            this.radCode.TabStop = true;
            this.radCode.UseVisualStyleBackColor = true;
            this.radCode.CheckedChanged += new System.EventHandler(this.radCode_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCheckout,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCheckout
            // 
            this.menuCheckout.Name = "menuCheckout";
            this.menuCheckout.Size = new System.Drawing.Size(102, 29);
            this.menuCheckout.Text = "&Checkout";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCardMenuBtn,
            this.reissueCardMenuBtn});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.optionsToolStripMenuItem.Text = "O̲ptions";
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
            // btnCheckout
            // 
            this.btnCheckout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckout.BackgroundImage")));
            this.btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(582, 392);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(150, 50);
            this.btnCheckout.TabIndex = 10;
            this.btnCheckout.Text = "CHECKOUT";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // CheckoutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 456);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.dynamicGbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(768, 512);
            this.MinimumSize = new System.Drawing.Size(768, 512);
            this.Name = "CheckoutDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutForm";
            this.dynamicGbox.ResumeLayout(false);
            this.dynamicGbox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label nameLabel;
        private TextBox tbxCode;
        private Label phoneLabel;
        private TextBox tbxPhone;
        private TextBox tbxName;
        private Label codeLabel;
        private GroupBox dynamicGbox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCheckout;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem newCardMenuBtn;
        private ToolStripMenuItem reissueCardMenuBtn;
        private ColoringButton.ButtonGradientDark btnCheckout;
        private RadioButton radPhone;
        private RadioButton radCode;
    }
}