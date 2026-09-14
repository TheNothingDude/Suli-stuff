using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orok_Tegla
{
    class Teglalap
    {
        protected float a;
        protected float b;

        public Teglalap() : this(0,0){}
        public Teglalap(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        protected virtual float Szamol1() {
            return a * b;
        }
        protected virtual float Szamol2()
        {
            return 2 * (a + b);
        }
        protected virtual void Write()
        {
            Console.WriteLine($"Ter :{Szamol1()}, Ker :{Szamol2()}");
        }
        public void Show()
        {
            Write();
        }
    }
    class Teglatest : Teglalap
    {
        protected new float a;
        protected new float b;
        protected float c;

        public Teglatest() : this(0, 0, 0) { }

        public Teglatest(float a, float b, float c)
        {
            this.a = a; 
            this.b=b;
            this.c = c;
            
        }
        protected override float Szamol1()
        {
            return a * b * c;
        }
        protected override float Szamol2()
        {
            return 2 * (a * b + b * c + c * a);
        }
        protected override void Write() 
        {
            Console.WriteLine($"Ter :{Szamol1()}, Fel :{Szamol2()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Teglalap teglalap = new Teglalap(5, 6);

            Teglatest teglatest = new Teglatest(2,7,3);
            
            teglalap.Show();
            teglatest.Show();
        }
    }
}
