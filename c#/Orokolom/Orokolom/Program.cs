using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokolom
{
    class A
    {
        protected int a;

        public A() : this(0) { }
        public A(int x) 
        {
            this.a = x;
        }
        protected void Write()
        {
            Console.WriteLine(a);
        }
        public void Show () {Write();}
    }
    class B : A
    {
        protected new int a;
        public B() : this(0,0) { }
        public B(int x, int y) : base(x) {a = y;}

        protected new void Write () {
            base.Write();
            Console.WriteLine(a);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A alfa = new A(12);
            alfa.Show();

            B beta = new B(5, 9);
            beta.Show();
            if (beta is B)
            {
                (beta as B).Show();
            }
            if (beta is A)
            {
                (beta as A).Show();
            }
            ((A)beta).Show();

            //Early binding 

        }
    }
}
