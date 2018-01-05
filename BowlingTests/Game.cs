using System;

namespace BowlingTests
{
    public class Game
    {
        private string scoreSheet;

        public Game(string scoreSheet)
        {
            this.scoreSheet = scoreSheet;
        }

        public int TotalScore { get { throw (new NotImplementedException()); } }
    }
}