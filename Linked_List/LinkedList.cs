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

        public void deleteNode(int position)
        {
            if (this.head == null)
                return;

            Node temp = this.head;

            if(position == 0)
            {
                this.head = temp.next;
                return;
            }

            for (int i = 0; temp != null && i < position - 1; i++)
                temp = temp.next;

            if (temp == null || temp.next == null)
                return;

            Node next = temp.next.next;

            temp.next = next;
        }
        internal void Display()
        {
            Node temp = this.head;
            //if(temp == null)
            //{
            //    Console.WriteLine("LinkedList is empty");
            //    return;
            //}
            while (temp != null)
            {
                Console.Write(temp.data + "-->");
                temp = temp.next;
            }
        }

    }
}
