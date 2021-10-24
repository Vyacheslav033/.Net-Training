using System;
using System.Text.RegularExpressions;

namespace ChessLibrary
{
    /// <summary>
    /// Позиция на шахматной доске.
    /// </summary>
    public class Position
    {
        private string x;

        private int y;

        /// <summary>
        /// Инициализатор класса Position.
        /// </summary>
        /// <param name="x"> Позиция по горизонтали. </param>
        /// <param name="y"> Позиция по вертикали. </param>
        public Position(string x, int y)
        {
            if (x.Length != 1)
            {
                throw new ArgumentException("Позиция по горизонтали задана в неправильном формате.");
            }

            if (!Regex.Match(x, @"[a-hA-H]").Success)
            {
                throw new ArgumentException("Позиция по горизонтали выходит за диапозон A-H.");
            }

            if (y < 1 || y > 8)
            {
                throw new ArgumentException("Позиция по вертикали выходит за диапозон 1-8.");
            }

            this.x = x.ToUpper();
            this.y = y;
        }

        /// <summary>
        /// Позиция по горизонтали.
        /// </summary>
        public string X
        {
            get { return x; }
        }

        /// <summary>
        /// Позиция по вертикали.
        /// </summary>
        public int Y
        {
            get { return y; }
        }

        /// <summary>
        /// Сравнение позиций фигур на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Возвращает true в случае равенства позиций, в противном случае false. </returns>
        public override bool Equals(object obj)
        {
            if (obj is Position)
            {
                Position pos = (Position)obj;

                return (this.x == pos.x) && (this.y == pos.y);
            }

            return false;             
        }

        public override int GetHashCode()
        {       
            return base.GetHashCode();
        }

        /// <summary>
        /// Вывод позиции в строковом представлении.
        /// </summary>
        /// <returns> Позиция на шахматной доске. </returns>
        public override string ToString()
        {
            return $"{x}{y}";
        }
    }
}
