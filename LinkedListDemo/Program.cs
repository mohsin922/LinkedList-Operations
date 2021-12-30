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
            list.Append(30);
            list.Append(70);
            //Display Operation
            Console.WriteLine("Appended Nodes inside Linked List are : ");
            list.Display();
        }
    }
}
