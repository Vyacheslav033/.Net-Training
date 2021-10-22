using System;
using System.Collections.Generic;

namespace ChessLibrary
{
    /// <summary>
    /// Игрок за чёрных.
    /// </summary>
    public class BlackPlayer : Player
    {
        /// <summary>
        /// Инициализатор класса BlackPlayer.
        /// </summary>
        public BlackPlayer()
        {
            pieces = new List<Piece>()
            {
                new Rook(new Position("a", 8), PieceColor.Black),
                new Knight(new Position("b", 8), PieceColor.Black),
                new Bishop(new Position("c", 8), PieceColor.Black),
                new King(new Position("d", 8), PieceColor.Black),
                new Queen(new Position("e", 8), PieceColor.Black),
                new Bishop(new Position("f", 8), PieceColor.Black),
                new Knight(new Position("g", 8), PieceColor.Black),
                new Rook(new Position("h", 8), PieceColor.Black),
                new Pawn(new Position("a", 7), PieceColor.Black),
                new Pawn(new Position("b", 7), PieceColor.Black),
                new Pawn(new Position("c", 7), PieceColor.Black),
                new Pawn(new Position("d", 7), PieceColor.Black),
                new Pawn(new Position("e", 7), PieceColor.Black),
                new Pawn(new Position("f", 7), PieceColor.Black),
                new Pawn(new Position("g", 7), PieceColor.Black),
                new Pawn(new Position("h", 7), PieceColor.Black),
            };
        }

    }
}
