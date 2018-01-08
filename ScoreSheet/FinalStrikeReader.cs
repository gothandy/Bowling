using Bowling;

namespace ScoreSheet
{
    public class FinalStrikeReader : IFrameReader
    {
        public BaseFrame GetFrame(string s) => new FinalStrike(
                BallReader.GetPins(s[1]),
                BallReader.GetPins(s[2])
            );

        public bool IsMatch(string s) => s.Length == 3 && BallReader.IsStrike(s[0]);
    }
}