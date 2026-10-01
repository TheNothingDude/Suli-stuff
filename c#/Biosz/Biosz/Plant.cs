using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Biosz
{
    class Plant : IPlant
    {
        int Age {  get; set; }
        string Name { get; set; }
        public Plant(int age, string name) { Age = age; Name = name; }
        public void Photosynthesis()
        {
            Console.WriteLine("elvezi a napocskat");
        }
        public void Reproduce()
        {
            Console.WriteLine("elveti a seedjeit");
        }
    }
}
