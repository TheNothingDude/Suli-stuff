using System;
using System.Runtime.CompilerServices;

namespace GenericDel
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] Args)
        {
            List<int> ints = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                ints.Add(rnd.Next(1000));
            }
            List<int> even = ints.FindAll(item => item % 2 == 0);
            foreach (var item in even)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}