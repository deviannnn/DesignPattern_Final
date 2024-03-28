namespace YameStore.Screen.Initial
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backLoginBtn = new System.Windows.Forms.Label();
            this.resetPasswordBtn = new System.Windows.Forms.Button();
            this.inputResetTbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.initialLayout1 = new YameStore.Screen.Initial.InitialLayout();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 220);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::YameStore.Properties.Resources.locked_icon;
            this.pictureBox1.Location = new System.Drawing.Point(179, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.backLoginBtn);
            this.panel2.Controls.Add(this.resetPasswordBtn);
            this.panel2.Controls.Add(this.inputResetTbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 424);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 52);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter your gmail, phone, or account_id \r\nand then we\'ll send you a new password.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "Trouble logging in?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backLoginBtn
            // 
            this.backLoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backLoginBtn.AutoSize = true;
            this.backLoginBtn.Location = new System.Drawing.Point(199, 317);
            this.backLoginBtn.Name = "backLoginBtn";
            this.backLoginBtn.Size = new System.Drawing.Size(115, 25);
            this.backLoginBtn.TabIndex = 10;
            this.backLoginBtn.Text = "Back to login";
            this.backLoginBtn.Click += new System.EventHandler(this.backLoginBtn_Click);
            // 
            // resetPasswordBtn
            // 
            this.resetPasswordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resetPasswordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(39)))));
            this.resetPasswordBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetPasswordBtn.ForeColor = System.Drawing.Color.White;
            this.resetPasswordBtn.Location = new System.Drawing.Point(37, 211);
            this.resetPasswordBtn.Name = "resetPasswordBtn";
            this.resetPasswordBtn.Size = new System.Drawing.Size(448, 76);
            this.resetPasswordBtn.TabIndex = 9;
            this.resetPasswordBtn.Text = "RESET PASSWORD";
            this.resetPasswordBtn.UseVisualStyleBackColor = false;
            // 
            // inputResetTbox
            // 
            this.inputResetTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputResetTbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputResetTbox.Location = new System.Drawing.Point(37, 142);
            this.inputResetTbox.Name = "inputResetTbox";
            this.inputResetTbox.PlaceholderText = "Username";
            this.inputResetTbox.Size = new System.Drawing.Size(448, 39);
            this.inputResetTbox.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.initialLayout1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 644);
            this.panel3.TabIndex = 10;
            // 
            // initialLayout1
            // 
            this.initialLayout1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("initialLayout1.BackgroundImage")));
            this.initialLayout1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.initialLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initialLayout1.Location = new System.Drawing.Point(0, 0);
            this.initialLayout1.Name = "initialLayout1";
            this.initialLayout1.Size = new System.Drawing.Size(480, 644);
            this.initialLayout1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(480, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 644);
            this.panel4.TabIndex = 11;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 644);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(1024, 700);
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label backLoginBtn;
        private Button resetPasswordBtn;
        public TextBox inputResetTbox;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private InitialLayout initialLayout1;
        private Panel panel4;
    }
}