using System;
using System.Linq;

namespace Bowling
{
    public class ScoreSheet
    {
        public const char Strike = 'X';
        public const char Spare = '/';
        public const char Foul = 'F';
        public const char Miss = '-';

        public static int[] GetPinsKnockedDown(string scoreSheetFrame)
        {
            if (scoreSheetFrame[1] == Spare)
            {
                int firstBall = pinsFromChar(scoreSheetFrame[0]);
                return new int[] { firstBall, 10 - firstBall };
            }
            else
            {
                return scoreSheetFrame.Select(c => pinsFromChar(c)).ToArray();
            }
        }

        private static int ConvertCharToInt(char c)
        {
            return Convert.ToInt32(c.ToString());
        }

        private static int pinsFromChar(char c)
        {
            if (c == Miss || c == Foul) return 0;
            if (Char.IsDigit(c)) return ConvertCharToInt(c);

            throw (new NotImplementedException());
        }
    }
}
