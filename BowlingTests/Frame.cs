using System;
using System.Collections.Generic;

namespace BowlingTests
{
    public class Frame
    {
        private int[] throws;

        public Frame(string frameScoreSheet)
        {
            throws = new int[frameScoreSheet.Length];

            for (int i = 0; i < frameScoreSheet.Length; i++)
            {
                throws[i] = getNumberOfThrowsFromScoreCardChar(frameScoreSheet[i]);
            }
        }

        private int getNumberOfThrowsFromScoreCardChar(char c)
        {
            return 0;
        }

        public int[] Throws => throws;
    }
}