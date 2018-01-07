using System;
using System.Collections.Generic;
using System.Linq;
using BowlingTests;

namespace Bowling
{
    public class Game
    {
        private List<BaseFrame> frames = new List<BaseFrame>();
        private List<int> balls = new List<int>();

        public int TotalScore
        {
            get
            {
                return frames.Sum(f => f.Score);
            }
        }

        public void AddFrame(BaseFrame frame)
        {
            frames.Add(frame);

            frame.AddBalls(ref balls);
        }

        public IEnumerable<BaseFrame> Frames => frames.ToArray();
    }
}