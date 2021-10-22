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

        /// <summary>
        /// Поиск номера фигуры в списке.
        /// </summary>
        /// <param name="searchPiece"> Фигура для поиска. </param>
        /// <returns> Возвращает номер фигуры в списе, в случае отсутсвии фигуры возвращает -1.</returns>
        private int GetPieceId(Piece searchPiece)
        {
            for (var i = 0; i < pieces.Count; i++)
            {
                if (pieces[i].Equals(searchPiece))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Удаление фигуры из списка.
        /// </summary>
        /// <param name="index"> Номер фигуры. </param>
        /// <returns> Возвращает true в случае удаления фигуры, в противном случае false.</returns>
        public bool RemovePiece(int index)
        { 
            // !!!
            if (index > 0 && index < pieces.Count)
            {
                pieces.RemoveAt(index);

                return true;
            }

            return false;
        }
    }
}
