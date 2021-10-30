using System;

namespace ChessLibrary
{
    /// <summary>
    /// Игрок за белых.
    /// </summary>
    public class WhitePlayer : Player
    {
        /// <summary>
        /// Получить фигуры белого цвета.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        public override void GetOwnPieces(CheesBoard board)
        {
            pieces = board.GetPieces(PieceColor.White);
        }
    }
}
