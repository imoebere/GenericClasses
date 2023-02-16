using genericNode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    internal class LinkedList<T> : IEnumerable<T>
    {
        public NodeClass<T> head;
        public NodeClass<T> tail;
        public int size;
        
        // Constructor of the class
        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        // To Check if an element is empty
        public bool IsEmpty()
        {
            return size == 0;
        }

        // To Add element to the list
        public void Add(T item) 
        {
            NodeClass<T> newest = new NodeClass<T>(item, null);
            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                tail.Next_Element = newest;
                tail = newest;
            }
            size++;
        }

        //To remove element from the list
        public bool Remove()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return false;
            }
            else
            {
                T value = head.Data;
                head = head.Next_Element;
                size--;
                return true;
            }
        }

        //To Check if an element exist in the list
        public bool Check(T index)
        {
            NodeClass<T> q = head;
            while (q != null)
            {
                if (q.Data.Equals(index))
                {
                    return true;
                }
                q = q.Next_Element;
            }
            return false;
        }

        //To Check the Index of a particular element
        public int Index(T index)
        {
            NodeClass<T> q = head;
            int value = 0;
            while (q != null)
            {
                if (q.Data.Equals(index))
                {
                    return value;
                }
                else 
                { 
                    q = q.Next_Element;
                }
                value++;
            }
             return -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            NodeClass<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next_Element;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
