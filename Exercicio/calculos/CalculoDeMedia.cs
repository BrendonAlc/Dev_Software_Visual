using System;

namespace Calculos
{
    class CalculoDeMedia
    {
        public double media { get ; private set; }

        public CalculoDeMedia(double[] numeros)
        {
            double soma = CalculoDeMedia.somarDadosArray(numeros);

            int tamanho = CalculoDeMedia.tamanhoDoArray(numeros);

            setMedia(CalculoDeMedia.dividirSomaPeloTamanho(soma, tamanho));
        }

        private void setMedia(double media)
        {
            this.media = media;
        }

        private static double somarDadosArray(double[] array)
        {
            double soma = 0;
            
            foreach (var item in array)
            {
                soma = soma + item;
            } 
            return soma;
        } 

        private static int tamanhoDoArray(double[] array)
        {
            return array.Length;
        }

        private static double dividirSomaPeloTamanho(double soma, int tamanho)
        {
            return soma / tamanho;
        }
    }
}