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
            list.InsertBetween(2, 30);
            list.Add(70);
            Console.WriteLine(list.Search(30));
        }
    }
}
