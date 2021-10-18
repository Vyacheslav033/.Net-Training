using System;
using ChessLibrary.Board;

namespace ChessLibrary.Pieces
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
        public King(Position position) : base(position)
        { }
    }
}
