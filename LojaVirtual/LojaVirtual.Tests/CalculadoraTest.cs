using System;
using LojaVirtual.BLL.Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LojaVirtual.Tests
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Somar_valores_com_sucesso()
        {
            var valor1 = 1;
            var valor2 = 2;
            var valorEsperado = 3;

            var calculadora = new Calculadora();
            var resultado = calculadora.Somar(valor1, valor2);

            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}
