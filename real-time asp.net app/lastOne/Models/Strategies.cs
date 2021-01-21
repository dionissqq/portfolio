using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lastOne.Models
{
    interface factoryInterface
    {
        KingMovesStrategy CreateKingPossibleMovesStrategy();
        GoldMovesStrategy CreateGoldPossibleMovesStrategy();
        SilverMovesStrategy CreateSilverPossibleMovesStrategy();
        PawnMovesStrategy CreatePawnPossibleMovesStrategy();
        KnightMovesStrategy CreateKnightPossibleMovesStrategy();
        RookMovesStrategy CreateRookPossibleMovesStrategy();
        LanceMovesStrategy CreateLancePossibleMovesStrategy();
        BishopMovesStrategy CreateBishopPossibleMovesStrategy();
        PromotedBishopMovesStrategy CreatePromotedBishopPossibleMovesStrategy();
        PromotedRookMovesStrategy CreatePromotedRookPossibleMovesStrategy();
    }
    abstract class SideBoardAbstractPlayerStrategiesFactory : factoryInterface
    {
        public abstract KingMovesStrategy CreateKingPossibleMovesStrategy();
        public abstract GoldMovesStrategy CreateGoldPossibleMovesStrategy();
        public abstract SilverMovesStrategy CreateSilverPossibleMovesStrategy();
        public abstract PawnMovesStrategy CreatePawnPossibleMovesStrategy();
        public abstract KnightMovesStrategy CreateKnightPossibleMovesStrategy();
        public abstract RookMovesStrategy CreateRookPossibleMovesStrategy();
        public abstract LanceMovesStrategy CreateLancePossibleMovesStrategy();
        public abstract BishopMovesStrategy CreateBishopPossibleMovesStrategy();
        public abstract PromotedBishopMovesStrategy CreatePromotedBishopPossibleMovesStrategy();
        public abstract PromotedRookMovesStrategy CreatePromotedRookPossibleMovesStrategy();
    }
    class SideBoardPlayer1StrategiesFactory : SideBoardAbstractPlayerStrategiesFactory
    {
        public override KingMovesStrategy CreateKingPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override GoldMovesStrategy CreateGoldPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override SilverMovesStrategy CreateSilverPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override PawnMovesStrategy CreatePawnPossibleMovesStrategy()
        {
            return new SideBoardPlayer1PawnPossibleMovesStrategy();
        }
        public override KnightMovesStrategy CreateKnightPossibleMovesStrategy()
        {
            return new SideBoardPlayer1KnigthPossibleMovesStrategy();
        }
        public override RookMovesStrategy CreateRookPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override LanceMovesStrategy CreateLancePossibleMovesStrategy()
        {
            return new SideBoardPlayer1LancePossibleMovesStrategy();
        }
        public override BishopMovesStrategy CreateBishopPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override PromotedBishopMovesStrategy CreatePromotedBishopPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override PromotedRookMovesStrategy CreatePromotedRookPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
    }
    class SideBoardPlayer2StrategiesFactory : SideBoardAbstractPlayerStrategiesFactory
    {
        public override KingMovesStrategy CreateKingPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override GoldMovesStrategy CreateGoldPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override SilverMovesStrategy CreateSilverPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override PawnMovesStrategy CreatePawnPossibleMovesStrategy()
        {
            return new SideBoardPlayer2PawnPossibleMovesStrategy();
        }
        public override KnightMovesStrategy CreateKnightPossibleMovesStrategy()
        {
            return new SideBoardPlayer2KnigthPossibleMovesStrategy();
        }
        public override RookMovesStrategy CreateRookPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override LanceMovesStrategy CreateLancePossibleMovesStrategy()
        {
            return new SideBoardPlayer2LancePossibleMovesStrategy();
        }
        public override BishopMovesStrategy CreateBishopPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override PromotedBishopMovesStrategy CreatePromotedBishopPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
        public override PromotedRookMovesStrategy CreatePromotedRookPossibleMovesStrategy()
        {
            return new SideBoardOtherPossibleMovesStrategy();
        }
    }
    abstract class AbstractPlayerStrategiesFactory : factoryInterface
    {
        public abstract KingMovesStrategy CreateKingPossibleMovesStrategy();
        public abstract GoldMovesStrategy CreateGoldPossibleMovesStrategy();
        public abstract SilverMovesStrategy CreateSilverPossibleMovesStrategy();
        public abstract PawnMovesStrategy CreatePawnPossibleMovesStrategy();
        public abstract KnightMovesStrategy CreateKnightPossibleMovesStrategy();
        public abstract RookMovesStrategy CreateRookPossibleMovesStrategy();
        public abstract LanceMovesStrategy CreateLancePossibleMovesStrategy();
        public abstract BishopMovesStrategy CreateBishopPossibleMovesStrategy();
        public abstract PromotedBishopMovesStrategy CreatePromotedBishopPossibleMovesStrategy();
        public abstract PromotedRookMovesStrategy CreatePromotedRookPossibleMovesStrategy();
    }
    class Player1StrategiesFactory : AbstractPlayerStrategiesFactory
    {
        public override KingMovesStrategy CreateKingPossibleMovesStrategy()
        {
            return new Player1KingPossibleMovesStrategy();
        }
        public override GoldMovesStrategy CreateGoldPossibleMovesStrategy()
        {
            return new Player1GoldPossibleMovesStrategy();
        }
        public override SilverMovesStrategy CreateSilverPossibleMovesStrategy()
        {
            return new Player1SilverPossibleMovesStrategy();
        }
        public override PawnMovesStrategy CreatePawnPossibleMovesStrategy()
        {
            return new Player1PawnPossibleMovesStrategy();
        }
        public override KnightMovesStrategy CreateKnightPossibleMovesStrategy()
        {
            return new Player1KnigthPossibleMovesStrategy();
        }
        public override RookMovesStrategy CreateRookPossibleMovesStrategy()
        {
            return new RookPossibleMovesStrategy();
        }
        public override LanceMovesStrategy CreateLancePossibleMovesStrategy()
        {
            return new Player1LancePossibleMovesStrategy();
        }
        public override BishopMovesStrategy CreateBishopPossibleMovesStrategy()
        {
            return new BishopPossibleMovesStrategy();
        }
        public override PromotedBishopMovesStrategy CreatePromotedBishopPossibleMovesStrategy()
        {
            return new PromotedBishopPossibleMovesStrategy();
        }
        public override PromotedRookMovesStrategy CreatePromotedRookPossibleMovesStrategy()
        {
            return new PromotedRookPossibleMovesStrategy();
        }
    }
    class Player2StrategiesFactory : AbstractPlayerStrategiesFactory
    {
        public override KingMovesStrategy CreateKingPossibleMovesStrategy()
        {
            return new Player2KingPossibleMovesStrategy();
        }
        public override GoldMovesStrategy CreateGoldPossibleMovesStrategy()
        {
            return new Player2GoldPossibleMovesStrategy();
        }
        public override SilverMovesStrategy CreateSilverPossibleMovesStrategy()
        {
            return new Player2SilverPossibleMovesStrategy();
        }
        public override PawnMovesStrategy CreatePawnPossibleMovesStrategy()
        {
            return new Player2PawnPossibleMovesStrategy();
        }
        public override KnightMovesStrategy CreateKnightPossibleMovesStrategy()
        {
            return new Player2KnigthPossibleMovesStrategy();
        }
        public override RookMovesStrategy CreateRookPossibleMovesStrategy()
        {
            return new RookPossibleMovesStrategy();
        }
        public override LanceMovesStrategy CreateLancePossibleMovesStrategy()
        {
            return new Player2LancePossibleMovesStrategy();
        }
        public override BishopMovesStrategy CreateBishopPossibleMovesStrategy()
        {
            return new BishopPossibleMovesStrategy();
        }
        public override PromotedBishopMovesStrategy CreatePromotedBishopPossibleMovesStrategy()
        {
            return new PromotedBishopPossibleMovesStrategy();
        }
        public override PromotedRookMovesStrategy CreatePromotedRookPossibleMovesStrategy()
        {
            return new PromotedRookPossibleMovesStrategy();
        }
    }
    interface PossibleMovesStrategy
    {
        List<Square> possibleMoves(Board board, Square current);
    }
    interface KingMovesStrategy : PossibleMovesStrategy
    {

    }

    class Player1KingPossibleMovesStrategy : KingMovesStrategy
    {
        public List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i < 9 && j < 9 && i >= 0 && j >= 0 && !(i == x && j == y))
                    {
                        Square sq = board.getAt(j, i);
                        if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                            possibleMoves.Add(sq);
                    }
                }
            return possibleMoves;
        }
    }
    class Player2KingPossibleMovesStrategy : KingMovesStrategy
    {
        public List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i < 9 && j < 9 && i >= 0 && j >= 0 && !(i == x && j == y))
                    {
                        Square sq = board.getAt(j, i);
                        if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                            possibleMoves.Add(sq);
                    }
                }
            return possibleMoves;
        }
    }
    interface GoldMovesStrategy : PossibleMovesStrategy
    {
    }
    class Player1GoldPossibleMovesStrategy : GoldMovesStrategy
    {
        public List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (!(i == x && j == y) && i >= 0 && j >= 0 && i < 9 && j < 9 && !(i == (x + 1) && j == (y - 1)) && !(i == (x - 1) && j == (y - 1)))
                    {
                        Square sq = board.getAt(j, i);
                        if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                            possibleMoves.Add(sq);
                    }
                }

            return possibleMoves;
        }
    }
    class Player2GoldPossibleMovesStrategy : GoldMovesStrategy
    {
        public List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (!(i == x && j == y) && i >= 0 && j >= 0 && i < 9 && j < 9 && !(i == (x + 1) && j == (y + 1)) && !(i == (x - 1) && j == (y + 1)))
                    {
                        Square sq = board.getAt(j, i);
                        if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                            possibleMoves.Add(sq);
                    }
                }

            return possibleMoves;
        }
    }
    interface SilverMovesStrategy : PossibleMovesStrategy
    {

    }

    class Player1SilverPossibleMovesStrategy : SilverMovesStrategy
    {
        public List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                {

                    if (!(i == x && j == y) && i >= 0 && j >= 0 && i < 9 && j < 9 && !(i == x && j == (y - 1)) && !(i == (x + 1) && j == y) && !(i == (x - 1) && j == y))
                    {
                        Square sq = board.getAt(j, i);
                        if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                            possibleMoves.Add(sq);
                    }
                }

            return possibleMoves;
        }
    }
    class Player2SilverPossibleMovesStrategy : SilverMovesStrategy
    {
        public List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                {

                    if (!(i == x && j == y) && i >= 0 && j >= 0 && i < 9 && j < 9 && !(i == x && j == (y + 1)) && !(i == (x + 1) && j == y) && !(i == (x - 1) && j == y))
                    {
                        Square sq = board.getAt(j, i);
                        if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                            possibleMoves.Add(sq);
                    }
                }

            return possibleMoves;
        }
    }
    abstract class PawnMovesStrategy : PossibleMovesStrategy
    {
        abstract public List<Square> possibleMoves(Board board, Square current);
    }
    class Player1PawnPossibleMovesStrategy : PawnMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {

            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            if (y < 8)
            {
                Square sq = board.getAt(y + 1, x);
                if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                {
                    possibleMoves.Add(sq);
                }
            }

            return possibleMoves;
        }
    }
    class Player2PawnPossibleMovesStrategy : PawnMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {

            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            if (y > 0)
            {
                Square sq = board.getAt(y - 1, x);
                if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                {
                    possibleMoves.Add(sq);
                }
            }

            return possibleMoves;
        }
    }
    class SideBoardPlayer1PawnPossibleMovesStrategy : PawnMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {
            CertainPiece piece = current.getPiece();
            List<Square> list = new List<Square>();
            int y;
            y = 8;
            for (int i = 0; i < 9; i++)
            {
                bool cannot = false;
                for (int j = 0; j < 9; j++)
                    if (board.getAt(j, i).getPieceState() && board.getAt(j, i).getPieceType() == ShogiPieces.Pawn && board.getAt(j, i).getOwner() == piece.getPlayer())
                    {
                        cannot = true;
                        break;
                    }
                if (cannot)
                    continue;
                for (int j = 0; j < y; j++)
                {
                    if (!board.getAt(j, i).getPieceState())
                        list.Add(board.getAt(j, i));
                }
            }
            return list;
        }
    }
    class SideBoardPlayer2PawnPossibleMovesStrategy : PawnMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {

            CertainPiece piece = current.getPiece();
            List<Square> list = new List<Square>();
            int y;
            y = 8;
            for (int i = 0; i < 9; i++)
            {
                bool cannot = false;
                for (int j = 0; j < 9; j++)
                    if (board.getAt(j, i).getPieceState() && board.getAt(j, i).getPieceType() == ShogiPieces.Pawn && board.getAt(j, i).getOwner() == piece.getPlayer())
                    {
                        cannot = true;
                        break;
                    }
                if (cannot)
                    continue;
                for (int j = 8; j > 8 - y; j--)
                {
                    if (!board.getAt(j, i).getPieceState())
                        list.Add(board.getAt(j, i));
                }
            }
            return list;
        }
    }
    abstract class KnightMovesStrategy : PossibleMovesStrategy
    {
        abstract public List<Square> possibleMoves(Board board, Square current);
    }
    class Player1KnigthPossibleMovesStrategy : KnightMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            if (y < 7 && x > 0)
            {
                Square sq = board.getAt(y + 2, x - 1);
                if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                    possibleMoves.Add(sq);
            }
            if (y < 7 && x < 8)
            {
                Square sq = board.getAt(y + 2, x + 1);
                if ((!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner()))))
                    possibleMoves.Add(sq);
            }

            return possibleMoves;
        }
    }
    class Player2KnigthPossibleMovesStrategy : KnightMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            if (y > 1 && x > 0)
            {
                Square sq = board.getAt(y - 2, x - 1);
                if ((!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner()))))
                    possibleMoves.Add(sq);
            }
            if (y > 1 && x < 8)
            {
                Square sq = board.getAt(y - 2, x + 1);
                if ((!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner()))))
                    possibleMoves.Add(sq);
            }

            return possibleMoves;
        }
    }
    class SideBoardPlayer1KnigthPossibleMovesStrategy : KnightMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {
            CertainPiece piece = current.getPiece();
            List<Square> list = new List<Square>();
            int y;
            y = 7;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (!board.getAt(j, i).getPieceState())
                        list.Add(board.getAt(j, i));
                }
            }
            return list;
        }
    }
    class SideBoardPlayer2KnigthPossibleMovesStrategy : KnightMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {
            CertainPiece piece = current.getPiece();
            List<Square> list = new List<Square>();
            int y;
            y = 7;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (!board.getAt(j, i).getPieceState())
                        list.Add(board.getAt(j, i));
                }
            }
            return list;
        }
    }

    class SideBoardOtherPossibleMovesStrategy : KingMovesStrategy, GoldMovesStrategy, SilverMovesStrategy, RookMovesStrategy, BishopMovesStrategy, PromotedBishopMovesStrategy, PromotedRookMovesStrategy
    {
        public List<Square> possibleMoves(Board board, Square current)
        {
            CertainPiece piece = current.getPiece();
            List<Square> list = new List<Square>();
            int y;
            y = 9;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (!board.getAt(j, i).getPieceState())
                        list.Add(board.getAt(j, i));
                }
            }
            return list;
        }
    }

    abstract class LanceMovesStrategy : PossibleMovesStrategy
    {
        abstract public List<Square> possibleMoves(Board board, Square current);
    }
    class Player1LancePossibleMovesStrategy : LanceMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            for (int i = y + 1; i < 9; i++)
            {
                Square sq = board.getAt(i, x);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            return possibleMoves;
        }
    }
    class Player2LancePossibleMovesStrategy : LanceMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            for (int i = y - 1; i >= 0; i--)
            {
                Square sq = board.getAt(i, x);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }

            return possibleMoves;
        }
    }
    class SideBoardPlayer1LancePossibleMovesStrategy : LanceMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {
            CertainPiece piece = current.getPiece();
            List<Square> list = new List<Square>();
            int y;
            y = 8;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (!board.getAt(j, i).getPieceState())
                        list.Add(board.getAt(j, i));
                }
            }
            return list;
        }
    }
    class SideBoardPlayer2LancePossibleMovesStrategy : LanceMovesStrategy
    {
        public override List<Square> possibleMoves(Board board, Square current)
        {
            CertainPiece piece = current.getPiece();
            List<Square> list = new List<Square>();
            int y;
            y = 8;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (!board.getAt(j, i).getPieceState())
                        list.Add(board.getAt(j, i));
                }
            }
            return list;
        }
    }



    interface RookMovesStrategy : PossibleMovesStrategy
    {

    }
    class RookPossibleMovesStrategy : RookMovesStrategy
    {
        public List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;

            for (int i = y + 1; i < 9; i++)
            {
                Square sq = board.getAt(i, x);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = y - 1; i >= 0; i--)
            {
                Square sq = board.getAt(i, x);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = x + 1; i < 9; i++)
            {
                Square sq = board.getAt(y, i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = x - 1; i >= 0; i--)
            {
                Square sq = board.getAt(y, i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }

            return possibleMoves;
        }
    }
    interface PromotedRookMovesStrategy : PossibleMovesStrategy
    {

    }
    class PromotedRookPossibleMovesStrategy : PromotedRookMovesStrategy
    {
        public List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;
            for (int i = y + 1; i < 9; i++)
            {
                Square sq = board.getAt(i, x);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = y - 1; i >= 0; i--)
            {
                Square sq = board.getAt(i, x);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = x + 1; i < 9; i++)
            {
                Square sq = board.getAt(y, i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = x - 1; i >= 0; i--)
            {
                Square sq = board.getAt(y, i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            if (x < 8 && y < 8)
            {
                Square sq = board.getAt(y + 1, x + 1);
                if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                    possibleMoves.Add(sq);
            }
            if (x < 8 && y > 0)
            {
                Square sq = board.getAt(y - 1, x + 1);
                if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                    possibleMoves.Add(sq);
            }
            if (x > 0 && y < 8)
            {
                Square sq = board.getAt(y + 1, x - 1);
                if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                    possibleMoves.Add(sq);
            }
            if (x > 0 && y > 0)
            {
                Square sq = board.getAt(y - 1, x - 1);
                if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                    possibleMoves.Add(sq);
            }
            return possibleMoves;
        }
    }
    interface BishopMovesStrategy : PossibleMovesStrategy
    {

    }
    class BishopPossibleMovesStrategy : BishopMovesStrategy
    {
        public List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;
            for (int i = 1; x + i < 9 && y + i < 9; i++)
            {
                Square sq = board.getAt(y + i, x + i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = 1; x - i >= 0 && y - i >= 0; i++)
            {
                Square sq = board.getAt(y - i, x - i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = 1; x + i < 9 && y - i >= 0; i++)
            {
                Square sq = board.getAt(y - i, x + i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = 1; x - i >= 0 && y + i < 9; i++)
            {
                Square sq = board.getAt(y + i, x - i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            return possibleMoves;
        }
    }
    interface PromotedBishopMovesStrategy : PossibleMovesStrategy
    {
    }
    class PromotedBishopPossibleMovesStrategy : PromotedBishopMovesStrategy
    {
        public List<Square> possibleMoves(Board board, Square current)
        {
            List<Square> possibleMoves = new List<Square>();
            int x = current.x;
            int y = current.y;
            for (int i = 1; x + i < 9 && y + i < 9; i++)
            {
                Square sq = board.getAt(y + i, x + i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = 1; x - i >= 0 && y - i >= 0; i++)
            {
                Square sq = board.getAt(y - i, x - i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = 1; x + i < 9 && y - i >= 0; i++)
            {
                Square sq = board.getAt(y - i, x + i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            for (int i = 1; x - i > 0 && y + i < 9; i++)
            {
                Square sq = board.getAt(y + i, x - i);
                if (!sq.getPieceState())
                    possibleMoves.Add(sq);
                if (sq.getPieceState())
                {
                    if (sq.getOwner() != current.getOwner())
                        possibleMoves.Add(sq);
                    break;
                }
            }
            if (x < 9 && y < 8)
            {
                Square sq = board.getAt(y + 1, x);
                if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                    possibleMoves.Add(sq);
            }
            if (x < 8 && y > 9)
            {
                Square sq = board.getAt(y, x + 1);
                if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                    possibleMoves.Add(sq);
            }
            if (x > 0 && y < 9)
            {
                Square sq = board.getAt(y, x - 1);
                if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                    possibleMoves.Add(sq);
            }
            if (x < 9 && y > 0)
            {
                Square sq = board.getAt(y - 1, x);
                if (!sq.getPieceState() || (sq.getPieceState() && (sq.getOwner() != current.getOwner())))
                    possibleMoves.Add(sq);
            }
            return possibleMoves;
        }
    }
    abstract class MovesFactory
    {
        public abstract PossibleMovesStrategy getPossibleMovesStrategy(CertainPiece piece, bool side);
    }
    class PossibleMovesFactory : MovesFactory
    {
        factoryInterface factory;
        public override PossibleMovesStrategy getPossibleMovesStrategy(CertainPiece piece, bool side)
        {
            if (!side)
            {
                if (piece.getPlayer() == Players.Player1)
                    factory = new Player1StrategiesFactory();
                else
                    factory = new Player2StrategiesFactory();
            }
            else
            {
                if (piece.getPlayer() == Players.Player1)
                    factory = new SideBoardPlayer1StrategiesFactory();
                else
                    factory = new SideBoardPlayer2StrategiesFactory();
            }


            PossibleMovesStrategy strategy = factory.CreateKingPossibleMovesStrategy();
            switch (piece.getStringPieceType())
            {
                case "King":
                    strategy = factory.CreateKingPossibleMovesStrategy();
                    break;
                case "Gold":
                    strategy = factory.CreateGoldPossibleMovesStrategy();
                    break;
                case "Silver":
                    strategy = factory.CreateSilverPossibleMovesStrategy();
                    break;
                case "Knight":
                    strategy = factory.CreateKnightPossibleMovesStrategy();
                    break;
                case "Lance":
                    strategy = factory.CreateLancePossibleMovesStrategy();
                    break;
                case "Pawn":
                    strategy = factory.CreatePawnPossibleMovesStrategy();
                    break;
                case "Rook":
                    strategy = factory.CreateRookPossibleMovesStrategy();
                    break;
                case "Bishop":
                    strategy = factory.CreateBishopPossibleMovesStrategy();
                    break;
                case "PromotedGold":
                    strategy = factory.CreateGoldPossibleMovesStrategy();
                    break;
                case "PromotedSilver":
                    strategy = factory.CreateGoldPossibleMovesStrategy();
                    break;
                case "PromotedKnight":
                    strategy = factory.CreateGoldPossibleMovesStrategy();
                    break;
                case "PromotedLance":
                    strategy = factory.CreateGoldPossibleMovesStrategy();
                    break;
                case "PromotedPawn":
                    strategy = factory.CreateGoldPossibleMovesStrategy();
                    break;
                case "PromotedRook":
                    strategy = factory.CreatePromotedRookPossibleMovesStrategy();
                    break;
                case "PromotedBishop":
                    strategy = factory.CreatePromotedBishopPossibleMovesStrategy();
                    break;
            }
            return strategy;
        }
    }
}
