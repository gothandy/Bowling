namespace Bowling
{
    
    public class Strike : Ball
    {
        [Ball('X')]
        public Strike() : base(10) { }
    }
}