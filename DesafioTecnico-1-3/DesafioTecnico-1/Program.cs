using System;
using System.Diagnostics;
using System.Linq;
using DesafioTecnico_1.Collatz;

namespace DesafioTecnico_1
{
    class Program
    {
        //Configurando o número limite de execuções
        private const int LimitNumber = 1000000;

        static void Main(string[] args)
        {
            // Cria o StopWatch
            var sw = new Stopwatch();

            // Começa a contar o tempo
            sw.Start();
            
            //Gera uma lista de 1 até o limite de execuções
            var baseList = Enumerable.Range(1, LimitNumber).ToList();

            //Monta uma lista com o número que foi calculado e a quantidade de ocorrências que o mesmo gerou
            var resolvedList = baseList.Select(c => new Result
                {
                    Number = c,
                    OcccurencesNumber = CollatzCalculator.ResolveNumber(c)
                })
                .ToList();

            //Seleciona o número com o maior número de ocorrências
            var result = 
                resolvedList.OrderByDescending(c => c.OcccurencesNumber).FirstOrDefault();

            // Para de contar o tempo
            sw.Stop();


            // Obtém o tempo que a rotina demorou a executar
            var tempo = sw.Elapsed;

            //Monta e exibie a mensagem na tela
            Console.WriteLine(BuildResult(result.Number, result.OcccurencesNumber));

            //Exibe a quantidade em ms em que o código demorou para resolver
            Console.WriteLine($"tempo de processamento: {tempo.Milliseconds} ms");
            //Espera uma ação do usuário
            Console.ReadKey();
        }


        /// <summary>
        /// Monta a mensagem que será exibida no console
        /// </summary>
        /// <param name="number">Número que foi usado para o cálculo</param>
        /// <param name="occurrencesNumber">Quantidade de ocorrências em que o número gerou</param>
        /// <returns>Mensagem formatada para exibição</returns>
        private static string BuildResult(int number, long occurrencesNumber)
        {
            return $"O número: {number} gerou: {occurrencesNumber} ocorrências, sendo o maior número de ocorrências!";
        }


       

    }
}
