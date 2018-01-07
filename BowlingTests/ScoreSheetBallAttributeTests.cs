using Bowling;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit;
using System.Linq;

namespace BowlingTests
{
    public class ScoreSheetBallAttributeTests
    {
        [Theory]
        [InlineData(typeof(Ball), 2)]
        [InlineData(typeof(Spare), 1)]
        [InlineData(typeof(Strike), 1)]
        public void ConstructorCount(Type t, int expectedCount)
        {
            IEnumerable<ConstructorInfo> constructors = t.GetConstructors(BindingFlags.Instance|BindingFlags.Public);

            Assert.Equal<int>(expectedCount, constructors.Count());
        }

        [Theory]
        [InlineData(typeof(Ball), 0, 2)]
        [InlineData(typeof(Ball), 1, 2)]
        [InlineData(typeof(Spare), 0, 1)]
        [InlineData(typeof(Strike), 0, 1)]
        public void BallAttributeCount(Type t, int constructorIndex, int expectedCount)
        {
            IEnumerable<ConstructorInfo> constructors = t.GetConstructors(BindingFlags.Instance | BindingFlags.Public);

            IEnumerable<ScoreSheetBallAttribute> attributes = constructors.ElementAt(constructorIndex).GetCustomAttributes<ScoreSheetBallAttribute>(false);

            Assert.Equal<int>(expectedCount, attributes.Count());
        }
    }
}
