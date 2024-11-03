using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2Fas_Authenticator.AutMode;

namespace _2Fas_Authenticator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxSecretKey.Text = "ICJL VN3P 5DZI L47A GSH4 JRNC LEDN NMDZ";
            //textBoxSecretKey.Text = "12345678af";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateQRCode(Totp_Auth.CreateStringForTOTP(textBoxSecretKey.Text)); // Tạo mã QR từ secret key

            comboBox1.DataSource = Enum.GetValues(typeof(_2Fas_Authenticator.Enums.AuthenticatorType));
        }


        int hotpCounter = 0; // Đếm cho HOTP

        private void buttonGenerateOtp_Click(object sender, EventArgs e)
        {
            // Lấy mã bí mật từ textBoxSecretKey và tăng bộ đếm
            string secretKey = textBoxSecretKey.Text.Replace(" ","");

            string otp =
                comboBox1.SelectedIndex == 0 ? Totp_Auth.GenerateTotp(secretKey) :
                comboBox1.SelectedIndex == 1 ? Hotp_Auth.GenerateHotp(secretKey, hotpCounter++) :
                comboBox1.SelectedIndex == 2 ? Steam_Auth.GenerateSTEAMotp(secretKey) : 
                comboBox1.SelectedIndex == 3 ?  Yandex_Auth.GenerateYandexOtp(secretKey):
                Motp_Auth.GenerateMotp(secretKey);

            txt_counter.Text = hotpCounter.ToString();
            textBoxOtp.Text = otp; // Hiển thị mã OTP trong textBoxOtp

          
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
                    //Clipboard.SetImage(qrCodeImage); // Sao chép vào clipboard (tuỳ chọn)
                    pictureBox1.Image = qrCodeImage; // Hiển thị mã QR trên PictureBox
                }
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            // Xác thực mã OTP nhập vào
            string userOtp = textBoxOtp.Text;
            // Thêm logic xác thực mã OTP ở đây (so sánh với mã đã tạo)
            string secretKey = textBoxSecretKey.Text.Replace(" ", "");

            Clipboard.SetText(secretKey);
            MessageBox.Show(($"Uer name: {userOtp}\nCopied\nSecret key:{secretKey}")) ;
            
        }

      
    }
}
