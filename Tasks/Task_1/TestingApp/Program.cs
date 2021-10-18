using System;
using ChessLibrary.Board;
using ChessLibrary.Pieces;
using ChessLibrary.Players;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var position1 = new Position('c', 4);
            //var position2 = new Position('c', 4);

            //var pawn = new Pawn(position1);

            //Console.WriteLine(position1.Equals(position2).ToString());          

            var bp = new WhitePlayer();
            var list = bp.Pieces;

            foreach (Piece piece in list)
            {
                Console.WriteLine(piece.Position.ToString());
            }

            Console.ReadLine();
        }
    }
}
