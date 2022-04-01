using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_wuerfelnkonstrucktorleer()
        {
            //Arrange
            int seitenzahl = 6;

            //Act
            Wuerfel wuerfel = new Wuerfel();

            //Assert
            Assert.AreEqual(seitenzahl, wuerfel.AnzahlSeiten);
            Assert.IsFalse(wuerfel.Gesichert);

        }

    }
}
