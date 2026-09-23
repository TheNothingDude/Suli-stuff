using System;
using System.IO;
namespace svgesus
{
    abstract class Shape
    {
        protected int x1;
        protected int y1;
        protected string stroke;
        string filePath = "svg.svg";
        string tempFilePath = "vector_temp.svg";

        protected Shape(int x1, int y1, string stroke)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.stroke = stroke;
        }

        public abstract void Write();
        
        
    }
}
  