using System;
using System.Collections.Generic;

namespace ChessLibrary
{
    /// <summary>
    /// Слон.
    /// </summary>
    public class Bishop : Piece
    {
        /// <summary>
        /// Инициализатор класса Bishop.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        /// <param name="color"> Цвет фигуры. </param>
        public Bishop(Position position, PieceColor color) : base(position, color)
        { }

        /// <summary>
        /// Проверка хода слона.
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

            if (column != row)
            {
                return false;
            }

            int pathLength = row;
            int stepDirectionX = Math.Sign(newPos.Row - position.Row);
            int stepDirectionY = Math.Sign(newPos.Column - position.Column);

            row = position.Row;
            column = position.Column;

            for (int i = 1; i < pathLength; i++)
            {
                row += stepDirectionX;
                column += stepDirectionY;

                if (board[row, column] != null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
