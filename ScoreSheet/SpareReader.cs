using Bowling;
using System;

namespace ScoreSheet
{
    public class SpareReader : IFrameReader
    {
        public BaseFrame GetFrame(string s) => new Spare(BallReader.GetPins(s[0]));

        public bool IsMatch(string s) => (s.Length ==2 && BallReader.IsSpare(s[1]));
    }
}