using System;

namespace ChessLibrary
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
        /// <param name="color"> Цвет фигуры. </param>
        public Queen(Position position, PieceColor color) : base(position, color)
        { }
    }
}
