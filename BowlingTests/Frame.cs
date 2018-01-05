using System;
using System.Collections.Generic;

namespace BowlingTests
{
    public class Frame
    {
        private string frameScoreSheet;

        public Frame(string frameScoreSheet)
        {
            this.frameScoreSheet = frameScoreSheet;
        }

        public int[] Throws { get { throw (new NotImplementedException()); } }
    }
}