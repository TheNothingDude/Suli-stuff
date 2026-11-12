using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Array quick = new Array(1000000);
            Array bubble = new Array(quick);
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            quick.QuickSort();
            sw.Stop();
            System.Console.WriteLine(sw.Elapsed);
            sw.Reset();
            sw.Start();
            bubble.BubbleSort();
            sw.Stop();
            System.Console.WriteLine(sw.Elapsed);
        }
    }
}