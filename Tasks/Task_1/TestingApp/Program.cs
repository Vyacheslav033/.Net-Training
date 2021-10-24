using System;
using ChessLibrary;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new CheesBoard();           

            Console.ReadLine();
        }

        /// <summary>
        /// Вывод шахматной доски.
        /// </summary>
        /// <param name="cheesBoard"> Шахматная доска. </param>
        static void OutputBoard(CheesBoard cheesBoard)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;

            var board = cheesBoard.Board;
            int rows = board.GetUpperBound(0) + 1;
            int columns = board.Length / rows;

            var positionY = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };

            for (var i = 0; i < rows; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"{i + 1} ");

                for (var j = 0; j < columns; j++)
                {
                    Console.BackgroundColor = ((i + j) % 2) != 0 ? ConsoleColor.DarkRed : ConsoleColor.DarkYellow;

                    if (board[j, i] == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" - ");
                    }
                    else
                    {
                        Console.ForegroundColor = (board[j, i].Color == PieceColor.White) ? ConsoleColor.White : ConsoleColor.Black;

                        Console.Write($" {board[j, i]} ");
                    }                   
                }

                Console.WriteLine();         
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write("  ");

            for (int i = 0; i < rows; i++)
            {
                Console.Write($" {positionY[i].ToUpper()} ");
            }
        }
    }
}
