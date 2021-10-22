using System;
using ChessLibrary;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new CheesBoard();
            OutputBoard(board);
            
            Console.ResetColor();

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

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    if (board[j, i] == null)
                    {
                        Console.Write("[ ] ");
                    }

                    else
                    {
                        if (board[j, i].Color == PieceColor.Black)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        Console.Write($"[{board[j, i]}] ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
