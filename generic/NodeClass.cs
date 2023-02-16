using generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace genericNode
{
    // The NodeClass is a generic class representing a node in a singly linked list.
    public class NodeClass<T>  
    {
        public T Data; // This represents the value stored in the node 
         public NodeClass<T> Next_Element; // This represents a reference to the next node in the Linked List



     /*Constructor that take two parameters.
     The constructor sets the Data and Next_Element fields to the values of the value, and next_element parameters, respectively.
     */
        public NodeClass(T value, NodeClass<T> next_element) 
        {
            Data = value; //value of type T, 
            Next_Element = next_element;
           
        }
    }

    /*
        This class is a basic building block for implementing linked lists in C#. 
        The generic type parameter T allows the class to work with different types of data, such as integers, strings, 
        or custom data types.
     */
}