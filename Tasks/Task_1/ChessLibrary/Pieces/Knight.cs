using System;

namespace ChessLibrary
{
    /// <summary>
    /// Конь.
    /// </summary>
    public class Knight : Piece
    {
        /// <summary>
        /// Инициализатор класса Knight.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        /// <param name="color"> Цвет фигуры. </param>
        public Knight(Position position, PieceColor color) : base(position, color)
        { }

        /// <summary>
        /// Проверка хода коня.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        /// <param name="newPos"> Желаемая позиция хода. </param>
        /// <returns> Возвращает true если ход возможен, в противном случае false. </returns>
        public override bool CheckMove(CheesBoard board, Position newPos)
        {
            if (!BaseCheckMove(board, newPos))
            {
                return false;
            }

            int column = Math.Abs(newPos.Column - position.Column);
            int row = Math.Abs(newPos.Row - position.Row);

            if (column * row == 2)
            {
                return true;
            }

            return false;
        }
    }
}
