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
    class Program
    {
        static void Main(string[] args)
        {
            
            // Stack Testing
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Pop();
            Console.WriteLine(myStack.IsEmpty());
            foreach (var item in myStack) 
            { 
                Console.WriteLine("My Stack: " + item + " ");
            }
           
            //Queue Testing
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach(int i in queue)
            {
                Console.WriteLine("My Queue: " + i + " ");
            }

            //LinkedList Testing
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
                list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            foreach(int i in list)
            {
                Console.WriteLine(i + " ");
            }
        }      
    }
}




