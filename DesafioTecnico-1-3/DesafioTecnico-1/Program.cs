using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DesafioTecnico_1.Extensions;

namespace DesafioTecnico_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var listResult = new List<int>();
            for (int indexNumber = 1; indexNumber <= 1000000; indexNumber++)
            {
                listResult.Add(ResolveNumber(indexNumber));
                Console.WriteLine(indexNumber);
            }

            Console.WriteLine(listResult.Max(c => c));
        }

        private static int ResolveNumber(int number)
        {
            var count = 1;
            while (number != 1 || count == 1)
            {
                count++;

                number = CalculateNumber(number);
            }

            return count;
        }

        private static int CalculateNumber(int number)
        {
            if (number.IsEven())
            {
                return CalculateEven(number);
            }

            return CalculateOdd(number);
        }

        private static int CalculateEven(int number)
        {
            return number / 2;
        }

        private static int CalculateOdd(int number)
        {
            return number * 3 + 1;
        }

    }
}
