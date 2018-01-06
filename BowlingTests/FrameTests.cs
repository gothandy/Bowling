using Bowling;
using Xunit;

namespace BowlingTests
{
    public class FrameTests
    {
        [Theory]
        [InlineData(5, 3)]
        public void IsOpenFrame(params int[] pins)
        {
            Frame frame = new Frame(pins);

            Assert.True(frame.IsOpenFrame);
        }

        [Theory]
        [InlineData(8, 5, 3)]
        public void OpenFrameScore(int expectedScore, params int[] pins)
        {
            Frame frame = new Frame(pins);

            Assert.Equal<int>(expectedScore, frame.Score);
        }
    }
}
