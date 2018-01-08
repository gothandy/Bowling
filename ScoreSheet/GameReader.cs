using System;
using System.Collections.Generic;
using Bowling;

namespace ScoreSheet
{
    public class GameReader
    {
        public static Game GetGame(string scoreSheet)
        {
            Game game = new Game();

            foreach(string frame in scoreSheet.Split(' '))
            {
                game.AddFrame(GetFrame(frame));
            }

            return game;
        }

        public static BaseFrame GetFrame(string frame)
        {
            List<IFrameReader> readerList = new List<IFrameReader>()
            {
                new StrikeReader(),
                new SpareReader(),
                new OpenReader(),
                new FinalSpareReader(),
                new FinalStrikeReader()
            };

            foreach (IFrameReader reader in readerList)
            {
                if (reader.IsMatch(frame)) return reader.GetFrame(frame);
            }

            throw new NotImplementedException();
        }
    }
}