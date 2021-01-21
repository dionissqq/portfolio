using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lastOne.Models
{
    [Serializable]
    public abstract class Board
    {
        abstract public void init(string filename);
        abstract public Square getAt(int x, int y);

    }
    public class MainBoard : Board
    {
        public List<List<Square>> matrix { get; set; } = new List<List<Square>>();
        public string type { get; set; } = "main";

        public override Square getAt(int x, int y)
        {
            return matrix[x][y];
        }
        public override void init(string filename)
        {

        }
        public void initDefault()
        {
            ShogiPieces[,] pieces = new ShogiPieces[9, 9] {
                {ShogiPieces.Lance , ShogiPieces.Knight,ShogiPieces.Silver,ShogiPieces.Gold,ShogiPieces.King,ShogiPieces.Gold,ShogiPieces.Silver,ShogiPieces.Knight,ShogiPieces.Lance},
                {ShogiPieces.None,ShogiPieces.Bishop,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.Rook ,ShogiPieces.None },
                {ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn },
                {ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None },
                {ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None },
                {ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None },
                {ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn,ShogiPieces.Pawn },
                {ShogiPieces.None,ShogiPieces.Rook,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.None,ShogiPieces.Bishop ,ShogiPieces.None },
                {ShogiPieces.Lance , ShogiPieces.Knight,ShogiPieces.Silver,ShogiPieces.Gold,ShogiPieces.King,ShogiPieces.Gold,ShogiPieces.Silver,ShogiPieces.Knight,ShogiPieces.Lance}
            };

            JustPieceFactory factory = new JustPieceFactory();
            SquareWithotCoordinates sqWC = new SquareWithotCoordinates();

            for (int i = 0; i < 9; i++)
            {
                List<Square> list = new List<Square>();
                for (int j = 0; j < 9; j++)
                {
                    Players prayer;
                    if (i > 4)
                        prayer = Players.Player2;
                    else
                        prayer = Players.Player1;
                    SquareWithotCoordinates sqWt = sqWC.copy();
                    if (pieces[i, j] != ShogiPieces.None)
                        sqWt.setPiece(new CertainPiece(factory.getPiece(pieces[i, j]), prayer));
                    Square sqre = new Square(sqWt);
                    sqre.x = j;
                    sqre.y = i;
                    list.Add(sqre);
                }
                matrix.Add(list);
            }
        }
    }
    public class sideBoard
    {
        public Players owner;
        public List<Square> items { set; get; } = new List<Square>();
        public void AddItem(CertainPiece piece)
        {
            SquareWithotCoordinates sqWC = new SquareWithotCoordinates();
            sqWC.setPiece(piece);
            Square sq = new Square(sqWC);
            items.Add(sq);
        }
        public void removeItem(CertainPiece piece)
        {
            Square sp = null;
            foreach (Square sq in items)
            {
                if (sq.getPiece() == piece)
                    sp = sq;
            }
            if (sp != null)
                items.Remove(sp);
        }


    }
}
