using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ellista list = new Ellista("input.txt");
            Console.WriteLine(list.ToString());
            Console.WriteLine((int)'A');
        }
    }
}
