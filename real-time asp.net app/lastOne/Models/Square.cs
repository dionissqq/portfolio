using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace lastOne.Models
{
    [Serializable]
    public abstract class PieceState
    {
        public abstract bool hasPiece();
    }
    [Serializable]
    public class WPieceState : PieceState
    {
        public override bool hasPiece()
        {
            return true;
        }
    }
    [Serializable]
    public class WithoutPieceState : PieceState
    {
        public override bool hasPiece()
        {
            return false;
        }
    }
    [Serializable]
    public abstract class AbstractSquare
    {
        abstract public void setPiece(CertainPiece piece);
        abstract public void removePiece();
        abstract public CertainPiece getPiece();
        abstract public bool getPieceState();
        abstract public ShogiPieces getPieceType();
        abstract public Promoted getPromotion();
        abstract public void changeOwner(Players player);
    }

    [Serializable]
    public class SquareWithotCoordinates : AbstractSquare
    {
        public PieceState _pieceState { get; set; } = new WithoutPieceState();
        public CertainPiece _piece { get; set; }
        public override void setPiece(CertainPiece piece)
        {
            _piece = piece;
            _pieceState = new WPieceState();
        }
        public override void changeOwner(Players player)
        {
            _piece.setPlayer(player);
        }
        public override CertainPiece getPiece()
        {
            return this._piece;
        }
        public override Promoted getPromotion()
        {
            return _piece.getPromotion();
        }
        public override ShogiPieces getPieceType()
        {
            return _piece.getPieceType();
        }
        public override void removePiece()
        {
            _piece = null;
            _pieceState = new WithoutPieceState();
        }
        public override bool getPieceState()
        {
            return _pieceState.hasPiece();
        }
        public Players getPiecePlayer()
        {
            return _piece.getPlayer();
        }
        public SquareWithotCoordinates copy()
        {
            SquareWithotCoordinates sq;
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("data.bin", FileMode.Create))
            {
                formatter.Serialize(stream, this);
            }

            using (Stream stream = new FileStream("data.bin", FileMode.Open))
            {
                sq = (SquareWithotCoordinates)formatter.Deserialize(stream);
            }
            return sq;
        }
    }
    public class Square : AbstractSquare
    {
        private PossibleMovesStrategy strategy;
        public int x { get; set; }
        public int y { get; set; }
        public SquareWithotCoordinates _square { get; set; }
        public Square(SquareWithotCoordinates sq)
        {
            _square = sq;
        }
        public List<Square> getPossibleMoves(MainBoard board, bool side)
        {
            List<Square> squares = new List<Square>();
            if (this.getPieceState())
            {
                strategy = StrategiesFactory.getPossibleMovesStrategy(getPiece(), side);
                squares = strategy.possibleMoves(board, this);
            }
            return squares;
        }
        public override Promoted getPromotion()
        {
            return _square.getPromotion();
        }
        public override void changeOwner(Players player)
        {
            _square.changeOwner(player);
        }
        public override CertainPiece getPiece()
        {
            //if (!getPieceState() || Globals.move.player != getOwner())
            if (!getPieceState())
                return null;
            return this._square.getPiece();
        }
        public override void setPiece(CertainPiece piece)
        {
            if (_square != null)
                _square.setPiece(piece);
        }
        public override ShogiPieces getPieceType()
        {
            return _square.getPieceType();
        }
        public override void removePiece()
        {
            if (_square != null)
                _square.removePiece();
        }
        public override bool getPieceState()
        {
            if (_square != null)
                return _square.getPieceState();
            else
                return new WithoutPieceState().hasPiece();
        }
        public Players getOwner()
        {
            return _square.getPiecePlayer();
        }
    }
}
