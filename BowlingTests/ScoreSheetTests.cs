using Bowling;
using Xunit;

namespace BowlingTests
{
    public class ScoreSheetTests
    {
        [Theory]
        [InlineData("--", 0, 0)]
        [InlineData("11", 1, 1)]
        [InlineData("F1", 0, 1)]
        [InlineData("2F", 2, 0)]
        [InlineData("1/", 1, 9)]
        [InlineData("F/", 0, 10)]
        [InlineData("X", 10)]
        [InlineData("XXX", 10, 10, 10)]
        [InlineData("5/5", 5, 5, 5)]
        [InlineData("5/X", 5, 5, 10)]
        public void GetPinsKnockedDown(string frame, params int[] expected)
        {
            int[] actual = ScoreSheet.GetPinsKnockedDown(frame);

            Assert.Equal<int[]>(expected, actual);
        }
    }
}
