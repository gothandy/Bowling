namespace Bowling
{
    
    public class Strike : Ball
    {
        [ScoreSheetBall('X')]
        public Strike() : base(10) { }
    }
}