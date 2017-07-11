using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio08;

namespace Ejercicio08Test
{
    [TestClass]
    public class TurbomixTest
    {
        [TestMethod]
        public void TestPesar()
        {
            Alimento Alimento1 = new Alimento();
            Turbomix sut = new Turbomix();
            sut.Pesar(Alimento1);
        }

        [TestMethod]
        public void TestCalentar()
        {
            Alimento Alimento1 = new Alimento();
            Alimento Alimento2 = new Alimento();

            Turbomix sut = new Turbomix();
            sut.Calentar(Alimento1,Alimento2);
        }
    }
}
