using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio08;

namespace Ejercicio08Test
{
    [TestClass]
    public class TurbomixTest
    {
        [TestMethod]
        public void TestCalentar()
        {
            Turbomix sut = new Turbomix();
        }
    }

    public class PlatoPrueba :IPlato
    {

    }
}
