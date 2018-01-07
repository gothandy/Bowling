namespace Bowling
{
    public class FinalStrike : BaseFrame
    {
        private int ball2;
        private int ball3;

        public FinalStrike(int ball2, int ball3)
        {
            this.ball2 = ball2;
            this.ball3 = ball3;
        }

        public override int Score => 10 + ball2 + ball3;

        public override int[] Balls => new int[] { 10, ball2, ball3 };
    }
}