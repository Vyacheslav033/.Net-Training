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

        public override bool CheckMove(CheesBoard board, Position pos)
        {
            var revers = (color == PieceColor.White) ? 1 : -1;

            int cellsCountY = pos.Column - position.Column;
            int cellsCountX = Math.Abs(pos.Row - position.Row);

            // Проверка на возможность хода по вертикали.
            if ( (cellsCountY == 1 * revers) && (pos.Row == position.Row) )
            {
                return true;
            }
            if ( (cellsCountX == 1) && (pos.Column == position.Column) )
            {
                return true;
            }

            return false;
        }
    }
}
