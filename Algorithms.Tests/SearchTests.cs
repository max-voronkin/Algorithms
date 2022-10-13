namespace Algorithms.Tests
{
    public class SearchTests
    {
        [Theory]
        [InlineData(new int[] {1, 2, 3, 4, 5}, 2, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, -1, -1)]
        [InlineData(new int[] { -11, -2, 3, 24, 35, -3, 8}, 35, 4)]
        [InlineData(new int[] { -11, -2, 3, 24, 35, -3, 8 }, -3, 5)]
        [InlineData(new int[] { -11, -2, 3, 24, 35, -11, 8 }, -11, 5)]
        public void LinearSearchTest(int[] array, int x, int expected)
        {
            var result = Search.LinearSearch(array, x);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, -1, -1)]
        [InlineData(new int[] { -11, -2, 3, 24, 35, -3, 8 }, 35, 4)]
        [InlineData(new int[] { -11, -2, 3, 24, 35, -3, 8 }, -3, 5)]
        [InlineData(new int[] { -11, -2, 3, 24, 35, -11, 8 }, -11, 0)]
        public void BetterLinearSearchTest(int[] array, int x, int expected)
        {
            var result = Search.BetterLinearSearch(array, x);
            Assert.Equal(result, expected);
        }
    }
}
