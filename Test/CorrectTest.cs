using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace CorrectTest{

    [TestClass]
    public class CorrectTest
    {
        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Edades()
        {
            int total2 = PrimeService.Edades(1999,10,17);
            Assert.AreEqual(21, total2);
        }

        [TestMethod]
        public void testCSalario(){

            var result  = PrimeService.CSalario(0);
            Assert.AreEqual(0, result);
        }
    }
}