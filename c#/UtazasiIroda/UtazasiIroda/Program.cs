using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UtazasiIroda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Route[] routes = new Route[3];
            routes[0] = new AirRoute(3700);
            routes[1] = new LandRoute(250);
            routes[2] = new ShipRoute(1600);

            foreach(Route route in routes)
            {
                if(route is LandRoute )
                {
                    Console.WriteLine($"Szarazfoldi ut ideje {Math.Round(route.GetDuration(), 2)} ora");
                }
                else if (route is ShipRoute )
                {
                    Console.WriteLine($"Vizifoldi ut ideje {Math.Round(route.GetDuration(), 2)} ora");
                }
                else if (route is AirRoute ) 
                {
                    Console.WriteLine($"legi ut ideje {Math.Round(route.GetDuration(), 2)} ora");
                }
            }
        }
    }
}
