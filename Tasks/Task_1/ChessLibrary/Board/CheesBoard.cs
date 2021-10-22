using System;

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
            // Белые фигуры.
            SetPiece(new Rook(new Position("a", 1), PieceColor.White));
            SetPiece(new Knight(new Position("b", 1), PieceColor.White));
            SetPiece(new Bishop(new Position("c", 1), PieceColor.White));
            SetPiece(new King(new Position("d", 1), PieceColor.White));
            SetPiece(new Queen(new Position("e", 1), PieceColor.White));
            SetPiece(new Bishop(new Position("f", 1), PieceColor.White));
            SetPiece(new Knight(new Position("g", 1), PieceColor.White));
            SetPiece(new Rook(new Position("h", 1), PieceColor.White));
            SetPiece(new Pawn(new Position("a", 2), PieceColor.White));
            SetPiece(new Pawn(new Position("b", 2), PieceColor.White));
            SetPiece(new Pawn(new Position("c", 2), PieceColor.White));
            SetPiece(new Pawn(new Position("d", 2), PieceColor.White));
            SetPiece(new Pawn(new Position("e", 2), PieceColor.White));
            SetPiece(new Pawn(new Position("f", 2), PieceColor.White));
            SetPiece(new Pawn(new Position("g", 2), PieceColor.White));
            SetPiece(new Pawn(new Position("h", 2), PieceColor.White));

            // Чёрные фигуры.
            SetPiece(new Rook(new Position("a", 8), PieceColor.Black));
            SetPiece(new Knight(new Position("b", 8), PieceColor.Black));
            SetPiece(new Bishop(new Position("c", 8), PieceColor.Black));
            SetPiece(new King(new Position("d", 8), PieceColor.Black));
            SetPiece(new Queen(new Position("e", 8), PieceColor.Black));
            SetPiece(new Bishop(new Position("f", 8), PieceColor.Black));
            SetPiece(new Knight(new Position("g", 8), PieceColor.Black));
            SetPiece(new Rook(new Position("h", 8), PieceColor.Black));
            SetPiece(new Pawn(new Position("a", 7), PieceColor.Black));
            SetPiece(new Pawn(new Position("b", 7), PieceColor.Black));
            SetPiece(new Pawn(new Position("c", 7), PieceColor.Black));
            SetPiece(new Pawn(new Position("d", 7), PieceColor.Black));
            SetPiece(new Pawn(new Position("e", 7), PieceColor.Black));
            SetPiece(new Pawn(new Position("f", 7), PieceColor.Black));
            SetPiece(new Pawn(new Position("g", 7), PieceColor.Black));
            SetPiece(new Pawn(new Position("h", 7), PieceColor.Black));
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
    }
}
