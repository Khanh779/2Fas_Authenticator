using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Stratum.Core.Util
{
    public static class HashUtil
    {
        public static string Sha1(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        public static string Md5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        public static string Truncate(this string input, int length)
        {
            return input.Length > length ? input.Substring(0, length) : input;
        }

        public static byte[] Base32Decode(string base32)
        {
            const string base32Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
            int bits = 0;
            int value = 0;
            byte[] result = new byte[(base32.Length * 5 + 7) / 8];
            int index = 0;

            foreach (char c in base32)
            {
                if (c == '=')
                    break;

                int b = base32Chars.IndexOf(c);
                if (b < 0)
                    throw new FormatException($"Invalid base32 character: {c}");

                value = (value << 5) | b;
                bits += 5;

                if (bits >= 8)
                {
                    bits -= 8;
                    result[index++] = (byte)(value >> bits);
                }
            }

            return result;
        }
    }
}
