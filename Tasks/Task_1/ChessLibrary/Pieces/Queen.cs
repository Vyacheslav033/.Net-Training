using System;
using ChessLibrary.Board;

namespace ChessLibrary.Pieces
{
    /// <summary>
    /// Ферзь.
    /// </summary>
    public class Queen : Piece
    {
        /// <summary>
        /// Инициализатор класса Queen.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        public Queen(Position position) : base(position)
        { }
    }
}
