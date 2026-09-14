using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Set<int> s = new Set<int>();
            Set<int> t = new Set<int>();
            s.Add(1);
            s.Add(2);   
            s.Add(3);
            s.Add(4);
            s.Add(2);
            t.Add(1);
            t.Add(6);
            t.Add(3);
            Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine(Set<int>.Intersect(s, t));
            Console.WriteLine(Set<int>.Except(s, t));
            Console.WriteLine(Set<int>.Union(s,t));
        }
    }
}
