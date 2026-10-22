using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemes_HertelendyAron_SW
{
    class Uralkodo : IEroErzekeny, ISith
    {
        double gonoszsag;
        public Uralkodo() { gonoszsag = 100; }

        public double MekkoraAzEreje()
        {
            return gonoszsag * 2;
        }
        public bool LegyoziE(IEroErzekeny i)
        {
            if(i.MekkoraAzEreje() < gonoszsag)
            {
                return true;
            }
            return false;
        }
        public void EngeddElAHaragod()
        {
            gonoszsag += 50;
        }
        public override string ToString() 
        {
            return $"Uralkodo {gonoszsag}";
        }

    }
}
