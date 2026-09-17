using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    class HuskySledge : Vechicle
    {
        const int huskyFactor = 50;

        public override double GetPrice()
        {
            return basePrice * huskyFactor;
        }
    }
}
