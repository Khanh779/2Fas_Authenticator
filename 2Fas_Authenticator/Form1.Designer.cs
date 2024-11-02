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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_counter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTitle.Location = new System.Drawing.Point(53, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(460, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Two-Factor Authentication";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecretKey
            // 
            this.labelSecretKey.AutoSize = true;
            this.labelSecretKey.Location = new System.Drawing.Point(37, 63);
            this.labelSecretKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSecretKey.Name = "labelSecretKey";
            this.labelSecretKey.Size = new System.Drawing.Size(61, 13);
            this.labelSecretKey.TabIndex = 1;
            this.labelSecretKey.Text = "Secret Key:";
            // 
            // textBoxSecretKey
            // 
            this.textBoxSecretKey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSecretKey.Location = new System.Drawing.Point(113, 57);
            this.textBoxSecretKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSecretKey.Name = "textBoxSecretKey";
            this.textBoxSecretKey.Size = new System.Drawing.Size(165, 25);
            this.textBoxSecretKey.TabIndex = 2;
            this.textBoxSecretKey.Text = "JBSWY3DPEHPK3PXP";
            // 
            // labelOtp
            // 
            this.labelOtp.AutoSize = true;
            this.labelOtp.Location = new System.Drawing.Point(37, 96);
            this.labelOtp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOtp.Name = "labelOtp";
            this.labelOtp.Size = new System.Drawing.Size(31, 13);
            this.labelOtp.TabIndex = 3;
            this.labelOtp.Text = "OTP:";
            // 
            // textBoxOtp
            // 
            this.textBoxOtp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxOtp.Location = new System.Drawing.Point(113, 90);
            this.textBoxOtp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOtp.Name = "textBoxOtp";
            this.textBoxOtp.ReadOnly = true;
            this.textBoxOtp.Size = new System.Drawing.Size(165, 25);
            this.textBoxOtp.TabIndex = 4;
            // 
            // buttonGenerateOtp
            // 
            this.buttonGenerateOtp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonGenerateOtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateOtp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonGenerateOtp.Location = new System.Drawing.Point(112, 165);
            this.buttonGenerateOtp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateOtp.Name = "buttonGenerateOtp";
            this.buttonGenerateOtp.Size = new System.Drawing.Size(120, 26);
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
            this.buttonVerify.Location = new System.Drawing.Point(236, 165);
            this.buttonVerify.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(120, 26);
            this.buttonVerify.TabIndex = 6;
            this.buttonVerify.Text = "Verify OTP";
            this.buttonVerify.UseVisualStyleBackColor = false;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(386, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 210);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(537, 91);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Counter:";
            // 
            // txt_counter
            // 
            this.txt_counter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_counter.Location = new System.Drawing.Point(287, 90);
            this.txt_counter.Margin = new System.Windows.Forms.Padding(2);
            this.txt_counter.Name = "txt_counter";
            this.txt_counter.Size = new System.Drawing.Size(70, 25);
            this.txt_counter.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(561, 313);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_counter);
            this.Controls.Add(this.label1);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_counter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
