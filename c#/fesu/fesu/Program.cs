using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fesu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SkipList l = new SkipList();
            l.AddFirst("kecske");
            l.AddFirst("lo");
            l.AddFirst("alma", 1);
            l.AddFirst("korte", 1);
            Console.WriteLine(l.ToString());
            Console.WriteLine(l[1,0]);
        }
    }
}
