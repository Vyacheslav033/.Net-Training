using System;

namespace ChessLibrary
{
    /// <summary>
    /// Король.
    /// </summary>
    public class King : Piece
    {
        /// <summary>
        /// Инициализатор класса King.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        /// <param name="color"> Цвет фигуры. </param>
        public King(Position position, PieceColor color) : base(position, color)
        { }
    }
}
