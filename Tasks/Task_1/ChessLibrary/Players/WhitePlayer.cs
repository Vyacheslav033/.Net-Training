using System;
using System.Collections.Generic;

namespace ChessLibrary
{
    /// <summary>
    /// Игрок за белых.
    /// </summary>
    public class WhitePlayer : Player
    {
        /// <summary>
        /// Инициализатор класса WhitePlayer.
        /// </summary>
        public WhitePlayer()
        {
            pieces = new List<Piece>()
            {
                new Rook(new Position("a", 1), PieceColor.White),
                new Knight(new Position("b", 1), PieceColor.White),
                new Bishop(new Position("c", 1), PieceColor.White),
                new King(new Position("d", 1), PieceColor.White),
                new Queen(new Position("e", 1), PieceColor.White),
                new Bishop(new Position("f", 1), PieceColor.White),
                new Knight(new Position("g", 1), PieceColor.White),
                new Rook(new Position("h", 1), PieceColor.White),
                new Pawn(new Position("a", 2), PieceColor.White),
                new Pawn(new Position("b", 2), PieceColor.White),
                new Pawn(new Position("c", 2), PieceColor.White),
                new Pawn(new Position("d", 2), PieceColor.White),
                new Pawn(new Position("e", 2), PieceColor.White),
                new Pawn(new Position("f", 2), PieceColor.White),
                new Pawn(new Position("g", 2), PieceColor.White),
                new Pawn(new Position("h", 2), PieceColor.White),
            };
        }

    }
}
