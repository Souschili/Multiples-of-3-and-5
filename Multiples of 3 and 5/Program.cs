using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Multiples_of_3_and_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;


            Console.WriteLine(Div(n, 15));
            Console.WriteLine(Div(n, 5));
            Console.WriteLine(Div(n, 3));
            Console.WriteLine(Div(n, 3) + Div(n, 5) - Div(n, 15));


        }

        static BigInteger Div(BigInteger n, int min)
        {
            BigInteger count = (n - 1) / min;
            BigInteger maxVal = min + ((count - 1) * min);
            BigInteger summ = ((min + maxVal) * count) / 2;
            return summ;
        }

    }
}
