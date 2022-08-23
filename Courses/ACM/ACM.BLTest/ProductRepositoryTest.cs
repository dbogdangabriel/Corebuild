using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Birght Yellow Mini Sunflowers",
                ProductPrice = 15.96M,
              };

            // Act
            var actual = productRepository.Retrieve(2);
            // Assert
            // Assert.AreEqual(expected, actual); // nu folosim asta deoarece actual si expected sunt doua obiecte diferite
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductPrice, actual.ProductPrice);

        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                HasChanges = true,
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Birght Yellow Mini Sunflowers",
                ProductPrice = 18M,
            };

            // Act
            var actual = productRepository.Save(updateProduct);
            // Assert
            // Assert.AreEqual(expected, actual); // nu folosim asta deoarece actual si expected sunt doua obiecte diferite
            Assert.AreEqual(true, actual);

        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                HasChanges = true,
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Birght Yellow Mini Sunflowers",
                ProductPrice = null,
            };

            // Act
            var actual = productRepository.Save(updateProduct);
            // Assert
            // Assert.AreEqual(expected, actual); // nu folosim asta deoarece actual si expected sunt doua obiecte diferite
            Assert.AreEqual(false, actual);

        }
    }


    
}
