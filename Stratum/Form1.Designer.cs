namespace Stratum
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.buttonGenerateOtp = new System.Windows.Forms.Button();
            this.textBoxOtp = new System.Windows.Forms.TextBox();
            this.labelOtp = new System.Windows.Forms.Label();
            this.textBoxSecretKey = new System.Windows.Forms.TextBox();
            this.labelSecretKey = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Counter:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(377, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // buttonVerify
            // 
            this.buttonVerify.BackColor = System.Drawing.Color.LightCoral;
            this.buttonVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerify.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonVerify.Location = new System.Drawing.Point(227, 184);
            this.buttonVerify.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(120, 26);
            this.buttonVerify.TabIndex = 21;
            this.buttonVerify.Text = "Verify OTP";
            this.buttonVerify.UseVisualStyleBackColor = false;
            // 
            // buttonGenerateOtp
            // 
            this.buttonGenerateOtp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonGenerateOtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateOtp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonGenerateOtp.Location = new System.Drawing.Point(103, 184);
            this.buttonGenerateOtp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateOtp.Name = "buttonGenerateOtp";
            this.buttonGenerateOtp.Size = new System.Drawing.Size(120, 26);
            this.buttonGenerateOtp.TabIndex = 20;
            this.buttonGenerateOtp.Text = "Generate OTP";
            this.buttonGenerateOtp.UseVisualStyleBackColor = false;
            this.buttonGenerateOtp.Click += new System.EventHandler(this.buttonGenerateOtp_Click);
            // 
            // textBoxOtp
            // 
            this.textBoxOtp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxOtp.Location = new System.Drawing.Point(104, 109);
            this.textBoxOtp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOtp.Name = "textBoxOtp";
            this.textBoxOtp.ReadOnly = true;
            this.textBoxOtp.Size = new System.Drawing.Size(165, 25);
            this.textBoxOtp.TabIndex = 19;
            // 
            // labelOtp
            // 
            this.labelOtp.AutoSize = true;
            this.labelOtp.Location = new System.Drawing.Point(28, 115);
            this.labelOtp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOtp.Name = "labelOtp";
            this.labelOtp.Size = new System.Drawing.Size(30, 13);
            this.labelOtp.TabIndex = 18;
            this.labelOtp.Text = "OTP:";
            // 
            // textBoxSecretKey
            // 
            this.textBoxSecretKey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSecretKey.Location = new System.Drawing.Point(104, 76);
            this.textBoxSecretKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSecretKey.Name = "textBoxSecretKey";
            this.textBoxSecretKey.Size = new System.Drawing.Size(165, 25);
            this.textBoxSecretKey.TabIndex = 17;
            this.textBoxSecretKey.Text = "JBSWY3DPEHPK3PXP";
            // 
            // labelSecretKey
            // 
            this.labelSecretKey.AutoSize = true;
            this.labelSecretKey.Location = new System.Drawing.Point(28, 82);
            this.labelSecretKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSecretKey.Name = "labelSecretKey";
            this.labelSecretKey.Size = new System.Drawing.Size(61, 13);
            this.labelSecretKey.TabIndex = 16;
            this.labelSecretKey.Text = "Secret Key:";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTitle.Location = new System.Drawing.Point(43, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(460, 54);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Stratum\r\nTwo-Factor Authentication";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDown1.Location = new System.Drawing.Point(274, 109);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 25);
            this.numericUpDown1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(552, 242);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonGenerateOtp);
            this.Controls.Add(this.textBoxOtp);
            this.Controls.Add(this.labelOtp);
            this.Controls.Add(this.textBoxSecretKey);
            this.Controls.Add(this.labelSecretKey);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Button buttonGenerateOtp;
        private System.Windows.Forms.TextBox textBoxOtp;
        private System.Windows.Forms.Label labelOtp;
        private System.Windows.Forms.TextBox textBoxSecretKey;
        private System.Windows.Forms.Label labelSecretKey;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

