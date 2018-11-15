using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_clase_17;

namespace TestMiLista
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            MiLista<String> miLista = new MiLista<String>();

            string item1 = "Item 1";
            miLista.Add(item1);
            Assert.AreEqual(miLista.Count, 1);

        }
    }
}
