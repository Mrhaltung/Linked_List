﻿using System;

namespace Linked_List
{
    class Program
    {
        //private static Node head = null;
        private int n = 30;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program.");
            LinkedList List = new LinkedList();
            List.Add(56);
            List.Add(30);
            List.Add(40);
            List.Add(70);

            Console.Write("\n Create Linked List is : ");
            List.Display();

            Console.WriteLine("\n \n Searched the Node : ");
            List.Search(40);
        }
    }
}
