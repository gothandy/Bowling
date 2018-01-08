using Bowling;

namespace ScoreSheet
{
    public class StrikeReader : IFrameReader
    {
        public bool IsMatch(string s) => (s.Length == 1 &&  BallReader.IsStrike(s[0]));

        public BaseFrame GetFrame(string s)
        {
            return new Strike();
        }
    }
}