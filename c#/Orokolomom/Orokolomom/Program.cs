using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokolomom
{
    class A
    {
        public int a;
        public A() : this(0) { }
        public A(int x) { a = x; }

        protected virtual void Write()
        {
            Console.WriteLine(a);
        }
        public void Show() { Write(); }
    }
    class B : A {
        protected new int a;
        public B() : this(0,0) { }
        public B(int x, int y) :base(x){a = y;}
        protected override void Write()
        {
            Console.WriteLine(base.a);
            Console.WriteLine(a); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A(12);
            B b = new B(5,9);

            b.Show();
            if(b is A)
            {
                (b as A).Show();
            }
            ((A)b).Show();

            //polimorfizmus

            //kesei kotes - late binding
        }
    }
}
