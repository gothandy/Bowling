using Bowling;
using Xunit;
using System.Linq;

namespace BowlingTests
{
    public class GameTests
    {
        [Fact]
        public void Dutch200()
        {
            Game game = new Game();

            for (int i = 0; i < 4; i++)
            {
                game.AddFrame(new Spare(5));
                game.AddFrame(new Strike());
            }

            game.AddFrame(new Strike());
            game.AddFrame(new FinalSpare(5, 5));

            Assert.Equal(10, game.Frames.Count());
            Assert.Equal<int>(200, game.TotalScore);
        }

        [Fact]
        public void AllOpenNines()
        {
            Game game = new Game();

            for (int i = 0; i < 10; i++)
            {
                game.AddFrame(new Open(9,0));
            }

            Assert.Equal(10, game.Frames.Count());
            Assert.Equal<int>(90, game.TotalScore);
        }

        [Fact]
        public void PerfectGame()
        {
            Game game = new Game();

            for (int i = 0; i < 9; i++)
            {
                game.AddFrame(new Strike());
            }

            game.AddFrame(new FinalStrike(10, 10));

            Assert.Equal(10, game.Frames.Count());
            Assert.Equal<int>(300, game.TotalScore);
        }

        [Fact]
        public void AllSpares()
        {
            Game game = new Game();

            for (int i = 0; i < 9; i++)
            {
                game.AddFrame(new Spare(5));
            }

            game.AddFrame(new FinalSpare(5, 5));

            Assert.Equal(10, game.Frames.Count());
            Assert.Equal<int>(150, game.TotalScore);
        }
    }
}
