using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LojaVirtual.Tests
{
    [TestClass]
    public class CalculadoraProdutoTest
    {
        [TestMethod]
        public void Criar_classe_calculadora()
        {
            var calculadora = new CalculadoraProduto();

            Assert.IsNotNull(calculadora);
        }

        [TestMethod]
        public void Somar_dois_valores_inteiros()
        {
            var valor1 = 1;
            var valor2 = 2;
            var valorEsperado = 3;
            var calculadora = new CalculadoraProduto();

            var resultado = calculadora.Somar(valor1, valor2);

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void Somar_dois_valores_double()
        {
            var valor1 = 1.0;
            var valor2 = 2.5;
            var valorEsperado = 3.5;
            var calculadora = new CalculadoraProduto();

            var resultado = calculadora.Somar(valor1, valor2);

            Assert.AreEqual(valorEsperado, resultado);
        }

        private class CalculadoraProduto
        {
            public CalculadoraProduto()
            {
            }

            public double Somar(double valor1, double valor2)
            {
                return valor1 + valor2;
            }
        }
    }
}
