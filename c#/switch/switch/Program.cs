using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Csere<Type>(ref Type a, ref Type b)
        {
            (b, a) = (a, b);
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;
            Csere(ref a, ref b);
            string c = "alma";
            string d = "kecsle";
            Csere(ref c, ref d);
            Console.WriteLine(d);
            Console.WriteLine(a);
        }
    }
}
