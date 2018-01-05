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

        public int TotalScore
        {
            get
            {
                int total = 0;

                for (int i = 0; i < frames.Count; i++)
                {
                    total += frames[i].Total;

                    if (frames[i].IsSpare) total += frames[i + 1].Throws[0];

                    if (frames[i].IsStrike) total += frames[i + 1].Total;
                }

                return total;
            }
        }
    }
}