using Extension.Extensions;
using System;
using System.Linq;

namespace DesafioTecnico_2
{
    class Program
    {
        //Sequência de números proposto pelo exercício
        static int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

        static void Main(string[] args)
        {
            //Recupera somente os números ímpares
            var result = numeros.Where(n => !n.IsEven()).ToList();

            //Exibe o resultado
            Console.WriteLine(string.Join(",", result));
            
            //Aguarda a interação do usuário
            Console.ReadKey();
        }
    }
}
