using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportCompanyLibrary;

namespace TransportCompanyLibraryTests
{
    /// <summary>
    /// Тестирование класса Semitrailer.
    /// </summary>
    [TestClass()]
    public class SemitrailerTests
    {
        /// <summary>
        /// Тестирование конструктора на верную инициализацию объекта.
        /// </summary>
        [TestMethod()]
        public void SemitrailerTest()
        {
            // Arrange. 
            float expectedWeight = 700;
            int expectedLoadCapacity = 200;

            // Act.
            var actualProperty = new TankerSemitrailer(expectedWeight, expectedLoadCapacity);

            // Assert.            
            Assert.AreEqual(expectedWeight, actualProperty.Weight);
            Assert.AreEqual(expectedLoadCapacity, actualProperty.LoadCapacity);
        }

        /// <summary>
        /// Тестирование метода Equals() на сравнение не равных объектов.
        /// </summary>
        [TestMethod()]
        public void Equals_СomparisonNotEqualSemitrailer_ReturnsFalse()
        {
            // Arrange. 
            var trailer1 = new TankerSemitrailer(500, 1500);
            var trailer2 = new TankerSemitrailer(600, 2100);

            // Act.
            bool actual = trailer1.Equals(trailer2);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода GetHashCode() для не равных объектов.
        /// </summary>
        [TestMethod()]
        public void GetHashCode_СomparisonNotEqualSemitrailer_ReturnsFalse()
        {
            // Arrange. 
            int hashCode1 = new TankerSemitrailer(500, 1500).GetHashCode();
            int hashCode2 = new TankerSemitrailer(600, 2100).GetHashCode();

            // Act.
            bool actual = hashCode1 == hashCode2;

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода ToString().
        /// </summary>
        [TestMethod()]
        public void ToString_GetSemitrailerTypeString_ReturnsTankerSemitrailer()
        {
            // Arrange. 
            var trailer = new TankerSemitrailer(500, 1500);

            // Act.
            string actual = trailer.ToString();

            // Assert.            
            Assert.AreEqual("TankerSemitrailer", actual);
        }
    }
}