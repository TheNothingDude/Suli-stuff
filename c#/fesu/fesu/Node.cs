using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace fesu
{
    internal class Node
    {
        Node down;
        string data;

        public Node(string data)
        {
            down = null;
            this.data = data;
        }

        public Node Down
        {
            get { return down; }
            set { down = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
