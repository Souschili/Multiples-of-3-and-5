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
            int min = 5;
            //Console.WriteLine(Div(n,5));
            //Console.WriteLine(Div(n,3));
            //Console.WriteLine(Div(n,15));

            Console.WriteLine(Div(n,15));
            Console.WriteLine(Div(n,5));
            Console.WriteLine(Div(n,3));
            Console.WriteLine(Div(n,3)+Div(n,5)-Div(n,15));

            //BigInteger count = (n - 1) / min;
            //BigInteger maxVal = min + ((count - 1) * min);
            //BigInteger summ = ((min + maxVal) / 2) * count;

            //Console.WriteLine($"count ={count} maxVal= {maxVal}   summ= {summ}");
            //1683   =3
            //312    =15
            //950    =5


        }

        static BigInteger Div(BigInteger n,int min)
        {
            BigInteger count = (n - 1) / min;
            BigInteger maxVal=min+((count-1)* min);
            BigInteger summ=((min+maxVal)*count)/2;
            return summ;
        }

    }
}
