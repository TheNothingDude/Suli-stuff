using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree =new BinaryTree();
            tree.Insert(6);
            tree.Insert(7);
            tree.Insert(13);
            tree.Insert(99);
            tree.Insert(21);
            tree.Insert(0);
            tree.Insert(82);
            tree.Insert(12028);
            tree.Insert(66);
            tree.Insert(69);
            tree.Insert(8);
            tree.Insert(2);
            tree.Insert(-9);
            tree.Insert(71);
            tree.Insert(42);
            //Console.WriteLine(tree.MinValue());
            //Console.WriteLine();
            tree.InOrder();
            //Console.WriteLine(tree.Contains(1));
            //Console.WriteLine(tree.Contains(11));
            tree.Remove(13);
            Console.WriteLine();
            tree.InOrder();
        }
    }
}
