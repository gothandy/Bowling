using System;
using System.Collections.Generic;

namespace Bowling
{
    public static class ScoreSheet
    {
        public static List<int[]> ConvertToFrameList(string scoreSheet)
        {
            List<int[]> frames = new List<int[]>();

            foreach (string scoreSheetFrame in scoreSheet.Split(' '))
            {
                int[] throws = ScoreSheet.ConvertToThrowArray(scoreSheetFrame);

                frames.Add(throws);
            }

            return frames;
        }

        public static int[] ConvertToThrowArray(string scoreSheetFrame)
        {
            int[] throws = new int[scoreSheetFrame.Length];

            for (int i = 0; i < scoreSheetFrame.Length; i++)
            {
                throws[i] = getNumberOfThrowsFromScoreSheetChar(scoreSheetFrame[i]);
            }

            WhenSpareCalculateSecondThrow(throws);

            return throws;
        }

        private static void WhenSpareCalculateSecondThrow(int[] throws)
        {
            if (throws.Length > 1 && throws[1] == -1) throws[1] = 10 - throws[0];
        }

        private static int getNumberOfThrowsFromScoreSheetChar(char c)
        {
            if (char.IsNumber(c)) return Convert.ToInt32(c.ToString());
            if (c == 'X') return 10;
            if (c == '/') return -1;
            return 0;
        }
    }
}
