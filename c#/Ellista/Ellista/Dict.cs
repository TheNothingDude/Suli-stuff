using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellista
{
    internal class Dict
    {
        string name;
        int val;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Val
        {
            get { return val; }
            set { val = value; }
        }
        public Dict(string name, int val) 
        {
            this.name = name;
            this.val = val;
        }
    }
}
