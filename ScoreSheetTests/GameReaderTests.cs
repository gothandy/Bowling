using Bowling;
using ScoreSheet;
using System.Linq;
using Xunit;

namespace ScoreSheetTests
{
    public class GameReaderTests
    {
        [Theory]
        [InlineData("X X X X X X X X X XXX", 300, 120)]
        [InlineData("9- 9- 9- 9- 9- 9- 9- 9- 9- 9-", 90, 90)]
        [InlineData("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5", 150, 105)]
        [InlineData("5/ X 5/ X 5/ X 5/ X 5/ X55", 200, 110)]
        [InlineData("X 5/ X 5/ X 5/ X 5/ X 5/X", 200, 110)]
        public void GameReaderTotalScore(string scoreSheet, int expectedScore, int expectedPins)
        {
            Game game = GameReader.GetGame(scoreSheet);

            Assert.Equal(10, game.Frames.Count());
            Assert.Equal(expectedPins, game.Frames.Sum(f => f.Balls.Sum()));
            Assert.Equal(expectedScore, game.TotalScore);
        }
    }
}
