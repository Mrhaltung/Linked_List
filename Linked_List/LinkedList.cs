using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Linked_List
{
    class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            node.data = data;
            node.next = null;
            
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

        public bool Search(int n)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == n)
                {
                    Console.WriteLine("\n Element is Present");
                    Console.WriteLine("\n Display the Current Node : " + current.data);
                }
                current = current.next;   
            }
            //Console.WriteLine("\n Element is not Preset");
            return false;
        }
        internal void Display()
        {
            Node temp = this.head;
            
            while (temp != null)
            {
                Console.Write(temp.data + "-->");
                temp = temp.next;
            }
        }

    }
}
