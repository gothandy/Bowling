using Bowling;
using Xunit;

namespace BowlingTests
{
    public class FrameTests
    {
        [Theory]
        [InlineData(8, 5, 3)]
        public void OpenFramePinTotal(int expectedTotal, params int[] pins)
        {
            Frame frame = new Frame(pins);

            Assert.Equal<int>(expectedTotal, frame.PinTotal);
        }
    }
}
