using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Linked_List
{
    class LinkedList<T> where T : IComparable<T>
    {
        internal Node<T> head = null;
        internal Node<T> tail = null;

        internal void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            node.data = data;
            node.next = null;
            
            if(head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void sortList()
        {
            Node<T> current = head, index = null;
            T temp;

            if (head == null)
                return;
            else
            {
                while(current != null)
                {
                    index = current.next;

                    while(index != null)
                    {
                        if(current.data.CompareTo(index.data) > 0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
        internal void Display()
        {
            Node<T> current = head;
            if(head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            while (current != null)
            {
                Console.Write(current.data + "-->");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
