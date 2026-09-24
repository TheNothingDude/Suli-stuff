using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svgesus
{
    internal class Rectangle : Shape
    {
       public Rectangle(int x1, int y1, int rx , int ry, int width, int height, string stroke, string fill) : base(x1, y1, stroke)
       {
            def = $"<rect x=\"{x1}\" y=\"{y1}\" width=\"{width}\" height=\"{height}\" rx=\"{rx}\" ry=\"{ry}\" fill=\"{fill}\" stroke=\"{stroke}\"/>\"";
       }
    }
}
