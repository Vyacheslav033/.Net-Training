using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessLibrary;

namespace ChessLibraryTests
{
    /// <summary>
    /// Тестирование класса Pawn.
    /// </summary>
    [TestClass()]
    public class PawnTests
    {
        /// <summary>
        /// Тестирование метода CheckMove().
        /// </summary>
        [TestMethod()]
        public void CheckMove_NotCorrectPawnMove_ReturnsFalse()
        {
            // Arrange.         
            var piece = new Pawn(new Position("F2"), PieceColor.White);
            var position = new Position("F5");

            // Act.
            bool actual = piece.CheckMove(new CheesBoard(), position);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода CanTurningAPawn().
        /// </summary>
        [TestMethod()]
        public void CanTurningAPawn_CanNotTurningAPawn_ReturnsFalse()
        {
            // Arrange.         
            var piece = new Pawn(new Position("D8"), PieceColor.White);
            var newPiece = new King(new Position("D8"), PieceColor.White);

            // Act.
            bool actual = piece.CanTurningAPawn(newPiece);

            // Assert.            
            Assert.AreEqual(false, actual);
        }
    }
}