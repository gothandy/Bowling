using System;
using System.Linq;

namespace ScoreSheet
{
    public static class BallReader
    {
        private const char Miss = '-';
        private const char Foul = 'F';
        private const char Spare = '/';
        private const char Strike = 'X';

        private static char[] list = new char[] { Miss, Foul };

        public static int GetPins(char c)
        {
            if (list.Contains<char>(c)) return 0;

            if (IsStrike(c)) return 10;

            return Convert.ToInt32(c.ToString());
        }

        public static bool IsValid(char c) => list.Contains<char>(c) || char.IsDigit(c);

        public static bool IsStrike(char c) => c == Strike;
        public static bool IsSpare(char c) => c == Spare;

    }
}
