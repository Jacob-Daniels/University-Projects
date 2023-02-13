using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Queue
    {
        // Queue variables
        private const int maxSize = 10;
        public string[] namesQueue = new string[maxSize];
        private int head = 0;
        private int tail = 0;
        private int totalNames;

        // properties - used to encapsulate variables
        public int Head
        {
            get { return head; }
        }
        public int Tail
        {
            get { return tail; }
        }
        public int TotalNames
        {
            get { return totalNames; }
        }

        // Methods
        public void Enqueue(string name)
        {
            // Add name to the tail index of the array
            totalNames++;
            namesQueue[tail] = name;
            // Cycle to start is array limit is reached
            if (++tail == namesQueue.Length)
            {
                tail = 0;
            }
        }

        public string Dequeue()
        {
            // Remove name at the head position of the array
            string name = namesQueue[head];
            totalNames--;
            namesQueue[head] = null;
            // Cycle to start is array limit is reached
            if (++head == namesQueue.Length)
            {
                head = 0;
            }
            return name;
        }

        public bool IsFull()
        {
            // Check if the queue/array is full
            foreach (string name in namesQueue)
            {
                if (name == null)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsEmpty()
        {
            // Check if the queue/array is empty
            foreach (string name in namesQueue)
            {
                if (name != null)
                {
                    return false;
                }
            }
            return true;
        }

        public void ReverseOrder(int value)
        {
            // Reverse array variables
            int count = value / 2;
            int start = head;
            int end = head + value - 1;


            while (count > 0)
            {
                // Circle to end / start of array
                if (end == -1)
                {
                    end = namesQueue.Length - 1;
                }
                else if (end > 9)
                {
                    end -= namesQueue.Length;
                }
                if (start > namesQueue.Length - 1)
                {
                    start = 0;
                }

                // Swap 2 elements in array
                string thisTemp = namesQueue[start];
                namesQueue[start] = namesQueue[end];
                namesQueue[end] = thisTemp;

                // Counters
                start++;
                end--;
                count--;
            }
        }
    }
}