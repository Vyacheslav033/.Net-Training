using System;
using ChessLibrary.Board;

namespace ChessLibrary.Pieces
{
    /// <summary>
    /// Шахматная фигура.
    /// </summary>
    public abstract class Piece
    {
        private Position position;

        /// <summary>
        /// Инициализатор класса Piece.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        public Piece(Position position)
        {
            this.position = position;
        }

        /// <summary>
        /// Позиция фигуры.
        /// </summary>
        public Position Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
