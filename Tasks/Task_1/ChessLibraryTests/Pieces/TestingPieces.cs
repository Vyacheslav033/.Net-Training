using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessLibrary;

namespace ChessLibraryTests
{
    /// <summary>
    /// Тестирование классов фигур.
    /// </summary>
    [TestClass()]
    public class TestingPieces
    {        
        /// <summary>
        /// Тестирование метода CheckMove() у класса Pawn.
        /// </summary>
        [TestMethod()]
        public void CheckMove_NotCorrectKnightMove_ReturnsFalse()
        {
            // Arrange.         
            var piece = new Knight(new Position("G8"), PieceColor.Black);
            var position = new Position("G6");

            // Act.
            bool actual = piece.CheckMove(new CheesBoard(), position);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода CheckMove() у класса Rook.
        /// </summary>
        [TestMethod()]
        public void CheckMove_NotCorrectRookMove_ReturnsFalse()
        {
            // Arrange.         
            var piece = new Rook(new Position("A8"), PieceColor.Black);
            var position = new Position("B7");

            // Act.
            bool actual = piece.CheckMove(new CheesBoard(), position);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода CheckMove() у класса Bishop.
        /// </summary>
        [TestMethod()]
        public void CheckMove_NotCorrectBishopMove_ReturnsFalse()
        {
            // Arrange.         
            var piece = new Bishop(new Position("C1"), PieceColor.White);
            var position = new Position("D1");

            // Act.
            bool actual = piece.CheckMove(new CheesBoard(), position);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода CheckMove() у класса King.
        /// </summary>
        [TestMethod()]
        public void CheckMove_NotCorrectKingMove_ReturnsFalse()
        {
            // Arrange.         
            var piece = new King(new Position("E1"), PieceColor.White);
            var position = new Position("D2");

            // Act.
            bool actual = piece.CheckMove(new CheesBoard(), position);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода CheckMove() у класса Queen.
        /// </summary>
        [TestMethod()]
        public void CheckMove_NotCorrectQueenMove_ReturnsFalse()
        {
            // Arrange.         
            var piece = new Queen(new Position("D8"), PieceColor.Black);
            var position = new Position("D8");

            // Act.
            bool actual = piece.CheckMove(new CheesBoard(), position);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

    }
}
