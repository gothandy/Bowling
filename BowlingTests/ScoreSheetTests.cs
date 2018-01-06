using Bowling;
using System.Collections.Generic;
using Xunit;
using System.Linq;

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
        public void SingleFrame(string frameStr, params int[] expected)
        {
            Ball[] balls = ScoreSheet.GetBalls(frameStr);

            int[] actual = balls.Select(b => b.PinsKnockedOver).ToArray();

            Assert.Equal<int[]>(expected, actual);
        }
    }
}
