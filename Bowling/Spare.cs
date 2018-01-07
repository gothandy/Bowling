namespace Bowling
{
   
    public class Spare : Ball
    {
        [ScoreSheetBall('/')]
        public Spare(Ball previousBall)
        {
            pins = 10 - previousBall.PinsKnockedOver;
        }
    }
}