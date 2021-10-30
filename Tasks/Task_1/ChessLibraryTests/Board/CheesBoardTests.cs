using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessLibrary;

namespace ChessLibraryTests
{
    /// <summary>
    /// Тестирование класса CheesBoard.
    /// </summary>
    [TestClass()]
    public class CheesBoardTests
    {
        /// <summary>
        /// Тестирование метода MovePiece() на возможность передвинуть фигуру.
        /// </summary>
        [TestMethod()]
        public void MovePiece_MovePawn_ReturnsTrue()
        {
            // Arrange. 
            var board = new CheesBoard();
            var piece = new Pawn(new Position("A2"), PieceColor.White);

            // Act.
            bool actual = board.MovePiece(piece, new Position("A3"));

            // Assert.            
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Тестирование метода RemovePiece() на удаление фигуры с доски.
        /// </summary>
        [TestMethod()]
        public void RemovePiece_RemovingPieceFromBoard_ReturnsNull()
        {
            // Arrange. 
            var board = new CheesBoard();
            var piece = new Pawn(new Position("A7"), PieceColor.Black);

            // Act.
            board.RemovePiece(piece);

            // Assert.            
            Assert.AreEqual(null, board[piece.Position.Row, piece.Position.Column]);
        }
    }
}