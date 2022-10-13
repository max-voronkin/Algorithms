using System.Diagnostics;
using static System.Console;

namespace Algorithms
{
    public static class Search
    {
        /// <summary>
        /// Returns the index of last found x in array. Returns -1 if x not found
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int LinearSearch(int[] array, int x)
        {
            var watch = new Stopwatch();           
            watch.Start();

            int result = -1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == x)
                {
                    result = i;
                }
            }
            watch.Stop();

            WriteLine($"Linear search elapsed {watch.Elapsed}");
            WriteLine($"Result: {result}");
            return result;
        }

        /// <summary>
        /// Returns the index of first found x in array and breaks the loop. Returns -1 if x not found
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int BetterLinearSearch(int[] array, int x)
        {
            var watch = new Stopwatch();
            watch.Start();

            int result = -1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == x)
                {
                    watch.Stop();
                    WriteLine($"Better linear search elapsed {watch.Elapsed}");
                    WriteLine($"Result: {i}");
                    return i;
                }
            }
            return result;
        }
    }
}
