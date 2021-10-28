using System;

namespace ChessLibrary
{
    /// <summary>
    /// Реализация шахматной игры.
    /// </summary>
    public class Game
    {
        private CheesBoard board;

        private CheesRules rules;

        private CheesLogger logger;

        private WhitePlayer whitePlayer;

        private BlackPlayer blackPlayer;

        private PieceColor playerWithMove;

        /// <summary>
        /// Инициализатор класса Game.
        /// </summary>
        /// <param name="whitePlayer"> Игрок за белых. </param>
        /// <param name="blackPlayer"> Игрок за чёрных. </param>
        public Game()
        {
            board = new CheesBoard();
            rules = new CheesRules();
            logger = new CheesFileLogger();
            playerWithMove = PieceColor.White;

            //ref WhitePlayer whitePlayer, ref BlackPlayer blackPlayer
            //this.whitePlayer = whitePlayer;
            //this.blackPlayer = blackPlayer;
        }

        /// <summary>
        /// Шахматная доска.
        /// </summary>
        public CheesBoard Board
        {
            get { return board; }
        }

        /// <summary>
        /// Чей ход.
        /// </summary>
        public PieceColor PlayerWithMove
        {
            get { return playerWithMove; }
        }

        /// <summary>
        /// Ход.
        /// </summary>
        /// <param name="piece"> Фигура которая ходит. </param>
        /// <param name="movePosition"> Желаемая позиция фигуры. </param>
        /// <returns> Возвражает true если ход возможен, в случае хода в не очереди или невозможности хода false. </returns>
        public bool Move(Piece piece, Position movePosition)
        {
            // Проверяем чья очередь хода и на пустую фигуру.
            if ( (piece != null) && (piece.Color == playerWithMove) )
            {
                // Проверяем может ли так ходить фигура.
                if ( piece.CheckMove(board, movePosition) )
                {
                    // Проверяем не нарушает ли ход правила.
                    if ( rules.CheckRules(board, piece, movePosition) )
                    {
                        logger.AddLog(board, piece, movePosition);

                        board.MovePiece(piece, movePosition);

                        playerWithMove = (playerWithMove == PieceColor.White) ? PieceColor.Black : PieceColor.White;

                        return true;
                    }                  
                }  
            }

            return false;
        }    
    }
}
