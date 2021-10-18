using System;
using ChessLibrary.Board;

namespace ChessLibrary.Pieces
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
        public Rook(Position position) : base(position)
        { }
    }
}
