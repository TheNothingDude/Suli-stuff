using System;

namespace interfacesssss
{
    
    class Vasember : Bosszuallo, IMilliardos
    {
        Random rnd = new Random();        
        public Vasember() : base(150, true)
        {
        }
        public void kutyutKeszit()
        {
            Szuperero += rnd.NextDouble()*10;
        }
        public override bool megmentiAVilagot()
        {
            if(Szuperero > 1000)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Vasember: szuperero: {Szuperero}, Gyengesege: {VanEGyengesege}";
        }
    }

}