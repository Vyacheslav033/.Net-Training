using System;
using System.Collections.Generic;

namespace ChessLibrary
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
