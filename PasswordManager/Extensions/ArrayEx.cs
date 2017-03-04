using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PasswordManager.Extensions
{
    internal static class ArrayEx
    {
        public static T[] Clone<T>(T[] array)
        {
            if (array.Length == 0)
                return Array.Empty<T>();
            
            return (T[])array.Clone();
        }

        public static void Clone<T>(T[] src, ref T[] dst)
        {
            Debug.Assert(src != null);

            if (src.Length > 0)
            {
                if (dst != null && src.Length == dst.Length)
                    Array.Copy(src, dst, src.Length);
                else
                    dst = (T[])src.Clone();
            }
            else if (dst == null || dst.Length > 0)
            {
                dst = Array.Empty<T>();
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        public static void ZeroMemory(Array array)
        {
            Array.Clear(array, 0, array.Length);
        }
    }
}
