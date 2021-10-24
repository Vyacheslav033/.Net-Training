using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{
    
    public class CheesRules
    {
        private CheesBoard cheesBoard;

        /// <summary>
        /// Инициалищатор класса CheesRules.
        /// </summary>
        /// <param name="cheesBoard"> Шахмотная доска. </param>
        public CheesRules(CheesBoard cheesBoard)
        {
            this.cheesBoard = cheesBoard;
        }


        /// <summary>
        /// Проверка на возможность хода.
        /// </summary>
        /// <param name="piece"> Фигура которая ходит. </param>
        /// <param name="movePosition"> Желаемая позиция фигуры. </param>
        /// <returns></returns>
        public bool CanMove(Piece piece, Position movePosition)
        {
            

            return false;
        }
    }
}
