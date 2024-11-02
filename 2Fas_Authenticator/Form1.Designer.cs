namespace _2Fas_Authenticator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSecretKey = new System.Windows.Forms.Label();
            this.textBoxSecretKey = new System.Windows.Forms.TextBox();
            this.labelOtp = new System.Windows.Forms.Label();
            this.textBoxOtp = new System.Windows.Forms.TextBox();
            this.buttonGenerateOtp = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTitle.Location = new System.Drawing.Point(53, 16);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(460, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Two-Factor Authentication (Xác thực 2 yếu tố)";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecretKey
            // 
            this.labelSecretKey.AutoSize = true;
            this.labelSecretKey.Location = new System.Drawing.Point(55, 67);
            this.labelSecretKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSecretKey.Name = "labelSecretKey";
            this.labelSecretKey.Size = new System.Drawing.Size(61, 13);
            this.labelSecretKey.TabIndex = 1;
            this.labelSecretKey.Text = "Secret Key:";
            // 
            // textBoxSecretKey
            // 
            this.textBoxSecretKey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSecretKey.Location = new System.Drawing.Point(131, 65);
            this.textBoxSecretKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSecretKey.Name = "textBoxSecretKey";
            this.textBoxSecretKey.Size = new System.Drawing.Size(232, 25);
            this.textBoxSecretKey.TabIndex = 2;
            this.textBoxSecretKey.Text = "JBSWY3DPEHPK3PXP";
            // 
            // labelOtp
            // 
            this.labelOtp.AutoSize = true;
            this.labelOtp.Location = new System.Drawing.Point(55, 108);
            this.labelOtp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOtp.Name = "labelOtp";
            this.labelOtp.Size = new System.Drawing.Size(30, 13);
            this.labelOtp.TabIndex = 3;
            this.labelOtp.Text = "OTP:";
            // 
            // textBoxOtp
            // 
            this.textBoxOtp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxOtp.Location = new System.Drawing.Point(131, 105);
            this.textBoxOtp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOtp.Name = "textBoxOtp";
            this.textBoxOtp.Size = new System.Drawing.Size(232, 25);
            this.textBoxOtp.TabIndex = 4;
            // 
            // buttonGenerateOtp
            // 
            this.buttonGenerateOtp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonGenerateOtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateOtp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonGenerateOtp.Location = new System.Drawing.Point(131, 198);
            this.buttonGenerateOtp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateOtp.Name = "buttonGenerateOtp";
            this.buttonGenerateOtp.Size = new System.Drawing.Size(112, 32);
            this.buttonGenerateOtp.TabIndex = 5;
            this.buttonGenerateOtp.Text = "Generate OTP";
            this.buttonGenerateOtp.UseVisualStyleBackColor = false;
            this.buttonGenerateOtp.Click += new System.EventHandler(this.buttonGenerateOtp_Click);
            // 
            // buttonVerify
            // 
            this.buttonVerify.BackColor = System.Drawing.Color.LightCoral;
            this.buttonVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerify.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonVerify.Location = new System.Drawing.Point(251, 198);
            this.buttonVerify.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(112, 32);
            this.buttonVerify.TabIndex = 6;
            this.buttonVerify.Text = "Verify OTP";
            this.buttonVerify.UseVisualStyleBackColor = false;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(397, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 247);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(537, 91);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(58, 150);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(185, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Use TOTP (renew in 30 seconds)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(58, 173);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Use HOTP";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(561, 350);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonGenerateOtp);
            this.Controls.Add(this.textBoxOtp);
            this.Controls.Add(this.labelOtp);
            this.Controls.Add(this.textBoxSecretKey);
            this.Controls.Add(this.labelSecretKey);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2FA Authenticator (Xác thực 2 lớp)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSecretKey;
        private System.Windows.Forms.TextBox textBoxSecretKey;
        private System.Windows.Forms.Label labelOtp;
        private System.Windows.Forms.TextBox textBoxOtp;
        private System.Windows.Forms.Button buttonGenerateOtp;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}
