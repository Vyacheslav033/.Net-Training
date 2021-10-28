using System;

namespace ChessLibrary
{
    /// <summary>
    /// Правила игры в шахматы.
    /// </summary>
    public class CheesRules
    {
        /// <summary>
        /// Инициалищатор класса CheesRules.
        /// </summary>
        public CheesRules() { }

        /// <summary>
        /// Проверка на возможность хода по правилам и учитывание различных ситуаций.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        /// <param name="piece"> Ходячая фигура. </param>
        /// <param name="position"> Позиция хода. </param>
        /// <returns> Возвращает true если ход не нарушает правил, в противном случае false. </returns>
        public bool CheckRules(CheesBoard board, Piece piece, Position position)
        {
            if (IsKing(board, position))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Проверка на короля.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        /// <param name="position"> Позиция хода. </param>
        /// <returns> Возвращает true если на данной позиции стоит King, в противном случае false. </returns>
        private bool IsKing(CheesBoard board, Position position)
        {
            if (board[position.Row, position.Column] is King)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка на превращение пешки.
        /// </summary>
        /// <param name="piece"> Ходячая фигура. </param>
        /// <param name="position"> Позиция хода. </param>
        /// <returns> Возвращает true если превращение возможно, в противном случае false. </returns>
        private bool IsTurningAPawn(Piece piece, Position position)
        {
            if ( !(piece is Pawn) )
            {
                return false;
            }

            if ( (piece.Position.Column != 6) && (piece.Position.Column != 1))
            {
                return false;
            }

            if ( (piece.Color == PieceColor.White) && (position.Column != 7) ||
                 (piece.Color == PieceColor.Black) && (position.Column != 0))
            {
                return false;
            }

            return true;
        }

    }
}
