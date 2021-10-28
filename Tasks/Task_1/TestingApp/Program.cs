﻿using System;
using ChessLibrary;
using System.Text.RegularExpressions;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var game = new Game();

            for (var i = 0; i < 100; i++)
            {
                OutputBoard(game.Board);

                bool rightMove = true;

                string color = (game.PlayerWithMove == PieceColor.White) ? "белых" : "чёрных";
                Console.WriteLine("Ход " + color + "!");

                do
                {
                    Console.Write("Позиция фигуры-позиция хода: ");
                    string posInfo = Console.ReadLine();

                    var positions = Regex.Split(posInfo, "-");

                    var piecePosition = new Position(positions[0]);

                    rightMove = game.Move(game.Board[piecePosition.Row, piecePosition.Column], new Position(positions[1]));

                    if (!rightMove)
                    {
                        Console.WriteLine("Ход невозможен");
                    }
                }
                while (rightMove == false);

                Console.WriteLine();
            }
       
            //var position = new Position[]
            //{                 
            //    new Position("f7"),
            //    new Position("f8"),
            //    new Position("f5"),
            //};

            //var piece = new Queen(new Position("f3"), PieceColor.White);

            //board.MovePiece(new Queen(new Position("d1"), PieceColor.White), piece.Position);

            //OutputBoard(board);

            //Console.WriteLine();

            //for (var i = 0; i < position.Length; i++)
            //{
            //    Console.WriteLine(position[i] + " - " + piece.CheckMove(board, position[i]));
            //}

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

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n");
        }
    }
}
