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

        private Type playerWithMove;

        /// <summary>
        /// Инициализатор класса Game.
        /// </summary>
        /// <param name="whitePlayer"> Игрок за белых. </param>
        /// <param name="blackPlayer"> Игрок за чёрных. </param>
        public Game(ref WhitePlayer whitePlayer, ref BlackPlayer blackPlayer)
        {
            board = new CheesBoard();
            rules = new CheesRules();
            logger = new CheesFileLogger();

            whitePlayer.GetOwnPieces(board);
            blackPlayer.GetOwnPieces(board);

            playerWithMove = typeof(WhitePlayer);
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
        public Type PlayerWithMove
        {
            get { return playerWithMove; }
        }       

        /// <summary>
        /// Ход.
        /// </summary>
        /// <param name="player"> Фигура которая ходит. </param>
        /// <param name="movePosition"> Желаемая позиция фигуры. </param>
        /// <returns> Возвражает true если ход был сделан, в случае хода в не очереди или невозможности хода false. </returns>
        public bool Move(Player player, Position movePosition)
        {
            // Проверяем чья очередь хода и на пустую фигуру.
            if ( (player.MovingPiece != null) && (player.GetType() == playerWithMove) )
            {
                // Проверяем может ли так ходить фигура.
                if ( player.MovingPiece.CheckMove(board, movePosition) )
                {
                    // Проверяем не нарушает ли ход правила.
                    if ( rules.CheckRules(board, player.MovingPiece, movePosition) )
                    {
                        // Логируем ход.
                        logger.AddLog(board, player.MovingPiece, movePosition);

                        // Ходим фигурой.
                        board.MovePiece(player.MovingPiece, movePosition);

                        // Даём ход другому игроку.
                        playerWithMove = ( playerWithMove == typeof(WhitePlayer) ) ? typeof(BlackPlayer) : typeof(WhitePlayer);

                        return true;
                    }                  
                }  
            }

            return false;
        }    
    }
}
