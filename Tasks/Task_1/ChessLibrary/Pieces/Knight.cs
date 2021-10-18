using System;
using ChessLibrary.Board;

namespace ChessLibrary.Pieces
{
    /// <summary>
    /// Конь.
    /// </summary>
    public class Knight : Piece
    {
        /// <summary>
        /// Инициализатор класса Knight.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        public Knight(Position position) : base(position)
        { }
    }
}
