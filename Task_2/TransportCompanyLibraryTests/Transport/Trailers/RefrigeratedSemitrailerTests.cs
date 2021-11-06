using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportCompanyLibrary;


namespace TransportCompanyLibraryTests
{
    /// <summary>
    /// Тестирование класса RefrigeratedSemitrailer.
    /// </summary>
    [TestClass()]
    public class RefrigeratedSemitrailerTests
    {
        /// <summary>
        /// Тестирование метода CanAddProductTest() на возможность добавить товара в трейлер рефрижиратор.
        /// </summary>
        [TestMethod()]
        public void CanAddProduct_NotCorrectProductAdding_ReturnsFalse()
        {
            // Arrange.         
            var semitrailer = new RefrigeratedSemitrailer(700, 2000);

            var product = new Mercury("Ртуть", 500, MeasureUnit.Litre, 550);
          
            // Act.
            bool actual = semitrailer.CanAddProduct(product);

            // Assert.            
            Assert.AreEqual(false, actual);
        }
    }
}