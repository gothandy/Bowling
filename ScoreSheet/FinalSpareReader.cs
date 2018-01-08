using Bowling;

namespace ScoreSheet
{
    public class FinalSpareReader : IFrameReader
    {
        public BaseFrame GetFrame(string s) => new FinalSpare(
                BallReader.GetPins(s[0]),
                BallReader.GetPins(s[2])
            );

        public bool IsMatch(string s) => s.Length == 3 && BallReader.IsSpare(s[1]);

    }
}