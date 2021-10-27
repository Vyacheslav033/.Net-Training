using System;

namespace ChessLibrary
{
    /// <summary>
    /// Реализация шахматной игры.
    /// </summary>
    public class Game
    {
        private CheesBoard cheesBoard;

        private CheesRules rules;

        private WhitePlayer whitePlayer;

        private BlackPlayer blackPlayer;

        private PieceColor playerWithMove;

        /// <summary>
        /// Инициализатор класса Game.
        /// </summary>
        /// <param name="whitePlayer"> Игрок за белых. </param>
        /// <param name="blackPlayer"> Игрок за чёрных. </param>
        public Game(ref WhitePlayer whitePlayer, ref BlackPlayer blackPlayer)
        {
            cheesBoard = new CheesBoard();
            rules = new CheesRules(cheesBoard);

            this.whitePlayer = whitePlayer;
            this.blackPlayer = blackPlayer;

            playerWithMove = PieceColor.White;            
        }

        /// <summary>
        /// Ход.
        /// </summary>
        /// <param name="piece"> Фигура которая ходит. </param>
        /// <param name="movePosition"> Желаемая позиция фигуры. </param>
        /// <returns> Возвражает true если ход возможен, в случае хода в не очереди или невозможности хода false. </returns>
        public bool Move(Piece piece, Position movePosition)
        {
            if (piece.Color == playerWithMove)
            {
                bool can =  piece.CheckMove(cheesBoard, movePosition);

                if (can)
                {
                    // Добавить сюда проверку по правилам.
                    cheesBoard.MovePiece(piece, movePosition);

                    
                }

                playerWithMove = (playerWithMove == PieceColor.White) ? PieceColor.Black : PieceColor.White;
            }

            return false;
        }    
    }
}
