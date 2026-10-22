using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemes_HertelendyAron_SW
{
    abstract class Jedi : IEroErzekeny
    {
        double ero;
        bool atallhatE;

        public Jedi(double ero, bool atallhat) 
        {
            if (ero < 0)
            {
                throw new ArgumentException("Az erő értéke csakis pozitív lehet");
            }
            this.ero = ero;
            this.atallhatE = atallhat;
        }

        public double Ero 
        {   
            get { return this.ero; }  
            set
            {
                if (value < 0) 
                    { throw new Exception("hibás érték"); } 
                this.ero = value; 
            } 
        }
        public bool AtallhatE { get { return atallhatE; } set { atallhatE = value; } }
        public abstract bool MegteremtiAzEgyensulyt();
        public double MekkoraAzEreje()
        {
            return ero;
        }

        public bool LegyoziE(IEroErzekeny i)
        {
            if (i is Uralkodo)
            {
                if(MekkoraAzEreje() > i.MekkoraAzEreje() * 2)
                {
                    return true;
                }
                return false;
            }
            else if (i is Jedi)
            {
                if ((i as Jedi).atallhatE && this.ero > i.MekkoraAzEreje())
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString() 
        {
            return $"ero: {this.ero} atlahat-e: {this.atallhatE}";
        }
    }
}
