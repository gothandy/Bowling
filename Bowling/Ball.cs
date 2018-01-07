namespace Bowling
{
    public class Ball
    {
        protected int pins = 0;

        [ScoreSheetBall('-')]
        [ScoreSheetBall('F')]
        public Ball() { }

        [ScoreSheetBall(IsDigit = true)]
        public Ball(int v)
        {
            this.pins = v;
        }

        public int PinsKnockedOver { get { return pins; } }
    }
}