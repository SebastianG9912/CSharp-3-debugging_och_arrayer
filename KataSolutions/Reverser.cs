using System;

namespace KataSolutions
{
    public class Reverser
    {
        public static void Reverse<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                T swap = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = swap;
            }
        }

        public static int[] GetReverse(int[] original)
        {
            throw new NotImplementedException();
        }
    }
}
