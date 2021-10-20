using System;
using ChessLibrary.Board;
using ChessLibrary.Pieces;
using ChessLibrary.Players;
using ChessLibrary.Game;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var position1 = new Position("e", 1);
            var position2 = new Position("e", 8);

            var piece1 = new Queen(position1);
            var piece2 = new Bishop(position1);

            //Console.WriteLine(piece1.Equals(piece2).ToString());

            //var wp = new WhitePlayer();
            //var list = wp.Pieces;

            //foreach (Piece piece in list)
            //{
            //    Console.WriteLine(piece);
            //}

            //var game = new Game(ref wp, ref bp);

            //Console.WriteLine(game.Start());




            Console.ReadLine();
        }
    }
}
