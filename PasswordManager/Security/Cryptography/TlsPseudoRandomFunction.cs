using System;
using System.Security.Cryptography;
using PasswordManager.Extensions;

namespace PasswordManager.Security.Cryptography
{
    /// <summary>
    ///     TLS Pseudorandom Function ( https://tools.ietf.org/html/rfc5246#section-5 )
    /// </summary>
    public sealed class TlsPseudoRandomFunction : IDisposable
    {
        private byte[] _secret;
        private byte[] _seed;

        private HMAC _hmac;

        private byte[] _a;
        private byte[] _aAndSeed;

        private byte[] _buffer;
        private int _bytesLeft;

        private bool _disposed = false;

        public TlsPseudoRandomFunction(byte[] secret, byte[] seed)
        {
            if (secret == null)
                throw new ArgumentNullException(nameof(secret));
            if (seed == null)
                throw new ArgumentNullException(nameof(seed));

            Initialize(secret, seed);
        }

        public byte[] Secret
        {
            get => ArrayEx.Clone(_secret);
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));

                CheckDisposed();
                Initialize(value, null);
            }
        } 

        public byte[] Seed
        {
            get => ArrayEx.Clone(_seed);
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));

                CheckDisposed();
                Initialize(null, value);
            }
        }

        public void GetBytes(byte[] buffer)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            CheckDisposed();
            InternalGetBytes(buffer, 0, buffer.Length);
        }

        public void GetBytes(byte[] buffer, int offset, int count)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));
            if (offset < 0 || offset > buffer.Length)
                throw new ArgumentOutOfRangeException(nameof(offset));
            if (count < 0 || count > buffer.Length - offset)
                throw new ArgumentOutOfRangeException(nameof(count));

            CheckDisposed();
            InternalGetBytes(buffer, offset, count);
        }

        public void Initialize(byte[] secret, byte[] seed)
        {
            CheckDisposed();

            if (secret != null)
                ArrayEx.Clone(secret, ref _secret);
            if (seed != null)
                ArrayEx.Clone(seed, ref _seed);

            if (_hmac == null)
                _hmac = new HMACSHA256(_secret);
            else
                _hmac.Key = _seed;

            _a = _hmac.ComputeHash(_secret);

            if (_aAndSeed == null || _aAndSeed.Length != _a.Length + _seed.Length)
                _aAndSeed = new byte[_a.Length + _seed.Length];

            Array.Copy(_a, 0, _aAndSeed, 0, _a.Length);
            Array.Copy(_seed, 0, _aAndSeed, _a.Length, _seed.Length);

            _hmac.Key = _aAndSeed;
            _buffer = _hmac.ComputeHash(_secret);
            _bytesLeft = _buffer.Length;
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            _hmac.Dispose();
            ArrayEx.ZeroMemory(_secret);
            ArrayEx.ZeroMemory(_seed);
            ArrayEx.ZeroMemory(_a);
            ArrayEx.ZeroMemory(_aAndSeed);
            ArrayEx.ZeroMemory(_buffer);

            _disposed = true;
        }
        
        private void InternalGetBytes(byte[] buffer, int offset, int count)
        {
            if (_buffer == null)
                throw new ObjectDisposedException(GetType().FullName);

            if (count <= _bytesLeft)
            {
                Array.Copy(_buffer, _buffer.Length - _bytesLeft, buffer, offset, count);
                _bytesLeft -= count;
                return;
            }

            if (_bytesLeft > 0)
            {
                Array.Copy(_buffer, _buffer.Length - _bytesLeft, buffer, offset, _bytesLeft);
                offset += _bytesLeft;
                count -= _bytesLeft;
                _bytesLeft = 0;
            }

            while (count >= _buffer.Length)
            {
                _buffer = ComputeNextHash();

                Array.Copy(_buffer, 0, buffer, offset, _buffer.Length);
                offset += _buffer.Length;
                count -= _buffer.Length;
            }

            if (count > 0)
            {
                _buffer = ComputeNextHash();

                Array.Copy(_buffer, 0, buffer, offset, count);
                _bytesLeft = _buffer.Length - count;
            }
        }

        private byte[] ComputeNextHash()
        {
            _hmac.Key = _a;
            _a = _hmac.ComputeHash(_secret);

            Array.Copy(_a, 0, _aAndSeed, 0, _a.Length);

            _hmac.Key = _aAndSeed;

            return _hmac.ComputeHash(_secret);
        }

        private void CheckDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(GetType().FullName);
        }
    }
}
