using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtazasiIroda
{
    class LandRoute : Route
    {
        const int averageLandRoute = 75;
        public LandRoute(double s)
        {
            base.s = s;
        }
        public override double GetDuration()
        {
            return s / averageLandRoute;
        }
    }
}
