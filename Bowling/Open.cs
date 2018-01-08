namespace Bowling
{
    public class Open : BaseFrame
    {
        private int firstBall;
        private int secondBall;

        public Open(int firstBall, int secondBall)
        {
            this.firstBall = firstBall;
            this.secondBall = secondBall;
        }

        public override int Score => firstBall + secondBall;

        public override int[] Balls => Pins(firstBall, secondBall);
    }
}