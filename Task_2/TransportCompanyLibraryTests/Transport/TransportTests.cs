using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportCompanyLibrary;

namespace TransportCompanyLibraryTests
{
    /// <summary>
    /// Тестирование класса Transport.
    /// </summary>
    [TestClass()]
    public class TransportTests
    {
        /// <summary>
        /// Тестирование конструктора на верную инициализацию объекта.
        /// </summary>
        [TestMethod()]
        public void Transport_CorrectInitialization_ReturnsEqualProperty()
        {
            // Arrange. 
            string expectedMark = "volvo";
            string expectedModel = "fx200";
            float expectedWeight = 3000;
            int expectedEnginePower = 500;
            int expectedMileage = 220;
            int expectedLoadCapacity = 5000;
            FuelType expectedFuelType = FuelType.Gasolin;
            float expectedFuelConsumption = 24.5f;

            // Act.
            var actualProperty = new Tractor(expectedMark, expectedModel, expectedWeight, expectedEnginePower, expectedMileage, expectedLoadCapacity, expectedFuelType, expectedFuelConsumption);

            // Assert.            
            Assert.AreEqual(expectedMark, actualProperty.Mark);
            Assert.AreEqual(expectedModel, actualProperty.Model);
            Assert.AreEqual(expectedWeight, actualProperty.Weight);
            Assert.AreEqual(expectedEnginePower, actualProperty.EnginePower);
            Assert.AreEqual(expectedMileage, actualProperty.Mileage);
            Assert.AreEqual(expectedLoadCapacity, actualProperty.LoadCapacity);
            Assert.AreEqual(expectedFuelType, actualProperty.FuelType);
            Assert.AreEqual(expectedFuelConsumption, actualProperty.FuelConsumption);
        }

        /// <summary>
        /// Тестирование метода Equals() на сравнение не равных объектов.
        /// </summary>
        [TestMethod()]
        public void Equals_СomparisonNotEqualTransport_ReturnsFalse()
        {
            // Arrange. 
            var transport1 = new Tractor("volvo", "fx200", 3000, 500, 220, 5000, FuelType.Gasolin, 24.5f);
            var transport2 = new Tractor("Man", "i2000", 3500, 500, 450, 5000, FuelType.Gas, 55);

            // Act.
            bool actual = transport1.Equals(transport2);

            // Assert.            
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Тестирование метода GetHashCode() для не равных объектов.
        /// </summary>
        [TestMethod()]
        public void GetHashCode_СomparisonNotEqualTransport_ReturnsFalse()
        {
            // Arrange. 
            int hashCode1 = new Tractor("volvo", "fx200", 3000, 500, 220, 5000, FuelType.Gasolin, 24.5f).GetHashCode();
            int hashCode2 = new Tractor("Man", "i2000", 3500, 500, 450, 5000, FuelType.Gas, 55).GetHashCode();

            // Act.
            bool actual = hashCode1 == hashCode2;

            // Assert.            
            Assert.AreEqual(false, actual);
        }
    }
}