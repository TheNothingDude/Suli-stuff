using System;
using System.Dynamic;

namespace interfacesssss
{
    abstract class Bosszuallo : ISuperHero
    {
        double szuperero;
        bool vanEGyengesege;

        public double Szuperero
        {
            get {return szuperero;}
            set {szuperero = value;}
        }
        public bool VanEGyengesege
        {
            get {return vanEGyengesege;}
            set {vanEGyengesege = value;}
        }
        public Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }
        public abstract bool megmentiAVilagot(); 
        public double mekkoraAzEreje()
        {
            return szuperero;
        } 
        public bool legyoziE(ISuperHero hero)
        {
            if(hero is Bosszuallo)
            {
                if((hero as Bosszuallo).vanEGyengesege && this.szuperero > (hero as Bosszuallo).szuperero)
                {
                    return true;
                }
                return false;
            } 
            return false;
        }
    }
}