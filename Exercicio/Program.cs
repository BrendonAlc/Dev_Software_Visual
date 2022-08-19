using System;
using Calculos;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = {123, 321, 4325, 12, -32};

            CalculoDeMedia calculo = new CalculoDeMedia(numeros);

            Print.printarMedia(calculo.media);

            Print.printarMediana(calculo.media);
        }
    }
}
