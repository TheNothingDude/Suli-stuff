using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strandd
{
    abstract class Cikk
    {
        Random rnd = new Random();
        static protected string id = string.Empty;
        bool kolcsonzott; 

        public Cikk() 
        {
            for(int i = 0; i < 30; i++)
            {
                id += (char)(rnd.Next(0, 100));
            }
            kolcsonzott = false;
        }

        public void Kolcsonoz()
        {
            kolcsonzott = true;
        }

    }
}
