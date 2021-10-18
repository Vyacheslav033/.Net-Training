using System;
using ChessLibrary.Board;

namespace ChessLibrary.Pieces
{
    /// <summary>
    /// Пешка
    /// </summary>
    public class Pawn : Piece
    {
        /// <summary>
        /// Инициализатор класса Pawn.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        public Pawn(Position position) : base (position)
        { }
    }
}
