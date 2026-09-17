using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtazasiIroda
{
    class ShipRoute : Route
    {
        const int averageShipRoute = 60;
        public ShipRoute(double s)
        {
            base.s = s;
        }
        public override double GetDuration()
        {
            return s / averageShipRoute;
        }
    }
}
