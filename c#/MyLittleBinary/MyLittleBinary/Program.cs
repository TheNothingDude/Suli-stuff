using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBinary b1 = new MyBinary(0001);
            MyBinary b2 = new MyBinary(11100);
            MyBinary b3 = new MyBinary(1101011);
            MyBinary b4 = new MyBinary(11);
            Console.WriteLine(b3.Decimal());
            MyBinary b5 = b4 << 3;
            Console.WriteLine(b5.Decimal());
        }
    }
}
