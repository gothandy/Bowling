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

            ConvertFrameScoreSheetStringToThrows(frameScoreSheet);
        }

        private void ConvertFrameScoreSheetStringToThrows(string frameScoreSheet)
        {
            for (int i = 0; i < frameScoreSheet.Length; i++)
            {
                throws[i] = getNumberOfThrowsFromScoreCardChar(frameScoreSheet[i]);
            }

            WhenSpareCalculateSecondThrow();
        }

        private void WhenSpareCalculateSecondThrow()
        {
            if (throws.Length > 1 && throws[1] == -1) throws[1] = 10 - throws[0];
        }

        private int getNumberOfThrowsFromScoreCardChar(char c)
        {
            if (char.IsNumber(c)) return Convert.ToInt32(c.ToString());
            if (c == 'X') return 10;
            if (c == '/') return -1;
            return 0;
        }

        public int[] Throws => throws;
    }
}