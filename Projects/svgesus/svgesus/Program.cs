using System;

namespace svgesus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line l = new Line(50, 20, 100, 50, "blue");
            
            l.Write();
        }
    }
}