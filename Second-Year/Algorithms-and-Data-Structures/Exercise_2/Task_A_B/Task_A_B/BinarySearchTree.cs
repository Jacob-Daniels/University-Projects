using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A_B
{
    class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
    {
        // Constructor
        public BinarySearchTree()
        {
            root = null;
        }

        public bool InsertItem(T item)
        {
            // Check if item can be added
            if (!treeContains(root, item))
            {
                insertItem(item, ref root);
                return true;
            } else
            {
                return false;
            }
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
    }
}
