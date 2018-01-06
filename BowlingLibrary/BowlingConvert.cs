using System.Collections.Generic;

namespace Bowling
{
    public static class BowlingConvert
    {
        public static List<Frame> ScoreSheetToFrameList(string scoreSheet)
        {
            List<Frame> frames = new List<Frame>();

            foreach (string scoreSheetFrame in scoreSheet.Split(' '))
            {
                frames.Add(BowlingConvert.ScoreSheetToFrame(scoreSheetFrame));
            }

            return frames;
        }

        public static Frame ScoreSheetToFrame(string scoreSheetFrame)
        {
            Frame frame = new Frame(scoreSheetFrame);

            return frame;
        }
    }
}
