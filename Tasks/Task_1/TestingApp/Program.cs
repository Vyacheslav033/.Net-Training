using System;
using ChessLibrary;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var board = new CheesBoard();
            //var whitePlayer = new WhitePlayer();
            //var blackPlayer = new BlackPlayer();

            //var game = new Game(ref whitePlayer, ref blackPlayer);

            var board = new CheesBoard();

            var position = new Position[]
            {
                new Position("f2"),
                new Position("f1"),
                new Position("f3"),
                new Position("f4"),
                new Position("f5"),
                new Position("f7"),
                new Position("e3"),
                new Position("g3"),
                new Position("h4"),
            };

            var piece = new Pawn(new Position("f2"), PieceColor.White);

            for (var i = 0; i < position.Length; i++)
            {
                Console.WriteLine(position[i] + " - " + piece.CheckMove(board, position[i]));
            }


            //Console.WriteLine($"Позиция фигуры ( x = {position.Row}, y = {position.Column} )  {position}");

            //bool rez = game.Move(piece, new Position("d3"));

            //Console.WriteLine(rez);

            //var board = new CheesBoard();

            //var piece = new Knight(new Position("g1"), PieceColor.White);

            //var newPosition = new Position("d8");

            //bool rez = board.MovePiece(piece, newPosition);

            //OutputBoard(board);

            //Console.WriteLine("\n\n" + rez);

            Console.ReadLine();
        }      

        /// <summary>
        /// Вывод шахматной доски.
        /// </summary>
        /// <param name="cheesBoard"> Шахматная доска. </param>
        static void OutputBoard(CheesBoard board)
        {
            for (var j = board.RowsCount - 1; j >= 0; j--)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"{j + 1} ");

                for (var i = 0; i < board.ColumnsCount; i++)
                {
                    Console.BackgroundColor = ((i + j) % 2) != 0 ? ConsoleColor.DarkYellow : ConsoleColor.DarkRed;

                    string sym = String.Empty;

                    Piece piece = board[i, j];

                    if (piece == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;

                        sym = "-";
                    }
                    else
                    {
                        Console.ForegroundColor = (piece.Color == PieceColor.White) ? ConsoleColor.White : ConsoleColor.Black;

                        sym = piece.ToString();
                    }

                    Console.Write($" {sym} ");
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write("  ");

            var positionY = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };

            for (int i = 0; i < board.RowsCount; i++)
            {
                Console.Write($" {positionY[i].ToUpper()} ");
            }
        }
    }
}
