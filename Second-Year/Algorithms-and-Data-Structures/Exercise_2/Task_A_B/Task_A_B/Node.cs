using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A_B
{
    class Node<T> where T : IComparable
    {
        private T data;
        public Node<T> Left, Right;

        //Constructor
        public Node(T item)
        {
            this.data = item;
            Left = null;
            Right = null;
        }

        // Properties
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
