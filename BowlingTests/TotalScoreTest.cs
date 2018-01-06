using Bowling;
using Xunit;

namespace BowlingTests
{
    public class TotalScoreTest
    {
        [Theory]
        [InlineData("X X X X X X X X X XXX", 300)]
        [InlineData("9- 9- 9- 9- 9- 9- 9- 9- 9- 9-", 90)]
        [InlineData("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5", 150)]
        public void TotalScore(string scoreSheet, int totalScore)
        {
            Game game = new Game(scoreSheet);

            Assert.Equal(totalScore, game.TotalScore);
        }
    }
}
