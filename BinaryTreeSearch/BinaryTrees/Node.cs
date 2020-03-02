using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch.BinaryTree
{
    public class Node
    {
        //member vars
        public string key;
        public int data;
        public Node left;
        public Node right;
        public bool isLeaf;
        //constructor
        public Node(string key, int data, bool isLeaf)
        {
            this.key = key;
            this.data = data;
            this.isLeaf = isLeaf;
        }
        //member methods
        
    }
}
