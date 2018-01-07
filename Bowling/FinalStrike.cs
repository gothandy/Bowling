namespace Bowling
{
    public class FinalStrike : BaseFrame
    {
        private int v1;
        private int v2;

        public FinalStrike(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public override int Score => 10 + v1 + v2;

        public override int[] Balls => new int[] { 10, v1, v2 };
    }
}