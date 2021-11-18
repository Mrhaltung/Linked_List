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
            Node node = new Node();
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

        public void insert(int position, int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;

            if(this.head == null)
            {
                if(position != 0)
                {
                    return;
                }
                else
                {
                    this.head = node;
                }
            }

            if(head != null && position == 0)
            {
                node.next = this.head;
                this.head = node;
                return;
            }

            Node current = this.head;
            Node previous = null;

            int i = 0;

            while(i < position) 
            {
                previous = current;
                current = current.next;

                if(current == null)
                {
                    break;
                }
                i++;
            }
            node.next = current;
            previous.next = node;
            Console.WriteLine("\n value inserted in between \n");
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
                Console.Write(temp.data + "-->");
                temp = temp.next;
            }
        }

    }
}
