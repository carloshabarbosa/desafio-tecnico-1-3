using System;

namespace Extension.Extensions
{
    /// <summary>
    /// Extension para trabalhar com o tipo Long
    /// </summary>
    public static class LongExtension
    {
        /// <summary>
        /// Método de extensão para descobrir se um número do tipo LONG é par!
        /// </summary>
        /// <param name="number">Número que deseja verificar</param>
        /// <returns>true para par e false para ímpar</returns>
        public static bool IsEven(this long number)
        {
            return number % 2 == 0;
        }

    }
}