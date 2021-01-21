using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lastOne.Models
{
    static class StrategiesFactory
    {
        public static PossibleMovesFactory _factory = new PossibleMovesFactory();
        public static PossibleMovesStrategy getPossibleMovesStrategy(CertainPiece piece, bool side)
        {
            return _factory.getPossibleMovesStrategy(piece, side);
        }
    }
}
