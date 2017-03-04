using System;
using System.Windows.Forms;
using PasswordManager.Forms;
using System.Linq;

namespace PasswordManager
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public static string ByteArrayToString(byte[] array, int offset, int count)
        {
            return BitConverter.ToString(array, offset, count).Replace("-", "").ToLowerInvariant();
        }
    }
}
