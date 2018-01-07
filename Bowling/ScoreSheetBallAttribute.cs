using System;

namespace Bowling
{
    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = true)]
    public class ScoreSheetBallAttribute : Attribute
    {
        private char c;

        public ScoreSheetBallAttribute()
        {
        }

        public ScoreSheetBallAttribute(char c)
        {
            this.c = c;
        }

        public bool IsDigit { get; set; }
    }
}