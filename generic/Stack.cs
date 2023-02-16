using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using genericNode;
using System.Xml.Linq;
using System.Collections.Concurrent;

namespace generic
{
    class Stack<T> : IEnumerable<T>
    { 
        public NodeClass<T> top;
        public int size;

        //Constructor of a class
        public Stack()
        {
            top = null;
            size = 0;
        }

        //To Check if the Stack is empty
        public bool IsEmpty()
        {
            return size == 0;
        }

        //To Add an element to the Stack
        public void Push(T item)
        {
            
            NodeClass<T> newest = new NodeClass<T>(item, null);
            if (IsEmpty())
            {
                top = newest;
            }
            else
            {
                newest.Next_Element = top;
                top = newest;
            }
            size++;
        }
        
        //To Remove an element from the Stack
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
                return default(T);
            }
            T value = top.Data;
            top = top.Next_Element;
            size--;
            return value;
        }
      
        // To print the top element of the Stack
       public T peek()
       {
           if (IsEmpty())
           {
             Console.WriteLine("stack is empty");
             return default(T);
           }
                return top.Data;
       }

        /*The code you provided is implementing an iterator for a linked list data structure.The GetEnumerator
        method returns an instance of IEnumerator<T>, which allows iterating through the elements of the linked
       list in a foreach loop or by calling the MoveNext and Current methods. */
        
        public IEnumerator<T> GetEnumerator() 
        {
            NodeClass<T> current = top;
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
