using System;

namespace ChessLibrary
{
    /// <summary>
    /// Логирования шахматной партии через консоль.
    /// </summary>
    public class CheesConsoleLogger : CheesLogger
    {
        /// <summary>
        /// Добавить запись и вывести на консоль.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        /// <param name="piece"> Ходячая фигура. </param>
        /// <param name="movePosition"> Позиция хода. </param>
        public override void AddLog(CheesBoard board, Piece piece, Position movePosition)
        {
            string messege = CreateLog(board, piece, movePosition);

            Console.WriteLine(messege);
        }
    }
}
