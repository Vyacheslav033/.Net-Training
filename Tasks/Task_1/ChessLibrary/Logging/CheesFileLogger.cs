using System.IO;

namespace ChessLibrary
{
    /// <summary>
    /// Логирования шахматной партии в текстовом файле.
    /// </summary>
    public class CheesFileLogger : CheesLogger
    {
        private readonly string path = @"CheesLog.txt";
        private bool isFile = false;

        /// <summary>
        /// Добавить запись в файл.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        /// <param name="piece"> Ходячая фигура. </param>
        /// <param name="movePosition"> Позиция хода. </param>
        public override void AddLog(CheesBoard board, Piece piece, Position movePosition)
        {
            using (StreamWriter sw = new StreamWriter(path, isFile))
            {
                string messege = CreateLog(board, piece, movePosition);

                sw.WriteLine(messege);

                isFile = true;
            }
        }      
    }
}
