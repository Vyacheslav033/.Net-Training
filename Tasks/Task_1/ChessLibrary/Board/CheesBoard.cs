using System;
using System.Collections.Generic;

namespace ChessLibrary
{
    /// <summary>
    /// Шахматная доска.
    /// </summary>
    public class CheesBoard
    {
        private Piece[,] board;
        private const int dimension = 8;

        /// <summary>
        /// Инициализатор класса CheesBoard.
        /// </summary>
        public CheesBoard()
        {
            board = new Piece[dimension, dimension];

            ArrangePieces();
        }

        /// <summary>
        /// Доска.
        /// </summary>
        public Piece[,] Board
        {
            get { return board; }
        }

        /// <summary>
        /// Расставить фигуры.
        /// </summary>
        private void ArrangePieces()
        {
            var row = 1;
            var color = PieceColor.White;
            var positionY = new string[] {"a", "b", "c", "d", "e", "f", "g", "h" };
                
            // Расставляем все фигуры, кроме пешек.
            for (var i = 0; i < 2; i++)
            {              
                SetPiece(new Rook(new Position("a", row), color));
                SetPiece(new Knight(new Position("b", row), color));
                SetPiece(new Bishop(new Position("c", row), color));
                SetPiece(new King(new Position("d", row), color));
                SetPiece(new Queen(new Position("e", row), color));
                SetPiece(new Bishop(new Position("f", row), color));
                SetPiece(new Knight(new Position("g", row), color));
                SetPiece(new Rook(new Position("h", row), color));

                row = 8;
                color = PieceColor.Black;
            }

            // Расставляем пешки.
            for (var i = 0; i < positionY.Length; i++)
            {
                SetPiece(new Pawn(new Position(positionY[i], 2), PieceColor.White));
                SetPiece(new Pawn(new Position(positionY[i], 7), PieceColor.Black));
            }           
        }

        /// <summary>
        /// Установка фигуры на доске.
        /// </summary>
        /// <param name="piece"> Фигура. </param>
        private void SetPiece(Piece piece)
        {
            // !!!
            int x = (int) Enum.Parse(typeof(VerticalPosition), piece.Position.X);
            int y = piece.Position.Y - 1;

            board[x, y] = piece;            
        }

        /// <summary>
        /// Поиск фигуры на доске.
        /// </summary>
        /// <param name="searchPiece"> Фигура для поиска. </param>
        /// <returns> Возвращает true если фигура существует, в противном случае false.</returns>
        private bool PieceSearch(Piece searchPiece)
        {
            foreach (Piece piece in Board)
            {
                if (piece.Equals(searchPiece))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Проверка на возможность хода.
        /// </summary>
        /// <param name="piece"> Фигура которая ходит. </param>
        /// <param name="movePosition"> Желаемая позиция фигуры. </param>
        /// <returns></returns>
        public bool CanMove(Piece piece, Position movePosition)
        {
            // Реализовать!

            return false;
        }

        /// <summary>
        /// Получение списка фигур заданного цвета. 
        /// </summary>
        /// <param name="color"> Цвет фигур. </param>
        /// <returns> Список фигур. </returns>
        public List<Piece> GetPieces(PieceColor color)
        {
            var pieces = new List<Piece>();

            foreach (Piece piece in Board)
            {
                if (piece.Color == color)
                {
                    pieces.Add(piece);
                }
            }

            return pieces;
        }
    }
}
