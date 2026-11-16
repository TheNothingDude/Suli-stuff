using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Array quick = new Array(100);
            Array heap = new Array(quick);
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            quick.QuickSort();
            sw.Stop();
            System.Console.WriteLine("quick " + sw.Elapsed);
            sw.Reset();
            sw.Start();
            heap.HeapSort();
            sw.Stop();
            System.Console.WriteLine("kupac " + sw.Elapsed);
            System.Console.WriteLine(heap);
        }
    }
}