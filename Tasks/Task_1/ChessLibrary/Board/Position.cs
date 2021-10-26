using System;
using System.Text.RegularExpressions;

namespace ChessLibrary
{
    /// <summary>
    /// Позиция на шахматной доске, клетка.
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

            if (CheckPosition(x, y))
            {
                this.x = x.ToUpper();
                this.y = y;
            } 
        }

        /// <summary>
        /// Инициализатор класса Position.
        /// </summary>
        /// <param name="position"> Позиция на доске в формате "XY". </param>
        public Position(string position)
        {
            string pX = position[0].ToString();
            int pY = 0;

            if ( (position.Length != 2) || (!Int32.TryParse(position[1].ToString(), out pY)) )
            {
                throw new ArgumentException("Позиция на доске задана в неправильном формате.");
            }

            if (CheckPosition(pX, pY))
            {
                this.x = pX.ToUpper();
                this.y = pY;
            }             
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
        /// Номер ряда в двумерном массиве.
        /// </summary>
        public int Row
        {
            get { return (int)Enum.Parse(typeof(VerticalPosition), x); }
        }

        /// <summary>
        /// Номер столбца в двумерном массиве.
        /// </summary>
        public int Column
        {
            get { return y - 1; }
        }

        /// <summary>
        /// Проверка позиции на доске.
        /// </summary>
        /// <param name="pX"> Позиция по горизонтали. </param>
        /// <param name="pY"> Позиция по вертикали. </param>
        /// <returns> Возвращает true если данная позиция существует, в противном случае false. </returns>
        private bool CheckPosition(string pX, int pY)
        {
            if (!Regex.Match(pX, @"[a-hA-H]").Success)
            {
                throw new ArgumentException("Позиция по горизонтали выходит за диапозон A-H.");
            }

            if (pY < 1 || pY > 8)
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
