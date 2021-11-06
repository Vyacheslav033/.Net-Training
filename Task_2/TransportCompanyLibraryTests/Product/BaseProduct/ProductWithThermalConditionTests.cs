using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportCompanyLibrary;

namespace TransportCompanyLibraryTests
{
    /// <summary>
    /// Тестирование класса ProductWithThermalConditionTests.
    /// </summary>
    [TestClass()]
    public class ProductWithThermalConditionTests
    {
        /// <summary>
        /// Тестирование конструктора на верную инициализацию объекта.
        /// </summary>
        [TestMethod()]
        public void ProductWithThermalConditionTestsTest()
        {
            // Arrange. 
            string expectedName = "молоко";
            int expectedCount = 500;
            MeasureUnit expectedMeasure = MeasureUnit.Litre;
            int expectedWeight = 1000;
            int expectedMinGradus = -10;
            int expectedMaxGradus = 10;

            // Act.
            var actualProperty = new Milk(expectedName, expectedCount, expectedMeasure, expectedWeight, expectedMinGradus, expectedMaxGradus);

            // Assert.            
            Assert.AreEqual(expectedName, actualProperty.Name);
            Assert.AreEqual(expectedCount, actualProperty.Count);
            Assert.AreEqual(expectedMeasure, actualProperty.Measure);
            Assert.AreEqual(expectedWeight, actualProperty.Weight);
            Assert.AreEqual(expectedMinGradus, actualProperty.MinGradus);
            Assert.AreEqual(expectedMaxGradus, actualProperty.MaxGradus);
        }

        /// <summary>
        /// Тестирование метода CheckTemperatureCompatibility() на совместимость температур продуктов.
        /// </summary>
        [TestMethod()]
        public void CheckTemperatureCompatibility_СomparisonTemperatureCompatibility_ReturnsFalse()
        {
            // Arrange. 
            var product1 = new Milk("Молоко", 500, MeasureUnit.Litre, 2100, -10, 10);
            var product2 = new Milk("Молоко", 200, MeasureUnit.Litre, 2100, -15, 5);

            // Act.
            bool actual = product1.CheckTemperatureCompatibility(product2);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода Equals() на сравнение не равных объектов.
        /// </summary>
        [TestMethod()]
        public void Equals_СomparisonNotEqualProduct_ReturnsFalse()
        {
            // Arrange. 
            var product1 = new Milk("Молоко", 500, MeasureUnit.Litre, 2100, -10, 10);
            var product2 = new Milk("Молоко", 200, MeasureUnit.Litre, 2100, -15, 5);

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
            int hashCode2 = new Milk("Молоко", 200, MeasureUnit.Litre, 2100, -15, 5).GetHashCode();

            // Act.
            bool actual = hashCode1 == hashCode2;

            // Assert.            
            Assert.AreEqual(false, actual);
        }
    }
}