using System;
using System.Text.RegularExpressions;

namespace ChessLibrary.Board
{
    /// <summary>
    /// Позиция на шахматной доске.
    /// </summary>
    public class Position
    {
        private string vertical;

        private int horizontal;

        /// <summary>
        /// Инициализатор класса Position.
        /// </summary>
        /// <param name="vertical"> Позиция по вертикали. </param>
        /// <param name="horizontal"> Позиция по горизонтали. </param>
        public Position(string vertical, int horizontal)
        {
            if (vertical.Length != 1)
            {
                throw new ArgumentException("Позиция по вертикали задана в неправильном формате.");
            }

            if (!Regex.Match(vertical, @"[a-hA-H]").Success)
            {
                throw new ArgumentException("Позиция по вертикали выходит за диапозон A-H.");
            }

            if (horizontal < 1 || horizontal > 8)
            {
                throw new ArgumentException("Позиция по горизонтали выходит за диапозон 1-8.");
            }

            this.vertical = vertical.ToUpper();
            this.horizontal = horizontal;
        }

        /// <summary>
        /// Позиция по вертикали.
        /// </summary>
        public string Vertical
        {   
            get { return vertical; }
        }

        /// <summary>
        /// Позиция по горизонтали.
        /// </summary>
        public int Horizontal
        {
            get { return horizontal; }
        }

        /// <summary>
        /// Сравнение позиций фигур.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Результат сравнения. </returns>
        public override bool Equals(object obj)
        {
            if ((obj == null) || (this.GetType() != obj.GetType()))
            {
                return false;
            }
            else
            {
                Position p = (Position)obj;

                return (vertical == p.vertical) && (horizontal == p.horizontal);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Position = {vertical}{horizontal}";
        }
    }
}
