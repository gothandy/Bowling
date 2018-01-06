using Bowling;
using Xunit;

namespace BowlingTests
{
    public class FrameTests
    {


        [Theory]
        [InlineData("4/", true)]
        [InlineData("4/4", false)]
        public void IsSpare(string scoreSheetFrame, bool expected)
        {
            int[] throws = ScoreSheet.ConvertToThrowArray(scoreSheetFrame);

            Frame frame = new Frame(throws);

            Assert.Equal<bool>(expected, frame.IsSpare);
        }

        [Theory]
        [InlineData("X", true)]
        [InlineData("XXX", false)]
        [InlineData("XX-", false)]
        [InlineData("X--", false)]
        public void IsStrike(string scoreSheetFrame, bool expected)
        {
            int[] throws = ScoreSheet.ConvertToThrowArray(scoreSheetFrame);

            Frame frame = new Frame(throws);

            Assert.Equal<bool>(expected, frame.IsStrike);
        }
    }
}
