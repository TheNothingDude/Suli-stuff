using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vechicle[] vechicles = new Vechicle[3];
            vechicles[0] = new HorseSledge();
            vechicles[1] = new ReindeerSleigh();
            vechicles[2] = new HuskySledge();

            foreach(Vechicle vechicle in vechicles)
            {
                Console.WriteLine(vechicle.GetPrice());
            }
        }
    }
}
