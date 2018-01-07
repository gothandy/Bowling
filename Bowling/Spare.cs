using System.Collections.Generic;
using Bowling;

namespace BowlingTests
{
    public class Spare : BaseFrame
    {
        private int v;

        public Spare(int first)
        {
            this.v = first;
        }

        public override int Score => 10 + balls[i];

        public override int[] Balls => new int[] { v, 10 - v };
    }
}