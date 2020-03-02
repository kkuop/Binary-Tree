using BinaryTreeSearch.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class CustomBinaryTree
    {
        //member vars
        Node node;
        private Node root;
        //constructor
        public CustomBinaryTree()
        {
            root = null;
        }
        //member methods

        public Node Find(string key)
        {
            Node temporaryNode = root;
            while (temporaryNode != null)
            {
                if (Comparer<string>.Default.Compare(key, temporaryNode.key) == 0)
                {
                    return temporaryNode;
                }
                if (Comparer<string>.Default.Compare(key, temporaryNode.key) < 0)
                {
                    temporaryNode = temporaryNode.left;
                }
                else
                {
                    temporaryNode = temporaryNode.right;
                }
            }
            return null;
        }
        public void Add(Node node, Node temporaryNode)
        {
            if (temporaryNode == null)
            {
                temporaryNode = node;
            }
            else
            {
                if(Comparer<string>.Default.Compare(node.key, temporaryNode.key) == 0)
                {
                    throw new System.ArgumentException("Duplicate node exists","node");
                }
                if(Comparer<string>.Default.Compare(node.key, temporaryNode.key) < 0)
                {
                    Add(node, temporaryNode.left);
                }
                else
                {
                    Add(node, temporaryNode.right);
                }
            }
        }
    }
}
