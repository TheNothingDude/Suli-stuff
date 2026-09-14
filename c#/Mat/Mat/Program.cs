using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mat
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Tort t1 = new Tort(1, 2);
            //Tort t2 = new Tort(1, 5);

            //Tort t3 = t1 * t2;
            //Console.WriteLine(t3.ToString());

            //Tort t4 = new Tort(6,7);
            //Tort t5 = new Tort(7,6);
            //Console.WriteLine((t4-t5).ToString());
            //Tort t6 = new Tort(20, 36);
            //Console.WriteLine(t6.ToString());
            Tort t1 = new Tort(1,2);
            Tort t2 = new Tort(2,3);
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 != t2);
        }
    }
}
