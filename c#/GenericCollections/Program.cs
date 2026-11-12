using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

namespace GenericCollections
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<string> l = new List<string>() { "Rudi", "BMW", "Citroen" };
            l.Add("Dacia");

            l.Sort();
            for (int i = 0; i < l.Count; i++)
            {
                System.Console.WriteLine(l[i]);
            }

            System.Console.WriteLine("- - - - - - - - - - - - - - - -");

            LinkedList<int> linked = new LinkedList<int>();
            for (int i = 0; i < 100; i++)
            {
                linked.AddFirst(rnd.Next(10, 100));
            }

            foreach (int i in linked)
            {
                System.Console.Write($"{i}, ");
            }

            System.Console.WriteLine("- - - - - - - - - - - - - - - -");

            SortedList<string, double> ds = new SortedList<string, double>();
            ds.Add("Robert", 1.74);
            ds.Add("Mici Macko", 1.52);

            foreach (KeyValuePair<string, double> kvp in ds)
            {
                System.Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            System.Console.WriteLine("- - - - - - - - - - - - - - - -");

            Stack<int> verem = new Stack<int>();

            System.Console.WriteLine("- - - - - - - - - - - - - - - -");

            Queue<int> sor = new Queue<int>();
            sor.Enqueue(5);
            sor.Enqueue(7);
            System.Console.WriteLine(sor.Dequeue());

            Dictionary<string, int> leltar = new Dictionary<string, int>();
            leltar.Add("Kenyer", 12);
            leltar.Add("szalami", 99);

            foreach (KeyValuePair<string, int> i in leltar)
            {
                System.Console.WriteLine($"{i.Key} : {i.Value}");
            }

            System.Console.WriteLine("- - - - - - - - - - - - - - - -");

            HashSet<string> halmaz = new HashSet<string>() { "alma", "korte" };
            halmaz.Add("alma");
            halmaz.Add("eper");
            halmaz.Add("dinnye");

            foreach (string i in halmaz)
            {
                if ("alma".GetHashCode() == i.GetHashCode())
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("- - - - - - - - - - - - - - - -");

            LinkedList<LinkedList<string>> ll = new LinkedList<LinkedList<string>>();
            ll.AddLast(new LinkedList<string>(new List<string>() { "nagypap" }));
            int n = 0;
            foreach (LinkedList<string> i in ll)
            {
                System.Console.WriteLine($"{n}");
                foreach (string j in i)
                {
                    System.Console.WriteLine(j);
                }
            }
        }
    }
}