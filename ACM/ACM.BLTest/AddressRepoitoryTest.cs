using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class AddressRepoitoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // Arrange
            var addressRepository = new AddressRepository();
            var expected = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag end",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",
            };

            // Act
            var actual = addressRepository.Retrieve(1);
            // Assert
            // Assert.AreEqual(expected, actual); // nu folosim asta deoarece actual si expected sunt doua obiecte diferite
            Assert.AreEqual(expected.AddressType, actual.AddressType); 
            Assert.AreEqual(expected.StreetLine1, actual.StreetLine1);
            Assert.AreEqual(expected.StreetLine2, actual.StreetLine2);
            Assert.AreEqual(expected.City, actual.City);
            Assert.AreEqual(expected.State, actual.State);
            Assert.AreEqual(expected.Country, actual.Country);
            Assert.AreEqual(expected.PostalCode, actual.PostalCode);


        }
    }
}
