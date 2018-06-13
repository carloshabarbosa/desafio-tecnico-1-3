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
            for (int indexNumber = 0; indexNumber < 1000000; indexNumber++)
            {
                var teste = ResolveNumber(indexNumber, 0);
            }
        }

        private static int ResolveNumber(int number, int count)
        {
            if (number == 1)
                return count;

            number = CalculateNumber(number);

            return ResolveNumber(number, count);
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
