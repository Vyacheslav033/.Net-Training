using System;
using System.Collections.Generic;

namespace ChessLibrary
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
        /// <param name="color"> Цвет фигуры. </param>
        public Bishop(Position position, PieceColor color) : base(position, color)
        { }

        public override bool CheckMove(CheesBoard board, Position newPos)
        {
            
            return true;
        }
    }
}
