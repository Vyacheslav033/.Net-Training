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
        /// <returns> Возвращает статус данного хода. </returns>
        public override MoveStatus CheckMove(CheesBoard board, Position pos)
        {
            var possibleСells = (firstMove == true) ? 2 : 1;
            var revers = (color == PieceColor.White) ? 1 : -1;        

            int cellsCount = pos.Column - position.Column;

            // Проверка на возможность хода по вертикали.
            if ( ( (cellsCount == possibleСells * revers) || (cellsCount == 1 * revers)) && (pos.Row == position.Row))
            {
                firstMove = false;

                return MoveStatus.Normal;             
            }
            // Проверка на битьё фигуры.
            else if( (cellsCount == 1 * revers) && ( (pos.Row == position.Row - 1) || (pos.Row == position.Row + 1) ) )
            {
                Piece p = board[pos.Row, pos.Column];

                if ( (p != null) && (p.Color != color) )
                {
                    return MoveStatus.Beat;
                }               
            }
           
            return MoveStatus.Impossible;
        }      
    }
}
