﻿// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only


using Stratum.Core.Util;

namespace Stratum.Core.Generator
{
    public class Totp : HmacOtp, IGenerator
    {
        private readonly int _period;

        public Totp(string secret, int period, HashAlgorithm algorithm, int digits) : base(secret, algorithm, digits)
        {
            _period = period;
        }

        public string Compute(long counter)
        {
            var material = base.Compute(GetCounterBytes(counter, _period));
            return Finalise(material);
        }

        public static byte[] GetCounterBytes(long counter, int period)
        {
            var window = counter / period;
            var bytes = new byte[sizeof(long)];

            //for (int i = 0; i < bytes.Length; i++)
            //{
            //    bytes[bytes.Length - 1 - i] = (byte)(window >> (8 * i));
            //}
            BytesUtil.WriteInt64BigEndian(bytes, window);

            return bytes;
        }


        protected virtual string Finalise(int material)
        {
            return Truncate(material);
        }
    }
}