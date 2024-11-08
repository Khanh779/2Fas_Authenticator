﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _2Fas_Authenticator.AutMode
{
    internal class Steam_Auth
    {
        private const int TimeStep = 30; // Thời gian bước, 30 giây
        private static byte[] steamGuardCodeTranslations = new byte[] { 50, 51, 52, 53, 54, 55, 56, 57, 66, 67, 68, 70, 71, 72, 74, 75, 77, 78, 80, 81, 82, 84, 86, 87, 88, 89 };

        public static string GenerateSTEAMotp(string secretKey)
        {
            if (secretKey == null || secretKey.Length == 0)
            {
                return "";
            }

            string sharedSecretUnescaped = Regex.Unescape(secretKey);
            byte[] sharedSecretArray = Base32Encoding.ToBytes(sharedSecretUnescaped);

            byte[] timeArray = new byte[8];

            long time = GetCurrentUnixTime();

            for (int i = 8; i > 0; i--)
            {
                timeArray[i - 1] = (byte)time;
                time >>= 8;
            }

            HMACSHA1 hmacGenerator = new HMACSHA1();
            hmacGenerator.Key = sharedSecretArray;
            byte[] hashedData = hmacGenerator.ComputeHash(timeArray);
            byte[] codeArray = new byte[5];
            try
            {
                byte b = (byte)(hashedData[19] & 0xF);
                int codePoint = (hashedData[b] & 0x7F) << 24 | (hashedData[b + 1] & 0xFF) << 16 | (hashedData[b + 2] & 0xFF) << 8 | (hashedData[b + 3] & 0xFF);

                for (int i = 0; i < 5; ++i)
                {
                    codeArray[i] = steamGuardCodeTranslations[codePoint % steamGuardCodeTranslations.Length];
                    codePoint /= steamGuardCodeTranslations.Length;
                }
            }
            catch (Exception)
            {
                return null; //Change later, catch-alls are bad!
            }
            return Encoding.UTF8.GetString(codeArray);
        }

   
        private static long GetCurrentUnixTime()
        {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds / 30; // 30 giây cho TOTP
        }

    }
}
