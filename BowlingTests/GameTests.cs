using Bowling;
using System.Collections.Generic;
using Xunit;

namespace BowlingTests
{
    public class GameTests
    {
        [Theory]
        [InlineData("X X X X X X X X X XXX", 300)]
        [InlineData("9- 9- 9- 9- 9- 9- 9- 9- 9- 9-", 90)]
        [InlineData("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5", 150)]
        public void TotalScore(string scoreSheet, int totalScore)
        {
            List<int[]> frames = ScoreSheet.ConvertToFrameList(scoreSheet);

            Game game = new Game(frames);

            Assert.Equal(totalScore, game.TotalScore);
        }
    }
}
