namespace Bowling
{
    public class Strike : BaseFrame
    {
        public override int Score => 10 + NextBall + NextBall2;

        public override int[] Balls => new int[] { 10 };
    }
}