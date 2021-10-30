using System;
using System.Text.RegularExpressions;

namespace ChessLibrary
{
    /// <summary>
    /// Позиция на шахматной доске, клетка.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Позиция по горизонтали.
        /// </summary>
        private string row;

        /// <summary>
        /// Позиция по вертикали.
        /// </summary>
        private int columm;

        /// <summary>
        /// Инициализатор класса Position.
        /// </summary>
        /// <param name="row"> Позиция по горизонтали. </param>
        /// <param name="column"> Позиция по вертикали. </param>
        public Position(string row, int column)
        {
            if (row.Length != 1)
            {
                throw new ArgumentException("Позиция по горизонтали задана в неправильном формате.");
            }

            if (CheckPosition(row, column))
            {
                this.row = row.ToUpper();
                this.columm = column;
            } 
        }

        /// <summary>
        /// Инициализатор класса Position.
        /// </summary>
        /// <param name="cell"> Позиция на доске в формате "XY". </param>
        public Position(string cell)
        {
            string row = cell[0].ToString();
            int column = 0;

            if ( (cell.Length != 2) || (!Int32.TryParse(cell[1].ToString(), out column)) )
            {
                throw new ArgumentException("Позиция на доске задана в неправильном формате.");
            }

            if (CheckPosition(row, column))
            {
                this.row = row.ToUpper();
                this.columm = column;
            }             
        }
  
        /// <summary>
        /// Номер ряда в двумерном массиве.
        /// </summary>
        public int Row
        {
            get { return (int)Enum.Parse(typeof(VerticalPosition), row); }
        }

        /// <summary>
        /// Номер столбца в двумерном массиве.
        /// </summary>
        public int Column
        {
            get { return columm - 1; }
        }

        /// <summary>
        /// Проверка позиции на доске.
        /// </summary>
        /// <param name="row"> Позиция по горизонтали. </param>
        /// <param name="column"> Позиция по вертикали. </param>
        /// <returns> Возвращает true если данная позиция существует, в противном случае false. </returns>
        private bool CheckPosition(string row, int column)
        {
            if (!Regex.Match(row, @"[a-hA-H]").Success)
            {
                throw new ArgumentException("Позиция по горизонтали выходит за диапозон A-H.");
            }

            if (column < 1 || column > 8)
            {
                throw new ArgumentException("Позиция по вертикали выходит за диапозон 1-8.");
            }

            return true;
        }

        /// <summary>
        /// Сравнение позиций фигур на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Возвращает true в случае равенства позиций, в противном случае false. </returns>
        public override bool Equals(object obj)
        {
            if ( (obj != null) && (obj is Position) )
            {
                Position pos = (Position)obj;

                return (this.row == pos.row) && (this.columm == pos.columm);
            }

            return false;             
        }

        /// <summary>
        /// Получить HashCode объекта Position.
        /// </summary>
        /// <returns> HashCode объекта Position. </returns>
        public override int GetHashCode()
        {
            return row.GetHashCode() ^ columm;
        }

        /// <summary>
        /// Вывод позиции в строковом представлении.
        /// </summary>
        /// <returns> Позиция на шахматной доске. </returns>
        public override string ToString()
        {
            return $"{row}{columm}";
        }
    }
}
