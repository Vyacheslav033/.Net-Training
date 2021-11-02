using System;
using ChessLibrary;
using System.Text.RegularExpressions;

namespace CheesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var whitePlayer = new WhitePlayer();
            var blackPlayer = new BlackPlayer();

            var game = new Game( whitePlayer,  blackPlayer);

            Console.WriteLine("Ход вводится в формате позиция фигуры-позиция хода, латинские буквы. \n Например: A2-A3 \n\n");

            while (true)
            {
                OutputBoard(game.Board);

                bool rightMove = true;

                string color = (game.PlayerWithMove == typeof(WhitePlayer)) ? "белых" : "чёрных";
                Console.WriteLine("Ход " + color + "!\n");

                do
                {
                    try
                    {
                        Console.Write("Позиция фигуры-позиция хода: ");
                        string posInfo = Console.ReadLine();

                        var positions = Regex.Split(posInfo, "-");

                        var piecePosition = new Position(positions[0]);

                        if (game.PlayerWithMove == typeof(WhitePlayer))
                        {
                            //whitePlayer.GetOwnPieces(game.Board);

                            whitePlayer.MovingPiece = game.Board[piecePosition.Row, piecePosition.Column];

                            rightMove = game.Move(whitePlayer, new Position(positions[1]));

                            //Console.WriteLine(whitePlayer.Pieces.Count);
                        }
                        else
                        {
                            blackPlayer.MovingPiece = game.Board[piecePosition.Row, piecePosition.Column];

                            rightMove = game.Move(blackPlayer, new Position(positions[1]));

                            //Console.WriteLine(blackPlayer.Pieces.Count);
                        }

                        if ( !rightMove )
                        {
                            Console.WriteLine("Ход невозможен!\n");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + "\n");

                        rightMove = false;
                    }
                }
                while (!rightMove);

                Console.WriteLine();
            }
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

                        sym = piece.ToString()[0].ToString();
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

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n");
        }
    }
}
