using System.Collections.Generic;

namespace Bowling
{
    public class Strike : BaseFrame
    {
        public override int Score => 10 + balls[i] + balls[i + 1];

        public override int[] Balls => new int[] { 10 };
    }
}