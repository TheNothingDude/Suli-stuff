using System;
using System.Runtime.Remoting.Messaging;


namespace Doga_Linked
{
    class Node
    {
        double data;
        Node next;

        public Node(double data)
        {
            this.data = data;
            next = null;
        }
        public double Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node Next
        {
            get { return next; }
            set {  next = value; }
        }
    }
}
