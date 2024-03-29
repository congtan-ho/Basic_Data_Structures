﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List
{
    class Program
    {
        public class Node
        {
            public Node next;
            public object data;
        }

        public class LinkedList
        {
            private Node head;

            public void printAllNodes()
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
            public void AddFirst(Object data)
            {
                Node toAdd = new Node();

                toAdd.data = data;
                toAdd.next = head;

                head = toAdd;
            }

            public void AddLast(Object data)
            {
                if (head == null)
                {
                    head = new Node();

                    head.data = data;
                    head.next = null;
                }
                else
                {
                    Node toAdd = new Node();
                    toAdd.data = data;

                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = toAdd;
                }
            }
            public void remove(LinkedList singlyList, object data)
            {
                Node temp = singlyList.head;
                Node prev = null;
                if (temp == null)
                {
                    return;
                }
                if (temp != null && temp.data == data)
                {
                    singlyList.head = temp.next;
                    return;
                }
                while (temp != null && temp.data != data)
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    return;
                }
                prev.next = temp.next;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Add First:");
                LinkedList myList1 = new LinkedList();

                myList1.AddFirst("Hello");
                myList1.AddFirst("Magical");
                myList1.AddFirst("World");
                myList1.printAllNodes();
                Console.ReadLine();

                myList1.remove(myList1, "Magical");
                myList1.printAllNodes();
                Console.ReadLine();

                Console.WriteLine("Add Last:");
                LinkedList myList2 = new LinkedList();

                myList2.AddLast("Hello");
                myList2.AddLast("Magical");
                myList2.AddLast("World");
                myList2.printAllNodes();
                Console.ReadLine();
            }
        }
    }
}
