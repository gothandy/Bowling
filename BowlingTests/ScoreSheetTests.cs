using Bowling;
using ScoreSheet;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BowlingTests
{
    public class ScoreSheetTests
    {
        [Theory]
        [InlineData("X", typeof(Strike), 10)]
        [InlineData("5/", typeof(Spare), 5,5)]
        [InlineData("45", typeof(Open), 4,5)]
        [InlineData("-/", typeof(Spare), 0,10)]
        [InlineData("F9", typeof(Open), 0,9)]
        [InlineData("5/5", typeof(FinalSpare), 5,5,5)]
        [InlineData("X23", typeof(FinalStrike), 10,2,3)]
        [InlineData("XX3", typeof(FinalStrike), 10,10,3)]
        [InlineData("XXX", typeof(FinalStrike), 10,10,10)]
        public void GetFrameReader(string s, Type t, params int[] p)
        {
            BaseFrame frame = GameReader.GetFrame(s);

            Assert.Equal(t, frame.GetType());
            Assert.Equal<int>(p, frame.Balls);
        }

        [Theory]
        [InlineData('-', 0)]
        [InlineData('F', 0)]
        [InlineData('1', 1)]
        public void  BallReaderGetPins(char c, int e)
        {
            Assert.Equal<int>(e, BallReader.GetPins(c));
        }

        [Theory]
        [InlineData("X X X X X X X X X XXX", 300, 120)]
        [InlineData("9- 9- 9- 9- 9- 9- 9- 9- 9- 9-", 90, 90)]
        [InlineData("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5", 150, 105)]
        [InlineData("5/ X 5/ X 5/ X 5/ X 5/ X55", 200, 110)]
        public void GameReaderTotalScore(string scoreSheet, int expectedScore, int expectedPins)
        {
            Game game = GameReader.GetGame(scoreSheet);

            Assert.Equal(10, game.Frames.Count());
            Assert.Equal(expectedPins, game.Frames.Sum(f => f.Balls.Sum()));
            Assert.Equal(expectedScore, game.TotalScore);
        }
    }
}
