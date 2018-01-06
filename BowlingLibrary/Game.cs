using System.Collections.Generic;

namespace Bowling
{
    public class Game
    {
        private List<Frame> frames;

        public Game(string scoreSheet)
        {
            frames = ScoreSheet.ConvertToFrameList(scoreSheet);
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

                    if (frames[i].IsStrike)
                    {
                        if (frames[i+1].IsStrike)
                        {
                            total += frames[i + 1].Throws[0] + frames[i + 2].Throws[0];
                        }
                        else
                        {
                            total += frames[i + 1].Throws[0] + frames[i + 1].Throws[1];
                        }
                    }
                }

                return total;
            }
        }
    }
}