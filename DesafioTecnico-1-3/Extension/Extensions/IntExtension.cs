namespace Extension.Extensions
{
    public static class IntExtension
    {
        /// <summary>
        /// Método de extensão para descobrir se um número do tipo INT é par!
        /// </summary>
        /// <param name="number">Número que deseja verificar</param>
        /// <returns>true para par e false para ímpar</returns>
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}