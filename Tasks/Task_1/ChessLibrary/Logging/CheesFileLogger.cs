using System;
using System.Collections.Generic;
using System.IO;

namespace ChessLibrary
{
    /// <summary>
    /// Логирования шахматной партии в текстовом файле.
    /// </summary>
    public class CheesFileLogger : CheesLogger
    {
        private readonly string path = @"D:\C#\.Net-Training\Tasks\Task_1\CheesLog.txt";
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

        /// <summary>
        /// Удалить запись по номеру.
        /// </summary>
        /// <param name="id"> Номер записи. </param>
        /// <returns> Возвращает true если запись удалена, в противном случае false. </returns>
        public override bool RemoveLogById(int id)
        {
            if ( File.Exists(path) && base.RemoveLogById(id) )
            {
                var fileLog = new List<string>();

                fileLog.AddRange(File.ReadAllLines(path));
                fileLog.RemoveAt(id);

                File.WriteAllLines(path, fileLog);

                return true;
            }

            return false;
        }
    }
}
