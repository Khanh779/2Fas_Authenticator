using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2Fas_Authenticator.AutMode
{
    internal class Yandex_Auth
    {

        private const long TimeStep = 30; // Thời gian bước, thường là 30 giây

        public static string GenerateYandexOtp(string secretKey, string password = "00000000")
        {
            // Kiểm tra chiều dài của password
            if (password.Length != 8 || !IsNumeric(password))
                throw new ArgumentException("Password must be exactly 8 characters long and numeric.", nameof(password));

            int digits = 8;

            byte[] key = Base32Encoding.ToBytes(secretKey); // Chuyển đổi secret key sang byte
            long timeCounter = DateTimeOffset.UtcNow.ToUnixTimeSeconds() / TimeStep; // Tính toán thời gian bước hiện tại

            byte[] counterBytes = BitConverter.GetBytes(timeCounter);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(counterBytes); // Đảm bảo định dạng Big-endian

            using (var hmac = new HMACSHA256(key)) // Sử dụng HMACSHA256 để tạo mã
            {
                byte[] hash = hmac.ComputeHash(counterBytes);

                int offset = hash[hash.Length - 1] & 0x0F; // Lấy 4 byte cuối cùng của mã
                int binaryCode = ((hash[offset] & 0x7F) << 24) |
                                 ((hash[offset + 1] & 0xFF) << 16) |
                                 ((hash[offset + 2] & 0xFF) << 8) |
                                 (hash[offset + 3] & 0xFF);

                return (binaryCode % (int)Math.Pow(10, digits)).ToString().PadLeft(digits, '0'); // Trả về mã TOTP
            }
        }

        // Phương thức kiểm tra xem chuỗi có phải là số hay không
        private static bool IsNumeric(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
