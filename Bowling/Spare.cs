namespace Bowling
{
    public class Spare : Ball
    {
        [Ball('/')]
        public Spare(Ball previousBall)
        {
            pins = 10 - previousBall.PinsKnockedOver;
        }
    }
}