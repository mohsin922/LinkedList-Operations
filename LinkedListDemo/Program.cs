using System;

namespace LinkedListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Operations!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Console.WriteLine("Linkedlist before insertion: ");
            list.Display();
            Console.WriteLine("\n");
            list.InsertAfter(list.head.next, 40);
            Console.WriteLine("Linkedlist After insertion: ");
            list.Display();
        }
    }
}

