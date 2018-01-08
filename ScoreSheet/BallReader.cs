using System;
using System.Linq;

namespace ScoreSheet
{
    public static class BallReader
    {
        public static int GetPins(char c)
        {
            if (IsMiss(c) || IsFoul(c)) return 0;
            if (IsStrike(c)) return 10;
            if (IsDigit(c)) return Convert.ToInt32(c.ToString());

            throw new NotImplementedException();
        }
        public static bool IsValid(char c) => (IsDigit(c) || IsMiss(c) || IsFoul(c));

        public static bool IsDigit(char c) => char.IsDigit(c);
        public static bool IsStrike(char c) => (c == 'X');
        public static bool IsSpare(char c) => (c == '/');
        public static bool IsMiss(char c) => (c == '-');
        public static bool IsFoul(char c) => (c == 'F');
    }
}
