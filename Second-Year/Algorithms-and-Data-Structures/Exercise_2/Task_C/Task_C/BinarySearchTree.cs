using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
    {
        // Constructor
        public BinarySearchTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }
        private void insertItem(T item, ref Node<T> tree)
        {
            // Insert item in order (smallest to the left, largest to the right)
            if (tree == null)
            {
                tree = new Node<T>(item);
            } else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            } else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
        }

        public void RemoveItem(T item)
        {
            // Check the tree contains the item to remove it
            if (TreeContains(item))
            {
                removeItem(item, ref root);
            }
        }
        protected void removeItem(T item, ref Node<T> tree)
        {
            if (tree != null)
            {
                // Check if nodes data is equal to item being removed
                if (item.CompareTo(tree.Data) == 0)
                {
                    if (tree.Left == null && tree.Right == null)
                    {
                        // Tree has no sub-trees
                        tree = null;
                    } else
                    {
                        if (tree.Left == null && tree.Right != null)
                        {
                            // Single, Right sub-tree
                            tree = tree.Right;
                        } else if (tree.Left != null && tree.Right == null)
                        {
                            // Single, Left sub-tree
                            tree = tree.Left;
                        } else if (tree.Left != null && tree.Right != null)
                        {
                            // 2 Sub-trees
                            // Assign the smallest item on the right tree and then remove it (this keeps the tree in order)
                            Node<T> newRoot = leastItem(tree.Right);
                            tree = newRoot;
                            Node<T> removeLeaf = tree.Right;
                            removeItem(newRoot.Data, ref removeLeaf);
                            tree.Right = removeLeaf;
                        }
                    }
                } else
                {
                    // Traverse through tree until item is found
                    removeItem(item, ref tree.Left);
                    removeItem(item, ref tree.Right);
                }
            }
        }
    }
}
