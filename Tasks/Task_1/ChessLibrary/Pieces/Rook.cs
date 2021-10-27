using System;

namespace ChessLibrary
{
    /// <summary>
    /// Ладья.
    /// </summary>
    public class Rook : Piece
    {
        /// <summary>
        /// Инициализатор класса Rook.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        /// <param name="color"> Цвет фигуры. </param>
        public Rook(Position position, PieceColor color) : base(position, color)
        { }

        public override bool CheckMove(CheesBoard board, Position pos)
        {
           
            return true;
        }
    }
}
