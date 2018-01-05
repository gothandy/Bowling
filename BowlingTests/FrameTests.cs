using Xunit;

namespace BowlingTests
{
    public class FrameTests
    {
        [Theory]
        [InlineData("--", 0, 0)]
        [InlineData("11", 1, 1)]
        [InlineData("81", 8, 1)]
        [InlineData("34", 3, 4)]
        [InlineData("72", 7, 2)]
        [InlineData("4/", 4, 6)]
        [InlineData("4/4", 4, 6, 4)]
        [InlineData("X", 10)]
        [InlineData("XXX", 10, 10, 10)]
        public void TwoMisses (string scoreCard, params int[] expectedThrows)
        {
            Frame frame = new Frame(scoreCard);

            Assert.Equal<int[]>(expectedThrows, frame.Throws);
        }
    }
}
