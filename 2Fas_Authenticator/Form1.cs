using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace _2Fas_Authenticator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxSecretKey.Text = "ICJL VN3P 5DZI L47A GSH4 JRNC LEDN NMDZ";
        }

        int hotpCounter = 0; // Đếm cho HOTP

        private void buttonGenerateOtp_Click(object sender, EventArgs e)
        {
            // Lấy mã bí mật từ textBoxSecretKey và tăng bộ đếm
            string secretKey = textBoxSecretKey.Text.Replace(" ","");

        

            string otp = radioButton1.Checked? TOTP_Auth.GenerateTotp(secretKey ): HOTP_Auth.GenerateHotp(secretKey, hotpCounter++); // Tạo mã OTP
            textBoxOtp.Text = otp; // Hiển thị mã OTP trong textBoxOtp

            GenerateQRCode(TOTP_Auth.CreateStringForTOTP(secretKey)); // Tạo mã QR từ secret key
        }

     
   

    private void GenerateQRCode(string secretKey)
        {
            // Tạo mã QR từ secret key
            using (var qrGenerator = new QRCodeGenerator())
            {
                var qrCodeData = qrGenerator.CreateQrCode(secretKey, QRCodeGenerator.ECCLevel.Q);
                using (var qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrCodeImage = qrCode.GetGraphic(20); // Thay đổi kích thước nếu cần
                    Clipboard.SetImage(qrCodeImage); // Sao chép vào clipboard (tuỳ chọn)
                    pictureBox1.Image = qrCodeImage; // Hiển thị mã QR trên PictureBox
                }
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            // Xác thực mã OTP nhập vào
            string userOtp = textBoxOtp.Text;
            // Thêm logic xác thực mã OTP ở đây (so sánh với mã đã tạo)
            // ...
            
        }

    }
}
