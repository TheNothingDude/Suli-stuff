using System;
using System.Reflection;

namespace MyExeption
{
    class UwUException : Exception
    {
        public UwUException() { }
        public UwUException(string message) : base(message) { }
        public UwUException(string message, Exception inner) : base(message, inner) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gyumi = new string[] { "alma", "banan", "korte", "cseresznye" };
            System.Console.WriteLine("which one do u want?");
            for (int i = 0; i < gyumi.Length; i++)
            {
                System.Console.Write($"{gyumi[i]}, ");
            }
            string input = System.Console.ReadLine();
            try
            {
                if (!gyumi.Contains(input))
                {
                    throw new UwUException($"no gyumi like this exists: {input}");
                }
            }
            catch (UwUException err) { System.Console.WriteLine(err.Message); }
        }
    }
}