using System;
using ChessLibrary.Board;

namespace ChessLibrary.Pieces
{
    /// <summary>
    /// Слон.
    /// </summary>
    public class Bishop : Piece
    {
        /// <summary>
        /// Инициализатор класса Bishop.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        public Bishop(Position position) : base(position)
        { }
    }
}
