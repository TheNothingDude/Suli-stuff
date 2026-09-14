using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cases.StartGame();
            Console.WriteLine(Cases.BankOffer(2));
        }
    }
}
