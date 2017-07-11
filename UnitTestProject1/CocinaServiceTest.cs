using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio08;

namespace Ejercicio08Test
{
    [TestClass]
    public class CocinaServiceTest
    {
        [TestMethod]
        public void TestCocina()
        {
            ICocina sut = new CocinaService();

            Alimento Alimento1 = new Alimento();
            Alimento Alimento2 = new Alimento();

            sut.Calentar(Alimento1, Alimento2);
            Assert.IsTrue(Alimento1.Calentado);
            Assert.IsTrue(Alimento2.Calentado);
        }
    }
}
