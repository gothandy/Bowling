namespace Bowling
{
    public class FinalStrike : BaseFrame
    {
        private int secondBall;
        private int bonusBall;

        public FinalStrike(int secondBall, int bonusBall)
        {
            this.secondBall = secondBall;
            this.bonusBall = bonusBall;
        }

        public override int Score => 10 + secondBall + bonusBall;

        public override int[] Balls => Pins(10, secondBall, bonusBall);
    }
}