using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _2Fas_Authenticator.AutMode
{
    internal class Hotp_Auth
    {
        public static string GenerateHotp(string secretKey, long counter)
        {
            byte[] key = Base32Encoding.ToBytes(secretKey); // Chuyển đổi secret key thành byte[]

            // Chuyển đổi counter thành byte[]
            byte[] counterBytes = BitConverter.GetBytes(counter);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(counterBytes); // Đảm bảo định dạng Big-endian

            // Tạo HMAC-SHA1
            using (var hmac = new HMACSHA1(key))
            {
                byte[] hash = hmac.ComputeHash(counterBytes);
                int offset = hash[hash.Length - 1] & 0x0F;
                int binary =
                    ((hash[offset] & 0x7F) << 24) |
                    ((hash[offset + 1] & 0xFF) << 16) |
                    ((hash[offset + 2] & 0xFF) << 8) |
                    (hash[offset + 3] & 0xFF);

                // Lấy mã từ binary
                int otp = binary % 1000000; // 6 chữ số
                return otp.ToString("D6"); // Đảm bảo 6 chữ số
            }
        }
    }
}
