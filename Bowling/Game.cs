using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class Game
    {
        private List<BaseFrame> frames = new List<BaseFrame>();
        private List<int> balls = new List<int>();

        public void AddFrame(BaseFrame frame)
        {
            frames.Add(frame);

            frame.AddBalls(ref balls);
        }

        public int TotalScore => frames.Sum(f => f.Score);

        public IEnumerable<BaseFrame> Frames => frames.ToArray();
    }
}