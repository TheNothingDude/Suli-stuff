using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosz
{
    class Mammal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Mammal(int age, string name) {
            Age = age;
            Name = name;
        }
        public void Mozgas()
        {   
            Console.WriteLine($"{Name} is moving");
        }
        public void Eves()
        {
            Console.WriteLine($"{Name} eszeget");
        }
        public void Reproduce()
        {
            Console.WriteLine($"{Name} eleven szul");
        }
    }
    class Bird : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Bird(int age, string name)
        {
            Age = age; Name = name;
        }
        public void Reproduce()
        {
            Console.WriteLine($"{Name} tojas rak");
        }
        public void Eves()
        {
            Console.WriteLine("csipeget");
        }
        public void Mozgas()
        {
            Console.WriteLine("repul uwu");
        }
    }
}
