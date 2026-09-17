using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    class HorseSledge : Vechicle
    {
        const int horseFactor = 60;
        public override double GetPrice()
        {
            return basePrice * horseFactor;
        }
    }
}
