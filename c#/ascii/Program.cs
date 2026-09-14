using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valami = "hello";
            if(valami.Contains('a') && valami.Contains('o'))
            {
                System.Console.WriteLine("van");
            }
        }
    }
}