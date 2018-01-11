using ScoreSheet;
using Xunit;

namespace ScoreSheetTests
{
    public class BallReaderTests
    {
        [Theory]
        [InlineData('-', 0)]
        [InlineData('F', 0)]
        [InlineData('1', 1)]
        public void BallReaderGetPins(char c, int e)
        {
            Assert.Equal<int>(e, BallReader.GetPins(c));
        }
    }
}
