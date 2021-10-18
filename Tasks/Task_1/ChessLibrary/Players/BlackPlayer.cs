using System;
using System.Collections.Generic;
using ChessLibrary.Pieces;
using ChessLibrary.Board;

namespace ChessLibrary.Players
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
                new Rook(new Position("a", 8)),
                new Knight(new Position("b", 8)),
                new Bishop(new Position("c", 8)),
                new King(new Position("d", 8)),
                new Queen(new Position("e", 8)),
                new Bishop(new Position("f", 8)),
                new Knight(new Position("g", 8)),
                new Rook(new Position("h", 8)),
                new Pawn(new Position("a", 7)),
                new Pawn(new Position("b", 7)),
                new Pawn(new Position("c", 7)),
                new Pawn(new Position("d", 7)),
                new Pawn(new Position("e", 7)),
                new Pawn(new Position("f", 7)),
                new Pawn(new Position("g", 7)),
                new Pawn(new Position("h", 7)),
            };
        }
    }
}
