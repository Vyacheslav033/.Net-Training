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
        /// Индексатор.
        /// </summary>
        /// <param name="i"> Ряд. </param>
        /// <param name="j"> Столбец. </param>
        /// <returns> Фигуру на заданной позиции. </returns>
        public Piece this[int i, int j]
        {
            get { return board[i, j]; }
        }

        /// <summary>
        /// Количество строк.
        /// </summary>
        public int RowsCount
        {
            get { return board.GetUpperBound(0) + 1; }
        }

        /// <summary>
        /// Количество столбцов.
        /// </summary>
        public int ColumnsCount
        {
            get { return board.Length / RowsCount; }
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
                SetPiece(new King(new Position("e", row), color));
                SetPiece(new Queen(new Position("d", row), color));
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
            board[piece.Position.Row, piece.Position.Column] = piece;            
        }

        /// <summary>
        /// Передвинуть фигуру.
        /// </summary>
        /// <param name="piece"> Передвигаемая фигура. </param>
        /// <param name="position"> Новая позиция. </param>
        /// <returns> Возвращает true если фигура передвинута, в противном случае false. </returns>
        public bool MovePiece(Piece piece, Position position)
        {
            if (SearchPiece(piece))
            {
                board[piece.Position.Row, piece.Position.Column] = null;          
                board[position.Row, position.Column] = piece;

                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка на существовании фигуры на доске.
        /// </summary>
        /// <param name="piece"> Фигура для поиска. </param>
        /// <returns> Возвращает true если фигура существует, в противном случае false.</returns>
        private bool SearchPiece(Piece piece)
        {
            foreach (Piece p in board)
            {
                if ( (p != null) && (p.Equals(piece)) )
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Удаление фигуры с доски.
        /// </summary>
        /// <param name="piece"> Удаляемая фигура. </param>
        /// <returns> Возвращает true в случае удаления фигуры, в противном случае false. </returns>
        public bool RemovePiece(Piece piece)
        {
            if (SearchPiece(piece))
            {
                board[piece.Position.Row, piece.Position.Column] = null;

                return true;
            }
            
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

            foreach (Piece piece in board)
            {
                if ( (piece != null) && (piece.Color == color) )
                {
                    pieces.Add(piece);
                }
            }

            return pieces;
        }
    }
}
