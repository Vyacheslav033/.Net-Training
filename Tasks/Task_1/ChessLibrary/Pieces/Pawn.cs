using System;

namespace ChessLibrary
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
        /// <param name="color"> Цвет фигуры. </param>
        public Pawn(Position position, PieceColor color) : base (position, color)
        { } 
    }
}
