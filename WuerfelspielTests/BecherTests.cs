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

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        private void SicherungUmschalten_Wuerfel_Nicht_Verhanden()
        {
            // Arrange
            int anzahlWuerfel = 5;
            Becher b = new Becher(anzahlWuerfel);

            // Act
            b.WuerfelSicherungUmschalten(6);
        }

        [TestMethod]
        public void WuerfelSicherungUmschalten_Wuerfel_Umgeschaltet()
        {
            // Arrange 
            int anzahlWuerfel = 5;
            Becher b = new Becher(anzahlWuerfel);
            bool wuerfelIstGeschichert = b.Wuerfel[3].Gesichert;

            // Act
            b.WuerfelSicherungUmschalten(3);

            // Assert
            Assert.AreNotEqual(b.Wuerfel[3].Gesichert, wuerfelIstGeschichert);
        }
    }
}
