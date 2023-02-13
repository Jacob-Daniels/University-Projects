using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A_B
{
    class BinaryTree<T> where T : IComparable
    {
        protected Node<T> root;

        // Constructors
        public BinaryTree()
        {
            this.root = null;
        }

        public BinaryTree(Node<T> node)
        {
            this.root = node;
        }

        // Methods
        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }
        private void inOrder(Node<T> tree, ref string buffer)
        {
            // Recursion to get the Left & Right nodes for the current root
            if (tree != null)
            {
                // Traverse Left subtree then the right
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ", ";
                inOrder(tree.Right, ref buffer);
            }
        }

        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }
        private void preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                // Get value of node then traverse the tree
                buffer += tree.Data.ToString() + ", ";
                preOrder(tree.Left, ref buffer);
                preOrder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }
        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                // Traverse the tree then get the value of the node
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ", ";
            }
        }

        public int TreeHeight()
        {
            return treeHeight(root);
        }
        private int treeHeight(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            } else
            {
                // Grab the furthest node from the root, from both sides (grabs the max value between the left and right side each recursion)
                return 1 + Math.Max(treeHeight(tree.Left), treeHeight(tree.Right));
            }
        }

        public int CountNodes()
        {
            return countNodes(root);
        }
        private int countNodes(Node<T> tree)
        {
            if (tree != null)
            {
                // Return 1 if node is not null (traverse whole tree with recursion until each is null)
                return 1 + countNodes(tree.Left) + countNodes(tree.Right);
            } else
            {
                return 0;
            }
        }

        public bool TreeContains(T item)
        {
            return treeContains(root, item);
        }
        protected bool treeContains(Node<T> tree, T item)
        {
            if (tree != null)
            {
                if (item.CompareTo(tree.Data) == 0)
                {
                    // Node is equal to item
                    return true;
                }
                if (treeContains(tree.Left, item) || treeContains(tree.Right, item))
                {
                    // node further in tree was equal to item
                    return true;
                }
            }
            return false;
        }
    }
}
