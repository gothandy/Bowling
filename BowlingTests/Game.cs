using System;
using System.Collections.Generic;

namespace BowlingTests
{
    public class Game
    {
        private List<Frame> frames = new List<Frame>();

        public Game(string scoreSheet)
        {
            foreach(string frameScoreSheet in scoreSheet.Split(' '))
            {
                frames.Add(new Frame(frameScoreSheet));
            }
        }

        public int TotalScore => GetTotalScore();

        private int GetTotalScore()
        {
            int total = 0;
            foreach(Frame frame in frames)
            {
                foreach (int t in frame.Throws) total += t;
            }

            return total;
        }
    }
}