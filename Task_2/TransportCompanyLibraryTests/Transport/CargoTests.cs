using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportCompanyLibrary;

namespace TransportCompanyLibraryTests
{
    /// <summary>
    /// Тестирование класса Cargo.
    /// </summary>
    [TestClass()]
    public class CargoTests
    {
        /// <summary>
        /// Тестирование конструктора на верную инициализацию объекта.
        /// </summary>
        [TestMethod()]
        public void CargoTest()
        {
            // Arrange. 
            var trailer = new TankerSemitrailer(800, 2000);

            // Act.
            var actualProperty = new Cargo(trailer);

            // Assert.            
            Assert.AreEqual(trailer.GetType(), actualProperty.SemitrailerType);
        }

        /// <summary>
        /// Тестирование метода RemoveAllProduct().
        /// </summary>
        [TestMethod()]
        public void RemoveAllProduct_RemovingAllProductFromCargo_ReturnsZero()
        {
            // Arrange.         
            var cargo = new Cargo(new TankerSemitrailer(700, 2000));

            // Act.
            cargo.AddProduct(new Milk("Молоко", 50, MeasureUnit.Litre, 1500, -5, 5));
            cargo.RemoveAllProduct();

            // Assert.            
            Assert.AreEqual(0, cargo.ProductCount);
        }

        /// <summary>
        /// Тестирование метода IsThereProductCategory().
        /// </summary>
        [TestMethod()]
        public void IsThereProductCategory_SearchProductCategoryInCargo_ReturnsTrue()
        {
            // Arrange.         
            var cargo = new Cargo(new TankerSemitrailer(700, 2000));
            var product = new Milk("Молоко", 50, MeasureUnit.Litre, 1500, -5, 5);

            // Act.
            cargo.AddProduct(product);

            bool actual = cargo.IsThereProductCategory(product.GetType());

            // Assert.            
            Assert.AreEqual(true, actual);
        }
    }
}