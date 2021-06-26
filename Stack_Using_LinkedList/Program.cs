using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Using_LinkedList
{
    class Program
    {
        public class Node
        {
            public Node next;
            public object data;
        }
        public class Stack_Using_LinkedList
        {
            public Node Top;

            public void Push(object value)
            {
                Node newNode = new Node();
                newNode.data = value;

                if (Top == null)
                {
                    newNode.next = null;
                }
                else
                {
                    newNode.next = Top;
                }
                Top = newNode;
                Console.WriteLine("{0} pushed to stack", value);
            }
            public void Pop()
            {
                if (Top == null)
                {
                    Console.WriteLine("Stack Underflow. Deletion not possible");
                    return;
                }

                Console.WriteLine("Item popped is {0}", Top.data);
                Top = Top.next;
            }
            internal void Peek()
            {
                if (Top == null)
                {
                    Console.WriteLine("Stack Underflow.");
                    return;
                }

                Console.WriteLine("{0} is on the top of Stack", Top.data);
            }
        }
        static void Main(string[] args)
        {
            Stack_Using_LinkedList mystack = new Stack_Using_LinkedList();
            mystack.Push(1);
            mystack.Push(4);
            mystack.Push(7);
            mystack.Push(9);
            mystack.Pop();
            mystack.Peek();
            mystack.Pop();
            Console.ReadLine();
        }
    }
}
