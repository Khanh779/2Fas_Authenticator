using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _2Fas_Authenticator.AutMode
{
    internal class Motp_Auth
    {
        public static string GenerateMotp(string secretKey, string pinCode = "0000", int period = 10, int digits = 6)
        {
            // Tính toán counter dựa trên thời gian hiện tại (sử dụng giây)
            long counter = DateTimeOffset.UtcNow.ToUnixTimeSeconds() / period;

            // Kết hợp secretKey, counter và pinCode để tạo đầu vào cho MD5
            string input = $"{counter}{secretKey}{pinCode}";

            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Chuyển đổi byte thành chuỗi hex
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                // Lấy 6 ký tự cuối của mã băm để tạo OTP
                string otp = sb.ToString().Substring(0, digits);

                // Đảm bảo OTP là chuỗi số
                return otp;
            }
        }

        private static byte[] ConvertHexToBytes(string hex)
        {
            int length = hex.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }
    }
}
