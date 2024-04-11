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
            this.nameLabel = new System.Windows.Forms.Label();
            this.namecodeTbox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTbox = new System.Windows.Forms.TextBox();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.dynamicBtn = new System.Windows.Forms.Button();
            this.dynamicGbox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkoutMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCardMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.reissueCardMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
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
            // namecodeTbox
            // 
            this.namecodeTbox.BackColor = System.Drawing.Color.White;
            this.namecodeTbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namecodeTbox.ForeColor = System.Drawing.Color.Black;
            this.namecodeTbox.Location = new System.Drawing.Point(188, 57);
            this.namecodeTbox.Name = "namecodeTbox";
            this.namecodeTbox.Size = new System.Drawing.Size(430, 39);
            this.namecodeTbox.TabIndex = 2;
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
            // phoneTbox
            // 
            this.phoneTbox.BackColor = System.Drawing.Color.White;
            this.phoneTbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneTbox.ForeColor = System.Drawing.Color.Black;
            this.phoneTbox.Location = new System.Drawing.Point(188, 134);
            this.phoneTbox.Name = "phoneTbox";
            this.phoneTbox.Size = new System.Drawing.Size(430, 39);
            this.phoneTbox.TabIndex = 4;
            // 
            // nameTbox
            // 
            this.nameTbox.BackColor = System.Drawing.Color.White;
            this.nameTbox.Enabled = false;
            this.nameTbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTbox.ForeColor = System.Drawing.Color.Black;
            this.nameTbox.Location = new System.Drawing.Point(188, 221);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(430, 39);
            this.nameTbox.TabIndex = 6;
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
            // dynamicBtn
            // 
            this.dynamicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.dynamicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dynamicBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dynamicBtn.ForeColor = System.Drawing.Color.White;
            this.dynamicBtn.Location = new System.Drawing.Point(582, 392);
            this.dynamicBtn.Name = "dynamicBtn";
            this.dynamicBtn.Size = new System.Drawing.Size(150, 50);
            this.dynamicBtn.TabIndex = 7;
            this.dynamicBtn.Text = "Check-in";
            this.dynamicBtn.UseVisualStyleBackColor = false;
            // 
            // dynamicGbox
            // 
            this.dynamicGbox.Controls.Add(this.nameTbox);
            this.dynamicGbox.Controls.Add(this.namecodeTbox);
            this.dynamicGbox.Controls.Add(this.codeLabel);
            this.dynamicGbox.Controls.Add(this.nameLabel);
            this.dynamicGbox.Controls.Add(this.phoneTbox);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkoutMenuBtn,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkoutMenuBtn
            // 
            this.checkoutMenuBtn.Name = "checkoutMenuBtn";
            this.checkoutMenuBtn.Size = new System.Drawing.Size(102, 29);
            this.checkoutMenuBtn.Text = "C̲heckout";
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
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 456);
            this.Controls.Add(this.dynamicBtn);
            this.Controls.Add(this.dynamicGbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(768, 512);
            this.MinimumSize = new System.Drawing.Size(768, 512);
            this.Name = "CheckoutForm";
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
        private TextBox namecodeTbox;
        private Label phoneLabel;
        private TextBox phoneTbox;
        private TextBox nameTbox;
        private Label codeLabel;
        private Button dynamicBtn;
        private GroupBox dynamicGbox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem checkoutMenuBtn;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem newCardMenuBtn;
        private ToolStripMenuItem reissueCardMenuBtn;
    }
}