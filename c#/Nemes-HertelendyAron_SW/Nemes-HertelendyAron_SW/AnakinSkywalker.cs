using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemes_HertelendyAron_SW
{
    class AnakinSkywalker : Jedi, ISith
    {
        Random rnd = new Random();
        public AnakinSkywalker() : base(150, true) { }

        public void EngeddElAHaragod()
        {
            this.Ero += rnd.NextDouble() * 10;
        }
        public override bool MegteremtiAzEgyensulyt()
        {
            if (this.Ero > 1000) 
            { 
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Anakin Skywalker: {base.ToString()}";
        }

    }
}
