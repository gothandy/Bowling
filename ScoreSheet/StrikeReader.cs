using Bowling;

namespace ScoreSheet
{
    public class StrikeReader : IFrameReader
    {
        public bool IsMatch(string s) => (s.Length == 1 && s == "X");

        public BaseFrame GetFrame(string s)
        {
            return new Strike();
        }
    }
}