namespace Bowling
{
    public class Miss : Ball
    {
        [Ball('-')]
        public Miss() : base(0) { }
    }

    public class Foul : Ball
    {
        [Ball('F')]
        public Foul() : base (0) { }
    }
}
