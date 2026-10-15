using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node<T>
    {
        T data;
        Node<T> left;
        Node<T> right;

        public Node(T data)
        {
            this.data = data;
            left = null;
            right = null;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node<T> Left
        {
            get { return left; }
            set { left = value; }
        }
        public Node<T> Right
        {
            get { return right; }
            set { right = value; }
        }
    }
}
