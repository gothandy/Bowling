using Bowling;
using System.Collections.Generic;
using Xunit;

namespace BowlingTests
{
    public class FrameTests
    {
        [Fact]
        public void OpenTest()
        {
            List<int> balls = new List<int>();

            Open frame = new Open(1, 1);

            frame.AddBalls(ref balls);

            Assert.Equal(2, frame.Score);
            Assert.Equal<int>(new int[] { 1, 1 }, frame.Balls);
            Assert.Equal<int>(new int[] { 1, 1 }, balls);
        }

        [Fact]
        public void SpareTest()
        {
            List<int> balls = new List<int>();

            Spare frame = new Spare(1);

            frame.AddBalls(ref balls);

            balls.Add(2);

            Assert.Equal(12, frame.Score);
            Assert.Equal<int>(new int[] { 1, 9 }, frame.Balls);
            Assert.Equal<int>(new int[] { 1, 9, 2 }, balls);
        }

        [Fact]
        public void StrikeTest()
        {
            List<int> balls = new List<int>();

            Strike frame = new Strike();

            frame.AddBalls(ref balls);

            balls.Add(2);
            balls.Add(3);

            Assert.Equal(15, frame.Score);
            Assert.Equal<int>(new int[] { 10 }, frame.Balls);
            Assert.Equal<int>(new int[] { 10, 2, 3 }, balls);
        }

        [Fact]
        public void FinalSpareTest()
        {
            List<int> balls = new List<int>();

            FinalSpare frame = new FinalSpare(1, 5);

            frame.AddBalls(ref balls);

            Assert.Equal(15, frame.Score);
            Assert.Equal<int>(new int[] { 1, 9, 5 }, frame.Balls);
            Assert.Equal<int>(new int[] { 1, 9, 5 }, balls);
        }

        [Fact]
        public void FinalStrikeTest()
        {
            List<int> balls = new List<int>();

            FinalStrike frame = new FinalStrike(2, 3);

            frame.AddBalls(ref balls);

            Assert.Equal(15, frame.Score);
            Assert.Equal<int>(new int[] { 10, 2, 3 }, frame.Balls);
            Assert.Equal<int>(new int[] { 10, 2, 3 }, balls);
        }
    }
}
