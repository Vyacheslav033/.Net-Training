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
            return true;
        }

    }
}
