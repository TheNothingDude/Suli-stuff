using System;
using System.ComponentModel.DataAnnotations;

namespace interfacesssss
{
    class Batman : Bosszuallo, IMilliardos
    {
        double lelemenyesseg;
        private static double GetInitialLelemenyesseg()
        {
            return 100;
        }
        public Batman() : base(GetInitialLelemenyesseg()*2, true)
        {
            lelemenyesseg = GetInitialLelemenyesseg();
        }
        public bool legyoziE(ISuperHero hero)
        {
            if(hero is Bosszuallo)
            {
                if((hero as Bosszuallo).Szuperero < lelemenyesseg)
                {
                    return true;
                }
            }
            return false;
        }

        public void kutyutKeszit()
        {
            lelemenyesseg +=50;
        }
        public override string ToString()
        {
            return $"Batman, IQ:{lelemenyesseg}";
        }
        public override bool megmentiAVilagot()
        {
            throw new NotImplementedException();
        }
     }
}