using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teki
{
    class Crab : Food
    {
        int size;
        public Crab(int size)
        {
            if (size > 0 && size < 11)
            {
                this.size = size;
            }
        }

        public override int Value()
        {
            return size * 10;
        }
    }
}
