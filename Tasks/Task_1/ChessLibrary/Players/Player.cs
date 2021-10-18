using System;
using System.Collections.Generic;
using ChessLibrary.Pieces;
using ChessLibrary.Board;

namespace ChessLibrary.Players
{
    /// <summary>
    /// Игрок.
    /// </summary>
    public abstract class Player
    {
        protected List<Piece> pieces;

        /// <summary>
        /// Фигуры игрока.
        /// </summary>
        public List<Piece> Pieces
        {
            get { return pieces; }
        }
    }
}
