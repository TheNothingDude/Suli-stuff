using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    //abstract shitt
    abstract class Sikidom
    {
        public Sikidom() { }

        public abstract double Terulet();
        public abstract double Kerulet();
        public abstract string Name();
    }
    class Kor : Sikidom
    {
        const double PI = Math.PI;
        double r;
        public Kor(double r)
        {
            this.r = Math.Abs(r);
        }
        public override double Terulet()
        {
            return r * r * PI;
        }
        public override double Kerulet()
        {
            return 2 * r * PI;
        }
        public override string Name()
        {
            return "Kor";
        }
    }
    class Teglalap : Sikidom
    {
        double a, b;
        public Teglalap(double a, double b)
        {
            this.a = Math.Abs(a);
            this.b = Math.Abs(b);
        }
        public override double Kerulet()
        {
            return 2 * (a + b);
        }
        public override double Terulet()
        {
            return a * b;
        }
        public override string Name()
        {
            return "Teglalap";
        }
    }
    class Haromszog : Sikidom
    {
        double a;
        double b;
        double c;
        public Haromszog(double a, double b, double c) {

                if (a+b > c && a+c > b && c+b > a)
                {
                    this.a = a;
                    this.b = b;
                    this.c = c;
                }
        }
        public override double Kerulet()
        {
            return a + b + c;
        }
        public override double Terulet()
        {
            double s = Kerulet() / 2;
            return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        }
        public override string Name()
        {
            return "haromszog";
        }
        public string Valami()
        {
            return "smth";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Teglalap t1 = new Teglalap(4, 1);
            Haromszog h1 = new Haromszog(3, 4, 5);
            Console.WriteLine(h1.Terulet());


            Sikidom kor = new Kor(5.3);
            Console.WriteLine(kor.Terulet());

            Sikidom[] geometria = new Sikidom[3];
            geometria[0] = new Kor(3.1);
            geometria[1] = new Teglalap(2, 9);
            geometria[2] = new Haromszog(3, 5, 7);

            object[] objects = new object[4];
            objects[0] = 1;
            objects[1] = 'c';
            objects[2] = new Haromszog(2, 3, 4);
            objects[3] = new Random();

            for (int i = 0; i < geometria.Length; i++)
            {
                Console.WriteLine($"{geometria[i].Name()} terulete {geometria[i].Terulet()}");
            }

            if (geometria[2] is Haromszog)
            {
                Console.WriteLine((geometria[2] as Haromszog).Valami());
            }
         
        }
    }
}
