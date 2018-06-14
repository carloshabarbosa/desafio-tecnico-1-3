using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnico_3
{
    class Program
    {
        //Sequência de números proposto pelo exercício
        static int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
        static int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };
        static void Main(string[] args)
        {
            //Recupera os números dos primeiro array que não estejam contidos no segundo
            var result = primeiroArray.Where(c => !segundoArray.Contains(c)).ToList();
            //Exibe o resultado na tela
            Console.WriteLine(string.Join(",", result));
            //Espera a interação do usuário
            Console.ReadKey();
        }
    }
}
