using System;
using System.ComponentModel;

namespace MyApp
{
    class Adat
    {
        protected List<int> data = new List<int>();
        public Adat()
        {
            data = new List<int>();
        }
        public Adat(List<int> data)
        {
            
            foreach (int i in data)
            {
                this.data.Add(i);
            }
        }

        public Adat(int i)
        {
             
            this.data.Add(i);
        }

        public void Add(int i)
        {
            data.Add(i);
        }

        public virtual double Szamol()
        {
            return data.Sum() / (double)data.Count;
        }

    }

    class UjAdat : Adat
    {
        public UjAdat() : base()
        { }
        public UjAdat(List<int> l) : base(l)
        {
        }
        public override double Szamol()
        {
            int product = 1;
            foreach (int i in data)
            {
                product *= i;
            }
            return Math.Pow(product, 1 / (double)data.Count);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>() { 5, 2, 5, 6, 8, 11, 2, 3, 43 };
            Adat a = new Adat(l);
            UjAdat u = new UjAdat(l);
            Console.WriteLine(a.Szamol());
            Console.WriteLine(u.Szamol());
            
        }
    }
}