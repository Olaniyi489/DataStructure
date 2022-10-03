using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week2Project
{
    internal class Queue<T>
    {
        public int count = 0;
        public Qnode front = null;
        public Qnode rear = null;
        public class Qnode
        {
            public T item;
            public Qnode next;
            public Qnode(T item)
            {
                this.item = item;
                this.next = null;
            }

        }

        public int Enqueue(T item)
        {
             Qnode temp = new Qnode(item);

            if(front == null) front = temp;
            else rear.next = temp;

            rear = temp;
            count++;
            return count;
        }


        public T Dequeue()
        {
            if (count == 0) throw new Exception("Queue is empty");
            T item = front.item;

            if (front.next == null) front = null;
            else front = front.next;
          
            return item;
        }

        public void Print()
        {
            Qnode qnode = front;
            while (qnode != null)
            {
                Console.WriteLine(qnode.item);
                qnode = qnode.next;
            }
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public int Size()
        {
           return count;
        }
        
    }
}
