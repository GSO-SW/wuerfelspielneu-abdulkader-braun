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
            int seitenzahlpruefen = 6;
            bool gesichert = false;
            Wuerfel expectedwuerfel = new Wuerfel();
            //Act
            Wuerfel wuerfel = new Wuerfel();
            //Assert
            Assert.AreEqual(expectedwuerfel, wuerfel);

        }
 
    }
}
