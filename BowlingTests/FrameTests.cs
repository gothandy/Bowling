using Xunit;

namespace BowlingTests
{
    public class FrameTests
    {
        [Theory]
        [InlineData("--", new int[]{0, 0})]
        [InlineData("11", new int[] { 1, 1 })]
        [InlineData("81", new int[] { 8, 1 })]
        [InlineData("34", new int[] { 3, 4 })]
        [InlineData("72", new int[] { 7, 2 })]
        public void TwoMisses (string scoreCard, int[] expectedThrows)
        {
            Frame frame = new Frame(scoreCard);

            Assert.Equal<int[]>(expectedThrows, frame.Throws);
        }
    }
}
