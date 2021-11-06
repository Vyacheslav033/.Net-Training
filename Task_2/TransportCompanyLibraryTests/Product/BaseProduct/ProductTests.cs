using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportCompanyLibrary;

namespace TransportCompanyLibraryTests
{
    /// <summary>
    /// Тестирование класса Product.
    /// </summary>
    [TestClass()]
    public class ProductTests
    {
        /// <summary>
        /// Тестирование конструктора на верную инициализацию объекта.
        /// </summary>
        [TestMethod()]
        public void ProductTest()
        {
            // Arrange. 
            string expectedName = "ртуть";
            int expectedCount = 500;
            MeasureUnit expectedMeasure = MeasureUnit.Litre;
            int expectedWeight = 500;

            // Act.
            var actualProperty = new Mercury(expectedName, expectedCount, expectedMeasure, expectedWeight);

            // Assert.            
            Assert.AreEqual(expectedName, actualProperty.Name);
            Assert.AreEqual(expectedCount, actualProperty.Count);
            Assert.AreEqual(expectedMeasure, actualProperty.Measure);
            Assert.AreEqual(expectedWeight, actualProperty.Weight);
        }

        /// <summary>
        /// Тестирование метода Equals() на сравнение не равных объектов.
        /// </summary>
        [TestMethod()]
        public void Equals_СomparisonNotEqualProduct_ReturnsFalse()
        {
            // Arrange. 
            var product1 = new Milk("Молоко", 500, MeasureUnit.Litre, 2100, -10, 10);
            var product2 = new Mercury("Ртуть", 500, MeasureUnit.Litre, 550);

            // Act.
            bool actual = product1.Equals(product2);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода GetHashCode() для не равных объектов.
        /// </summary>
        [TestMethod()]
        public void GetHashCode_СomparisonNotEqualProduct_ReturnsFalse()
        {
            // Arrange. 
            int hashCode1 = new Milk("Молоко", 500, MeasureUnit.Litre, 2100, -10, 10).GetHashCode();
            int hashCode2 = new Mercury("Ртуть", 500, MeasureUnit.Litre, 550).GetHashCode();

            // Act.
            bool actual = hashCode1 == hashCode2;

            // Assert.            
            Assert.AreEqual(false, actual);
        }

    }
}