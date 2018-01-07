namespace Bowling
{
    public class Ball
    {
        protected int pins = 0;

        protected Ball() { }

        public Ball(int v)
        {
            this.pins = v;
        }

        public int PinsKnockedOver { get { return pins; } }
    }
}