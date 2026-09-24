using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace svgesus
{
    abstract class Shape
    {
        protected int x1;
        protected int y1;
        protected string stroke;
        protected string def;

        public Shape(int x1, int y1, string stroke)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.stroke = stroke;
        }
        public void GenFile()
        {
            FileStream fs = new FileStream("svg.svg", FileMode.Create);
            StreamWriter rs = new StreamWriter(fs);
            rs.WriteLine("<svg width=\"200\" height=\"200\" xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\" >");
            rs.WriteLine("</svg>");
            rs.Close();
            fs.Close();
        }
        public void Write()
        {

            FileStream fs = new FileStream("svg.svg", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<string> strings = new List<string>();
            string line = string.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                strings.Add(line);
            }
            fs.Close();
            sr.Close();
            FileStream newFs = new FileStream("svg.svg", FileMode.Create);
            StreamWriter newSr = new StreamWriter(newFs);
            strings.Insert(1, def);
            foreach (string s in strings)
            {
                newSr.WriteLine(s);
            }
            newSr.Close();
            newFs.Close();
        }
    }
}
