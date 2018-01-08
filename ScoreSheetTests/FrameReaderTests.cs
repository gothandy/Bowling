using Bowling;
using ScoreSheet;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ScoreSheetTests
{
    public class FrameReaderTests
    {
        [Theory]
        [InlineData("X", typeof(Strike), 10)]
        [InlineData("5/", typeof(Spare), 5, 5)]
        [InlineData("45", typeof(Open), 4, 5)]
        [InlineData("-/", typeof(Spare), 0, 10)]
        [InlineData("F9", typeof(Open), 0, 9)]
        [InlineData("5/5", typeof(FinalSpare), 5, 5, 5)]
        [InlineData("X23", typeof(FinalStrike), 10, 2, 3)]
        [InlineData("XX3", typeof(FinalStrike), 10, 10, 3)]
        [InlineData("XXX", typeof(FinalStrike), 10, 10, 10)]
        [InlineData("5/X", typeof(FinalSpare), 5, 5, 10)]
        public void GetFrameReader(string s, Type t, params int[] p)
        {
            BaseFrame frame = GameReader.GetFrame(s);

            Assert.Equal(t, frame.GetType());
            Assert.Equal<int>(p, frame.PinsPerBall);
        }
    }
}
