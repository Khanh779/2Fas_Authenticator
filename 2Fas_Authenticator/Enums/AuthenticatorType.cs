using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Fas_Authenticator.Enums
{
    public enum AuthenticatorType
    {
        TOTP_New30Secs,
        HOTP,
        Steam,
        Yandex,
        MOTP
    }
}
