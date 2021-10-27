using System;

namespace ChessLibrary
{
    /// <summary>
    /// Король.
    /// </summary>
    public class King : Piece
    {
        /// <summary>
        /// Инициализатор класса King.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        /// <param name="color"> Цвет фигуры. </param>
        public King(Position position, PieceColor color) : base(position, color)
        { }

        /// <summary>
        /// Проверка хода короля.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        /// <param name="newPos"> Желаемая позиция хода. </param>
        /// <returns> Возвращает true если ход возможен, в противном случае false. </returns>
        public override bool CheckMove(CheesBoard board, Position newPos)
        {
            Piece p = board[newPos.Row, newPos.Column];

            if (p != null && p.Color == color)
            {
                return false;
            }

            int cellsCountY = Math.Abs(newPos.Column - position.Column);
            int cellsCountX = Math.Abs(newPos.Row - position.Row);

            if ( (cellsCountY == 1) && (newPos.Row == position.Row) )
            {
                return true;
            }
            if ( (cellsCountX == 1) && (newPos.Column == position.Column) )
            {
                return true;
            }

            return false;
        }
    }
}
