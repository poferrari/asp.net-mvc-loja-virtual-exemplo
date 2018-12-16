using LojaVirtual.BLL._Base;

namespace LojaVirtual.BLL.Calculadora
{
    public class Calculadora : EntidadeBase
    {
        public double PrimeiroValor { get; private set; }
        public double SegundoValor { get; private set; }

        public int Somar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
    }
}
