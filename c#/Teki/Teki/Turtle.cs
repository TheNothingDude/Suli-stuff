using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Teki
{
    class Turtle
    {
        protected int happiness = 0;
        protected int fedLevel = 0;

        public void Eat(Food food)
        {
            if (fedLevel + food.Value() > 1000)
            {
                fedLevel = 1000;
                Console.WriteLine("teli van szegeny");
                return;
            }
            if (fedLevel < 500)
            {
                if(fedLevel + food.Value() <= 500)
                {
                    happiness += food.Value() * 2;
                    fedLevel += food.Value();
                }
                else
                {
                    happiness += (Math.Abs(fedLevel - 500)) * 2;
                    fedLevel += food.Value();
                }
            }
            else if (fedLevel > 500)
            { 

            }

        }
    }
}
