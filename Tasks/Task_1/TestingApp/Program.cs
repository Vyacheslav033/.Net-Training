using System;
using ChessLibrary;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new CheesBoard();
       
            var position = new Position[]
            {
     
                // ДЛЯ ЛАДЬИ НА С5
                new Position("c5"),
                new Position("c2"),
                new Position("c6"),
                new Position("c7"),
                new Position("c8"),
                new Position("c4"),
                new Position("e5"),
                new Position("a5"),
                new Position("b5"),
                new Position("a4"),
                new Position("d4"),
                new Position("h4"),
                new Position("d5"),
                new Position("e6"),
                new Position("a5"),
                new Position("a6"),
                new Position("c8"),
                new Position("b8"),
                new Position("b7"),
                new Position("c1"),
                new Position("h5"),
                new Position("c3"),
                new Position("c1"),

            };

            var piece = new Rook(new Position("c5"), PieceColor.Black);

            board.MovePiece(new Rook(new Position("a8"), PieceColor.Black), piece.Position);

            OutputBoard(board);

            Console.WriteLine();

            for (var i = 0; i < position.Length; i++)
            {
                Console.WriteLine(position[i] + " - " + piece.CheckMove(board, position[i]));
            }

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
