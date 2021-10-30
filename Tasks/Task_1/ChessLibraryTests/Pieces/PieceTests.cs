using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessLibrary;

namespace ChessLibraryTests
{
    /// <summary>
    /// Тестирование класса Piece.
    /// </summary>
    [TestClass()]
    public class PieceTests
    {
        /// <summary>
        /// Тестирование конструктора на верную инициализацию объекта.
        /// </summary>
        [TestMethod()]
        public void Piece_CorrectInitialization_ReturnsA1AndWhite()
        {
            // Arrange. 
            var expectedPosition = new Position("A1");
            var expectedColor = PieceColor.White;
            var piece = new Pawn(expectedPosition, expectedColor);

            // Act.
            Position actualPosition = piece.Position;
            PieceColor actualColor = piece.Color;

            // Assert.            
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        /// <summary>
        /// Тестирование конструктора копирования на верную инициализацию объекта.
        /// </summary>
        [TestMethod()]
        public void Piece1_CorrectInitialization_ReturnsG1AndBlack()
        {
            // Arrange. 
            var expected = new Pawn(new Position("G1"), PieceColor.Black);

            // Act.
            var actual = new Knight(expected);

            // Assert.            
            Assert.AreEqual(expected.Position, actual.Position);
            Assert.AreEqual(expected.Color, actual.Color);
        }

        /// <summary>
        /// Тестирование метода Equals() на сравнение двух равных объектов.
        /// </summary>
        [TestMethod()]
        public void Equals_СomparisonEqualPieces_ReturnsTrue()
        {
            // Arrange. 
            var piece1 = new Bishop(new Position("B3"), PieceColor.Black);
            var piece2 = new Bishop(new Position("B3"), PieceColor.Black);

            // Act.
            bool actual = piece1.Equals(piece2);

            // Assert.            
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Тестирование метода Equals() на сравнение не равных объектов.
        /// </summary>
        [TestMethod()]
        public void Equals_СomparisonNotEqualPieces_ReturnsFalse()
        {
            // Arrange. 
            var piece1 = new Bishop(new Position("B3"), PieceColor.Black);
            var piece2 = new Bishop(new Position("G1"), PieceColor.White);

            // Act.
            bool actual = piece1.Equals(piece2);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода GetHashCode() для равных объектов.
        /// </summary>
        [TestMethod()]
        public void GetHashCode_СomparisonEqualPieces_ReturnsTrue()
        {
            // Arrange. 
            int hashCode1 = new Queen(new Position("C1"), PieceColor.Black).GetHashCode();
            int hashCode2 = new Queen(new Position("C1"), PieceColor.Black).GetHashCode();

            // Act.
            bool actual = hashCode1 == hashCode2;

            // Assert.            
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Тестирование метода GetHashCode() для не равных объектов.
        /// </summary>
        [TestMethod()]
        public void GetHashCode_СomparisonNotEqualPieces_ReturnsFalse()
        {
            // Arrange. 
            int hashCode1 = new Queen(new Position("C6"), PieceColor.Black).GetHashCode();
            int hashCode2 = new Queen(new Position("B6"), PieceColor.White).GetHashCode();

            // Act.
            bool actual = hashCode1 == hashCode2;

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода ToString().
        /// </summary>
        [TestMethod()]
        public void ToString_GetPieceName_ReturnsKing()
        {
            // Arrange. 
            var piece = new King(new Position("D2"), PieceColor.White);

            // Act.
            string actual = piece.ToString();

            // Assert.            
            Assert.AreEqual("King", actual);
        }
    }
}