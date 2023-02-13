using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    class BinaryTree<T> where T : IComparable
    {
        protected Node<T> root;

        // Constructor
        public BinaryTree()
        {
            root = null;
        }
        public BinaryTree(Node<T> node)
        {
            root = node;
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
                // Traverse Left subtree first, then the right
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
                // Get value of node then traverse down the tree
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
                // Traverse the tree then get the value from the node coming back up
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ", ";
            }
        }

        public int TreeHeight()
        {
            return treeHeight(root);
        }
        protected int treeHeight(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            } else
            {
                // Grab the furthest node form the root, by finding the max value of each side (through Math.Max)
                return 1 + Math.Max(treeHeight(tree.Left), treeHeight(tree.Right));
            }
        }

        public int CountNodes()
        {
            return countNodes(root);
        }
        private int countNodes(Node<T> tree)
        {
            if (tree == null)
            {
                return 0; 
            } else
            {
                // Return 1 for every node that is not null
                return 1 + countNodes(tree.Left) + countNodes(tree.Right);
            }
        }

        public int CountNodeItems()
        {
            return countNodeItems(root);
        }
        private int countNodeItems(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                // Return total items for every node that is not null
                return tree.Total + countNodeItems(tree.Left) + countNodeItems(tree.Right);
            }
        }

        public bool TreeContains(T item)
        {
            // return true, if node.data is equal to item
            if (findNode(root, item) != null) { return true; }
            return false;
        }
        public Node<T> FindNode(T item)
        {
            // Return the node equal to item
            return findNode(root, item);
        }
        protected Node<T> findNode(Node<T> tree, T item)
        {
            if (tree != null)
            {
                if (item.CompareTo(tree.Data) == 0)
                {
                    // Node is equal to item
                    return tree;
                }
                if (findNode(tree.Left, item) != null)
                {
                    // return true if node further in the tree was equal to item
                    return tree.Left;
                } else if (findNode(tree.Right, item) != null)
                {
                    return tree.Right;
                }
            }
            return null;
        }

        public void LeastItem()
        {
            leastItem(root);
        }
        protected Node<T> leastItem(Node<T> tree)
        {
            // Grab the smallest item in the tree
            if (tree.Left == null)
            {
                return tree;
            } else
            {
                return leastItem(tree.Left);
            }
        }

        public bool CheckBalanceFactor()
        {
            // Check tree is balaned
            return checkBalanceFactor(root);
        }
        private bool checkBalanceFactor(Node<T> tree)
        {
            if (tree != null)
            {
                // return false if not balanced
                if (!checkBalanceFactor(tree.Left) || !checkBalanceFactor(tree.Right))
                {
                    return false;
                }
                // Get balance factor
                if (tree.BalanceFactor > 1 || tree.BalanceFactor < -1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}
