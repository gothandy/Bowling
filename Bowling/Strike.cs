namespace Bowling
{
    public class Strike : BaseFrame
    {
        public override int Score => 10 + NextTwoBalls;

        public override int[] PinsPerBall => Pins(10);
    }
}