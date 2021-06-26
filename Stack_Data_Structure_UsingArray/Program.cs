﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Data_Structure_UsingArray
{
    class Program
    {
        internal class Stack
        {
            static int MAX = 1000;
            int top;
            int[] stack = new int[MAX];

            public Stack()
            {
                top = -1;
            }
            
            internal void Push(int data)
            {
                if (top >= MAX)
                {
                    Console.WriteLine("Stack Overflow");
                    
                }
                else
                {
                    stack[++top] = data;
                    
                }
            }
           
            internal int Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return 0;
                }
                else
                {
                    int value = stack[top--];
                    return value;
                }
            }
           
            internal void Peek()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                    Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
            }
            
            internal void PrintStack()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the Stack are :");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }
            static void Main(string[] args)
            {
                
                Stack myStack = new Stack();

                
                Console.WriteLine("Stack:");
                Console.WriteLine("====================================");

                myStack.Push(10);
                myStack.Push(20);
                myStack.Push(30);
                myStack.Push(40);
               
                myStack.PrintStack();
               
                myStack.Peek();
                
                Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
                
                myStack.PrintStack();

            }
        }
    }
}
