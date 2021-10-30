using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessLibrary;

namespace ChessLibraryTests
{

    /// <summary>
    /// Тестирование класса Position.
    /// </summary>
    [TestClass()]
    public class PositionTests
    {
        /// <summary>
        /// Тестирование конструктора на верную инициализацию объекта.
        /// </summary>
        [TestMethod()]
        public void Position_CorrectInitialization_ReturnsA3()
        {
            // Arrange. 
            string row = "A";
            int column = 3;
            string expectedPosition = $"{row}{column}";

            // Act.
            string actualPosition = new Position(row, column).ToString();

            // Assert.            
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        /// <summary>
        /// Тестирование конструктора на верную инициализацию объекта.
        /// </summary>
        [TestMethod()]
        public void Position1_CorrectInitialization_ReturnsB7()
        {
            // Arrange. 
            string expectedPosition = "B7";

            // Act.
            string actualPosition = new Position(expectedPosition).ToString();

            // Assert.            
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        /// <summary>
        /// Тестирование метода Equals() на сравнение равных объектов Position.
        /// </summary>
        [TestMethod()]
        public void Equals_СomparisonEqualPositions_ReturnsTrue()
        {
            // Arrange. 
            var position1 = new Position("H5");
            var position2 = new Position("H5");

            // Act.
            bool actual = position1.Equals(position2);

            // Assert.            
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Тестирование метода Equals() на сравнение не равных объектов Position.
        /// </summary>
        [TestMethod()]
        public void Equals_СomparisonNotEqualPositions_ReturnsFalse()
        {
            // Arrange. 
            var position1 = new Position("H5");
            var position2 = new Position("H8");

            // Act.
            bool actual = position1.Equals(position2);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода GetHashCode() для равных объектов Position.
        /// </summary>
        [TestMethod()]
        public void GetHashCode_СomparisonEqualPositions_ReturnsTrue()
        {
            // Arrange. 
            int hashCode1 = new Position("C1").GetHashCode();
            int hashCode2 = new Position("C1").GetHashCode();

            // Act.
            bool actual = hashCode1 == hashCode2;

            // Assert.            
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Тестирование метода GetHashCode() для не равных объектов Position.
        /// </summary>
        [TestMethod()]
        public void GetHashCode_СomparisonNotEqualPositions_ReturnsFalse()
        {
            // Arrange. 
            int hashCode1 = new Position("f2").GetHashCode();
            int hashCode2 = new Position("B4").GetHashCode();

            // Act.
            bool actual = hashCode1 == hashCode2;

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода ToString().
        /// </summary>
        [TestMethod()]
        public void ToString_GetPosition_ReturnsB7()
        {
            // Arrange. 
            string expected = "B7";

            // Act.
            string actual = new Position(expected).ToString();

            // Assert.            
            Assert.AreEqual(expected, actual);
        }
    }
}