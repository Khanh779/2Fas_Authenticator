using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratum.Core.Util
{
    public static class BytesUtil
    {
        public static void WriteInt64BigEndian(byte[] destination, long value)
        {
            if (destination == null || destination.Length < 8)
                throw new ArgumentException("Destination array must be at least 8 bytes long.");

            // Chuyển đổi từng byte từ giá trị Int64 sang Big-Endian và lưu vào mảng byte
            destination[0] = (byte)(value >> 56);
            destination[1] = (byte)(value >> 48);
            destination[2] = (byte)(value >> 40);
            destination[3] = (byte)(value >> 32);
            destination[4] = (byte)(value >> 24);
            destination[5] = (byte)(value >> 16);
            destination[6] = (byte)(value >> 8);
            destination[7] = (byte)(value);
        }
        public static long ReadInt64BigEndian(byte[] source)
        {
            if (source == null || source.Length < 8)
                throw new ArgumentException("Source array must be at least 8 bytes long.");

            return ((long)source[0] << 56) |
                   ((long)source[1] << 48) |
                   ((long)source[2] << 40) |
                   ((long)source[3] << 32) |
                   ((long)source[4] << 24) |
                   ((long)source[5] << 16) |
                   ((long)source[6] << 8) |
                   (long)source[7];
        }

    }
}
