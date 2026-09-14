using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatok
{
    class Allat
    {
        string fajta;
        string taplal;
        int eletkor;
        static int c = 0;

        public Allat(string fajta, string taplal, int eletkor)
        {
            this.fajta = fajta;
            this.taplal = taplal;
            this.eletkor = eletkor;
            c++;
        }
        public static int Count
        {
            get { return c; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Allat a1 = new Allat("pok", "rovarok", 1);
            Allat a2 = new Allat("csiga", "noveny", 2);

            //allat osztaly peldanyszam
            Console.WriteLine(Allat.Count);
        }
    }
}
