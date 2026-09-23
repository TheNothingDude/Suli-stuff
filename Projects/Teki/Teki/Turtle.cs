using System;

namespace Teki
{
    class Turtle
    {
        protected int happiness = 0;
        protected int fedLevel = 0;

        public int FedLevel => fedLevel;
        public int Happiness => happiness;

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
                    return;
                }
                else
                {
                    int c = 0;
                    for (int i = fedLevel; i <= 500; i++, c++);
                    happiness += c * 2;
                    c = 0;
                    for (int i = 500; i <= fedLevel + food.Value(); i++, c++);
                    happiness -= c * 2;
                    fedLevel += food.Value();
                    return;
                }
            }
            else if (fedLevel > 500)
            { 
                happiness -= food.Value() * 2;
                fedLevel += food.Value();
            }

        }
    }
}
