using System;
using System.Runtime.InteropServices;

namespace Lambda
{
    internal class Program
    {
        static Random rnd = new Random();
        public delegate double Muvelet(double a, double b);
        static void Main(string[] args)
        {
            Func<int, int> square = (x) => x * x;

            System.Console.WriteLine(square(55));

            List<int> szamok = new List<int>();
            for (int i = 0; i < 100; i++)
                szamok.Add(rnd.Next(1, 100));

            szamok.ForEach(i => { System.Console.Write($"{i + 2}, "); });

            Muvelet osszead = (a, b) => a + b;
            Muvelet osztas = (x, y) => x / y;
            System.Console.WriteLine();
            System.Console.WriteLine(osszead(2, 4));
            System.Console.WriteLine(osztas(2, 5));

            System.Console.WriteLine(szamok.Find(x => x == 23));
            System.Console.WriteLine(szamok.Find(x => x % 7 == 0));
        }
    }
}