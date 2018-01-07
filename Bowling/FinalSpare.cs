namespace Bowling
{
    public class FinalSpare : BaseFrame
    {
        private int ball1;
        private int ball3;

        public FinalSpare(int ball1, int ball3)
        {
            this.ball1 = ball1;
            this.ball3 = ball3;
        }

        public override int Score => 10 + ball3;

        public override int[] Balls => new int[] { ball1, 10 - ball1, ball3 };

    }
}
