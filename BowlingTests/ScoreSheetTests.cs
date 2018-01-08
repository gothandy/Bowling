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
        public void GetReader(string s, Type t)
        {
            BaseFrame f = null;

            List<IFrameReader> l = new List<IFrameReader>()
            {
                new StrikeReader()
            };

            foreach(IFrameReader r in l) if (r.IsMatch(s)) f = r.GetFrame(s);

            Assert.Equal(t, f.GetType());
        }
    }
}
