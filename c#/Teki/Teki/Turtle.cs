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
            if (fedLevel <= 500)
            {
                int c = 0;
                if(fedLevel +  food.Value() < 500)
                {
                    for (int i = fedLevel; i <= 500 && c < food.Value(); i++, c++) ;
                    fedLevel += c * 2;
                }
                else
                {
                    for (int i = fedLevel; i <= fedLevel + food.Value() && c < food.Value(); i++, c++) ;
                    fedLevel -= c * 2;
                }
             
            }

        }
    }
}
