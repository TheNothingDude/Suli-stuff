using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinked
{
    internal class Node<T>
    {
        T data;
        Node<T> prev;
        Node<T> next;
        public T Data { get { return data; } set { data = value; } }
        public Node<T> Prev { get { return prev; } set { prev = value; } }
        public Node<T> Next { get { return next;} set { next = value; } }
        public Node(T data)
        {
            this.data = data;
            prev = null;
            next = null;
        }
    }
}
