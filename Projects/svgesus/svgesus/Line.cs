using System;
using System.IO;

namespace svgesus;

class Line : Shape
{
    private int x2;
    private int y2;
    public Line(int x1, int y1, int y2, int x2, string stroke) : base(x1, y1, stroke)
    {
        this.y2 = y2;
        this.x2 = x2;
    }

    public override void Write()
    {
        FileStream fs = new FileStream("svg.html", FileMode.Open);
        StreamWriter sw = new StreamWriter(fs);
        StreamReader sr = new StreamReader(fs);
        
        bool inserted = false;
        string line;

        while ((line = sr.ReadLine()) != null)
        {
            if (!inserted && line.Trim().StartsWith("</svg>"))
            {
                sw.WriteLine($"<line> x1=\"{x1}\" y1=\"{y1}\" x2=\"{x2}\" y2=\"{y2}\" stroke=\"{stroke}\" </line>");
                inserted = true;
            }
        }
        sw.Close();
        sr.Close();
        fs.Close();
        
    }
}