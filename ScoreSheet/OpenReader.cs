using Bowling;
using System;

namespace ScoreSheet
{
    public class OpenReader : IFrameReader
    {
        public BaseFrame GetFrame(string s)
        {
            return new Open(
                    Convert.ToInt32(s[0].ToString()),
                    Convert.ToInt32(s[1].ToString())
                );
        }

        public bool IsMatch(string s) => (
                s.Length == 2 && 
                char.IsDigit(s[0]) && 
                char.IsDigit(s[1])
            );
    }
}