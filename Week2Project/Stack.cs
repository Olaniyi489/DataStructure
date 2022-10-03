using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week2Project
{
    internal class Stack<T>
    {
        public int count = 0;
        public Snode top = null;

        public  class Snode
        {
           public Snode next;
           public T data;

            public Snode()
            {
                this.next = null;
            }
        }

      

        public int Push(T data)
        {
            Snode temp = new Snode();

            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                
            }

            temp.data = data;
            temp.next = top;
            top = temp;
            count++;
            return count;
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                return top.data;
            }
            else
            {
                throw new Exception("Stack is Empty");
            }
        }

        public void Pop()
        {
           if ( top == null)
           {
                throw new Exception("Stack Underflow");
           } 
           top = top.next;
           count--;
        }

        

        public void Display()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Snode temp = top;
                while (temp != null)
                {
                    Console.Write("{0}->", temp.data);
                    temp = temp.next;
                }
            }
        }

        public bool empty()
        {
            return count == 0;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public int Size()
        {
            return count;
        }
    }
}
