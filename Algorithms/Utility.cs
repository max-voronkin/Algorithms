namespace Algorithms
{
    internal static class Utility
    {
        private static int[]? unsortedArray;
        public static int[] UnsortedArray => unsortedArray ??= GenerateRandomArray(1000000, -1000, 1000);
        private static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            int[] array = new int[size];
            var rng = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rng.Next(minValue, maxValue);
            }

            return array;
        }
    }
}
