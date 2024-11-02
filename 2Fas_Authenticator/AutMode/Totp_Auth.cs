using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Media.Animation;

namespace _2Fas_Authenticator.AutMode
{
    internal class Totp_Auth
    {


        private const int TimeStep = 30;

        public static string GenerateTotp(string secretKey)
        {
            int digits = 6;

            byte[] key = Base32Encoding.ToBytes(secretKey); // Chuyển đổi secret key sang byte
            long timeCounter = DateTimeOffset.UtcNow.ToUnixTimeSeconds() / TimeStep;  // Tính toán thời gian bước hiện tại

            byte[] timeCounterBytes = GetBigEndianBytes(timeCounter);

            using (var hmac = new HMACSHA1(key))// Sử dụng HMACSHA1 để tạo mã
            {
                byte[] hash = hmac.ComputeHash(timeCounterBytes);

                int offset = hash[hash.Length - 1] & 0x0F;   // Lấy 4 byte cuối cùng của mã
                int binaryCode = ((hash[offset] & 0x7F) << 24) |
                                 ((hash[offset + 1] & 0xFF) << 16) |
                                 ((hash[offset + 2] & 0xFF) << 8) |
                                 (hash[offset + 3] & 0xFF);

                return (binaryCode % (int)Math.Pow(10, digits)).ToString().PadLeft(digits, '0');  // Trả về mã TOTP
            }
        }



        private static byte[] GetBigEndianBytes(long input)
        {
            // Since .net uses little endian numbers, we need to reverse the byte order to get big endian.
            var data = BitConverter.GetBytes(input);
            Array.Reverse(data);
            return data;
        }



        //private static byte[] Base32Decode(string base32)
        //{
        //    const string base32Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
        //    int bits = 0;
        //    int value = 0;
        //    byte[] result = new byte[(base32.Length * 5 + 7) / 8];
        //    int index = 0;

        //    foreach (char c in base32)
        //    {
        //        if (c == '=')
        //            break;

        //        int b = base32Chars.IndexOf(c);
        //        if (b < 0)
        //            throw new FormatException($"Invalid base32 character: {c}");

        //        value = (value << 5) | b;
        //        bits += 5;

        //        if (bits >= 8)
        //        {
        //            bits -= 8;
        //            result[index++] = (byte)(value >> bits);
        //        }
        //    }

        //    return result;
        //}



        public static string CreateStringForTOTP(string secretKey)
        {
            return $"otpauth://totp/2Fas Authenticator?secret={secretKey}&issuer=2Fas Authenticator";
        }

        public static string CreateStringForTOTP(string secretKey, string userName, string serviveProvider)
        {
            return $"otpauth://totp/{userName}?secret={secretKey}&issuer={serviveProvider}";
        }


    }
}
