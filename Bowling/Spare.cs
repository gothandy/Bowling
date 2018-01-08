namespace Bowling
{
    public class Spare : BaseFrame
    {
        private int firstBall;

        public Spare(int firstBall)
        {
            this.firstBall = firstBall;
        }

        public override int Score => 10 + NextBall;

        public override int[] Balls => Pins(firstBall, 10 - firstBall);
    }
}