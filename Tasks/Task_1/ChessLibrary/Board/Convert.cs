using System;

namespace ChessLibrary
{
    /// <summary>
    /// Конвертация позиций на шахматной доске в позиции в двумерном массиве.
    /// </summary>
    public class Convert
    {
        /// <summary>
        /// Конвертация горизонтальной позиции на доске в номер ряда в двумерном массиве.
        /// </summary>
        /// <param name="position"> Позиция на доске. </param>
        /// <returns> Номер ряда. </returns>
        public static int ToRowValue(Position position)
        {
            return (int)Enum.Parse(typeof(VerticalPosition), position.X);
        }

        /// <summary>
        /// Конвертация вертикальной позиции на доске в номер столбца в двумерном массиве.
        /// </summary>
        /// <param name="position"> Позиция на доске. </param>
        /// <returns> Номер столбца. </returns>
        public static int ToColumnValue(Position position)
        {
            return position.Y - 1;
        }
    }
}
