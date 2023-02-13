using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    class Node<T> where T : IComparable
    {
        private T data;
        private int total;
        private int balanceFactor;
        public Node<T> Left, Right;

        // Constructor
        public Node(T item)
        {
            this.data = item;
            total++;
            Left = null;
            Right = null;
        }

        // Properties
        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public int BalanceFactor
        {
            get { return this.balanceFactor; }
            set { this.balanceFactor = value; }
        }
        public int Total
        {
            get { return this.total; }
            set { this.total = value; }
        }
    }
}
