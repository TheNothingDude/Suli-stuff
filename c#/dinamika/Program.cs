using System;

namespace MyApp
{
    internal class Program
    {
        static void Add(ref int[] t, int n)
        {
            int[] tmp = new int[t.Length+1];
            for(int i =0;i<t.Length;i++)
            {
                tmp[i] = t[i];
            }
            tmp[t.Length] = n;
            t = tmp;
        }
        static void Main(string[] args)
        {
            int[] t = new int[0];
            System.Console.WriteLine("írj be egy számot: ");
            string user_inp = System.Console.ReadLine();
            while(user_inp != string.Empty)
            {
                Add(ref t, int.Parse(user_inp));
                user_inp = System.Console.ReadLine();
            } 
            foreach(int i in t)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}