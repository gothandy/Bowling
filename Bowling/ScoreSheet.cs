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
            return GetPinsKnockedDown(scoreSheetFrame.ToCharArray());
        }

        public static int[] GetPinsKnockedDown(char[] scoreSheetFrame)
        {
            ReplaceSpareWithNumber(scoreSheetFrame);

            return scoreSheetFrame.Select(c => pinsFromChar(c)).ToArray();
        }

        private static void ReplaceSpareWithNumber(char[] scoreSheetFrame)
        {
            if (scoreSheetFrame.Length > 1 && scoreSheetFrame[1] == Spare)
            {
                
                scoreSheetFrame[1] = ConvertIntToScoreCardChar(10 - pinsFromChar(scoreSheetFrame[0]));
            }
        }

        private static char ConvertIntToScoreCardChar(int i)
        {
            if (i == 10) return Strike;
            return i.ToString().ToCharArray()[0];
        }

        private static int pinsFromChar(char c)
        {
            if (c == Miss || c == Foul) return 0;
            if (c == Strike) return 10;

            if (Char.IsDigit(c)) return Convert.ToInt32(c.ToString());

            throw (new NotImplementedException());
        }
    }
}
