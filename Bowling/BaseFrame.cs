using System.Collections.Generic;

namespace Bowling
{
    public abstract class BaseFrame
    {
        private int indexOfNextBall;
        private List<int> pinsPerBallForGame;

        protected int NextBall =>
            pinsPerBallForGame[indexOfNextBall];

        protected int NextTwoBalls =>
            pinsPerBallForGame[indexOfNextBall] +
            pinsPerBallForGame[indexOfNextBall + 1];

        protected int[] Pins(params int[] pins) => pins;

        public abstract int Score { get; }

        public abstract int[] PinsPerBall { get; }

        public void AddBalls(ref List<int> pinsPerBallForGame)
        {
            this.pinsPerBallForGame = pinsPerBallForGame;

            this.pinsPerBallForGame.AddRange(this.PinsPerBall);

            indexOfNextBall = pinsPerBallForGame.Count;
        }
    }
}