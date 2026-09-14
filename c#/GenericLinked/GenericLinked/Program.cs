using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ilist = new LinkedList<int>();
            ilist.AddFirst(1);
            ilist.AddFirst(2);
            ilist.AddFirst(3); 
            ilist.AddFirst(4);
            ilist.AddFirst(5);

            ilist.Sort();
            ilist.Insert(1, 8);
            Console.WriteLine(ilist.ToString());
        }
    }
}
