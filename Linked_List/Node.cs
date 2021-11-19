using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Linked_List
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
}
