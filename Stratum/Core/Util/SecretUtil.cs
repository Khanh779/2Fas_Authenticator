using Stratum.Core.Generator;
using Stratum.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratum.Core.Util
{
    public static class SecretUtil
    {
        public static string Clean(string input, AuthenticatorType type)
        {
            if (type.HasBase32Secret())
            {
                input = input.ToUpper();
            }

            input = input.Replace(" ", "");
            input = input.Replace("-", "");

            return input;
        }

        public static bool HasBase32Secret(this AuthenticatorType type)
        {
            switch (type)
            {
                case AuthenticatorType.Hotp:
                case AuthenticatorType.Totp:
                case AuthenticatorType.SteamOtp:
                case AuthenticatorType.YandexOtp:
                    return true;

                case AuthenticatorType.MobileOtp:
                    return false;

                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
        }


        public static void Validate(string secret, AuthenticatorType type)
        {
            if (string.IsNullOrEmpty(secret))
            {
                throw new ArgumentException("Secret cannot be null or empty");
            }

            if (type.HasBase32Secret())
            {
                byte[] bytes;

                try
                {
                    bytes = HashUtil.Base32Decode(secret);
                }
                catch (Exception e)
                {
                    throw new ArgumentException("Error decoding secret", e);
                }

                if (bytes.Length == 0)
                {
                    throw new ArgumentException("Error decoding secret, output length 0");
                }

                if (type == AuthenticatorType.YandexOtp && bytes.Length < YandexOtp.SecretByteCount)
                {
                    throw new ArgumentException("Secret is too short for Yandex OTP");
                }
            }

            if (type == AuthenticatorType.MobileOtp && secret.Length < MobileOtp.SecretMinLength)
            {
                throw new ArgumentException("Too few characters in secret for mOTP");
            }
        }
    }
}
