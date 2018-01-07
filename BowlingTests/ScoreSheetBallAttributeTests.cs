using Bowling;
using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace BowlingTests
{
    public class ScoreSheetBallAttributeTests
    {
        [Theory]
        [InlineData(typeof(Ball), 1)]
        [InlineData(typeof(Miss), 1)]
        [InlineData(typeof(Foul), 1)]
        [InlineData(typeof(Spare), 1)]
        [InlineData(typeof(Strike), 1)]
        public void ConstructorCount(Type t, int expectedCount)
        {
            var constructors = t.GetConstructors(BindingFlags.Instance|BindingFlags.Public);

            Assert.Equal(expectedCount, constructors.Count());
        }

        [Theory]
        [InlineData(typeof(Ball), 0, 1)]
        [InlineData(typeof(Miss), 0, 1)]
        [InlineData(typeof(Foul), 0, 1)]
        [InlineData(typeof(Spare), 0, 1)]
        [InlineData(typeof(Strike), 0, 1)]
        public void BallAttributeCount(Type t, int constructorIndex, int expectedCount)
        {
            var constructors = t.GetConstructors(BindingFlags.Instance | BindingFlags.Public);

            var attributes = constructors.ElementAt(constructorIndex).GetCustomAttributes<BallAttribute>(false);

            Assert.Equal(expectedCount, attributes.Count());
        }

        [Theory]
        [InlineData(typeof(Miss), 0, 0, '-')]
        [InlineData(typeof(Foul), 0, 0, 'F')]
        [InlineData(typeof(Spare), 0, 0, '/')]
        [InlineData(typeof(Strike), 0, 0, 'X')]
        public void BallAttributeChar(Type t, int c, int a, char e)
        {
            var constructors = t.GetConstructors(BindingFlags.Instance | BindingFlags.Public);

            var attribute = constructors.ElementAt(c).GetCustomAttributes<BallAttribute>(false).ElementAt(a);

            Assert.Equal<char>(e, attribute.ScoreSheetChar);
        }

        [Theory]
        [InlineData(typeof(Ball), 0, 0, typeof(int))]
        [InlineData(typeof(Spare), 0, 0, typeof(Ball))]
        public void BallAttributeParameterType(Type b, int c, int p, Type t)
        {
            var constructors = b.GetConstructors(BindingFlags.Instance | BindingFlags.Public);

            var parameter = constructors.ElementAt(c).GetParameters().ElementAt(p);

            Assert.Equal(t, parameter.ParameterType);
        }

        [Theory]
        [InlineData(typeof(Ball))]
        [InlineData(typeof(Spare))]
        [InlineData(typeof(Strike))]
        public void BallAttributeTypeExists(Type e)
        {
            Assert.True(Assembly.GetAssembly(typeof(Ball)).GetTypes().Where(t => (t == e)).Count() == 1);
        }
    }
}
