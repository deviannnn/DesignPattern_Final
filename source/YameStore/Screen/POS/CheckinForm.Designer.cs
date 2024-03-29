namespace YameStore.Screen.POS
{
    partial class CheckinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckinForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.scanMemBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newMemBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reissueBtn = new System.Windows.Forms.ToolStripButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.namecodeTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneTbox = new System.Windows.Forms.TextBox();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkinBtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanMemBtn,
            this.toolStripSeparator1,
            this.newMemBtn,
            this.toolStripSeparator2,
            this.reissueBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(746, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // scanMemBtn
            // 
            this.scanMemBtn.BackColor = System.Drawing.SystemColors.Control;
            this.scanMemBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.scanMemBtn.Image = ((System.Drawing.Image)(resources.GetObject("scanMemBtn.Image")));
            this.scanMemBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scanMemBtn.Name = "scanMemBtn";
            this.scanMemBtn.Size = new System.Drawing.Size(125, 29);
            this.scanMemBtn.Text = "Scan Member";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // newMemBtn
            // 
            this.newMemBtn.BackColor = System.Drawing.SystemColors.Control;
            this.newMemBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newMemBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newMemBtn.Image = ((System.Drawing.Image)(resources.GetObject("newMemBtn.Image")));
            this.newMemBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMemBtn.Name = "newMemBtn";
            this.newMemBtn.Size = new System.Drawing.Size(184, 29);
            this.newMemBtn.Text = "New Member && Card";
            this.newMemBtn.ToolTipText = "New Member && Card";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // reissueBtn
            // 
            this.reissueBtn.BackColor = System.Drawing.SystemColors.Control;
            this.reissueBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reissueBtn.Image = ((System.Drawing.Image)(resources.GetObject("reissueBtn.Image")));
            this.reissueBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reissueBtn.Name = "reissueBtn";
            this.reissueBtn.Size = new System.Drawing.Size(116, 29);
            this.reissueBtn.Text = "Reissue Card";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(22, 283);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 28);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.Visible = false;
            // 
            // namecodeTbox
            // 
            this.namecodeTbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namecodeTbox.Location = new System.Drawing.Point(22, 89);
            this.namecodeTbox.Name = "namecodeTbox";
            this.namecodeTbox.Size = new System.Drawing.Size(700, 39);
            this.namecodeTbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone number";
            // 
            // phoneTbox
            // 
            this.phoneTbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneTbox.Location = new System.Drawing.Point(22, 200);
            this.phoneTbox.Name = "phoneTbox";
            this.phoneTbox.Size = new System.Drawing.Size(700, 39);
            this.phoneTbox.TabIndex = 4;
            // 
            // nameTbox
            // 
            this.nameTbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTbox.Location = new System.Drawing.Point(22, 311);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(700, 39);
            this.nameTbox.TabIndex = 6;
            this.nameTbox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code";
            // 
            // checkinBtn
            // 
            this.checkinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkinBtn.Location = new System.Drawing.Point(610, 387);
            this.checkinBtn.Name = "checkinBtn";
            this.checkinBtn.Size = new System.Drawing.Size(112, 48);
            this.checkinBtn.TabIndex = 7;
            this.checkinBtn.Text = "Check-in";
            this.checkinBtn.UseVisualStyleBackColor = true;
            // 
            // CheckinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 456);
            this.Controls.Add(this.checkinBtn);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namecodeTbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(768, 512);
            this.MinimumSize = new System.Drawing.Size(768, 512);
            this.Name = "CheckinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members Check-in";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton newMemBtn;
        private ToolStripButton scanMemBtn;
        private Label nameLabel;
        private TextBox namecodeTbox;
        private Label label2;
        private TextBox phoneTbox;
        private ToolStripSeparator toolStripSeparator1;
        private TextBox nameTbox;
        private Label label3;
        private Button checkinBtn;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton reissueBtn;
    }
}