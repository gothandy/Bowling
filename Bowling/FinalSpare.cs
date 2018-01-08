namespace Bowling
{
    public class FinalSpare : BaseFrame
    {
        private int firstBall;
        private int bonusBall;

        public FinalSpare(int firstBall, int bonusBall)
        {
            this.firstBall = firstBall;
            this.bonusBall = bonusBall;
        }

        public override int Score => 10 + bonusBall;

        public override int[] Balls => Pins(firstBall, 10 - firstBall, bonusBall);

    }
}
