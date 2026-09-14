using System;

namespace Mat
{
    class Tort
    {
        int szamlalo;
        int nevezo;

        public int Szamlalo
        {
            get { return szamlalo; }
            set { szamlalo = value; }
        }
        public int Nevezo
        {
            get { return nevezo; }
            set
            {
                if (value != 0)
                {
                    nevezo = value;
                }
                else
                {
                    nevezo = 1;
                }
            }
        }
        public Tort(int szamlalo, int nevezo = 1)
        {
            Szamlalo = szamlalo;
            Nevezo = nevezo;
            Egyszerusit();
        }

        public static Tort operator+ (Tort a, Tort b)
        {
            int kozos = a.nevezo * b.nevezo;
            int szamalo = a.szamlalo * b.nevezo + b.szamlalo * a.nevezo;
            return new Tort(kozos, szamalo);
        }

        public static Tort operator*(Tort a, Tort b)
        {
            return new Tort(a.szamlalo * b.szamlalo, a.nevezo*b.nevezo);
        }

        public static Tort operator-(Tort a, Tort b)
        {
            return a + b * new Tort(-1) ;
        }

        public static Tort Reciprok(Tort a)
        {
           return new Tort(a.nevezo, a.szamlalo);
        }

        public static Tort operator/(Tort a, Tort b)
        {
            return a * Reciprok(b);
        }

        public static double Tort2Double(Tort t)
        {
            return t.szamlalo / (double)t.nevezo;
        }
        
        public static bool operator==(Tort a, Tort b)
        {
            return Tort2Double(a) == Tort2Double(b);
        }

        public static bool operator !=(Tort a, Tort b)
        {
            return !(a == b);
        }

        public static bool operator <(Tort a, Tort b)
        {
            return Tort2Double(a) < Tort2Double(b);
        }

        public static bool operator >(Tort a, Tort b)
        {
            return Tort2Double(b) > Tort2Double(a);
        }

        public static bool operator >=(Tort a, Tort b)
        {
            return !(a < b);
        }

        public static bool operator <=(Tort a, Tort b)
        {
            return !(a > b);
        }

        private static int LNKO(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);    
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }
        private void Egyszerusit()
        {
            int lnko = LNKO(nevezo,szamlalo);
            this.nevezo = nevezo/lnko;
            this.szamlalo = szamlalo/lnko;
        }

        public string ToString()
        {
            return $"{szamlalo}/{nevezo}";
        }
       
    }
}
