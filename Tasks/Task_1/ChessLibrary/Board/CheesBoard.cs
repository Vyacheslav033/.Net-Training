using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{
    public class CheesBoard
    {
        private Piece[,] board;
        private const int dimension = 8;


        public CheesBoard()
        {
            board = new Piece[dimension, dimension];
        }
    }
}
