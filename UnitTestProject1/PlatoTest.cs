﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio08;

namespace Ejercicio08Test
{
    [TestClass]
    public class PlatoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IAlimento Alimento1 = new IAlimento();
            Plato Plato1 = new Plato(Alimento1,Alimento2);
        }
    }
}
