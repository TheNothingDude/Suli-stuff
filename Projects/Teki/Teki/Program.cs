using System;


namespace Teki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turtle teki = new Turtle();

            Console.WriteLine($"{teki.FedLevel}, {teki.Happiness}");

            teki.Eat(new Crab(5));
            Console.WriteLine($"{teki.FedLevel}, {teki.Happiness}");
            teki.Eat(new Crab(10));
            teki.Eat(new Crab(10));
            teki.Eat(new Crab(10));
            teki.Eat(new Crab(10));
            teki.Eat(new Crab(10));

            Console.WriteLine($"{teki.FedLevel}, {teki.Happiness}");
        }
    }
}
