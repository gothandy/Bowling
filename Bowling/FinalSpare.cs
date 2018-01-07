using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling
{
    public class FinalSpare : BaseFrame
    {
        private int v1;
        private int v2;

        public FinalSpare(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public override int Score => 10 + v2;

        public override int[] Balls => new int[] { v1, 10 - v1, v2 };

    }
}
