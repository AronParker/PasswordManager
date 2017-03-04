using System;
using System.Text;

namespace PasswordManager.Extensions
{
    internal static class StringEx
    {
        private static UTF8Encoding _utf8 = new UTF8Encoding(false, true);

        public static byte[] GetBytes(this string s)
        {
            if (s.Length == 0)
                return Array.Empty<byte>();

            return _utf8.GetBytes(s);
        }
    }
}
