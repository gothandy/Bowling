using System;
using System.Collections.Generic;
using System.Linq;
using BowlingTests;

namespace Bowling
{
    public class Game
    {
        public List<BaseFrame> Frames = new List<BaseFrame>();
        private List<int> Balls = new List<int>();

        public int TotalScore
        {
            get
            {
                return Frames.Sum(f => f.Score);
            }
        }

        public void AddFrame(BaseFrame frame)
        {
            Frames.Add(frame);

            frame.AddBalls(ref Balls);
        }
    }
}