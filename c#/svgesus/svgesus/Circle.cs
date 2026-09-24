using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svgesus
{
    class Circle : Shape
    {
        int radius;
        string fill;
        public Circle(int x1, int y1,int radius, string stroke, string fill) : base(x1, y1, stroke)
        {
            def = $"<circle cx=\"{x1}\" cy=\"{y1}\" r=\"{radius}\" fill=\"{fill}\" stroke=\"{stroke}\"/>";
        }
    }
}
