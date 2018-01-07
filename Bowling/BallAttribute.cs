using System;
using System.Collections.Generic;

namespace Bowling
{
    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = true)]
    public class BallAttribute : Attribute
    {
        private char c;

        public BallAttribute()
        {
        }

        public BallAttribute(char c)
        {
            this.c = c;
        }

        public bool IsDigit { get; set; }
        public char ScoreSheetChar => c;
    }
}