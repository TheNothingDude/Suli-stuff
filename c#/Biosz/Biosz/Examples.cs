using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biosz
{
    class Eagle : Bird
    {
        public Eagle(int age) : base(age, "Eagle") { }
    }
    class Dog : Mammal
    {
        public Dog(int age) : base(age, "Dog"){}
    }
    class Lion : Mammal
    {
        public Lion(int age) : base(age, "Lion"){}
    }
}
