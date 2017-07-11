using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio08;

namespace Ejercicio08Test
{
    [TestClass]
    public class TurbomixTest
    {
        [TestMethod]
        public void TestHacerPlato()
        {
            Alimento Alimento1 = new Alimento();
            Turbomix sut = new Turbomix(new CocinaService(),new BasculaService());
            sut.HacerPlato(Alimento1,Alimento1);
        }

       
    }
}
