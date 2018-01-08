using Bowling;

namespace ScoreSheet
{
    public class StrikeReader : IFrameReader
    {
        public BaseFrame GetFrame(string s) => new Strike();

        public bool IsMatch(string s) => (s.Length == 1 &&  BallReader.IsStrike(s[0]));
    }
}