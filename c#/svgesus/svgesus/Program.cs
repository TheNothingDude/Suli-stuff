using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svgesus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line l = new Line(50, 10, 100, 30, "green");
            l.GenFile();
            l.Write();
        }
    }
}
