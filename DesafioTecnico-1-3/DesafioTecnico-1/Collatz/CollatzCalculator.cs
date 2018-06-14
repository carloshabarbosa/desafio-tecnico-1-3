using System;
using Extension.Extensions;

namespace DesafioTecnico_1.Collatz
{
    /// <summary>
    /// Classe para o cálculo do problema de Collatz
    /// </summary>
    public static class CollatzCalculator
    {
        /// <summary>
        /// Resolve o número contando a quantidade de ocorrências em que o mesmo gerou
        /// </summary>
        /// <param name="number">Número para ser calculado</param>
        /// <returns>Quantidade de ocorrências em que o número gerou</returns>
        public static long ResolveNumber(long number)
        {
            if (number < 0)
                throw new Exception("Não é possível calcular um número negativo");
            //Inicia a contagem de ocorrências
            var count = 1;

            //Repete a operação até o número ficar com o valor de 1 ou se o número é igual a 1
            while (number != 1 || count == 1)
            {
                //Calcula o número
                number = CalculateNumber(number);
                //incrementa o contador
                count++;
            }

            //retorna a quantidade de ocorrências
            return count;
        }

        /// <summary>
        /// Método para calcular um número
        /// </summary>
        /// <param name="number">Número a ser calculado</param>
        /// <returns>O resultado do cálculo</returns>
        private static long CalculateNumber(long number)
        {
            //Verifica se o número é PAR e chama a função correspondente 
            return number.IsEven() ? CalculateEven(number) : CalculateOdd(number);
        }

        /// <summary>
        /// Calcula um número PAR
        /// </summary>
        /// <param name="number">Número a ser calculado</param>
        /// <returns>O resultado do cálculo</returns>
        private static long CalculateEven(long number)
        {
            return number / 2;
        }

        /// <summary>
        /// Cálcula um número ÍMPAR
        /// </summary>
        /// <param name="number">Número a ser cálculado</param>
        /// <returns>O resultado do cálculo</returns>
        private static long CalculateOdd(long number)
        {
            return number * 3 + 1;
        }
    }
}