using System;

namespace ChessLibrary
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
        /// <param name="color"> Цвет фигуры. </param>
        public Knight(Position position, PieceColor color) : base(position, color)
        { }

        public override MoveStatus CheckMove(CheesBoard board, Position pos)
        {
            throw new NotImplementedException();
        }
    }
}
