using Bowling;
using Xunit;

namespace BowlingTests
{
    public class ScoreSheetTests
    {
        [Theory]
        [InlineData("--", 0,0)]
        [InlineData("11", 1, 1)]
        public void GetPinsKnockedDown(string frame, params int[] expected)
        {
            int[] actual = ScoreSheet.GetPinsKnockedDown(frame);

            Assert.Equal<int[]>(expected, actual);
        }
    }
}
