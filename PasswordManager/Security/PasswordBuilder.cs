using System;
using System.Security.Cryptography;
using System.Text;
using PasswordManager.Security.Cryptography;
using PasswordManager.Extensions;

namespace PasswordManager.Security
{
    public sealed class PasswordBuilder : IDisposable
    {
        private HMAC _secretHmac;
        private HMAC _tagHmac;
        private TlsPseudoRandomFunction _prf;
        private StringBuilder _sb;
        private byte[] _number;
        private bool _disposed = false;

        public PasswordBuilder() : this(string.Empty)
        {
        }

        public PasswordBuilder(string passphrase)
        {
            if (passphrase == null)
                throw new ArgumentNullException(nameof(passphrase));

            _secretHmac = new HMACSHA256("secret".GetBytes());
            _tagHmac = new HMACSHA256("tag".GetBytes());
            _prf = new TlsPseudoRandomFunction(_secretHmac.ComputeHash(passphrase.GetBytes()), Array.Empty<byte>());
            _sb = new StringBuilder();
            _number = new byte[sizeof(uint)];
        }

        public string Passphrase
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                if (_disposed)
                    throw new ObjectDisposedException(GetType().FullName);

                _prf.Secret = _secretHmac.ComputeHash(value.GetBytes());
            }
        }

        public string GetPassword(string tag, string characterSet, int passwordLength)
        {
            if (tag == null)
                throw new ArgumentNullException(nameof(tag));
            if (characterSet == null)
                throw new ArgumentNullException(nameof(characterSet));
            if (characterSet.Length == 0)
                throw new ArgumentException("characterSet must contain at least one character.");
            if (passwordLength < 0)
                throw new ArgumentOutOfRangeException(nameof(passwordLength));
            if (_disposed)
                throw new ObjectDisposedException(GetType().FullName);

            if (passwordLength == 0)
                return string.Empty;
            if (characterSet.Length == 1)
                return new string(characterSet[0], passwordLength);

            _prf.Seed = _tagHmac.ComputeHash(tag.GetBytes());
            _sb.EnsureCapacity(passwordLength);
            
            for (int i = 0; i < passwordLength; i++)
            {
                _prf.GetBytes(_number);

                var sample = (double)BitConverter.ToUInt32(_number, 0) / (1L << 32);

                _sb.Append(characterSet[(int)(sample * characterSet.Length)]);
            }

            var result = _sb.ToString();
            _sb.Clear();
            return result;
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            _secretHmac.Dispose();
            _tagHmac.Dispose();
            _prf.Dispose();
            _disposed = true;
        }
    }
}
