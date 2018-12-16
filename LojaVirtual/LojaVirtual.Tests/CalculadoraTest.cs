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
            //arrange
            var valor1 = 1;
            var valor2 = 2;
            var valorEsperado = 3;
            var calculadora = new Calculadora();
            //act
            var resultado = calculadora.Somar(valor1, valor2);
            //assert
            Assert.IsTrue(valorEsperado == resultado);
            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}
