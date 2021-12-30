using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListOperations
{
    public class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} node is created into LinkedList", node.data);
        }
        //Insert Front
        public void InsertFront(int data)
        {
            Node new_node = new Node(data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("Inserted the list in front " + new_node.data);
        }
        //Append new Node
        public void Append(int data)
        {
            Node new_node = new Node(data);
            new_node.data = data;//assign data element
            new_node.next = null;//assign null to next of new node
            //check linkedlist empty 
            if (head == null)
            {
                head = new_node;

            }
            else
            {
                //traverse to last node
                Node temp = new Node(data);
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;

            }
            Console.WriteLine("{0} node is Appended in the LinkedList", new_node.data);
        }

        //Display the nodes
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Console.Write("LinkedList Sequence: ");
            while (temp != null)
            {
                Console.Write(temp.data);
                Console.Write("->");
                temp = temp.next;
            }
        }
    }
}
