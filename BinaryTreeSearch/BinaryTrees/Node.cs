using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch.BinaryTree
{
    class Node
    {
        //member vars
        public string key;
        public int data;
        public Node left;
        public Node right;
        public bool isLeaf;
        //constructor
        public Node(string key, int data, Node left, Node right, bool isLeaf)
        {
            this.key = key;
            this.data = data;
            this.left = left;
            this.right = right;
            this.isLeaf = isLeaf;
        }
        //member methods
        
    }
}
