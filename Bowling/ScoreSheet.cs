using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class ScoreSheet
    {
        public const char Strike = 'X';
        public const char Spare = '/';
        public const char Foul = 'F';
        public const char Miss = '-';

        public static Ball[] GetBalls(string frame)
        {
            Ball previousBall = null;
            List<Ball> balls = new List<Ball>();

            foreach(char c in frame)
            {
                Ball ball = getBall(c, previousBall);
                balls.Add(ball);
                previousBall = ball;
            }

            return balls.ToArray();
        }

        private static Ball getBall(char ball, Ball previous)
        {
            if (ball == Strike) return new Strike();
            if (ball == Spare) return new Spare(previous);
            if (ball == Foul) return new Ball(0);
            if (ball == Miss) return new Ball(0);
            if (Char.IsDigit(ball)) return new Ball(Convert.ToInt32(ball.ToString()));

            throw (new NotImplementedException());
        }
    }
}
