using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratum.Enums
{
    public enum AuthenticatorType
    {
        Hotp = 1,
        Totp = 2,
        MobileOtp = 3,
        SteamOtp = 4,
        YandexOtp = 5
    }
}
