using System.Numerics;
using System.Runtime.InteropServices;

namespace GenomicRangeQuery
{
    // Compatible with Codility
    internal sealed class SparseTableMin
    {
        private readonly int[,] _table;

        public SparseTableMin(int[] numbers)
        {
            var length = numbers.Length;
            var levels = FloorLog2((uint)length) + 1;
            _table = new int[levels, length];

            // Fill _table
            int bytes = Buffer.ByteLength(numbers);
            Buffer.BlockCopy(numbers, 0, _table, 0, bytes);
            for (int i = 1; i < levels; i++)
                for (int j = 0; j + (1 << i) <= length; j++)
                    _table[i, j] = Math.Min(_table[i - 1, j], _table[i - 1, j + (1 << (i - 1))]);
        }

        public int GetMinValue(int l, int r)
        {
            var i = FloorLog2((uint)(r - l + 1));
            return Math.Min(_table[i, l], _table[i, r - (1 << i) + 1]);
        }

        private static int FloorLog2(uint x)
        {
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;

            x -= (x >> 1) & 0x55555555;
            x = ((x >> 2) & 0x33333333) + (x & 0x33333333);
            x = ((x >> 4) + x) & 0x0f0f0f0f;
            x += x >> 8;
            x += x >> 16;

            return (int)(x & 0x0000003f) - 1;
        }
    }

    // Optimized, incompatible with Codility
    internal sealed class SparseTableMin<T> where T : INumber<T>
    {
        private readonly T[,] _table;

        public SparseTableMin(T[] numbers)
        {
            ArgumentNullException.ThrowIfNull(numbers);
            ArgumentOutOfRangeException.ThrowIfZero(numbers.Length, nameof(numbers));

            var length = numbers.Length;
            var levels = BitOperations.Log2((uint)length) + 1;
            _table = new T[levels, length];

            // Fill _table
            numbers.AsSpan().CopyTo(MemoryMarshal.CreateSpan(ref _table[0, 0], length));
            for (int i = 1; i < levels; i++)
            {
                for (int j = 0; j + (1 << i) <= length; j++)
                {
                    var value1 = _table[i - 1, j];
                    var value2 = _table[i - 1, j + (1 << (i - 1))];
                    _table[i, j] = value1 < value2 ? value1 : value2;
                }
            }
        }

        public T GetMinValue(int l, int r)
        {
            var i = BitOperations.Log2((uint)(r - l + 1));
            var value1 = _table[i, l];
            var value2 = _table[i, r - (1 << i) + 1];
            return value1 < value2 ? value1 : value2;
        }
    }
}
