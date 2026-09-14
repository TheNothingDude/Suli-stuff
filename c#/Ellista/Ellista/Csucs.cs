using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellista
{
    class Csucs
    {
        string name;
        Dict[] neighbours = new Dict[0];

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Dict[] Neigbors
        {
            get { return neighbours; }
            set { neighbours = value; }
        }

        public Csucs(string name, string[] neighbours)
        {
            this.name = name;
            for (int i = 0; i <= neighbours.Length - 2; i+=2)
            {  
                Add(new Dict(neighbours[i], int.Parse(neighbours[i+1])));
            }
            
        }

        public void Add(Dict a)
        {
            Dict[] tmp = new Dict[neighbours.Length + 1];
            for (int i = 0; i < neighbours.Length; i++)
            {
                tmp[i] = neighbours[i];
            }
            tmp[neighbours.Length] = a;
            neighbours = tmp;
        }
    }
}
