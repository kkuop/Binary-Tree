using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomBinaryTree customBinaryTree = new CustomBinaryTree();
            customBinaryTree.Insert("tom", 25);
            customBinaryTree.Insert("verna", 67);
            customBinaryTree.Insert("katie", 51);
            customBinaryTree.Insert("mike", 53);
            customBinaryTree.Find("tom");
            customBinaryTree.Find("katie");
        }
    }
}
