using Bowling;

namespace ScoreSheet
{
    public class StrikeReader : IFrameReader
    {
        public bool IsMatch(string s) => (s == "X");

        public BaseFrame GetFrame(string s)
        {
            return new Strike();
        }
    }
}