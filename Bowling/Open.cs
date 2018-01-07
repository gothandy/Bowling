namespace Bowling
{
    public class Open : BaseFrame
    {
        private int v1;
        private int v2;

        public Open(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public override int Score => v1 + v2;

        public override int[] Balls => new int[] { v1, v2 };
    }
}