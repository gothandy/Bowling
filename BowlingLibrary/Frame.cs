using System;

namespace Bowling
{
    public class Frame
    {
        private int[] throws;

        public Frame(string scoreSheetFrame)
        {
            throws = ScoreSheet.ConvertToThrowArray(scoreSheetFrame);
        }

        public int[] Throws => throws;

        public int Total
        {
            get
            {
                int t = 0;
                foreach (int i in throws) t += i;
                return t;
            }
        }

        public bool IsSpare { get { return (throws.Length == 2 && (Total == 10)); } }

        public bool IsStrike { get { return (throws.Length == 1 && (Total == 10)); } }
    }
}