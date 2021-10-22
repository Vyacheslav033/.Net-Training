using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{
    /// <summary>
    /// Реализация шахматной игры.
    /// </summary>
    public class Game
    {
        private WhitePlayer whitePlayer;
        private BlackPlayer blackPlayer;
        private Type playerWithMove;
        private bool isGame;

        /// <summary>
        /// Инициализатор класса Game.
        /// </summary>
        /// <param name="whitePlayer"> Игрок за белых. </param>
        /// <param name="blackPlayer"> Игрок за чёрных. </param>
        public Game(ref WhitePlayer whitePlayer, ref BlackPlayer blackPlayer)
        {
            isGame = true;
            playerWithMove = typeof(WhitePlayer);
            this.whitePlayer = whitePlayer;
            this.blackPlayer = blackPlayer;
        }


        public void Start()
        {
            if (playerWithMove == whitePlayer.GetType())
            {
                whitePlayer.Motion();

                playerWithMove = typeof(BlackPlayer);
            }
            else
            {
                blackPlayer.Motion();

                playerWithMove = typeof(WhitePlayer);
            }
        }
    }
}
