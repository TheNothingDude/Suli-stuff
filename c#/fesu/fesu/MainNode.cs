using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fesu
{
    class MainNode
    {
        MainNode next;
        Node down;
        string data;
        int nodeCount;
        
        public MainNode(string data)
        {
            down = null;
            next = null;
            this.data = data;
            nodeCount = 0;
        }
        public MainNode()
        {
            down = null;
            next = null;
            data = null;
            nodeCount = 0;
        }
        public MainNode Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node Down
        {
            get { return down; }
            set { down = value; }
        }
        public string Data
        {
            get { return data;}
            set { data = value;} 
        }
        public int NodeCount
        {
            get { return nodeCount; }
            set{ nodeCount = value; }
        }

    }
}
