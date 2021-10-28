﻿using System;
using System.Collections.Generic;

namespace ChessLibrary
{
    /// <summary>
    /// Базовый класс логирования шахматной партии.
    /// </summary>
    public abstract class CheesLogger
    {
        protected List<string> logs;

        /// <summary>
        /// Инициализатор класса CheesLogger.
        /// </summary>
        public CheesLogger()
        {
            logs = new List<string>();
        }

        /// <summary>
        /// Журнал записей.
        /// </summary>
        public List<string> Logs
        {
            get { return logs; }
        }

        /// <summary>
        /// Добавить запись.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        /// <param name="piece"> Ходячая фигура. </param>
        /// <param name="movePosition"> Позиция хода. </param>
        public abstract void AddLog(CheesBoard board, Piece piece, Position movePosition);

        /// <summary>
        /// Создать запись информации о ходе.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        /// <param name="piece"> Ходячая фигура. </param>
        /// <param name="movePosition"> Позиция хода. </param>
        /// <returns> Возвращает информацию о ходе, в случае невозможности хода "". </returns>
        protected string CreateLog(CheesBoard board, Piece piece, Position movePosition)
        {
            if (piece == null)
            {
                return "";
            }

            string info = $"{piece.Color} {piece.GetType().Name} {piece.Position}";

            Piece p = board[movePosition.Row, movePosition.Column];

            if (p != null)
            {
                info += $" beats {p.GetType().Name} {p.Position}";
            }
            else
            {
                info += $" -> {movePosition}";
            }

            logs.Add(info);

            return info;
        }

        /// <summary>
        /// Удалить запись по номеру.
        /// </summary>
        /// <param name="id"> Номер записи. </param>
        /// <returns> Возвращает true если запись удалена, в противном случае false. </returns>
        public virtual bool RemoveLogById(int id)
        {
            if ( (id < 0) || (id >= logs.Count) )
            {
                return false;
            }

            logs.RemoveAt(id);

            return true;
            
        }

        /// <summary>
        /// Получить запись по номеру.
        /// </summary>
        /// <param name="id"> Номер записи. </param>
        /// <returns> Возвращает запись, если записи не существует "" </returns>
        public string GetLogById(int id)
        {
            if ((id < 0) || (id >= logs.Count))
            {
                return "";
            }

            return logs[id];
        }
    }
}
