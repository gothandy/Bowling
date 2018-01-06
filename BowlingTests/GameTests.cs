using System;
using Xunit;

namespace BowlingTests
{
    public class GameTests
    {
        const string perfectGame = "X X X X X X X X X X X X";
        const string cleanSheetFiveFive = "5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5";
        const string dutchTwoHundred = "5/ X 5/ X 5/ X 5/ X 5/ X 5/5";
        const string allOpenNines = "9- 9- 9- 9- 9- 9- 9- 9- 9- 9-";

        [Theory]
        [InlineData(perfectGame, 300)]
        [InlineData(allOpenNines, 90)]
        [InlineData(cleanSheetFiveFive, 150)]
        [InlineData(dutchTwoHundred, 200)]
        public void TotalScore(string scoreSheet, int totalScore)
        {
            throw (new NotImplementedException());
        }
    }
}
