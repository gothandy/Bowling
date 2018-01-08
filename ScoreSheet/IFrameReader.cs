using Bowling;

namespace ScoreSheet
{
    public interface IFrameReader
    {
        bool IsMatch(string s);

        BaseFrame GetFrame(string s);
    }
}
