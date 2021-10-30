using System;

namespace ChessLibrary
{
    /// <summary>
    /// Игрок за чёрных.
    /// </summary>
    public class BlackPlayer : Player
    {
        /// <summary>
        /// Получить фигуры чёрного цвета.
        /// </summary>
        /// <param name="board"> Шахматная доска. </param>
        public override void GetOwnPieces(CheesBoard board)
        {
            pieces = board.GetPieces(PieceColor.Black);
        }

    }
}
