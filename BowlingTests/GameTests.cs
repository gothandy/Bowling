using Xunit;

namespace BowlingTests
{
    public class GameTests
    {
        [Theory]
        [InlineData("X X X X X X X X X X X X", 300)]
        [InlineData("9- 9- 9- 9- 9- 9- 9- 9- 9- 9-", 90)]
        [InlineData("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5", 150)]
        public void TotalScore(string scoreSheet, int totalScore)
        {

        }
    }
}
