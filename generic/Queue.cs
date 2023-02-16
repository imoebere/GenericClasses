using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using genericNode;

namespace generic
{
    internal class Queue<T> : IEnumerable<T>
    {
        private NodeClass<T> front;
        private NodeClass<T> rear;
        private int size;
        // Constructor of a class
        public Queue()
        {
            front = null;
            rear = null;
            size = 0;
        }
        // To check if the queue is empty
        public bool isEmpty()
        {
            return size == 0;
        }

        // To Add element into the queue
        public void Enqueue(T item)
        {
            NodeClass<T> newest = new NodeClass<T>(item, null);
            if (isEmpty())
            {
                front = newest;
                rear = newest;
            }
            else
            {
                rear.Next_Element = newest;
                rear = newest;
            }
                size++;
        }

        //To Remove an element from the queue
        public T Dequeue()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T value = front.Data;
            front = front.Next_Element;
             size--;
             if (isEmpty())
                
             rear = null;
             return value;
                   
                
        }
        // To Check the Length of the Queue
        public int Size()
        {
            return size;
        }

        public IEnumerator<T> GetEnumerator()
        {
           NodeClass<T> current = front;
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
