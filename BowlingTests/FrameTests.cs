using Xunit;

namespace BowlingTests
{
    public class FrameTests
    {
        [Theory]
        [InlineData("--", new int[]{0, 0})]
        public void TwoMisses (string scoreCard, int[] expectedThrows)
        {
            Frame frame = new Frame(scoreCard);

            Assert.Equal<int[]>(expectedThrows, frame.Throws);
        }
    }
}
