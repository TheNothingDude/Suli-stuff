using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinaryTree
{
    class BinaryTree<T> where T : IComparable<T>
    {
        Node<T> root;
        public BinaryTree()
        {
            root = null;
        }
        private void InsertRecursive(Node<T> current, Node<T> newNode)
        {
            if (newNode.Data.GetType() != typeof(T))
            {
                throw new ArgumentException("data types are not the same");
            }
            if (newNode.Data.CompareTo(current.Data) < 0)
            {
                //left
                if (current.Left == null)
                {
                    current.Left = newNode;
                }
                else
                    InsertRecursive(current.Left, newNode);
            }
            else
            {
                //right
                if (current.Right == null)
                {
                    current.Right = newNode;
                }
                else
                    InsertRecursive(current.Right, newNode);

            }
        }
        public void Insert(T newElement)
        {
            if (newElement.GetType() != typeof(T))
            {
                throw new ArgumentException("data types are not the same");
            }
            Node<T> newNode = new Node<T>(newElement);
            if (root == null)
            {
                root = newNode;
                return;
            }
            InsertRecursive(root, newNode);
        }
        private T MinFind(Node<T> current)
        {
            if (current.Left == null)
            {
                return current.Data;
            }
            else
            {
                return MinFind(current.Left);
            }
        }
        public T MinValue()
        {
            return MinFind(root);
        }
        private void InOrder(Node<T> Node)
        {
            if (Node == null)
            {
                return;
            }
            InOrder(Node.Left);
            Console.Write($"{Node.Data}, ");
            InOrder(Node.Right);
        }
        public void InOrder()
        {
            InOrder(root);
        }
        private bool Contains(Node<T> Node, T val)
        {
            if (val.GetType() != typeof(T))
            {
                throw new ArgumentException("data types are not the same");
            }
            if (Node == null)
            {
                return false;
            }

            if (Node.Data.CompareTo(val) == 0)
                return true;

            if (val.CompareTo(Node.Data) < 0)
            {
                return Contains(Node.Left, val);
            }
            else
            {
                return Contains(Node.Right, val);
            }
        }
        public bool Contains(T val)
        {
            return Contains(root, val);
        }
        private Node<T> Remove(Node<T> Node, T val)
        {
            if (val.GetType() != typeof(T))
            {
                throw new ArgumentException("data types are not the same");
            }
            if (Node == null)
            {
                return Node;
            }
            if (val.CompareTo(Node.Data) < 0)
            {
                Node.Left = Remove(Node.Left, val);
            }
            else if (val.CompareTo(Node.Data) > 0)
            {
                Node.Right = Remove(Node.Right, val);
            }
            else
            {
                //0 v 1
                if (Node.Left == null)
                {
                    return Node.Right;
                }
                else if (Node.Right == null)
                {
                    return Node.Left;
                }
                //2
                Node.Data = MinFind(Node.Right);
                Node.Right = Remove(Node.Right, Node.Data);
            }
            return Node;
        }
        public void Remove(T val)
        {
            Remove(root, val);
        }
    }
}
