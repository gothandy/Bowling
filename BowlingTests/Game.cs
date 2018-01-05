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

            for(int i = 0; i< frames.Count; i++)
            {
                Frame frame = frames[i];

                total += AddThrowsForThisFrame(frame);

                if (i < 10 && frame.IsSpare) total += frames[i + 1].Throws[0];
            }

            return total;
        }

        private static int AddThrowsForThisFrame(Frame frame)
        {
            int t = 0;
            foreach (int i in frame.Throws) t += i;
            return t;
        }
    }
}