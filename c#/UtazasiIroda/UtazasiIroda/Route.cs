using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtazasiIroda
{
    abstract class Route
    {
        protected double s;
        public abstract double GetDuration();
    }
}
