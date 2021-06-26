using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Using_LinkedList
{
    class Program
    {
        public class Node
        {
            public Node next;
            public object data;
        }
        public class Queue_Using_LinkedList
        {
           public Node front = null;
           public Node rear = null;

            public void Enqueue(int value)
            {
               
                Node newNode = new Node();
                newNode.data = value;
            
                if (rear == null)
                {
                    front = rear = newNode;
                }
                else
                {
                    
                   rear.next = newNode; 
                   rear = newNode;
                   
                }
                Console.WriteLine("{0} inserted into Queue", value);
            }
            public void Dequeue()
            {
                
                if (front == null)
                {
                    Console.WriteLine("The Queue is empty");
                    return;
                }

                Node temp = front;
                front = front.next;

                if (front == null)
                {
                   rear = null;
                }

                Console.WriteLine("Item deleted is {0}", temp.data);
            }
        }
        static void Main(string[] args)
        {
            Queue_Using_LinkedList myQueue = new Queue_Using_LinkedList();
            myQueue.Enqueue(4);
            myQueue.Enqueue(6);
            myQueue.Enqueue(3);
            myQueue.Enqueue(7);
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Dequeue();

            Console.ReadLine();

        }
    }
}
