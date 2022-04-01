using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    class BecherTests
    {
        [TestMethod]
        private void Becher_Erstellen()
        {
            // Arrange
            int anzahlWuerfel = 5;

            //Act
            Becher b = new Becher(anzahlWuerfel);

            //Assert
            Assert.IsInstanceOfType(b, Becher);
        }

        [TestMethod]
        private void Becher_Hat_Wuerfel()
        {
            // Arrange
            int anzahlWuerfel = 5;

            // Act
            Becher b = new Becher(anzahlWuerfel);

            // Assert
            Assert.AreEqual(b.Wuerfel.Length, anzahlWuerfel);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        private void Becher_Keine_0_Wuerfel()
        {
            // Arrange
            int anzahlWuerfel = 0;

            // Act
            Becher b = new Becher(anzahlWuerfel);
        }
    }
}
