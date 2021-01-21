using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lastOne.Models
{
    public enum ShogiPieces
    {
        None,
        King,
        Rook,
        Bishop,
        Gold,
        Silver,
        Knight,
        Lance,
        Pawn
    }
    public enum Promoted
    {
        Promoted,
        Unpromoted
    }
    [Serializable]
    public abstract class Piece
    {
        public ShogiPieces pieceClass { get; set; }
        public abstract ShogiPieces getPieceType();
        public abstract string getStringPieceType();
    }
    [Serializable]
    public class JustPiece : Piece
    {
        public JustPiece(ShogiPieces pieceClass)
        {
            this.pieceClass = pieceClass;
        }
        public override ShogiPieces getPieceType()
        {
            return pieceClass;
        }
        public override string getStringPieceType()
        {
            return pieceClass.ToString();
        }

    }
    [Serializable]
    public class CertainPiece : Piece
    {
        public JustPiece _piece { get; set; }
        public Players player { get; set; }
        public Promoted promotion { get; set; } = Promoted.Unpromoted;
        public CertainPiece(JustPiece piece, Players player)
        {
            this._piece = piece;
            this.player = player;
        }
        public override ShogiPieces getPieceType()
        {
            return _piece.getPieceType();
        }
        public override string getStringPieceType()
        {
            string str = _piece.getStringPieceType();
            if (promotion == Promoted.Promoted)
                str = "Promoted" + str;
            return str;
        }
        public Promoted getPromotion()
        {
            return promotion;
        }
        public void promote()
        {
            promotion = Promoted.Promoted;
        }
        public void depromote()
        {
            promotion = Promoted.Unpromoted;
        }
        public void setPlayer(Players player)
        {
            this.player = player;
        }
        public Players getPlayer()
        {
            return player;
        }
        public void switchPlayer()
        {
            if (this.player == Players.Player1)
                this.player = Players.Player2;
            else
                this.player = Players.Player1;
        }
    }

    class JustPieceFactory
    {
        private Hashtable pieces = new Hashtable();
        public JustPiece getPiece(ShogiPieces pieceClass)
        {
            JustPiece piece = pieces[pieceClass] as JustPiece;
            if (piece == null)
            {
                piece = new JustPiece(pieceClass);
                pieces.Add(pieceClass, piece);
            }
            return piece;
        }
    }
}
