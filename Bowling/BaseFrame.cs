using System.Collections.Generic;

namespace Bowling
{
    public abstract class BaseFrame
    {
        protected int i;
        protected List<int> balls;

        public abstract int Score { get; }

        public abstract int[] Balls { get; }

        public void AddBalls(ref List<int> balls)
        {
            this.balls = balls;
            this.balls.AddRange(this.Balls);
            i = balls.Count;
        }
    }
}