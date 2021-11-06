using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportCompanyLibrary;

namespace TransportCompanyLibraryTests
{
    /// <summary>
    /// Тестирование класса TankerSemitrailer.
    /// </summary>
    [TestClass()]
    public class TankerSemitrailerTests
    {
        /// <summary>
        /// Тестирование метода CanAddProductTest() на возможность добавить товара в трейлер автоцистерну.
        /// </summary>
        [TestMethod()]
        public void CanAddProduct_NotCorrectProductAdding_ReturnsFalse()
        {
            // Arrange.         
            var semitrailer = new TankerSemitrailer(700, 2000);

            var product = new Milk("Молоко", 50, MeasureUnit.Piece, 550, -5, 5);

            // Act.
            bool actual = semitrailer.CanAddProduct(product);

            // Assert.            
            Assert.AreEqual(false, actual);
        }
    }
}