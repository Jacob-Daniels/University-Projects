using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    class AVLTree<T> : BinarySearchTree<T> where T : IComparable
    {
        public new bool RemoveItem(T item)
        {
            if (TreeContains(item))
            {
                // Remove stack or node from the tree
                Node<T> temp = findNode(root, item);
                if (temp.Total == 1)
                {
                    removeItem(item, ref root);
                }
                else if (temp.Total > 1)
                {
                    temp.Total--;
                }
                return true;
            }
            return false;
        }
        public new void InsertItem(T item)
        {
            // Check whether to insert item or add to existing node
            Node<T> temp = findNode(root, item);
            if (temp == null)
            {
                insertItem(item, ref root);
                UpdateBalanceFactor();
            }
            else
            {
                temp.Total++;
            }
        }
        private void insertItem(T item, ref Node<T> tree)
        {
            // Insert item in order (left = smaller and right = larger
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

            // Check the balanceFacter to ensure the tree is balanced/level
            tree.BalanceFactor = treeHeight(tree.Left) - treeHeight(tree.Right);
            if (tree.BalanceFactor <= -2)
            {
                RotateLeft(ref tree);
            }
            if (tree.BalanceFactor >= 2)
            {
                RotateRight(ref tree);
            }
        }

        public void UpdateBalanceFactor()
        {
            updateBalanceFactor(ref root);
        }
        private void updateBalanceFactor(ref Node<T> tree)
        {
            // Rebalance and update the tree after inserting an item
            if (tree != null)
            {
                // Check the balanceFacter to ensure the tree is balanced/level
                tree.BalanceFactor = treeHeight(tree.Left) - treeHeight(tree.Right);
                if (tree.BalanceFactor <= -2)
                {
                    RotateLeft(ref tree);
                }
                if (tree.BalanceFactor >= 2)
                {
                    RotateRight(ref tree);
                }
                updateBalanceFactor(ref tree.Right);
                updateBalanceFactor(ref tree.Left);
            }
        }

        private void RotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
            {
                // Double rotate
                RotateRight(ref tree.Right);
            }
            // Balance tree
            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Right;
            // Move the 'newRoot's - left sub-tree into the 'oldRoot's right subtree
            oldRoot.Right = newRoot.Left;
            // Move the 'oldRoot' into the 'newRoot's left sub-tree
            newRoot.Left = oldRoot;
            // Replace the old tree with the new tree
            tree = newRoot;
        }

        private void RotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)
            {
                // Double rotate
                RotateLeft(ref tree.Left);
            }
            // Balance tree
            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Left;
            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;
            tree = newRoot;
        }
    }
}
