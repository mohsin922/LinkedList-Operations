using System;

namespace LinkedListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Operations!");
            LinkedList list = new LinkedList();
            list.InsertFront(70);
            list.InsertFront(30);
            list.InsertFront(56);
            //Display Operation
            Console.WriteLine("Insertion at Front: ");
            list.Display();
            

        }
    }
}
