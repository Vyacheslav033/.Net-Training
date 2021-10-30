using System;
using System.Collections.Generic;

namespace ChessLibrary
{
    /// <summary>
    /// Игрок.
    /// </summary>
    public abstract class Player
    {
        protected Piece movingPiece;
        protected List<Piece> pieces;

        /// <summary>
        /// Инициализатор класса Player.
        /// </summary>
        public Player()
        {
            movingPiece = null;
            pieces = new List<Piece>();
        }

        /// <summary>
        /// Ходячая фигура.
        /// </summary>
        public Piece MovingPiece
        {
            get { return movingPiece; }
            set
            {
                if ( SearchPiece(value) )
                {
                    movingPiece = value;                 
                }
                else
                {
                    movingPiece = null;
                }
            }
        }

        /// <summary>
        /// Фигуры игрока.
        /// </summary>
        public List<Piece> Pieces
        {
            get { return pieces; }
        }   

        /// <summary>
        /// Проверка на то имеет ли игрок данную фигуру.
        /// </summary>
        /// <param name="piece"> Фигура. </param>
        /// <returns> Возвращает true если игрок имеет данную фигуру, в противном случае false.</returns>
        private bool SearchPiece(Piece piece)
        {
            if (piece == null)
            {
                return false;
            }

            foreach (Piece p in pieces)
            {
                if (p.Equals(piece))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Получить свои фигуры.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        public abstract void GetOwnPieces(CheesBoard board);
       
    }
}
