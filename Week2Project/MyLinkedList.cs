using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Project
{
    public class MyLinkedList<T>
    {
        int count = 0;
        Node head = null;
        Node prevItem;
        public class Node
        {
            public T data;
            public Node next;

            public Node(T data)
            {
                this.data = data;
                this.next = null;
            }
        }

        public void PrintList()
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

        public int Add(T item)
        {
            Node nextItem;
            if (head == null) 
            { 
                head = new Node(item);
                prevItem = head;
                count++;
            } else
            {
                nextItem = new Node(item); //add item to node
                prevItem.next = nextItem; // Link first node with the next node
                prevItem = nextItem;
                count++;
            }
            return count;
        }

        public void Push(T item)
        {
            Node temp = head;
            head = new Node(item);
            head.next = temp;
            count++;
        }

        public int Size()
        {
            return count;
        }

        public Boolean Remove(T item)
        {
            Node temp = null;
            Node node = head;
            while (node != null)
            {
                if (node.data.Equals(item))
                {
                    if (node.next == null)
                    {
                        prevItem = temp;
                        if (temp != null) temp.next = null;
                        if (node == head) head = null;
                    }
                    else
                    {
                        Node nextNode = node.next;
                        temp.next = nextNode;
                    }
                    count--;
                    return true;
                }
                else
                {
                    temp = node;
                    node = node.next;
                }
            }

            return false;
        }

        public Boolean Check(T item)
        {
            Node node = head;
            while (node != null)
            {
                if (node.data.Equals(item))
                {
                    return true;
                }
                node = node.next;
            }
            return false;
        }

        public int Index(T item)
        {
            int index = 0;
            Node node = head;
            while(node != null)
            {
                if (item.Equals(node.data))
                {
                    return index;
                }
                node = node.next;
                index++;
            }
            return -1;
        }
    }

}
