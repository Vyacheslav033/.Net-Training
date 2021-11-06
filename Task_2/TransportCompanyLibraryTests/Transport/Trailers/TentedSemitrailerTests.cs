using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportCompanyLibrary;

namespace TransportCompanyLibraryTests
{
    /// <summary>
    /// Тестирование класса TentedSemitrailer.
    /// </summary>
    [TestClass()]
    public class TentedSemitrailerTests
    {
        /// <summary>
        /// Тестирование метода CanAddProductTest() на возможность добавить товара в тентованный трейлер.
        /// </summary>
        [TestMethod()]
        public void CanAddProduct_NotCorrectProductAdding_ReturnsFalse()
        {
            // Arrange.         
            var product1 = new Milk("Молоко", 50, MeasureUnit.Piece, 550, -5, 5);
            var product2 = new Mercury("Ртуть", 500, MeasureUnit.Litre, 550);

            var semitrailer = new TentedSemitrailer(700, 2000);
            semitrailer.Cargo.AddProduct(product1);

            // Act.
            bool actual = semitrailer.CanAddProduct(product2);

            // Assert.            
            Assert.AreEqual(false, actual);
        }
    }
}