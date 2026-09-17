using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    class ReindeerSleigh : Vechicle
    {
        const int reindeerFactor = 100;

        public override double GetPrice()
        {
            return basePrice * reindeerFactor;
        }
    }
}
