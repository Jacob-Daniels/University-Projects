using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    internal class Link<T>
    {
        private T data;
        private Link<T> next;

        // Constructors
        public Link(T item)
        {
            this.data = item;
        }

        public Link(T item, Link<T> list)
        {
            // Assign item and list to the members
            this.data = item;
            this.next = list;
        }

        // Properties
        public Link<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

    }
}
