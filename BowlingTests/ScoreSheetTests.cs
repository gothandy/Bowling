using Bowling;
using ScoreSheet;
using System;
using System.Collections.Generic;
using Xunit;

namespace BowlingTests
{
    public class ScoreSheetTests
    {
        [Theory]
        [InlineData("X", typeof(Strike))]
        [InlineData("5/", typeof(Spare))]
        [InlineData("45", typeof(Open))]
        [InlineData("-/", typeof(Spare))]
        [InlineData("F9", typeof(Open))]
        public void GetFrameReader(string s, Type t)
        {
            BaseFrame f = null;

            List<IFrameReader> l = new List<IFrameReader>()
            {
                new StrikeReader(),
                new SpareReader(),
                new OpenReader()
            };

            foreach(IFrameReader r in l) if (r.IsMatch(s)) f = r.GetFrame(s);

            Assert.Equal(t, f.GetType());
        }

        [Theory]
        [InlineData('-', 0)]
        [InlineData('F', 0)]
        [InlineData('1', 1)]
        public void  BallReaderGetPins(char c, int e)
        {
            Assert.Equal<int>(e, BallReader.GetPins(c));
        }
    }
}
