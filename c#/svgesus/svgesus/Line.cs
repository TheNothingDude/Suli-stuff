using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace svgesus
{
    class Line : Shape
    {
        int x2;
        int y2;
        
        public Line(int x1, int y1, int x2, int y2, string stroke ) : base(x1, y1, stroke)
        {
            this.x2 = x2;
            this.y2 = y2;
            def = $"\t<line x1=\"{x1}\" y1=\"{y1}\" x2=\"{x2}\" y2=\"{y2}\" stroke=\"{stroke}\"/>";
        }
    }
}
