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
            int Letztesergebniss = 0;
            //Act
            Wuerfel wuerfel = new Wuerfel();

            //Assert
            Assert.AreEqual(seitenzahl, wuerfel.AnzahlSeiten);
            Assert.IsFalse(wuerfel.Gesichert);
            Assert.AreEqual(Letztesergebniss, wuerfel.LetztesErgebniss);

        }

        [TestMethod]
        public void Wuerfel_wuerfelkostrukotnictLeer()
        {
            //Arrange
            int seitenzahl = 8;
            int Letztesergebniss = 0;
            //Act
            Wuerfel wuerfel = new Wuerfel(seitenzahl);
            wuerfel.gesichert = true;

            //Assert
            Assert.AreEqual(seitenzahl, wuerfel.AnzahlSeiten);
            Assert.IsTrue(wuerfel.Gesichert);
            Assert.AreEqual(Letztesergebniss, wuerfel.LetztesErgebniss);


        }



    }
}
