using System;

namespace ChessLibrary
{
    /// <summary>
    /// Пешка
    /// </summary>
    public class Pawn : Piece
    {
        private bool firstMove;

        /// <summary>
        /// Инициализатор класса Pawn.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        /// <param name="color"> Цвет фигуры. </param>
        public Pawn(Position position, PieceColor color) : base(position, color)
        {
            firstMove = true;
        }

        /// <summary>
        /// Проверка хода пешки.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        /// <param name="pos"> Желаемая позиция хода. </param>
        /// <returns> Возвращает true если ход возможен, в противном случае false. </returns>
        public override bool CheckMove(CheesBoard board, Position pos)
        {
            var possibleСells = (firstMove == true) ? 2 : 1;
            var revers = (color == PieceColor.White) ? 1 : -1;        

            int cellsCount = pos.Column - position.Column;

            // Проверка на возможность хода по вертикали.
            if ( ( (cellsCount == possibleСells * revers) || (cellsCount == 1 * revers)) && (pos.Row == position.Row))
            {
                if (board[pos.Row, pos.Column] == null)
                {
                    firstMove = false;

                    return true;
                }                
            }

            // Проверка на битьё фигуры.
            if( (cellsCount == 1 * revers) && ( (pos.Row == position.Row - 1) || (pos.Row == position.Row + 1) ) )
            {
                if (BaseCheckMove(board, pos))
                {
                    return true;
                }
            }
           
            return false;
        }      
    }
}
