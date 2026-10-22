using System;
using System.Data;

namespace Delagacio
{
    internal class Program
    {
        static void Pow(ref int item)
        {
            item = item * item;
        }
        static void DivideByTen(ref int item)
        {
            item = item / 10;
        }

        static void MultiplyBy2(ref int item)
        {
            item = item * 2;
        }
        static void SubtractBy2(ref int item)
        {
            item = item - 2;
        }
        static void Main(string[] args)
        {
            Array a = new Array(10);
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.Write(a[i] + " ");
            }
            System.Console.WriteLine();
            a.Transform(Pow);
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.Write(a[i] + " ");
            }
            System.Console.WriteLine();
            Array.Transformer handler = MultiplyBy2;
            handler += DivideByTen;
            a.Transform(handler);
            handler += SubtractBy2;
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.Write(a[i] + " ");
            }
        }
    }
}