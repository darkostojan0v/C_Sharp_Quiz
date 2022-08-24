using Microsoft.Azure.Cosmos.Core.Collections;
using System;

namespace Recursion
{
    public class Program
    {
        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int item)
            {
                data = item;
                left = right = null;
            }
        }

        public class BinaryTree
        {
            Node root;

            int maxDepth(Node node)
            {
                if (node == null)
                    return -1;
                else
                {
                    int lDepth = maxDepth(node.left);
                    int rDepth = maxDepth(node.right);

                    if (lDepth > rDepth)
                        return (lDepth + 1);
                    else
                        return (rDepth + 1);
                }
            }

            public static void Main(String[] args)
            {
                BinaryTree tree = new BinaryTree();

                tree.root = new Node(1);
                tree.root.left = new Node(2);
                tree.root.right = new Node(3);
                tree.root.left.left = new Node(4);
                tree.root.left.right = new Node(5);
                tree.root.left.left.left = new Node(6);

                Console.WriteLine("Height of tree is : " + tree.maxDepth(tree.root));
            }
        }

    }
}
