using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosz
{
    interface ICreature
    {
        void Reproduce();
    }

    interface IPlant : ICreature
    {
        void Photosynthesis();
    }
    interface IAnimal : ICreature
    {
        void Eves();
        void Mozgas();
    }
 
}
