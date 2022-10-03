using System;

namespace Week2Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> list = new MyLinkedList<int>();

            //list.Add("1");
            //list.PrintList();
            //int index = list.Index("1");
            //bool check = list.Check("1");
            //Console.WriteLine("Count: " + list.Size());
            //Console.WriteLine("Check: " + check);
            //Console.WriteLine("Index: " + index);
            //Console.WriteLine("\n");



            //bool result = list.Remove("1");
            //Console.WriteLine(result);



            //list.PrintList();
            //Console.WriteLine("Count: " + list.Size());
            //Console.WriteLine("\n");

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);

            //list.Push(1);
            //list.Push(2);
            //list.Add(4);
            //list.PrintList();
            //Console.WriteLine("Count: " + list.Size());
            //Console.WriteLine("\n");

            ////bool result = list.Remove("5");
            //bool result = list.Remove(5);
            //Console.WriteLine(result);
            //list.PrintList();
            //Console.WriteLine("Count: " + list.Size());
            //Console.WriteLine("\n");

            //list.Add(5);
            //list.PrintList();
            //Console.WriteLine("Count: " + list.Size());
            //Console.WriteLine("\n");

            //int index = list.Index(4);
            //bool check = list.Check(4);
            //Console.WriteLine("Check: " + check);
            //Console.WriteLine("Index: " + index);
            //Console.WriteLine("\n");

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //bool a = queue.IsEmpty();
            //int b = queue.Size();
            //queue.Print();
            ////Console.WriteLine(a);
            ////Console.WriteLine(b);
            //Console.WriteLine("\n");

            //int removedItem = queue.Dequeue();
            //Console.WriteLine(removedItem);
            //Console.WriteLine("\n");
            //queue.Print();

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            //stack.Push(3);
            //stack.Push(2);
            //stack.Push(4);


            Console.WriteLine(stack.Size());
            stack.Pop();
            //stack.Pop();
            //stack.empty();

            bool isEmpty = stack.IsEmpty();
           // Console.WriteLine(isEmpty);

            //stack.Size();


            int peekValue = stack.Peek();
           // Console.WriteLine(peekValue);

            //Console.WriteLine(stack.Size());

            //stack.Display();

        }
    }
}
