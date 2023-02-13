using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    internal class LinkedList<T> where T : IComparable<T>
    {
        private Link<T> list;

        public void Add(T item)
        {
            // Add item to the list
            list = new Link<T>(item, list);
        }

        public void AppendItem(T item)
        {
            // Add item to the end of the list
            Link<T> temp = list;
            if (temp == null)
            {
                list = new Link<T>(item);
            }
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new Link<T>(item);
            }
        }

        public void Remove(T item)
        {
            // Remove item from the list
            Link<T> temp = list;
            LinkedList<T> newList = new LinkedList<T>();
            while (temp != null)
            {
                // Add the item to the temp list if not equal to item being removed
                if (item.CompareTo(temp.Data) != 0)
                {
                    newList.AppendItem(temp.Data);
                }
                temp = temp.Next;
            }
            list = newList.list;
        }

        public string DisplayList()
        {
            // Create temporary list to iterate through
            Link<T> temp = list;
            string items = "";
            while (temp != null)
            {
                items += temp.Data.ToString() + "\n";
                temp = temp.Next;
            }
            // returns all items in string format
            return items;
        }

        public int NumberOfItems()
        {
            // Count the number of items in list
            Link<T> temp = list;
            int totalItems = 0;
            while (temp != null)
            {
                totalItems++;
                temp = temp.Next;
            }
            return totalItems;
        }

        public bool IsItemPresent(T item)
        {
            // Check item exists within the list
            Link<T> temp = list;
            while (temp != null)
            {
                if (item.CompareTo(temp.Data) == 0)
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public void InsertInOrder(T item)
        {
            // insert item in order
            Link<T> temp = list;
            LinkedList<T> newList = new LinkedList<T>();
            bool isInserted = false;

            if (temp == null)
            {
                newList.Add(item);
            } else
            {
                // Loop temp list to find where to insert item
                while (temp != null)
                {
                    if (temp.Data.CompareTo(item) == -1)
                    {
                        // Appending link, then item (if at the end of the list)
                        newList.AppendItem(temp.Data);
                        if (temp.Next == null && !isInserted)
                        {
                            newList.AppendItem(item);
                            isInserted = true;
                        }
                    }
                    else if (temp.Data.CompareTo(item) == 1)
                    {
                        // Appending item, then current link (if not already inserted)
                        if (!isInserted)
                        {
                            newList.AppendItem(item);
                            isInserted = true;
                        }
                        newList.AppendItem(temp.Data);
                    }
                    temp = temp.Next;
                }
            }
            list = newList.list;
        }

        public void SortList()
        {
            Link<T> temp = list;
            list = null;
            // loop temp list to insert in order
            while (temp != null)
            {
                InsertInOrder(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
