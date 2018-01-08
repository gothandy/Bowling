namespace Bowling
{
    public class Spare : BaseFrame
    {
        private int ball1;

        public Spare(int ball1)
        {
            this.ball1 = ball1;
        }

        public override int Score => 10 + NextBall;

        public override int[] Balls => new int[] { ball1, 10 - ball1 };
    }
}