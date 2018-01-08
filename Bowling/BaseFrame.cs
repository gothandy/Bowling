using System.Collections.Generic;

namespace Bowling
{
    public abstract class BaseFrame
    {
        private int i;
        private List<int> balls;

        public abstract int Score { get; }

        public abstract int[] Balls { get; }

        protected int NextBall => balls[i];

        protected int NextTwoBalls => balls[i] + balls[i + 1];

        protected int[] Pins(params int[] pins) => pins;

        public void AddBalls(ref List<int> balls)
        {
            this.balls = balls;
            this.balls.AddRange(this.Balls);
            i = balls.Count;
        }
    }
}