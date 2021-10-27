using System;

namespace ChessLibrary
{
    /// <summary>
    /// Ладья.
    /// </summary>
    public class Rook : Piece
    {
        /// <summary>
        /// Инициализатор класса Rook.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        /// <param name="color"> Цвет фигуры. </param>
        public Rook(Position position, PieceColor color) : base(position, color)
        { }

        /// <summary>
        /// Проверка хода ладьи.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        /// <param name="newPos"> Желаемая позиция хода. </param>
        /// <returns> Возвращает true если ход возможен, в противном случае false. </returns>
        public override bool CheckMove(CheesBoard board, Position newPos)
        {
            if ((position.Column != newPos.Column) && (position.Row != newPos.Row))
            {
                return false;
            }

            Piece p = board[newPos.Row, newPos.Column];

            if (p != null && p.Color == color)
            {
                return false;
            }

            int column = Math.Abs(newPos.Column - position.Column);
            int row = Math.Abs(newPos.Row - position.Row);

            if (row * column == 0)
            {
                int pathLength = row + column;

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

            return false;
        }
    }
}
