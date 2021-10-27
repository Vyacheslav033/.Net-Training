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
                new Position("b1"),
                new Position("b2"),
                new Position("b3"),
                new Position("b4"),
                new Position("a1"),
                new Position("a2"),
                new Position("a3"),
                new Position("a4"),
                new Position("c1"),
                new Position("c2"),
                new Position("c3"),
                new Position("c4"),
            };

            //var piece = new Bishop(new Position("f1"), PieceColor.White);

            //board.MovePiece(new Pawn(new Position("b7"), PieceColor.Black), new Position("b6"));
            //board.MovePiece(new Pawn(new Position("c7"), PieceColor.Black), new Position("c5"));
            //board.MovePiece(new Pawn(new Position("d7"), PieceColor.Black), new Position("d4"));
            //board.MovePiece(new Pawn(new Position("e7"), PieceColor.Black), new Position("e3"));

            //board.MovePiece(new Bishop(new Position("f1"), PieceColor.Black), new Position("f2"));
            //board.MovePiece(new Pawn(new Position("h2"), PieceColor.White), new Position("h5"));

            var piece = new King(new Position("b4"), PieceColor.Black);

            board.MovePiece(new King(new Position("e8"), PieceColor.Black), piece.Position);

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
