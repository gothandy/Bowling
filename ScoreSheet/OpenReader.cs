using Bowling;
using System;

namespace ScoreSheet
{
    public class OpenReader : IFrameReader
    {
        public BaseFrame GetFrame(string s) => new Open(
                BallReader.GetPins(s[0]),
                BallReader.GetPins(s[1])
            );

        public bool IsMatch(string s) => (
                s.Length == 2 && 
                BallReader.IsValid(s[0]) &&
                BallReader.IsValid(s[1])
            );
    }
}