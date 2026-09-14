using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(5);
            s1.Push(-2);
            s1.Push(176);
            s1.Push(1024);

            Stack<Car> cars = new Stack<Car>();
            cars.Push(new Car("Honda", "Civic", 2001));
            cars.Push(new Car("Toyota", "Yarris", 2010));

            Console.WriteLine(cars.Contains(new Car("Honda", "Civic", 2001)));
            Console.WriteLine(cars.Pop());

        }
    }
}
