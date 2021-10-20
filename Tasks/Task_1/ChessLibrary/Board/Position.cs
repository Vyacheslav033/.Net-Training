using System;
using System.Text.RegularExpressions;

namespace ChessLibrary.Board
{
    /// <summary>
    /// Позиция на шахматной доске.
    /// </summary>
    public class Position
    {
        private string y;

        private int x;

        /// <summary>
        /// Инициализатор класса Position.
        /// </summary>
        /// <param name="y"> Позиция по вертикали. </param>
        /// <param name="x"> Позиция по горизонтали. </param>
        public Position(string y, int x)
        {
            if (y.Length != 1)
            {
                throw new ArgumentException("Позиция по вертикали задана в неправильном формате.");
            }

            if (!Regex.Match(y, @"[a-hA-H]").Success)
            {
                throw new ArgumentException("Позиция по вертикали выходит за диапозон A-H.");
            }

            if (x < 1 || x > 8)
            {
                throw new ArgumentException("Позиция по горизонтали выходит за диапозон 1-8.");
            }

            this.y = y.ToUpper();
            this.x = x;
        }

        /// <summary>
        /// Позиция по вертикали.
        /// </summary>
        public string Y
        {   
            get { return y; }
        }

        /// <summary>
        /// Позиция по горизонтали.
        /// </summary>
        public int X
        {
            get { return x; }
        }

        /// <summary>
        /// Сравнение позиций фигур.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Результат сравнения. </returns>
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
            return $"{y}{x}";
        }
    }
}
