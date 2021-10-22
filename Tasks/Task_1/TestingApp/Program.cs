using System;
using ChessLibrary;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bp = new BlackPlayer();
            //var wp = new WhitePlayer();

            //var game = new Game(ref wp, ref bp);

            //game.Start();

            var pieces = bp.Pieces;


            var p1 = new Pawn(new Position("a", 4), PieceColor.Black);
            var p2 = new Pawn(new Position("a", 4), PieceColor.Black);

            Console.WriteLine(p1.Equals(p2));
            //Console.WriteLine(df.Color);


            Console.ReadLine();
        }
    }
}
