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
    }
}
