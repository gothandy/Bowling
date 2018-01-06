using System;
using System.Collections.Generic;

namespace Bowling
{
    public static class ScoreSheet
    {
        public static List<Frame> ConvertToFrameList(string scoreSheet)
        {
            List<Frame> frames = new List<Frame>();

            foreach (string scoreSheetFrame in scoreSheet.Split(' '))
            {
                frames.Add(ScoreSheet.ConvertToFrame(scoreSheetFrame));
            }

            return frames;
        }

        public static Frame ConvertToFrame(string scoreSheetFrame)
        {
            Frame frame = new Frame(scoreSheetFrame);

            return frame;
        }

        public static int[] ConvertToThrowArray(string scoreSheetFrame)
        {
            int[] throws = new int[scoreSheetFrame.Length];

            for (int i = 0; i < scoreSheetFrame.Length; i++)
            {
                throws[i] = getNumberOfThrowsFromScoreCardChar(scoreSheetFrame[i]);
            }

            WhenSpareCalculateSecondThrow(throws);

            return throws;
        }

        private static void WhenSpareCalculateSecondThrow(int[] throws)
        {
            if (throws.Length > 1 && throws[1] == -1) throws[1] = 10 - throws[0];
        }

        private static int getNumberOfThrowsFromScoreCardChar(char c)
        {
            if (char.IsNumber(c)) return Convert.ToInt32(c.ToString());
            if (c == 'X') return 10;
            if (c == '/') return -1;
            return 0;
        }
    }
}
