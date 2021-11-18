using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            
            if(this.head == null)
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
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        internal void InsertAfter(Node prev_node, int data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
                return;
            }
            Node NewNode = new Node(data);
            NewNode.next = head.next;
            head.next = node;
            NewNode.head = prev_node;
            if (NewNode.next != null)
            {
                NewNode.next.head = NewNode;
            }
        }
    }
}
