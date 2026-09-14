using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Car
    {
        string brand;
        string type;
        int year;

        public Car(string brand, string type, int year)
        {
            this.brand = brand;
            this.type = type;
            this.year = year;
        }
        public override bool Equals(object other)
        {
            Car car = (Car) other;
            if(car == null) return false;
            return this.brand == car.brand && this.type == car.type && this.year == car.year;
        }
        public override string ToString()
        {
            return $"Brand: {brand}, type: {type}, year: {year}";
        }
    }
}
