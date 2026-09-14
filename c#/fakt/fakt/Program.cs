using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace fakt
{
    internal class Program
    {
        static int Factorial(int c)
        {
            int sum = 1;
            for(int i = 1; i <= c; i++)
            {
                sum = sum * i;
            }
            return sum;
        }
        static long BetterFact(int N)
        {
            if (N == 0 || N == 1)
                return 1;
            return BetterFact(N - 1) * N;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BetterFact(50));
        }
    }
}
