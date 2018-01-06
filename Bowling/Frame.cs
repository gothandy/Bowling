using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class Frame
    {
        
        private Ball[] balls;

        public Frame(Ball[] balls)
        {
            this.balls = balls;
        }

        public int Score
        {
            get
            {
                if (this.IsOpenFrame) return this.balls.Sum(b => b.PinsKnockedOver);

                throw (new NotImplementedException());
            }
        }

        public bool IsOpenFrame => (balls.Sum(b => b.PinsKnockedOver) < 10);

        public Ball[] Balls => balls;
    }
}