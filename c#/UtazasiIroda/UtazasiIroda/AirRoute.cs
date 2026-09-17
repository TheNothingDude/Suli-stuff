using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtazasiIroda
{
    class AirRoute : Route
    {
        const int averageAirRoute = 900;
        public AirRoute(double s)
        {
            base.s = s;
        }
        public override double GetDuration()
        {
            return s / averageAirRoute;
        }
    }
}
