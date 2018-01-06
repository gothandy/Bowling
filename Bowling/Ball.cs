namespace Bowling
{
    public class Ball
    {
        protected int v;

        public Ball() { }

        public Ball(int v)
        {
            this.v = v;
        }

        public int PinsKnockedOver { get { return v; } }
    }
}