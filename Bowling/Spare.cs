namespace Bowling
{
    internal class Spare : Ball
    {
        public Spare(Ball previousBall)
        {
            v = 10 - previousBall.PinsKnockedOver;
        }
    }
}