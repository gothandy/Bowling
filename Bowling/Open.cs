namespace Bowling
{
    public class Open : BaseFrame
    {
        private int ball1;
        private int ball2;

        public Open(int ball1, int ball2)
        {
            this.ball1 = ball1;
            this.ball2 = ball2;
        }

        public override int Score => ball1 + ball2;

        public override int[] Balls => new int[] { ball1, ball2 };
    }
}