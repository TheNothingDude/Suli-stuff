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
    class BinaryTree
    {
        Node root;
        public BinaryTree()
        {
            root = null;
        }
        private void InsertRecursive(Node current, Node newNode)
        {
            if(newNode.Data <= current.Data)
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
        public void Insert(int newElement)
        {
            Node newNode = new Node(newElement);
            if(root == null) 
            {
                root = newNode;
                return;
            }
            InsertRecursive(root, newNode);
        }
        private int MinFind(Node current)
        {
            if(current.Left == null)
            {
                return current.Data;
            }
            else
            {
                return MinFind(current.Left);
            }
        }
        public int MinValue()
        {
            return MinFind(root);
        }
        private void InOrder(Node node)
        {
            if(node == null)
            {
                return;
            }
            InOrder(node.Left);
            Console.Write($"{node.Data}, ");
            InOrder(node.Right);
        }
        public void InOrder()
        {
            InOrder(root);
        }
        private bool Contains(Node node,int val)
        {
            if(node == null)
            {
                return false;
            }

            if(node.Data == val)
                return true;

            if(val < node.Data)
            {
                return Contains(node.Left, val);
            }
            else
            {
                return Contains(node.Right, val);
            }
        }
        public bool Contains(int val)
        {
            return Contains(root, val);
        }
        private Node Remove(Node node,int val)
        {
            if(node == null)
            {
                return node;
            }
            if (val < node.Data)
            {
                node.Left = Remove(node.Left, val);
            }
            else if(val > node.Data)
            {
                node.Right = Remove(node.Right , val);
            }
            else 
            {
                //0 v 1
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }
                //2
                node.Data = MinFind(node.Right);
                node.Right = Remove(node.Right, node.Data);
            }
            return node;
        }
        public void Remove(int val)
        {
            Remove(root, val);
        }
    }
}
