using System;


namespace Doga_Linked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            double[] ds = new double[5]
            {
                4.2, 5.2, 6.7, 2.7, 8.9
            }; 
            LinkedList l2 = new LinkedList(ds);
            l.AddFirst(5.8);
            LinkedList l3 = new LinkedList(l);
            l.AddLast(6.2);
            l3.AddLast(6.9);
            l3.AddFirst(3.1);
            Console.WriteLine(l.ToString());
            Console.WriteLine();
            Console.WriteLine(l2.ToString());
            Console.WriteLine();
            Console.WriteLine(l3.ToString());
            Console.WriteLine();
            Console.WriteLine(l[0]);
            Console.WriteLine(l.RemoveLast());
            Console.WriteLine(l.ToString());
            Console.WriteLine(l.Contains(6.9));
            Console.WriteLine(l3.Contains(6.9));
            
        }
    }
}
