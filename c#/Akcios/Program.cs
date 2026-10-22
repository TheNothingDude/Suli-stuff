using System;

namespace Akcios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Vegyesbolt.Bevesarlok(Console.ReadLine());
                Vegyesbolt.MiVanAKosaramban();

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}