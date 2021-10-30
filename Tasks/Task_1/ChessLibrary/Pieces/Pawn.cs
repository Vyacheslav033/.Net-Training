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
        /// Констртуктор копирования класса Pawn.
        /// </summary>
        /// <param name="piece"> Фигура. </param>
        public Pawn(Piece piece) : base(piece)
        {
            firstMove = true;
        }

        /// <summary>
        /// Проверка хода пешки.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        /// <param name="newPos"> Желаемая позиция хода. </param>
        /// <returns> Возвращает true если ход возможен, в противном случае false. </returns>
        public override bool CheckMove(CheesBoard board, Position newPos)
        {
            var possibleСells = (firstMove == true) ? 2 : 1;
            var revers = (color == PieceColor.White) ? 1 : -1;        

            int cellsCount = newPos.Column - position.Column;

            // Проверка на возможность хода по вертикали.
            if (  ((cellsCount == possibleСells * revers) || (cellsCount == 1 * revers)) && (newPos.Row == position.Row))
            {
                if (board[newPos.Row, newPos.Column] == null)
                {
                    firstMove = false;

                    return true;
                }                
            }

            // Проверка на битьё фигуры.
            if ((cellsCount == 1 * revers) && ((newPos.Row == position.Row - 1) || (newPos.Row == position.Row + 1)))
            {
                Piece p = board[newPos.Row, newPos.Column];

                if ((p != null) && (p.Color != color))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Превращение пешки.
        /// </summary>
        /// <param name="piece"> Фигура в которую желает превратиться пешка. </param>
        /// <returns> Возвращает true если пешка может превратиться в данную фигуру, в противном случае false. </returns>
        public bool CanTurningAPawn(Piece piece)
        {
            if (!(piece is Pawn) && !(piece is King) &&
                 (color == piece.Color) && position.Equals(piece.Position))
            {
                return true;
            }

            return false;
        }

    }
}
