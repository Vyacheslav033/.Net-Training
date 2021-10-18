using System;
using System.Collections.Generic;
using ChessLibrary.Pieces;
using ChessLibrary.Board;

namespace ChessLibrary.Players
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
                new Rook(new Position("a", 1)),
                new Knight(new Position("b", 1)),
                new Bishop(new Position("c", 1)),
                new King(new Position("d", 1)),
                new Queen(new Position("e", 1)),
                new Bishop(new Position("f", 1)),
                new Knight(new Position("g", 1)),
                new Rook(new Position("h", 1)),
                new Pawn(new Position("a", 2)),
                new Pawn(new Position("b", 2)),
                new Pawn(new Position("c", 2)),
                new Pawn(new Position("d", 2)),
                new Pawn(new Position("e", 2)),
                new Pawn(new Position("f", 2)),
                new Pawn(new Position("g", 2)),
                new Pawn(new Position("h", 2)),
            };
        }
    }
}
